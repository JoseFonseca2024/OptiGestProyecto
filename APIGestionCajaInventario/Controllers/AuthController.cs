using APIGestionCajaInventario.Dto;
using APIGestionCajaInventario.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGestionCajaInventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ILogger<AuthController> _logger;
        private readonly IEmailService _emailService;

        public AuthController(IUsuarioService usuarioService, IEmailService emailService, ILogger<AuthController> logger)
        {
            _usuarioService = usuarioService;
            _emailService = emailService;
            _logger = logger;
        }

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]

        public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest request)
        {
            _logger.LogInformation("Intento de login para usuario: {Usuario}", request.User);

            // Validación del modelo - el ExceptionMiddleware capturará cualquier excepción
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido en login para usuario: {Usuario}", request.User);
                return BadRequest(new { error = "Datos de entrada inválidos", detalles = ModelState });
            }

            var usuario = await _usuarioService.ValidarUsuarioAsync(request.User, request.Pass);

            if (usuario == null)
            {
                _logger.LogWarning("Credenciales incorrectas para usuario: {Usuario}", request.User);
                return Unauthorized(new { error = "Credenciales incorrectas" });
            }

            var token = await _usuarioService.GenerarTokenAsync(usuario);

            _logger.LogInformation("Login exitoso para usuario: {Usuario}, Rol: {Rol}",
                usuario.NombreUsuario, usuario.Rol);

            var response = new LoginResponse
            {
                Token = token,
                Usuario = usuario.NombreUsuario,
                Rol = usuario.Rol,
                Expiracion = DateTime.UtcNow.AddHours(1)
            };

            return Ok(response);
        }

        [HttpGet("verificar-disponibilidad")]
        public async Task<IActionResult> VerificarDisponibilidad(string nombreUsuario, string email)
        {
            bool existe = await _usuarioService.UsuarioOCorreoExisteAsync(nombreUsuario, email);
            return Ok(existe);
        }

        [HttpPost("registro")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RegistrarUsuario([FromBody] RegistroRequest request)
        {
            _logger.LogInformation("Intento de registro para usuario: {Usuario}", request.NombreUsuario);

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Modelo inválido en registro para usuario: {Usuario}", request.NombreUsuario);
                return BadRequest(new { error = "Datos inválidos", detalles = ModelState });
            }

            var (ok, error) = await _usuarioService.RegistrarUsuarioInicialAsync(
                request.NombreUsuario, request.Email, request.Clave);

            if (!ok)
            {
                _logger.LogWarning("Registro fallido para usuario: {Usuario}. Error: {Error}", request.NombreUsuario, error);
                return BadRequest(new { error });
            }

            _logger.LogInformation("Registro exitoso para usuario: {Usuario}", request.NombreUsuario);
            return Ok(new { mensaje = "Usuario registrado correctamente. Verifique su correo para continuar." });
        }

        [HttpPost("enviar-codigo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> EnviarCodigo([FromBody] CodigoVerificacionRequest request)
        {
            _logger.LogInformation("Solicitud de reenvío de código para: {Email}", request.Email);

            if (!ModelState.IsValid)
            {
                return BadRequest(new { error = "Datos inválidos", detalles = ModelState });
            }

            try
            {
                await _emailService.EnviarCodigoAsync(request.Email, request.Codigo);
                return Ok(new { mensaje = "Código reenviado correctamente." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al reenviar código.");
                return BadRequest(new { error = "No se pudo enviar el código." });
            }
        }
    }
}
