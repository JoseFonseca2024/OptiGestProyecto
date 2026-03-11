using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Turnos
{
    public class TurnosDto
    {
        public int TurnoID { get; set; }
        public int CajaID { get; set; }
        public string NombreCaja { get; set; } = string.Empty;
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public decimal MontoInicial { get; set; }
        public decimal? MontoFinal { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public bool Activo { get; set; }
    }

}
