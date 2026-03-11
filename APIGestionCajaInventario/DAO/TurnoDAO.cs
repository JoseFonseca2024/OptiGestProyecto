using APIGestionCajaInventario.Data;
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

    }
}
