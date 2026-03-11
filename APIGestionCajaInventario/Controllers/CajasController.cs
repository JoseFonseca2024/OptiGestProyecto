using APIGestionCajaInventario.Dto.Cajas;
using APIGestionCajaInventario.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class CajasController : ControllerBase
    {
        private readonly CajaService _service;
        private readonly IMapper _mapper;

        public CajasController(CajaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // Listar todas las cajas de la empresa del usuario
        [Authorize(Roles = "Administrador,Cajero")]
        [HttpGet("por-empresa")]
        public async Task<ActionResult<IEnumerable<CajaDto>>> GetAll()
        {
            var cajas = await _service.ObtenerCajasPorEmpresaAsync(User);
            var dto = _mapper.Map<List<CajaDto>>(cajas);
            return Ok(dto);
        }

        // Obtener caja por ID
        [Authorize(Roles = "Administrador,Cajero")]
        [HttpGet("{id}")]
        public async Task<ActionResult<CajaDto>> GetById(int id)
        {
            var caja = await _service.ObtenerPorIdAsync(id);
            if (caja == null) return NotFound();
            return Ok(caja);
        }

        // Crear nueva caja
        [Authorize(Roles = "Administrador")]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CajaCreateDto dto)
        {
            var id = await _service.CrearAsync(dto, User);
            return CreatedAtAction(nameof(GetById), new { id }, dto);
        }

        // Actualizar caja existente
        [Authorize(Roles = "Administrador")]
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] CajaUpdateDto dto)
        {
            var actualizado = await _service.ActualizarAsync(id, dto, User);
            return actualizado ? NoContent() : NotFound();
        }

        // Eliminar caja
        [Authorize(Roles = "Administrador")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var eliminado = await _service.EliminarAsync(id, User);
            return eliminado ? NoContent() : NotFound();
        }

        // Transferencia entre cajas
        [Authorize(Roles = "Administrador,Cajero")]
        [HttpPost("transferencia")]
        public async Task<ActionResult> Transferir([FromBody] TransferenciaDto dto)
        {
            var resultado = await _service.TransferirAsync(dto, User);
            if (!resultado) return BadRequest("No se pudo realizar la transferencia.");
            return Ok("Transferencia realizada con éxito.");
        }
    }
}
