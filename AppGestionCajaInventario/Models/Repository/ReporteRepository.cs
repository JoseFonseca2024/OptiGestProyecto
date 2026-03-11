using AppGestionCajaInventario.Models.Dto.Reporte;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository
{
    public class ReporteRepository : IReporteRepository
    {
        private readonly HttpClient _http;

        public ReporteRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<VentaReporteDto>> ObtenerVentasPorAnioAsync(int anio)
        {
            var response = await _http.GetAsync($"Reportes/Ventas/{anio}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<VentaReporteDto>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<VentaReporteDto>();
        }
    }
}
