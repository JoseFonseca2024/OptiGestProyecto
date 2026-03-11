using APIGestionCajaInventario.Data;
using Microsoft.Data.SqlClient;

namespace APIGestionCajaInventario.DAO
{
    public class ReporteDAO
    {
        private readonly ConexionDB _conexion;

        public ReporteDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Dictionary<string, object>>> ObtenerVentasPorAnioAsync(int anio)
        {
            var lista = new List<Dictionary<string, object>>();

            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(
                "SELECT * FROM vw_VentasMovimientos WHERE YEAR(FechaMovimiento) = @Anio ORDER BY FechaMovimiento;", cn);

            cmd.Parameters.AddWithValue("@Anio", anio);

            await cn.OpenAsync();
            using var dr = await cmd.ExecuteReaderAsync();
            while (await dr.ReadAsync())
            {
                var fila = new Dictionary<string, object>
                {
                    ["MovimientoCajaID"] = dr["MovimientoCajaID"],
                    ["NombreConcepto"] = dr["NombreConcepto"],
                    ["TipodeMovimiento"] = dr["TipodeMovimiento"],
                    ["Monto"] = dr["Monto"],
                    ["FechaMovimiento"] = dr["FechaMovimiento"]
                };
                lista.Add(fila);
            }

            return lista;
        }
    }
}
