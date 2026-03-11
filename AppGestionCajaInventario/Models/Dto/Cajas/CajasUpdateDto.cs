using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Cajas
{
    public class CajaUpdateDto
    {
        public string NombreCaja { get; set; } = string.Empty;
        public bool Activa { get; set; }
    }

}
