using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Dto.Usuarios
{
    public class UsuarioUpdateDto
    {
        [Required]
        public int UsuarioID { get; set; }

        [Required, StringLength(50)]
        public string NombreUsuario { get; set; } = string.Empty;
        [Required]
        public int RolID { get; set; } 

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public bool Estado { get; set; }

    }
}
