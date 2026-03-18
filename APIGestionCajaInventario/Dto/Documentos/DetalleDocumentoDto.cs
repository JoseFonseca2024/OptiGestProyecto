namespace APIGestionCajaInventario.Dto.Documentos
{
    public class DetalleDocumentoDto
    {
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PorcentajeDescuento { get; set; }
    }
}