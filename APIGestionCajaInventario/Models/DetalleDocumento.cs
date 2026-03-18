namespace APIGestionCajaInventario.Models
{
    public class DetalleDocumento
    {
        public int DetalleID { get; set; }

        public required int DocumentoID { get; set; }
        public required int ProductoID { get; set; }
        public required int Cantidad { get; set; }
        public required decimal PrecioUnitario { get; set; }
        public decimal PorcentajeDescuento { get; set; } = 0;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }

}
