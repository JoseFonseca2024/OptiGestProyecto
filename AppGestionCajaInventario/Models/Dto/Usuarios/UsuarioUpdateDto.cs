using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Usuarios
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
