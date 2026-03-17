using AppGestionCajaInventario.Forms.FormProductos;
using AppGestionCajaInventario.Forms.FormsEntidadesExternas;
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

namespace AppGestionCajaInventario.Forms.FormFacturación
{
    public partial class FormFacturación : Form
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IAdminRepository _adminRepository;

        public FormFacturación(IAdminRepository adminRepository, IClienteRepository clienteRepository, IProductoRepository productoRepository)
        {
            InitializeComponent();
            _adminRepository = adminRepository ?? throw new ArgumentNullException(nameof(adminRepository));
            _clienteRepository = clienteRepository;
            _productoRepository = productoRepository;
        }

        private void ibtnBuscarCliente_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes(_clienteRepository);
            formClientes.ClienteSeleccionado += cliente =>
            {
                txtNombreCliente.Text = cliente.NombreCliente;
                msktxtNumero.Text = cliente.TelefonoCliente;
            };
            formClientes.Show();
        }

        private void ibtnBuscarProducto_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos.FormProductos(_productoRepository);
            formProductos.ProductoSeleccionado += producto =>
            {
                txtCodigoProducto.Text = producto.CodigoProducto;
                txtNombreProducto.Text = producto.NombreProducto;
                txtPrecio.Text = producto.PrecioUnitario.ToString();
                txtStock.Text = producto.StockActual.ToString();
            };
            formProductos.Show();
        }

        private async void FormFacturación_Load(object sender, EventArgs e)
        {
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

        private void ibtPago_Click(object sender, EventArgs e)
        {
            var formPago = new FormPago();
            formPago.ShowDialog();
        }
    }
}
