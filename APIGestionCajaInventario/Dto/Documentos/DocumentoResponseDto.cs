namespace APIGestionCajaInventario.Dto.Documentos
{

    public class DocumentoResponseDto
    {
        public string NumeroDocumento { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public decimal Subtotal { get; set; }      
        public decimal IVA { get; set; }          
        public decimal TotalFactura { get; set; }

        public string EmpresaNombre { get; set; } = string.Empty;
        public string EmpresaRUC { get; set; } = string.Empty;
        public string ClienteNombre { get; set; } = string.Empty;
        public string ClienteTelefono { get; set; } = string.Empty;
        public DateTime FechaDocumento { get; set; }

        public List<DetalleDocumentoDto> Detalles { get; set; } = new();
    }



}
