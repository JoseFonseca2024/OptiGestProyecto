namespace APIGestionCajaInventario.Dto.Productos
{
    public class ProductosCreateDto
    {
        public string NombreProducto { get; set; }

        public string CodigoProducto { get; set; }

        public decimal CostoPromedio { get; set; }

        public decimal PrecioUnitario { get; set; }
    }
}
