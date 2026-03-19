namespace APIGestionCajaInventario.Dto.Documentos
{
    public class DetalleDocumentoDto
    {
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto {  get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PorcentajeDescuento { get; set; }
    }
}