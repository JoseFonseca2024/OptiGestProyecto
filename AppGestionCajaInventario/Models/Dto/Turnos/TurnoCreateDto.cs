using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Turnos
{
    public class TurnoCreateDto
    {
        public int CajaID { get; set; }
        public int UsuarioID { get; set; }
        public decimal MontoInicial { get; set; }
    }

}
