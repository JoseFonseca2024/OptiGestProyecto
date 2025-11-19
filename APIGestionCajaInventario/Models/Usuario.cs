using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        [Required, StringLength(50)]
        public string NombreUsuario { get; set; } = string.Empty;
        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Rol { get; set; } = string.Empty;  
        public bool Estado { get; set; } = true;
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
    }
}
