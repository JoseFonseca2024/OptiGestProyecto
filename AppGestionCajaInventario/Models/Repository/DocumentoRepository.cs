using AppGestionCajaInventario.Models.Dto;
using AppGestionCajaInventario.Models.Dto.Documentos;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AppGestionCajaInventario.Models.Repository
{
    public class DocumentoRepository : IDocumentoRepository
    {
        private readonly HttpClient _httpClient;

        public DocumentoRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<DocumentoResponseDto?> RegistrarDocumentoAsync(DocumentoRequestDto request)
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Documentos/registrar", content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new ApplicationException($"Error al registrar documento: {error}");
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponse<DocumentoResponseDto>>(jsonResponse, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return apiResponse?.Data;
        }
    }
}
