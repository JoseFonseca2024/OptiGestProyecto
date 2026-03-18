using APIGestionCajaInventario.DAO;
using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Dto.Documentos;
using Microsoft.Data.SqlClient;

namespace APIGestionCajaInventario.Services
{
    public class DocumentoService
    {
        private readonly DocumentosDAO _documentosDAO;
        private readonly ConexionDB _conexionDB;

        public DocumentoService(DocumentosDAO documentosDAO, ConexionDB conexionDB)
        {
            _documentosDAO = documentosDAO;
            _conexionDB = conexionDB;
        }

        public async Task<DocumentoResponseDto> RegistrarDocumentoAsync(DocumentoRequestDto request)
        {
            // Validaciones básicas
            if (request.EmpresaID <= 0) throw new ArgumentException("EmpresaID inválido");
            if (request.TipoDocumentoID <= 0) throw new ArgumentException("TipoDocumentoID inválido");
            if (request.TurnoID <= 0) throw new ArgumentException("TurnoID inválido");
            if (request.UsuarioID <= 0) throw new ArgumentException("UsuarioID inválido");
            if (request.TasaIVA <= 0) throw new ArgumentException("La tasa IVA debe ser mayor a 0");
            if (request.Detalles == null || !request.Detalles.Any()) throw new ArgumentException("Debe incluir al menos un detalle");

            // Reglas de negocio específicas
            if (request.TipoDocumentoID == 1 && request.ClienteID == null)
                throw new ArgumentException("Factura requiere ClienteID");

            if (request.TipoDocumentoID == 2 && request.ProveedorID == null)
                throw new ArgumentException("Compra requiere ProveedorID");

            // Validar turno activo
            using var cn = _conexionDB.GetConnection();
            using var cmd = new SqlCommand("SELECT Activo FROM TurnosOperativos WHERE TurnoID = @TurnoID", cn);
            cmd.Parameters.AddWithValue("@TurnoID", request.TurnoID);
            await cn.OpenAsync();
            var activo = (bool?)await cmd.ExecuteScalarAsync();

            if (activo != true)
                throw new InvalidOperationException("El turno no está activo, no se puede registrar el documento.");

            // Llamada al DAO
            var response = await _documentosDAO.RegistrarDocumentoAsync(request);

            // Ajustes de estado según tipo de documento
            if (request.TipoDocumentoID == 1) response.Estado = "Pagada";
            else if (request.TipoDocumentoID == 2) response.Estado = "Emitida";

            return response;
        }
    }

}
