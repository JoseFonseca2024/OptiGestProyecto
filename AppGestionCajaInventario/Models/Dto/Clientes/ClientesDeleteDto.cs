using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Clientes
{
    public class ClientesDeleteDto
    {
        public int ClienteID { get; set; }
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }
    }
}
