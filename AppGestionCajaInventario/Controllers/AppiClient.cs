using AppGestionCajaInventario.Models.Repository;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Controllers
{
    public class ApiClient
    {
        public HttpClient HttpClientInstance { get; }  // Expuesta para reuso
        public IUserRepository LoginUsers { get; }
        public IAdminRepository Admin { get; }
        public IProductoRepository Producto { get; }
        public IClienteRepository Cliente { get; }
        public IProveedorRepository Proveedor { get; }
        public ICajaRepository Caja { get; }
        public ITurnoRepository Turno { get; }
        public ApiClient()
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"]!;
            HttpClientInstance = new HttpClient
            {
                BaseAddress = new Uri(apiBaseUrl)  // Configura la URL base aquí
            };

            LoginUsers = new UserRepository(HttpClientInstance, "Auth/login");
            Admin = new AdminRepository(HttpClientInstance);
            Producto = new ProductoRepository(HttpClientInstance);
            Cliente = new ClienteRepository(HttpClientInstance);
            Proveedor = new ProveedorRepository(HttpClientInstance);
            Caja = new CajasRepository(HttpClientInstance);
            Turno = new TurnoRepository(HttpClientInstance);
        }

        internal void SetAuthToken(string? token)
        {
            if (string.IsNullOrEmpty(token))
            {
                HttpClientInstance.DefaultRequestHeaders.Authorization = null;
            }
            else
            {
                HttpClientInstance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public async Task<bool> VerificarDisponibilidadAsync(string nombreUsuario, string email)
        {
            // Ruta con '/' para evitar concatenaciones erróneas
            var response = await HttpClientInstance.GetAsync($"/auth/verificar-disponibilidad?nombreUsuario={nombreUsuario}&email={email}");
            if (!response.IsSuccessStatusCode) return true; // Por seguridad, asumimos que sí existe
            var contenido = await response.Content.ReadAsStringAsync();
            return bool.Parse(contenido);
        }
    }

}
