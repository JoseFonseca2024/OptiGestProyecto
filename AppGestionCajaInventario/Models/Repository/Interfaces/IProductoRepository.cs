using AppGestionCajaInventario.Models.Dto.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<ProductosDto>> ObtenerProductosPorEmpresaAsync();
        Task<ProductosDto?> ObtenerPorIdAsync(int id);
        Task<bool> CrearAsync(ProductosCreateDto dto);
        Task<bool> ActualizarAsync(int id, ProductosUpdateDto dto);
        Task<bool> EliminarAsync(int id);
    }
}
