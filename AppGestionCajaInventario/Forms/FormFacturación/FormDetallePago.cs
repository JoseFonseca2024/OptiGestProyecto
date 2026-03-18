using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace AppGestionCajaInventario.Forms.FormFacturación
{
    public partial class FormDetallePago : Form
    {
        private readonly decimal _totalFactura;
        private readonly decimal _totalPagado;
        public FormDetallePago(decimal totalFactura, decimal totalPagado)
        {
            InitializeComponent();
            _totalFactura = totalFactura;
            _totalPagado = totalPagado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void FormDetallePago_Load(object sender, EventArgs e)
        {
            decimal subtotal = _totalFactura / 1.15m;

            decimal iva = _totalFactura - subtotal;

            lblSubtotal.Text = $"SUBTOTAL: C${subtotal.ToString("N2")}";
            lblIVA.Text = $"IVA:      C${iva.ToString("N2")}";
            lblTotal.Text = $"TOTAL:    C${_totalFactura.ToString("N2")}";
            lblCambio.Text = $"CAMBIO:   C${(_totalPagado - _totalFactura).ToString("N2")}";
        }
    }
}
