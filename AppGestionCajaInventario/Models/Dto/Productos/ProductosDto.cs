using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Productos
{
    public class ProductosDto
    {
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; } = string.Empty;
        public string CodigoProducto { get; set; } = string.Empty;
        public decimal CostoPromedio { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int StockActual { get; set; } 
    }
}
