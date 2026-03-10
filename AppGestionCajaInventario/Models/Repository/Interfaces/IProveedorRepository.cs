using AppGestionCajaInventario.Models.Dto.Proveedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<ProveedorDto?>> GetAllPorEmpresaAsync();
        Task<ProveedorDto?> GetByIdPorEmpresaAsync(int id);
        Task<bool> CrearAsync(ProveedorCreateDto dto);
        Task<bool> ActualizarAsync(int id, ProveedorUpdateDto dto);
        Task<bool> EliminarAsync(int id);
    }
}
