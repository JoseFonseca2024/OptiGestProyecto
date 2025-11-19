using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Dto
{
    public class RegistroRequest
    {
        [Required]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Clave { get; set; } = string.Empty;
    }
}
