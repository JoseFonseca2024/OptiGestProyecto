using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Reporte
{
    public class VentaReporteDto
    {
        public int MovimientoCajaID { get; set; }
        public string NombreConcepto { get; set; } = string.Empty;
        public string TipodeMovimiento { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public DateTime FechaMovimiento { get; set; }
    }
}
