using APIGestionCajaInventario.Dto.Turnos;
using APIGestionCajaInventario.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(Roles = "Administrador,Operador")]
    [ApiController]
    [Route("api/[controller]")]
    public class TurnosController : ControllerBase
    {
        private readonly TurnoService _service;

        public TurnosController(TurnoService service)
        {
            _service = service;
        }

        [HttpPost("abrir")]
        public async Task<ActionResult> AbrirTurno([FromBody] TurnoCreateDto dto)
        {
            try
            {
                var turnoId = await _service.AbrirTurnoAsync(dto);
                return CreatedAtAction(nameof(AbrirTurno), new { id = turnoId }, dto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = true, message = "Error interno del servidor.", detail = ex.Message });
            }
        }
    }
}
