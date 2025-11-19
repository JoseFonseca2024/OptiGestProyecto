namespace APIGestionCajaInventario.Dto.Productos
{
    public class ProductosUpdateDto
    {
        public string NombreProducto { get; set; }

        public string CodigoProducto { get; set; }

        public decimal CostoPromedio { get; set; }

        public decimal PrecioUnitario { get; set; }
    }
}
