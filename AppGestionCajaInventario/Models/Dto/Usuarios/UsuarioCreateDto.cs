using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Usuarios
{
    public class UsuarioCreateDto
    {
        [Required]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Clave { get; set; } = string.Empty;

        [Required]
        public int RolID { get; set; }

        [Required]
        public bool Estado { get; set; } = true;
    }
}
