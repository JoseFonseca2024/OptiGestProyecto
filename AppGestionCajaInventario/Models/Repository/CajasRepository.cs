using AppGestionCajaInventario.Models.Dto.Cajas;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository
{
    public class CajasRepository : ICajaRepository
    {
        private readonly HttpClient _http;

        public CajasRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<CajasDto>> ObtenerCajasporEmpresaAsync()
        {
            var response = await _http.GetAsync("Cajas/por-empresa");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<CajasDto>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<CajasDto>();
        }

        public async Task<CajasDto?> ObtenerPorIdAsync(int id)
        {
            var response = await _http.GetAsync($"Cajas/{id}");
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CajasDto>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<bool> CrearAsync(CajaCreateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync("Cajas", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ActualizarAsync(int id, CajaUpdateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PutAsync($"Cajas/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var response = await _http.DeleteAsync($"Cajas/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> TransferirAsync(int origenId, int destinoId, decimal monto)
        {
            var dto = new { CajaOrigenID = origenId, CajaDestinoID = destinoId, Monto = monto };
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync("Cajas/transferir", content);
            return response.IsSuccessStatusCode;
        }

    }
}
