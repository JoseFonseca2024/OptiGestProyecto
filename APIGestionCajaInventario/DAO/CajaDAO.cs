using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace APIGestionCajaInventario.DAO
{
    public class CajaDAO : IRepository<Cajas>
    {
        private readonly ConexionDB _conexion;

        public CajaDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }

        public async Task<IEnumerable<Cajas>> GetAllAsync()
        {
            var cajas = new List<Cajas>();
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_CAJAS, cn) { CommandType = CommandType.StoredProcedure };

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                cajas.Add(new Cajas
                {
                    CajaID = Convert.ToInt32(reader["CajaID"]),
                    EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                    NombreCaja = reader["NombreCaja"].ToString()!,
                    SaldoActual = Convert.ToDecimal(reader["SaldoActual"]),
                    Activa = Convert.ToBoolean(reader["Activa"])
                });
            }

            return cajas;
        }

        public async Task<IEnumerable<Cajas>> GetByEmpresaAsync(int empresaId)
        {
            var cajas = new List<Cajas>();
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_CAJAS_POR_EMPRESA, cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                cajas.Add(new Cajas
                {
                    CajaID = Convert.ToInt32(reader["CajaID"]),
                    EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                    NombreCaja = reader["NombreCaja"].ToString()!,
                    SaldoActual = Convert.ToDecimal(reader["SaldoActual"]),
                    Activa = Convert.ToBoolean(reader["Activa"]),
                    EmpresaNombre = reader["NombreEmpresa"].ToString()!
                });
            }

            return cajas;
        }

        public async Task<Cajas?> GetByIdAsync(int id)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_CAJA_POR_ID, cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@CajaID", id);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                return new Cajas
                {
                    CajaID = Convert.ToInt32(reader["CajaID"]),
                    EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                    NombreCaja = reader["NombreCaja"].ToString()!,
                    SaldoActual = Convert.ToDecimal(reader["SaldoActual"]),
                    Activa = Convert.ToBoolean(reader["Activa"]),
                    EmpresaNombre = reader["NombreEmpresa"].ToString()!
                };
            }

            return null;
        }
        public async Task<int> CreateAsync(Cajas entity)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_CREAR_CAJA, cn) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@EmpresaID", entity.EmpresaID);
            cmd.Parameters.AddWithValue("@NombreCaja", entity.NombreCaja);

            await cn.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }

        public async Task<bool> UpdateAsync(Cajas entity)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_ACTUALIZAR_CAJA, cn) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@CajaID", entity.CajaID);
            cmd.Parameters.AddWithValue("@NombreCaja", entity.NombreCaja);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_CAJA, cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@CajaID", id);

            await cn.OpenAsync();
            var rows = await cmd.ExecuteNonQueryAsync();
            return rows > 0;
        }

        public async Task<bool> TransferirAsync(int cajaOrigenId, int cajaDestinoId, decimal monto)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_TRANSFERENCIA_ENTRE_CAJAS, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@CajaOrigenID", cajaOrigenId);
            cmd.Parameters.AddWithValue("@CajaDestinoID", cajaDestinoId);
            cmd.Parameters.AddWithValue("@Monto", monto);

            await cn.OpenAsync();
            try
            {
                await cmd.ExecuteNonQueryAsync();
                return true;
            }
            catch (SqlException)
            {
                // Podés loguear el error o devolver false si falla la transferencia
                return false;
            }
        }
    }
}
