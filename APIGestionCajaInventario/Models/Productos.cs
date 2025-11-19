using System.ComponentModel.DataAnnotations;

namespace APIGestionCajaInventario.Models
{
    public class Productos
    {
        public int ProductoID { get; set; }
        [Required, MaxLength(100)]
        public string NombreProducto { get; set; }
        [Required, MaxLength(50)]
        public string CodigoProducto { get; set; }
        [Required]
        public decimal CostoPromedio { get; set; }
        [Required]
        public decimal PrecioUnitario { get; set; }
    }
}
