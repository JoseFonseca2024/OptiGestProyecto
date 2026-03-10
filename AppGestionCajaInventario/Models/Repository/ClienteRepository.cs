using AppGestionCajaInventario.Models.Dto.Clientes;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly HttpClient _http;

        public ClienteRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<IEnumerable<ClienteDto?>> ObtenerClientesPorEmpresaAsync()
        {
            var response = await _http.GetAsync("Cliente/por-empresa");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<ClienteDto>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<ClienteDto>();
        }

        public async Task<ClienteDto?> ObtenerPorIdAsync(int id)
        {
            var response = await _http.GetAsync($"Cliente/{id}");
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ClienteDto>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<bool> CrearAsync(ClienteCreateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync("Cliente", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ActualizarAsync(int id, ClienteUpdateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PutAsync($"Cliente/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var response = await _http.DeleteAsync($"Cliente/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
