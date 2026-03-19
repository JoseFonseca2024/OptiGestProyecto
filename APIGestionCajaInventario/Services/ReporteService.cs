using APIGestionCajaInventario.DAO;

namespace APIGestionCajaInventario.Services
{
    public class ReporteService
    {
        private readonly ReporteDAO _dao;

        public ReporteService(ReporteDAO dao)
        {
            _dao = dao;
        }

        public async Task<List<Dictionary<string, object>>> GetVentasPorAnio(int anio, int empresaId)
        {
            return await _dao.ObtenerVentasPorAnioAsync(anio, empresaId);
        }
    }
}
