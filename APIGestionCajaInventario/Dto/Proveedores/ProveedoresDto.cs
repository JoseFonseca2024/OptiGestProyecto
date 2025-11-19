using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Dto.Proveedores
{
    public class ProveedoresDto
    {
        public int ProveedorID { get; set; }
        public string NombreProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
    }
}
