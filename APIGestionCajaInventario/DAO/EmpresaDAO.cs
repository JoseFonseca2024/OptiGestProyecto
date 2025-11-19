using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Dto;
using APIGestionCajaInventario.Dto.Empresas;
using APIGestionCajaInventario.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
using System.Data;

namespace APIGestionCajaInventario.DAO
{
    public class EmpresaDAO
    {
        private readonly ConexionDB _conexion;

        public EmpresaDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }

        public async Task<Empresa?> ObtenerEmpresaUnicaPorUsuarioAsync(int usuarioId)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand($@"
            SELECT TOP 1 EmpresaID, NombreEmpresa, RUC, Direccion, Telefono, Actividad
            FROM {Vistas.VW_EMPRESASPORUSUARIOS}
            WHERE UsuarioID = @UsuarioID", cn);

            cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            if (!reader.Read()) return null;

            return new Empresa
            {
                EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                NombreEmpresa = reader["NombreEmpresa"].ToString()!,
                RUC = reader["RUC"].ToString()!,
                Direccion = reader["Direccion"].ToString()!,
                Telefono = reader["Telefono"].ToString()!,
                Actividad = reader["Actividad"].ToString()!
            };
        }

        public async Task<int> CrearEmpresaYAsociarConUsuarioAsync(EmpresaCreateDto dto, int usuarioId)
        {
            using var cn = _conexion.GetConnection();
            using var command = new SqlCommand(Procedimientos.SP_CREAR_EMPRESA_Y_ASOCIAR_CON_USUARIO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@NombreEmpresa", dto.NombreEmpresa);
            command.Parameters.AddWithValue("@RUC", dto.RUC);
            command.Parameters.AddWithValue("@Direccion", dto.Direccion);
            command.Parameters.AddWithValue("@Telefono", dto.Telefono);
            command.Parameters.AddWithValue("@Actividad", dto.Actividad);
            command.Parameters.AddWithValue("@UsuarioID", usuarioId);

            await cn.OpenAsync();
            var result = await command.ExecuteScalarAsync();

            if (result == null || result == DBNull.Value)
                throw new Exception("No se pudo obtener el ID de la empresa creada.");

            return Convert.ToInt32(result);
        }

        public async Task<List<Empresa>> ObtenerEmpresasPorRucAsync(string ruc)
        {
            var empresas = new List<Empresa>();

            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand("SELECT * FROM Empresas WHERE RUC = @RUC", cn);
            cmd.Parameters.AddWithValue("@RUC", ruc);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                empresas.Add(new Empresa
                {
                    EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                    NombreEmpresa = reader["NombreEmpresa"].ToString()!,
                    RUC = reader["RUC"].ToString()!,
                    Telefono = reader["Telefono"].ToString()!,
                    Actividad = reader["Actividad"].ToString()!
                });
            }

            return empresas;
        }

        public async Task<(bool ok, string error)> ActualizarEmpresaAsync(Empresa empresa)
        {
            try
            {
                using var cn = _conexion.GetConnection();
                using var cmd = new SqlCommand(Procedimientos.SP_ACTUALIZAR_EMPRESA, cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@EmpresaID", empresa.EmpresaID);
                cmd.Parameters.AddWithValue("@NombreEmpresa", empresa.NombreEmpresa);
                cmd.Parameters.AddWithValue("@RUC", empresa.RUC);
                cmd.Parameters.AddWithValue("@Direccion", empresa.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", empresa.Telefono);
                cmd.Parameters.AddWithValue("@Actividad", empresa.Actividad);

                await cn.OpenAsync();
                var filas = await cmd.ExecuteNonQueryAsync();

                if (filas == 0)
                    return (false, "La actualización no afectó ninguna fila.");

                return (true, string.Empty);
            }
            catch (SqlException ex)
            {
                return (false, $"Error SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error general: {ex.Message}");
            }
        }
    }
}
