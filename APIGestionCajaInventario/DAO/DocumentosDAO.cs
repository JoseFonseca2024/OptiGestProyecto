using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Dto.Documentos;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace APIGestionCajaInventario.DAO
{
    public class DocumentosDAO
    {
        private readonly ConexionDB _conexionDB;

        public DocumentosDAO(ConexionDB conexionDB)
        {
            _conexionDB = conexionDB;
        }

        public async Task<DocumentoResponseDto> RegistrarDocumentoAsync(DocumentoRequestDto request, int empresaId)
        {
            var detallesXml = new XElement("Detalles",
            request.Detalles.Select(d =>
                new XElement("Detalle",
                    new XAttribute("ProductoID", d.ProductoID),
                    new XAttribute("CodigoProducto", d.CodigoProducto),
                    new XAttribute("NombreProducto", d.NombreProducto),
                    new XAttribute("Cantidad", d.Cantidad),
                    new XAttribute("PrecioUnitario", d.PrecioUnitario),
                    new XAttribute("Descuento", d.PorcentajeDescuento)
                )
            )
        );

            using var cn = _conexionDB.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_REGISTRARDOCUMENTO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);
            cmd.Parameters.AddWithValue("@ClienteID", (object?)request.ClienteID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ProveedorID", (object?)request.ProveedorID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@TurnoID", request.TurnoID);
            cmd.Parameters.AddWithValue("@TasaIVA", request.TasaIVA);
            cmd.Parameters.AddWithValue("@UsuarioID", request.UsuarioID);
            cmd.Parameters.AddWithValue("@TipoDocumentoID", request.TipoDocumentoID);
            cmd.Parameters.AddWithValue("@ConceptoID", request.ConceptoID); 
            cmd.Parameters.AddWithValue("@Detalles", detallesXml.ToString());


            await cn.OpenAsync();

            DocumentoResponseDto response = new DocumentoResponseDto();

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                response.NumeroDocumento = reader["NumeroDocumento"].ToString() ?? string.Empty;
                response.Subtotal = reader.GetDecimal(reader.GetOrdinal("Subtotal"));
                response.IVA = reader.GetDecimal(reader.GetOrdinal("IVA"));
                response.TotalFactura = reader.GetDecimal(reader.GetOrdinal("TotalFactura"));
                response.Estado = reader["Estado"].ToString() ?? "Emitida";

                response.EmpresaNombre = reader["EmpresaNombre"].ToString() ?? string.Empty;
                response.EmpresaRUC = reader["EmpresaRUC"].ToString() ?? string.Empty;
                response.ClienteNombre = reader["ClienteNombre"].ToString() ?? string.Empty;
                response.ClienteTelefono = reader["ClienteTelefono"].ToString() ?? string.Empty;
                response.FechaDocumento = reader.GetDateTime(reader.GetOrdinal("FechaDocumento"));
            }


            if (await reader.NextResultAsync())
            {
                response.Detalles = new List<DetalleDocumentoDto>();
                while (await reader.ReadAsync())
                {
                    response.Detalles.Add(new DetalleDocumentoDto
                    {
                        CodigoProducto = reader["CodigoProducto"].ToString() ?? "",
                        NombreProducto = reader["NombreProducto"].ToString() ?? "",
                        Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                        PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PrecioUnitario")),
                        PorcentajeDescuento = reader.GetDecimal(reader.GetOrdinal("PorcentajeDescuento"))
                    });
                }
            }

            return response;
        }

    }
}
