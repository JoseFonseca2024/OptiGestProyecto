using AppGestionCajaInventario.Models.Dto.Turnos;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
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
                var root = Newtonsoft.Json.Linq.JObject.Parse(errorJson);

                if (root.TryGetValue("detail", out var detailProp))
                    throw new Exception(detailProp.ToString());
                else if (root.TryGetValue("message", out var msgProp))
                    throw new Exception(msgProp.ToString());
                else
                    throw new Exception("Error desconocido en la API.");
            }
        }

        public async Task<List<TurnosDto>> ObtenerActivosAsync()
        {
            var response = await _http.GetAsync("Turnos/activos");
            if (!response.IsSuccessStatusCode) return new List<TurnosDto>();

            var json = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<TurnosDto>>(json)
                   ?? new List<TurnosDto>();
        }

        public async Task<TurnosDto?> ObtenerTurnoActivoAsync()
        {
            var response = await _http.GetAsync("Turnos/activo");
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TurnosDto>(json);
        }
    }
}
