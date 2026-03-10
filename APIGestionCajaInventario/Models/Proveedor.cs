using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace APIGestionCajaInventario.Models
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        [Required, MaxLength(100)]
        public string NombreProveedor { get; set; } = string.Empty;
        [Required, MaxLength(15)]
        public string TelefonoProveedor { get; set; } = string.Empty;
        [Required]
        public int EmpresaID { get; set; }

        public Empresa? Empresa { get; set; }
    }
}
