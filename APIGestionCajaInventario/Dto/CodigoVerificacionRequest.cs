using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Dto
{
    public class CodigoVerificacionRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Codigo { get; set; } = string.Empty;
    }
}
