using APIGestionCajaInventario.Models;

namespace APIGestionCajaInventario.DAO.Interfaces
{
    public interface IProveedorRepository : IRepository<Proveedor>
    {
        Task<IEnumerable<Proveedor>> GetAllPorEmpresaAsync(int empresaId);
        Task<Proveedor?> GetByIdPorEmpresaAsync(int id, int empresaId);
        Task<bool> DeletePorEmpresaAsync(int id, int empresaId);
    }
}
