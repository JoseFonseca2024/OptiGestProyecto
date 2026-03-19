using APIGestionCajaInventario.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class ReportesController : ControllerBase
    {
        private readonly ReporteService _service;

        public ReportesController(ReporteService service)
        {
            _service = service;
        }

        [HttpGet("Ventas/{anio}")]
        public async Task<IActionResult> GetVentasPorAnio(int anio)
        {
            var empresaIdClaim = User.FindFirst("EmpresaID")?.Value;

            if (empresaIdClaim == null)
                return Unauthorized("No se encontró EmpresaID en el token.");

            int empresaId = int.Parse(empresaIdClaim);

            Console.WriteLine($"EmpresaID recibido: {empresaId}");

            var ventas = await _service.GetVentasPorAnio(anio, empresaId);

            return Ok(ventas);
        }
    }

}
