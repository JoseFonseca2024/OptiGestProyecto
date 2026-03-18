using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Models.Dto.Facturas
{
    public class DetalleDocumentoTempDto
    {
        public int ProductoID { get; set; }
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal TotalLinea => (Cantidad * PrecioUnitario) * (1 - (PorcentajeDescuento / 100));
    }
}
