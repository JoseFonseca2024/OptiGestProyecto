using AppGestionCajaInventario.Models.Dto.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Repository.Interfaces
{
    public interface IReporteRepository
    {
        Task<List<VentaReporteDto>> ObtenerVentasPorAnioAsync(int anio);
    }
}
