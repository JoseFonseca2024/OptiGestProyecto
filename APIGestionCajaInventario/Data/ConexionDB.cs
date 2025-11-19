using Microsoft.Data.SqlClient;

namespace APIGestionCajaInventario.Data
{
    public class ConexionDB
    {
        private readonly string _cadenaSQL;

        public ConexionDB(IConfiguration configuration)
        {
            _cadenaSQL = configuration.GetConnectionString("CadenaSQL")!;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_cadenaSQL);
        }
    }

}
