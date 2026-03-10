using APIGestionCajaInventario.DAO.Interfaces;
using APIGestionCajaInventario.Models;

namespace APIGestionCajaInventario.Services.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> GetAllPorEmpresaAsync(int empresaId);
        Task<Cliente?> GetByIdPorEmpresaAsync(int id, int empresaId);
        Task<bool> DeletePorEmpresaAsync(int id, int empresaId);
    }
}
