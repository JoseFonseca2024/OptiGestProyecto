using AppGestionCajaInventario.Models.Dto.Turnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface ITurnoRepository
    {
        Task<int?> AbrirAsync(TurnoCreateDto dto);
        Task<List<TurnosDto>> ObtenerActivosAsync();
    }


}
