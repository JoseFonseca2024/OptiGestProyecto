using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace APIGestionCajaInventario.DAO
{
    public class ProductoDAO : IRepository<Producto>
    {
        private readonly ConexionDB _conexion;

        public ProductoDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            var productos = new List<Producto>();
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_PRODUCTOS, cn) { CommandType = CommandType.StoredProcedure };

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                productos.Add(new Producto
                {
                    ProductoID = Convert.ToInt32(reader["ProductoID"]),
                    EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                    CodigoProducto = reader["CodigoProducto"].ToString()!,
                    NombreProducto = reader["NombreProducto"].ToString()!,
                    CostoPromedio = Convert.ToDecimal(reader["CostoPromedio"]),
                    PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                    StockActual = reader["StockActual"] is DBNull ? 0 : Convert.ToInt32(reader["StockActual"])
                });
            }

            return productos;
        }

        public async Task<IEnumerable<Producto>> GetByEmpresaAsync(int empresaId)
        {
            var productos = new List<Producto>();
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_PRODUCTOS_POR_EMPRESA, cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                productos.Add(new Producto
                {
                    ProductoID = Convert.ToInt32(reader["ProductoID"]),
                    EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                    CodigoProducto = reader["CodigoProducto"].ToString()!,
                    NombreProducto = reader["NombreProducto"].ToString()!,
                    CostoPromedio = Convert.ToDecimal(reader["CostoPromedio"]),
                    PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                    StockActual = reader["StockActual"] is DBNull ? 0 : Convert.ToInt32(reader["StockActual"])
                });
            }

            return productos;
        }

        public async Task<Producto?> GetByIdAsync(int id)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_PRODUCTOS_POR_ID, cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@ProductoID", id);

            await cn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                return new Producto
                {
                    ProductoID = Convert.ToInt32(reader["ProductoID"]),
                    EmpresaID = Convert.ToInt32(reader["EmpresaID"]),
                    CodigoProducto = reader["CodigoProducto"].ToString()!,
                    NombreProducto = reader["NombreProducto"].ToString()!,
                    CostoPromedio = Convert.ToDecimal(reader["CostoPromedio"]),
                    PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                    StockActual = reader["StockActual"] is DBNull ? 0 : Convert.ToInt32(reader["StockActual"])
                };
            }

            return null;
        }

        public async Task<int> CreateAsync(Producto entity)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_CREAR_PRODUCTO, cn) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@EmpresaID", entity.EmpresaID);
            cmd.Parameters.AddWithValue("@CodigoProducto", entity.CodigoProducto);
            cmd.Parameters.AddWithValue("@NombreProducto", entity.NombreProducto);
            cmd.Parameters.AddWithValue("@CostoPromedio", entity.CostoPromedio);
            cmd.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);

            await cn.OpenAsync();
            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }

        public async Task<bool> UpdateAsync(Producto entity)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_ACTUALIZAR_PRODUCTO, cn) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@ProductoID", entity.ProductoID);
            cmd.Parameters.AddWithValue("@CodigoProducto", entity.CodigoProducto);
            cmd.Parameters.AddWithValue("@NombreProducto", entity.NombreProducto);
            cmd.Parameters.AddWithValue("@CostoPromedio", entity.CostoPromedio);
            cmd.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return true; 
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_ELIMINAR_PRODUCTO, cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@ProductoID", id);

            await cn.OpenAsync();
            var rows = await cmd.ExecuteNonQueryAsync();
            return rows > 0;
        }
    }
}
