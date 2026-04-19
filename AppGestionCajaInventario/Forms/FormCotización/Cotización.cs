using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
using AppGestionCajaInventario.Forms.FormsEntidadesExternas;
using AppGestionCajaInventario.Models.Dto;
using AppGestionCajaInventario.Models.Dto.Facturas;
using AppGestionCajaInventario.Models.Dto.Productos;
using AppGestionCajaInventario.Models.Repository;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCajaInventario.Forms.FormCotización
{
    public partial class Cotización : Form
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly ProductoRepository _productoRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly ApiClient _apiClient;
        private readonly LoginResponse _loginResponse;
        private int _usuarioId;
        private int _clienteId;
        private readonly FormService formService = new FormService();

        private ProductosDto _productoSeleccionado = new ProductosDto();

        private readonly List<DetalleDocumentoTempDto> _detallesTemp = new();


        public Cotización(IAdminRepository adminRepository, ClienteRepository clienteRepository, ProductoRepository productoRepository, ApiClient apiClient, LoginResponse loginResponse)
        {
            InitializeComponent();
            _adminRepository = adminRepository ?? throw new ArgumentNullException(nameof(adminRepository));
            _clienteRepository = clienteRepository;
            _productoRepository = productoRepository;
            _apiClient = apiClient;
            _loginResponse = loginResponse;
        }

        private void ibtnBuscarCliente_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes(_clienteRepository)
            {
                ModoSeleccion = true
            };

            formClientes.ClienteSeleccionado += cliente =>
            {
                txtNombreCliente.Text = cliente.NombreCliente;
                msktxtNumero.Text = cliente.TelefonoCliente;
                _clienteId = cliente.ClienteID;
            };
            formClientes.Show();
        }

        private void ibtnBuscarProducto_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos.FormProductos(_productoRepository)
            {
                ModoSeleccion = true
            };

            formProductos.ProductoSeleccionado += producto =>
            {
                _productoSeleccionado = producto;
                txtCodigoProducto.Text = producto.CodigoProducto;
                txtNombreProducto.Text = producto.NombreProducto;
                txtPrecio.Text = producto.PrecioUnitario.ToString();
                txtStock.Text = producto.StockActual.ToString();
            };

            formProductos.ShowDialog();
        }

        private async void Cotización_Load(object sender, EventArgs e)
        {
            _usuarioId = _loginResponse.UsuarioID;
            var empresa = await _adminRepository.ObtenerEmpresaDelUsuarioAsync();

            if (empresa != null)
            {
                txtRUC.Text = empresa.RUC;
            }
            else
            {
                txtRUC.Clear();
            }
        }


        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtDescuento.Text))
            {
                MessageBox.Show("No puede ingresar un precio ni porcentaje de descuento vacio. Por favor rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad valida para la facturación", "Cantidad Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var detalle = new DetalleDocumentoTempDto
            {
                ProductoID = _productoSeleccionado.ProductoID,
                CodigoProducto = txtCodigoProducto.Text,
                NombreProducto = txtNombreProducto.Text,
                Cantidad = (int)numCantidad.Value,
                PrecioUnitario = decimal.Parse(txtPrecio.Text),
                PorcentajeDescuento = decimal.Parse(txtDescuento.Text)
            };

            _detallesTemp.Add(detalle);

            LimpiarCampos();

            dgtvDetallesFactura.DataSource = null;
            dgtvDetallesFactura.DataSource = _detallesTemp;

            formService.CalculodeTotales(_detallesTemp, 0.15m, txtSubtotal, txtIVA, txtTotalaPagar);
        }

        private async void dgtvDetallesFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var productoSeleccionado = (DetalleDocumentoTempDto)dgtvDetallesFactura.Rows[e.RowIndex].DataBoundItem;
                txtCodigoProducto.Text = productoSeleccionado.CodigoProducto.ToString();
                txtNombreProducto.Text = productoSeleccionado.NombreProducto.ToString();
                numCantidad.Value = Convert.ToInt64(productoSeleccionado.Cantidad);
                txtPrecio.Text = productoSeleccionado.PrecioUnitario.ToString();
                txtDescuento.Text = productoSeleccionado.PorcentajeDescuento.ToString();

                // Consultar stock en BD
                var producto = await _productoRepository.ObtenerPorIdAsync(productoSeleccionado.ProductoID);
                if (producto != null)
                {
                    txtStock.Text = producto.StockActual.ToString();
                }
            }
        }

        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtDescuento.Clear();
            numCantidad.Value = 1;
        }

        private void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (dgtvDetallesFactura.CurrentRow?.DataBoundItem is not DetalleDocumentoTempDto productoSeleccionado)
            {
                MessageBox.Show("Seleccione el producto a modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtDescuento.Text))
            {
                MessageBox.Show("No puede ingresar un precio ni porcentaje de descuento vacio. Por favor rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad valida para la facturación", "Cantidad Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Confirmación = MessageBox.Show("¿Desea confirmar la actualización?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Confirmación == DialogResult.No) return;

            productoSeleccionado.Cantidad = (int)numCantidad.Value;
            productoSeleccionado.PrecioUnitario = decimal.Parse(txtPrecio.Text);
            productoSeleccionado.PorcentajeDescuento = decimal.Parse(txtDescuento.Text);

            LimpiarCampos();

            dgtvDetallesFactura.DataSource = null;
            dgtvDetallesFactura.DataSource = _detallesTemp;

            formService.CalculodeTotales(_detallesTemp, 0.15m, txtSubtotal, txtIVA, txtTotalaPagar);

            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgtvDetallesFactura.CurrentRow?.DataBoundItem is not DetalleDocumentoTempDto productoSeleccionado)
            {
                MessageBox.Show("Seleccione el producto a eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                               $"¿Desea eliminar el producto {productoSeleccionado.NombreProducto} de la factura?",
                                "Confirmación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No) return;

            _detallesTemp.Remove(productoSeleccionado);

            dgtvDetallesFactura.DataSource = null;
            dgtvDetallesFactura.DataSource = _detallesTemp;

            formService.CalculodeTotales(_detallesTemp, 0.15m, txtSubtotal, txtIVA, txtTotalaPagar);

            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void ibtnGenerarCotización_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_detallesTemp.Any())
                {
                    MessageBox.Show("Debe agregar al menos un producto a la cotización.", "Sin producto",MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }

                if (_clienteId <= 0)
                {
                    MessageBox.Show("Debe seleccionar un cliente a la cotización.", "Sin cliente", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }

                var response = await formService.RegistrarCotizacionAsync(
                    _apiClient,
                    _detallesTemp,
                    _clienteId,
                    _usuarioId
                );

                if (response != null)
                {
                    var pdfService = new DocumentoPDFService();

                    var rutaArchivo = formService.ObtenerRutaDocumento(
                        response.NumeroDocumento,
                        TipoDocumento.Cotizacion
                    );

                    pdfService.GenerarDocumentoPdf(response, rutaArchivo);

                    MessageBox.Show("Cotización generada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formService.LimpiarFormularioDocumento(txtNombreCliente, msktxtNumero, txtSubtotal, txtIVA, txtTotalaPagar, txtCodigoProducto, txtNombreProducto, txtPrecio, txtStock, txtDescuento, numCantidad, dgtvDetallesFactura, _detallesTemp, ref _clienteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
