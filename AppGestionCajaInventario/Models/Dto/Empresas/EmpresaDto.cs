using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Empresas
{
    public class EmpresaDto
    {
        public int EmpresaID { get; set; }
        public string NombreEmpresa { get; set; } = string.Empty;
        public string RUC { get; set; } = string.Empty;
        public string Direccion {  get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Actividad { get; set; } = string.Empty;
    }
}
