using APIGestionCajaInventario.Data;
using APIGestionCajaInventario.Dto.Usuarios;
using APIGestionCajaInventario.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace APIGestionCajaInventario.DAO
{
    public class UsuarioDAO
    {
        private readonly ConexionDB _conexion;

        public UsuarioDAO(ConexionDB conexion)
        {
            _conexion = conexion;
        }

        public async Task<Usuario?> ValidarUsuarioAsync(string nombre, string clave)
        {
            using var cn = _conexion.GetConnection();
            await cn.OpenAsync();

            using var cmd = new SqlCommand(Procedimientos.SP_VALIDARUSUARIO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@NombreUsuario", nombre);
            cmd.Parameters.AddWithValue("@Clave", clave);

            using var dr = await cmd.ExecuteReaderAsync();
            if (await dr.ReadAsync())
            {
                return new Usuario
                {
                    UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                    NombreUsuario = dr["NombreUsuario"].ToString()!,
                    Rol = dr["NombreRol"].ToString()!
                };
            }

            return null;
        }

        public async Task<bool> UsuarioOCorreoExisteAsync(string nombreUsuario, string email)
        {
            using var cn = _conexion.GetConnection();
            await cn.OpenAsync();

            using var cmd = new SqlCommand(Procedimientos.SP_VERIFICAR_USUARIO_O_CORREO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@Email", email);

            var result = await cmd.ExecuteScalarAsync();
            return result != null && Convert.ToBoolean(result);
        }

        public async Task<int> RegistrarUsuarioInicialAsync(string nombreUsuario, string email, string clave)
        {
            using var cn = _conexion.GetConnection();
            await cn.OpenAsync();

            using var cmd = new SqlCommand(Procedimientos.SP_REGISTRARUSUARIOINICIAL, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Clave", clave);

            var result = await cmd.ExecuteScalarAsync();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public async Task<List<Usuario>> ObtenerUsuariosPorEmpresaAsync(int adminId)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_USUARIOS_POR_EMPRESA, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@UsuarioID", adminId);

            var usuarios = new List<Usuario>();
            await cn.OpenAsync();
            using var dr = await cmd.ExecuteReaderAsync();
            while (await dr.ReadAsync())
            {
                usuarios.Add(new Usuario
                {
                    UsuarioID = Convert.ToInt32(dr["UsuarioID"]),
                    NombreUsuario = dr["NombreUsuario"].ToString()!,
                    Email = dr["Email"].ToString()!,
                    Rol = dr["Rol"].ToString()!,
                    Estado = Convert.ToBoolean(dr["Estado"]),
                    FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"])
                });
            }

            return usuarios;
        }

        public async Task<Empresa?> ObtenerEmpresaPorUsuarioAsync(int usuarioId)
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand(Procedimientos.SP_OBTENER_EMPRESA_POR_USUARIO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);

            await cn.OpenAsync();
            using var dr = await cmd.ExecuteReaderAsync();
            if (!await dr.ReadAsync()) return null;

            return new Empresa
            {
                EmpresaID = Convert.ToInt32(dr["EmpresaID"]),
                NombreEmpresa = dr["NombreEmpresa"].ToString()!
            };
        }

        public async Task<int> RegistrarUsuarioEnEmpresaAsync(UsuarioCreateDto dto, int empresaId)
        {
            using var cn = _conexion.GetConnection();
            await cn.OpenAsync();

            using var cmd = new SqlCommand(Procedimientos.SP_REGISTRAR_USUARIO_EN_EMPRESA, cn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@NombreUsuario", dto.NombreUsuario);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@Clave", dto.Clave);
            cmd.Parameters.AddWithValue("@RolID", dto.RolID);
            cmd.Parameters.AddWithValue("@Estado", dto.Estado);
            cmd.Parameters.AddWithValue("@EmpresaID", empresaId);

            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }

        public async Task<bool> ActualizarUsuarioAsync(UsuarioUpdateDto dto)
        {
            using var cn = _conexion.GetConnection();
            await cn.OpenAsync();

            using var cmd = new SqlCommand(Procedimientos.SP_ACTUALIZAR_USUARIO, cn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@UsuarioID", dto.UsuarioID);
            cmd.Parameters.AddWithValue("@NombreUsuario", dto.NombreUsuario);
            cmd.Parameters.AddWithValue("@RolID", dto.RolID);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@Estado", dto.Estado);

            try
            {
                var rows = await cmd.ExecuteNonQueryAsync();
                Console.WriteLine($"Actualización: UsuarioID={dto.UsuarioID}, Filas afectadas={rows}");

                if (rows == 0)
                {
                    // Verifica si el usuario existe
                    using var checkCmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE UsuarioID = @UsuarioID", cn);
                    checkCmd.Parameters.AddWithValue("@UsuarioID", dto.UsuarioID);
                    var count = (int?)await checkCmd.ExecuteScalarAsync();
                    if (count == 0)
                        throw new Exception("Usuario no encontrado.");
                    else
                        throw new Exception("No hubo cambios en los datos del usuario (valores idénticos).");
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error SQL en actualización: {ex.Message}");
                throw new Exception($"Error en la base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general en actualización: {ex.Message}");
                throw;
            }
        }
        public async Task<List<Rol>> ObtenerRolesAsync()
        {
            using var cn = _conexion.GetConnection();
            using var cmd = new SqlCommand("SELECT RolID, NombreRol FROM Roles", cn);

            var roles = new List<Rol>();
            await cn.OpenAsync();
            using var dr = await cmd.ExecuteReaderAsync();
            while (await dr.ReadAsync())
            {
                roles.Add(new Rol
                {
                    RolID = Convert.ToInt32(dr["RolID"]),
                    NombreRol = dr["NombreRol"].ToString()!
                });
            }

            return roles;
        }
    }

}