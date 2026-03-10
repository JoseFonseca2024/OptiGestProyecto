using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace APIGestionCajaInventario.DAO
{
    public class ProveedorDAO : IProveedorRepository
    {
        private readonly ConexionDB _conexion;

        public ProveedorDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }

        public Task<IEnumerable<Proveedor>> GetAllAsync()
        {
            return Task.FromException<IEnumerable<Proveedor>>(
                new NotSupportedException("Usar GetAllPorEmpresaAsync con EmpresaID.")
            );
        }

        public async Task<IEnumerable<Proveedor>> GetAllPorEmpresaAsync(int empresaId)
        {
            var lista = new List<Proveedor>();

            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_PROVEEDORES_POR_EMPRESA, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                lista.Add(new Proveedor
                {
                    ProveedorID = reader.GetInt32(0),
                    NombreProveedor = reader.GetString(1),
                    TelefonoProveedor = reader.GetString(2),
                    EmpresaID = reader.GetInt32(3)
                });
            }

            return lista;
        }

        public Task<Proveedor?> GetByIdAsync(int id)
        {
            return Task.FromException<Proveedor?>(
                new NotSupportedException("Usar GetByIdPorEmpresaAsync con EmpresaID.")
            );
        }

        public async Task<Proveedor?> GetByIdPorEmpresaAsync(int id, int empresaId)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_PROVEEDOR_POR_ID, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@ProveedorID", id);
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Proveedor
                {
                    ProveedorID = reader.GetInt32(0),
                    NombreProveedor = reader.GetString(1),
                    TelefonoProveedor = reader.GetString(2),
                    EmpresaID = reader.GetInt32(3)
                };
            }

            return null;
        }

        public async Task<int> CreateAsync(Proveedor proveedor)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_CREAR_PROVEEDOR, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
            cmd.Parameters.AddWithValue("@TelefonoProveedor", proveedor.TelefonoProveedor);
            cmd.Parameters.AddWithValue("@EmpresaID", proveedor.EmpresaID);

            await cn.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }

        public async Task<bool> UpdateAsync(Proveedor proveedor)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_ACTUALIZAR_PROVEEDOR, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@ProveedorID", proveedor.ProveedorID);
            cmd.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
            cmd.Parameters.AddWithValue("@TelefonoProveedor", proveedor.TelefonoProveedor);
            cmd.Parameters.AddWithValue("@EmpresaID", proveedor.EmpresaID);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            return true;
        }

        public Task<bool> DeleteAsync(int id)
        {
            return Task.FromException<bool>(
                new NotSupportedException("Usar DeletePorEmpresaAsync con EmpresaID.")
            );
        }

        public async Task<bool> DeletePorEmpresaAsync(int id, int empresaId)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_PROVEEDOR, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@ProveedorID", id);
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);
            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            return true;
        }

    }
}
