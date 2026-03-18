using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Dto.Turnos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace APIGestionCajaInventario.DAO
{
    public class TurnoDAO
    {
        private readonly ConexionDB _conexion;

        public TurnoDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }

        public async Task<int> AbrirTurnoAsync(int cajaId, int usuarioId, decimal montoInicial)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_ABRIR_TURNO, cn) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@CajaID", cajaId);
            cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);
            cmd.Parameters.AddWithValue("@MontoInicial", montoInicial);

            await cn.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result); // Devuelve TurnoID
        }

        public async Task<TurnoDto?> ObtenerTurnoActivoAsync(int usuarioId)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_TURNO_ACTIVO, cn) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                return new TurnoDto
                {
                    TurnoID = reader.GetInt32(reader.GetOrdinal("TurnoID")),
                    CajaID = reader.GetInt32(reader.GetOrdinal("CajaID")),
                    UsuarioID = reader.GetInt32(reader.GetOrdinal("UsuarioID")),
                    FechaApertura = reader.GetDateTime(reader.GetOrdinal("FechaApertura")),
                    MontoInicial = reader.GetDecimal(reader.GetOrdinal("MontoInicial"))
                };
            }

            return null;
        }


    }
}
