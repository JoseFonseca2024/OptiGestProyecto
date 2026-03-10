using APIGestionCajaInventario.DAO;
using APIGestionCajaInventario.Dto.Usuarios;
using APIGestionCajaInventario.Models;
using APIGestionCajaInventario.Services.Interfaces;

namespace APIGestionCajaInventario.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioDAO _usuarioDAO;
        private readonly EmpresaDAO _empresaDAO;
        private readonly JwtService _jwtService;
        private readonly IEmailService _emailService;

        public UsuarioService(UsuarioDAO usuarioDAO, JwtService jwtService, IEmailService emailService, EmpresaDAO empresaDAO)
        {
            _usuarioDAO = usuarioDAO;
            _jwtService = jwtService;
            _emailService = emailService;
            _empresaDAO = empresaDAO;
        }

        // Autenticación
        public Task<string> GenerarTokenAsync(Usuario usuario)
            => Task.FromResult(_jwtService.GenerateToken(usuario));

        public Task<Usuario?> ValidarUsuarioAsync(string usuario, string contrasena)
            => _usuarioDAO.ValidarUsuarioAsync(usuario, contrasena);

        public Task<bool> UsuarioOCorreoExisteAsync(string nombreUsuario, string email)
            => _usuarioDAO.UsuarioOCorreoExisteAsync(nombreUsuario, email);

        public async Task<(bool ok, string error)> RegistrarUsuarioInicialAsync(string nombreUsuario, string email, string clave)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(clave))
                return (false, "Todos los campos son obligatorios.");

            if (clave.Length < 6)
                return (false, "La clave debe tener al menos 6 caracteres.");

            var id = await _usuarioDAO.RegistrarUsuarioInicialAsync(nombreUsuario, email, clave);
            return id > 0 ? (true, string.Empty) : (false, "No se pudo registrar el usuario.");
        }

        public async Task<(bool ok, string error)> EnviarCodigoVerificacionAsync(string email, string codigo)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(codigo))
                return (false, "Email y código son obligatorios.");

            try
            {
                await _emailService.EnviarCodigoAsync(email, codigo);
                return (true, string.Empty);
            }
            catch (Exception ex)
            {
                return (false, $"Error al enviar el código: {ex.Message}");
            }
        }

        // Administración
        public Task<List<Usuario>> ObtenerUsuariosPorEmpresaAsync(int adminId)
            => _usuarioDAO.ObtenerUsuariosPorEmpresaAsync(adminId);

        public async Task<int> RegistrarUsuarioAsync(UsuarioCreateDto dto, int adminId)
        {
            var empresa = await _empresaDAO.ObtenerEmpresaUnicaPorUsuarioAsync(adminId);
            if (empresa == null)
                throw new Exception("El administrador no tiene empresa asociada.");
            return await _usuarioDAO.RegistrarUsuarioEnEmpresaAsync(dto, empresa.EmpresaID);
        }

        public async Task ActualizarUsuarioAsync(UsuarioUpdateDto dto)
        {
            var ok = await _usuarioDAO.ActualizarUsuarioAsync(dto);
            if (!ok)
                throw new Exception("No se pudo actualizar el usuario. Verifica los datos o restricciones en la base de datos.");
        }

        public Task<List<Rol>> ObtenerRolesAsync()
            => _usuarioDAO.ObtenerRolesAsync();
    }
}
