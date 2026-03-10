using AppGestionCajaInventario.Models.Dto.Productos;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository
{
    internal class ProductoRepository : IProductoRepository
    {
        private readonly HttpClient _http;

        public ProductoRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ProductosDto>> ObtenerProductosPorEmpresaAsync()
        {
            var response = await _http.GetAsync("Productos/por-empresa");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<ProductosDto>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<ProductosDto>();
        }

        public async Task<ProductosDto?> ObtenerPorIdAsync(int id)
        {
            var response = await _http.GetAsync($"Productos/{id}");
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ProductosDto>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<bool> CrearAsync(ProductosCreateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync("Productos", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ActualizarAsync(int id, ProductosUpdateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PutAsync($"Productos/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var response = await _http.DeleteAsync($"Productos/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
