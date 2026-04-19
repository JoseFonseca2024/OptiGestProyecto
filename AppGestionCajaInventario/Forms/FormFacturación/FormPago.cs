using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
using AppGestionCajaInventario.Models.Dto.Facturas;
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
        private readonly List<DetalleDocumentoTempDto> _detallesTemp;
        private readonly int _clienteId;
        private readonly int _usuarioId;
        private readonly ApiClient _apiClient;

        public decimal MontoPagado { get; private set; }

        public FormPago(decimal totalFactura,
                        List<DetalleDocumentoTempDto> detallesTemp,
                        int clienteId,
                        int usuarioId,
                        ApiClient apiClient)
        {
            InitializeComponent();
            _formService.RegistroDenominación(btn10cor, 10, txtPago);
            _formService.RegistroDenominación(btn20Cor, 20, txtPago);
            _formService.RegistroDenominación(btn100Cor, 100, txtPago);
            _formService.RegistroDenominación(btn200Cor, 200, txtPago);
            _formService.RegistroDenominación(btn500Cor, 500, txtPago);
            _formService.RegistroDenominación(btn1000Cor, 1000, txtPago);
            _totalFactura = totalFactura;
            _detallesTemp = detallesTemp;
            _clienteId = clienteId;
            _usuarioId = usuarioId;
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_totalFactura > Convert.ToDecimal(txtPago.Text))
            {
                MessageBox.Show("Monto por debajo a la obligación a pagar", "Monto inferior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                var result = await _formService.RegistrarFacturaContadoAsync(
                    _totalFactura,
                    _detallesTemp,
                    _clienteId,
                    _usuarioId,
                    _apiClient
                );

                if (result != null)
                {
                    MessageBox.Show($"Factura {result.NumeroDocumento} registrada. Estado: {result.Estado}, Total: {result.TotalFactura}",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var pdfService = new DocumentoPDFService();
                    string rutaArchivo = _formService.ObtenerRutaDocumento(result.NumeroDocumento, TipoDocumento.Factura);
                    pdfService.GenerarDocumentoPdf(result, rutaArchivo);

                    var formDetalle = new FormDetallePago(_totalFactura, Convert.ToDecimal(txtPago.Text));
                    formDetalle.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar documento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
