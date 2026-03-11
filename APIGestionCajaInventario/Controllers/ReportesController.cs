using APIGestionCajaInventario.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
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
            var ventas = await _service.GetVentasPorAnio(anio);
            return Ok(ventas);
        }
    }
}
