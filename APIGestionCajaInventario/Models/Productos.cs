using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }

        [Required, StringLength(100)]
        public string NombreProducto { get; set; } = string.Empty;

        [Required, StringLength(25)]
        public string CodigoProducto { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue)]
        public decimal CostoPromedio { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal PrecioUnitario { get; set; }
        public int StockActual { get; set; }

        [Required]
        public int EmpresaID { get; set; }

        public Empresa? Empresa { get; set; }
    }
}
