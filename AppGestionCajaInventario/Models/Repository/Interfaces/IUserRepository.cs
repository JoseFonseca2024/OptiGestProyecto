using AppGestionCajaInventario.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<string> ValidateCredentialsAsync(string username, string password);
        Task<bool> VerificarDisponibilidadAsync(string nombreUsuario, string email);
        Task<bool> EnviarCodigoVerificacionAsync(string email, string codigo);
        Task<bool> RegistrarUsuarioAsync(string nombreUsuario, string email, string clave);
        Task<LoginResponse> ObtenerLoginResponseAsync(string username, string password);
    }
}
