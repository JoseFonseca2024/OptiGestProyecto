using AppGestionCajaInventario.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCajaInventario.Forms.FormFacturación
{
    public partial class FormPago : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly decimal _totalFactura;

        public decimal MontoPagado { get; private set; }

        public FormPago()
        {
            InitializeComponent();
            _formService.RegistroDenominación(btn10cor, 10, txtPago);
            _formService.RegistroDenominación(btn20Cor, 20, txtPago);
            _formService.RegistroDenominación(btn100Cor, 100, txtPago);
            _formService.RegistroDenominación(btn200Cor, 200, txtPago);
            _formService.RegistroDenominación(btn500Cor, 500, txtPago);
            _formService.RegistroDenominación(btn1000Cor, 1000, txtPago);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var formDetalle = new FormDetallePago(_totalFactura, Convert.ToDecimal(txtPago.Text));
            formDetalle.ShowDialog();
            Close();
        }
    }
}
