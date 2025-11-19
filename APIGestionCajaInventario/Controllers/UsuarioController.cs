using APIGestionCajaInventario.Dto.Usuarios;
using APIGestionCajaInventario.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        private bool TryGetUsuarioId(out int usuarioId)
        {
            var claim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.TryParse(claim, out usuarioId);
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObtenerUsuariosDeEmpresa()
        {
            if (!TryGetUsuarioId(out var usuarioId))
                return Unauthorized();

            var usuarios = await _usuarioService.ObtenerUsuariosPorEmpresaAsync(usuarioId);
            var usuariosDto = usuarios.Select(u => _mapper.Map<UsuarioDto>(u));
            return Ok(usuariosDto);
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RegistrarUsuario([FromBody] UsuarioCreateDto dto)
        {
           if (!ModelState.IsValid)
               return BadRequest(ModelState);

            // Aquí obtenés el ID del usuario desde el token
            var adminId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value
                ?? throw new Exception("Token sin NameIdentifier"));

            var nuevoUsuarioId = await _usuarioService.RegistrarUsuarioAsync(dto, adminId);
             return Ok(new { mensaje = "Usuario registrado correctamente", usuarioID = nuevoUsuarioId });
          
        }

        [Authorize(Roles = "Administrador")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ActualizarUsuario(int id, [FromBody] UsuarioUpdateDto dto)
        {
            if (id != dto.UsuarioID)
                return BadRequest(new { error = "El ID del usuario no coincide." });
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                await _usuarioService.ActualizarUsuarioAsync(dto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    error = ex.Message,
                    tipo = ex.GetType().Name,
                    stackTrace = ex.StackTrace
                });
            }
        }
        [Authorize]
        [HttpGet("roles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObtenerRoles()
        {
            var roles = await _usuarioService.ObtenerRolesAsync();
            var rolesDto = roles.Select(r => _mapper.Map<RolDto>(r));
            return Ok(rolesDto);
        }

    }
}
