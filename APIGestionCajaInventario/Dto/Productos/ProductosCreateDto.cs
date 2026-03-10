namespace APIGestionCajaInventario.Dto.Productos
{
    public class ProductosCreateDto
    {
        public string NombreProducto { get; set; } = string.Empty;

        public string CodigoProducto { get; set; } = string.Empty;

        public decimal CostoPromedio { get; set; }

        public decimal PrecioUnitario { get; set; }
    }
}
