using AppGestionCajaInventario.Models.Dto.Turnos;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository
{
    public class TurnoRepository : ITurnoRepository
    {
        private readonly HttpClient _http;

        public TurnoRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<int?> AbrirAsync(TurnoCreateDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync("Turnos/abrir", content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return int.TryParse(result, out var turnoId) ? turnoId : null;
            }
            else
            {
                var errorJson = await response.Content.ReadAsStringAsync();
                try
                {
                    using var doc = JsonDocument.Parse(errorJson);
                    var root = doc.RootElement;

                    if (root.TryGetProperty("detail", out var detailProp))
                    {
                        throw new Exception(detailProp.GetString());
                    }
                    else if (root.TryGetProperty("message", out var msgProp))
                    {
                        throw new Exception(msgProp.GetString());
                    }
                    else
                    {
                        throw new Exception("Error desconocido en la API.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error: {ex.Message}");
                }
            }
        }

        public async Task<List<TurnosDto>> ObtenerActivosAsync()
        {
            var response = await _http.GetAsync("Turnos/activos");
            if (!response.IsSuccessStatusCode) return new List<TurnosDto>();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<TurnosDto>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<TurnosDto>();
        }

    }
}
