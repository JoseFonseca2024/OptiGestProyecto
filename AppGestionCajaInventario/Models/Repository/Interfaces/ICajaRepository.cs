using AppGestionCajaInventario.Models.Dto.Cajas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface ICajaRepository
    {
        Task<List<CajasDto>> ObtenerCajasporEmpresaAsync();
        Task<CajasDto?> ObtenerPorIdAsync(int id);
        Task<bool> CrearAsync(CajaCreateDto dto);
        Task<bool> ActualizarAsync(int id, CajaUpdateDto dto);
        Task<bool> EliminarAsync(int id);
        Task<bool> TransferirAsync(int origenId, int destinoId, decimal monto);
    }
}
