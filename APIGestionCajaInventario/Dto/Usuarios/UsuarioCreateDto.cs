using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Dto.Usuarios
{
    public class UsuarioCreateDto
    {
        [Required, StringLength(50)]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Clave { get; set; } = string.Empty;

        [Required]
        public int RolID { get; set; }  

        public bool Estado { get; set; } = true;
    }
}
