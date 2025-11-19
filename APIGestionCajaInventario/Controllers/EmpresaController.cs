using APIGestionCajaInventario.Dto.Empresas;
using APIGestionCajaInventario.Models;
using APIGestionCajaInventario.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;
        private readonly IMapper _mapper;
        private readonly ILogger<EmpresaController> _logger;

        public EmpresaController(
            IEmpresaService empresaService,
            IMapper mapper,
            ILogger<EmpresaController> logger)
        {
            _empresaService = empresaService;
            _mapper = mapper;
            _logger = logger;
        }

        private bool TryGetUsuarioId(out int usuarioId)
        {
            var claim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.TryParse(claim, out usuarioId);
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet("Verificar-RUC-Empresa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> VerificarRuc(string ruc)
        {
            var existe = await _empresaService.VerificarRucAsync(ruc);
            return Ok(existe); // true si ya existe, false si está disponible
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> CrearEmpresa([FromBody] EmpresaCreateDto dto)
        {
            _logger.LogInformation("Intentando crear empresa para el usuario autenticado");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al crear empresa");
                return BadRequest(ModelState);
            }

            if (!TryGetUsuarioId(out var usuarioId))
            {
                _logger.LogWarning("No se pudo obtener el ID del usuario desde el token");
                return Unauthorized(new { error = "Token inválido o sin identificador de usuario." });
            }

            var empresaExistente = await _empresaService.ObtenerEmpresaUnicaPorUsuarioAsync(usuarioId);
            if (empresaExistente != null)
            {
                _logger.LogWarning("El usuario ya tiene una empresa registrada.");
                return BadRequest(new { error = "Ya tienes una empresa registrada. Solo se permite una." });
            }

            try
            {
                var empresaId = await _empresaService.CrearEmpresaYAsociarAsync(dto, usuarioId);

                var empresa = _mapper.Map<Empresa>(dto);
                empresa.EmpresaID = empresaId;

                var empresaDto = _mapper.Map<EmpresaDto>(empresa);

                _logger.LogInformation("Empresa creada exitosamente con ID: {EmpresaID}", empresaId);

                return CreatedAtAction(nameof(ObtenerEmpresaDelUsuario), null, new
                {
                    message = "Empresa creada y asociada correctamente",
                    empresa = empresaDto
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear empresa");
                return BadRequest(new { error = "No se pudo crear la empresa." });
            }
        }

        [Authorize]
        [HttpGet("Empresa-del-Usuario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ObtenerEmpresaDelUsuario()
        {
            if (!TryGetUsuarioId(out var usuarioId))
            {
                _logger.LogWarning("No se pudo obtener el ID del usuario desde el token");
                return Unauthorized(new { error = "Token inválido o sin identificador de usuario." });
            }

            var empresa = await _empresaService.ObtenerEmpresaUnicaPorUsuarioAsync(usuarioId);
            if (empresa == null)
            {
                _logger.LogWarning("No se encontró empresa asociada al usuario {UsuarioID}", usuarioId);
                return NotFound(new { error = "No se encontró empresa asociada al usuario." });
            }

            var empresaDto = _mapper.Map<EmpresaDto>(empresa);
            return Ok(empresaDto);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> ActualizarEmpresa([FromBody] EmpresaUpdateDto dto)
        {
            _logger.LogInformation("Intentando actualizar empresa para el usuario autenticado");

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido al actualizar empresa");
                return BadRequest(ModelState);
            }

            if (!TryGetUsuarioId(out var usuarioId))
            {
                _logger.LogWarning("No se pudo obtener el ID del usuario desde el token");
                return Unauthorized(new { error = "Token inválido o sin identificador de usuario." });
            }

            var empresa = await _empresaService.ObtenerEmpresaUnicaPorUsuarioAsync(usuarioId);
            if (empresa == null)
            {
                _logger.LogWarning("No se encontró empresa asociada al usuario {UsuarioID}", usuarioId);
                return NotFound(new { error = "No se encontró empresa asociada al usuario." });
            }

            _mapper.Map(dto, empresa);

            var (ok, error) = await _empresaService.ActualizarEmpresaAsync(empresa);
            if (!ok)
            {
                _logger.LogError("Falló la actualización de empresa ID {EmpresaID}", empresa.EmpresaID);
                return BadRequest(new { error = "No se pudo actualizar la empresa." });
            }

            _logger.LogInformation("Empresa ID {EmpresaID} actualizada exitosamente", empresa.EmpresaID);
            return NoContent();
        }
    }
}