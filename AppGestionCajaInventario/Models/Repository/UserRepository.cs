using AppGestionCajaInventario.Models.Dto;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository
{
    internal class UserRepository : IUserRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;

        public UserRepository(HttpClient httpClient, string endpoint)
        {
            _httpClient = httpClient;
            _endpoint = endpoint;
        }

        public async Task<string> ValidateCredentialsAsync(string username, string password)
        {
            var loginRequest = new LoginRequest
            {
                User = username,
                Pass = password
            };

            var content = new StringContent(JsonConvert.SerializeObject(loginRequest),
                Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseData);

                if (loginResponse != null && !string.IsNullOrEmpty(loginResponse.Token))
                    return loginResponse.Token;

                throw new Exception("Respuesta inválida del servidor");
            }
            else
            {
                var errorData = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al validar las credenciales. " +
                    $"Respuesta: {errorData}");
            }

        }

        public async Task<bool> EnviarCodigoVerificacionAsync(string email, string codigo)
        {
            var request = new CodigoVerificacionRequest
            {
                Email = email,
                Codigo = codigo
            };

            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Auth/enviar-codigo", content);

            if (response.IsSuccessStatusCode)
                return true;

            var error = await response.Content.ReadAsStringAsync();
            throw new Exception($"Error al reenviar código: {error}");
        }

        public async Task<bool> VerificarDisponibilidadAsync(string nombreUsuario, string email)
        {
            var response = await _httpClient.GetAsync($"Auth/verificar-disponibilidad?nombreUsuario={nombreUsuario}&email={email}");
            if (!response.IsSuccessStatusCode) return true;

            var contenido = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<bool>(contenido);
        }

        public async Task<bool> RegistrarUsuarioAsync(string nombreUsuario, string email, string clave)
        {
            var registro = new RegistroRequest
            {
                NombreUsuario = nombreUsuario,
                Email = email,
                Clave = clave
            };

            var content = new StringContent(JsonConvert.SerializeObject(registro),
                Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Auth/registro", content);

            if (response.IsSuccessStatusCode)
                return true;

            var error = await response.Content.ReadAsStringAsync();
            throw new Exception($"Error al registrar usuario: {error}");
        }

        public async Task<LoginResponse> ObtenerLoginResponseAsync(string username, string password)
        {
            var loginRequest = new LoginRequest
            {
                User = username,
                Pass = password
            };

            var content = new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_endpoint, content);

            if (!response.IsSuccessStatusCode)
            {
                var errorData = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al validar las credenciales. Respuesta: {errorData}");
            }

            var responseData = await response.Content.ReadAsStringAsync();
            var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseData);

            if (loginResponse == null || string.IsNullOrEmpty(loginResponse.Token))
                throw new Exception("Respuesta inválida del servidor");

            return loginResponse;
        }

    }

}
