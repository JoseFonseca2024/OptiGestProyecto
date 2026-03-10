using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Proveedores
{
    public class ProveedorCreateDto
    {
        public string NombreProveedor { get; set; } = string.Empty;
        public string TelefonoProveedor { get; set; } = string.Empty;
    }
}
