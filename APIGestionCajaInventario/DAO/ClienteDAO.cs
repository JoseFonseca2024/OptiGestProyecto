using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Models;
using APIGestionCajaInventario.Services.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace APIGestionCajaInventario.DAO
{
    public class ClienteDAO : IClienteRepository
    {
        private readonly ConexionDB _conexion;

        public ClienteDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }

        public Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return Task.FromException<IEnumerable<Cliente>>(
                new NotSupportedException("Usar GetAllPorEmpresaAsync con EmpresaID.")
            );
        }

        public async Task<IEnumerable<Cliente>> GetAllPorEmpresaAsync(int empresaId)
        {
            var lista = new List<Cliente>();

            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_CLIENTES_POR_EMPRESA, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                lista.Add(new Cliente
                {
                    ClienteID = reader.GetInt32(0),
                    NombreCliente = reader.GetString(1),
                    TelefonoCliente = reader.GetString(2),
                    EmpresaID = reader.GetInt32(3)
                });
            }

            return lista;
        }

        public Task<Cliente?> GetByIdAsync(int id)
        {
            return Task.FromException<Cliente?>(
                new NotSupportedException("Usar GetByIdPorEmpresaAsync con EmpresaID.")
            );
        }

        public async Task<Cliente?> GetByIdPorEmpresaAsync(int id, int empresaId)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_CLIENTE_POR_ID, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@ClienteID", id);
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Cliente
                {
                    ClienteID = reader.GetInt32(0),
                    NombreCliente = reader.GetString(1),
                    TelefonoCliente = reader.GetString(2),
                    EmpresaID = reader.GetInt32(3)
                };
            }

            return null;
        }

        public async Task<int> CreateAsync(Cliente cliente)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_CREAR_CLIENTE, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
            cmd.Parameters.AddWithValue("@TelefonoCliente", cliente.TelefonoCliente);
            cmd.Parameters.AddWithValue("@EmpresaID", cliente.EmpresaID);

            await cn.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }

        public async Task<bool> UpdateAsync(Cliente cliente)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_ACTUALIZAR_CLIENTE, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);
            cmd.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
            cmd.Parameters.AddWithValue("@TelefonoCliente", cliente.TelefonoCliente);
            cmd.Parameters.AddWithValue("@EmpresaID", cliente.EmpresaID);

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
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_CLIENTE, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@ClienteID", id);
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            return true;
        }
    }
}
