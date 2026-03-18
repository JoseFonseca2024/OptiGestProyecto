namespace APIGestionCajaInventario.Dto.Documentos
{
    public class DocumentoRequestDto
    {
        public int EmpresaID { get; set; }
        public int TipoDocumentoID { get; set; }
        public int TurnoID { get; set; }
        public int UsuarioID { get; set; }
        public int? ClienteID { get; set; }
        public int? ProveedorID { get; set; }
        public decimal TasaIVA { get; set; }
        public int ConceptoID { get; set; }
        public List<DetalleDocumentoTempDto> Detalles { get; set; } = new();
    }
}
