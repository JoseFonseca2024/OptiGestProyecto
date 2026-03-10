using AppGestionCajaInventario.Models.Dto.Proveedores;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly HttpClient _http;

        public ProveedorRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<IEnumerable<ProveedorDto?>> GetAllPorEmpresaAsync()
        {
            var response = await _http.GetAsync("Proveedor/por-empresa");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<ProveedorDto>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<ProveedorDto>();
        }

        public async Task<ProveedorDto?> GetByIdPorEmpresaAsync(int id)
        {
            var response = await _http.GetAsync($"Proveedor/{id}");
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ProveedorDto>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<bool> CrearAsync(ProveedorCreateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync("Proveedor", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ActualizarAsync(int id, ProveedorUpdateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PutAsync($"Proveedor/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var response = await _http.DeleteAsync($"Proveedor/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
