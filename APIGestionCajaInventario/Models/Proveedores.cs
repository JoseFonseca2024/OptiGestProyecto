using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace APIGestionCajaInventario.Models
{
    public class Proveedores
    {
        public int ProveedorID { get; set; }
        [Required, MaxLength(100)]
        public string NombreProveedor { get; set; }
        [Required, MaxLength(15)]
        public string TelefonoProveedor { get; set; }
    }
}
