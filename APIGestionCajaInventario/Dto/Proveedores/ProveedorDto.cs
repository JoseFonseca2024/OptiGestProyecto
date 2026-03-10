using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Dto.Proveedores
{
    public class ProveedorDto
    {
        public int ProveedorID { get; set; }
        public string NombreProveedor { get; set; } = string.Empty;
        public string TelefonoProveedor { get; set; } = string.Empty;

    }
}
