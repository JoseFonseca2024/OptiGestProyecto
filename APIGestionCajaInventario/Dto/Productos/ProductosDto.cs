using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace APIGestionCajaInventario.Dto.Productos
{
    public class ProductosDto
    {
        public int ProductoID { get; set; }
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public decimal CostoPromedio { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int StockActual { get; set; }
    }
}
