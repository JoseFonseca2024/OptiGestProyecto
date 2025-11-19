using AppGestionCajaInventario.Models.Dto.Empresas;
using AppGestionCajaInventario.Models.Dto.Usuarios;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository
{
    internal class AdminRepository : IAdminRepository
    {
        private readonly HttpClient _httpClient;

        public AdminRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UsuarioDto>> ObtenerUsuariosAsync()
        {
            var response = await _httpClient.GetAsync("Usuario");
            if (!response.IsSuccessStatusCode)
                throw new Exception("Error al obtener usuarios");

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<UsuarioDto>>(json)!;
        }

        public async Task<List<RolDto>> ObtenerRolesAsync()
        {
            var response = await _httpClient.GetAsync("Usuario/roles");
            if (!response.IsSuccessStatusCode)
                throw new Exception("Error al obtener roles");

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<RolDto>>(json)!;
        }

        public async Task<bool> RegistrarUsuarioAsync(UsuarioCreateDto dto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Usuario", content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al registrar usuario: {error}");
            }

            return true;
        }

        public async Task<bool> ActualizarUsuarioAsync(UsuarioUpdateDto dto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"Usuario/{dto.UsuarioID}", content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar usuario: {error}");
            }

            return true;
        }

        public async Task<EmpresaDto?> ObtenerEmpresaDelUsuarioAsync()
        {
            var response = await _httpClient.GetAsync("Empresa/Empresa-del-Usuario");
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<EmpresaDto>(json);
        }

        public async Task<bool> VerificarRucAsync(string ruc)
        {
            var response = await _httpClient.GetAsync($"Empresa/verificar-ruc?ruc={ruc}");
            if (!response.IsSuccessStatusCode) return false;

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<bool>(json);
        }

        public async Task<int> CrearEmpresaAsync(EmpresaCreateDto dto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Empresa", content);

            if (!response.IsSuccessStatusCode)
                throw new Exception("Error al crear empresa");

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<dynamic>(json);

            if (result?.empresa?.empresaID == null)
                throw new Exception("La respuesta del servidor no contiene el ID de la empresa.");

            return (int)result.empresa.empresaID;
        }

        public async Task<bool> ActualizarEmpresaAsync(EmpresaUpdateDto dto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync("Empresa", content);

            return response.IsSuccessStatusCode;
        }
    }
}
