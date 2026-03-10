using AppGestionCajaInventario.Models.Dto.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<ClienteDto?>> ObtenerClientesPorEmpresaAsync();
        Task<ClienteDto?> ObtenerPorIdAsync(int id);
        Task<bool> CrearAsync(ClienteCreateDto dto);
        Task<bool> ActualizarAsync(int id, ClienteUpdateDto dto);
        Task<bool> EliminarAsync(int id);
    }
}
