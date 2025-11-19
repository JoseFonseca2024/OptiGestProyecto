using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Productos
{
    public class ProductosUpdateDto
    {

        public string NombreProducto { get; set; }

        public string CodigoProducto { get; set; }

        public decimal CostoPromedio { get; set; }

        public decimal PrecioUnitario { get; set; }
    }
}
