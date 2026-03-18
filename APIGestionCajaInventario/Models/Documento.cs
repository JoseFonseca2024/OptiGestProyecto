namespace APIGestionCajaInventario.Models
{
    public class Documento
    {
        public int DocumentoID { get; set; }

        public required int EmpresaID { get; set; }

        public string? NumeroDocumento { get; set; }

        public required int TipoDocumentoID { get; set; }

        public required int TurnoID { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int? ClienteID { get; set; }
        public int? ProveedorID { get; set; }

        public required decimal TasaIVA { get; set; }

        public string Estado { get; set; } = "Emitida";
    }


}
