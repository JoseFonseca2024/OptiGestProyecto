using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Cajas
{
    public class CajasDto
    {
        public int CajaID { get; set; }
        public string NombreCaja { get; set; } = string.Empty;
        public decimal SaldoActual { get; set; }
        public bool Activa { get; set; }
        public string EmpresaNombre { get; set; } = string.Empty;

    }
}
