using APIGestionCajaInventario.Dto.Usuarios;
using APIGestionCajaInventario.Models;

namespace APIGestionCajaInventario.Services.Interfaces
{
    public interface IUsuarioService
    {
        // Autenticación
        Task<Usuario?> ValidarUsuarioAsync(string usuario, string contrasena);
        Task<string> GenerarTokenAsync(Usuario usuario);
        Task<bool> UsuarioOCorreoExisteAsync(string nombreUsuario, string email);
        Task<(bool ok, string error)> RegistrarUsuarioInicialAsync(string nombreUsuario, string email, string clave);
        Task<(bool ok, string error)> EnviarCodigoVerificacionAsync(string email, string codigo);
        // Administración
        Task<List<Usuario>> ObtenerUsuariosPorEmpresaAsync(int adminId);
        Task<int> RegistrarUsuarioAsync(UsuarioCreateDto dto, int adminId);
        Task ActualizarUsuarioAsync(UsuarioUpdateDto dto);
        Task<List<Rol>> ObtenerRolesAsync();
    }
}
