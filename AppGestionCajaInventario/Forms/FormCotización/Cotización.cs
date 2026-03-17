using AppGestionCajaInventario.Forms.FormsEntidadesExternas;
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

        public Cotización(IAdminRepository adminRepository, ClienteRepository clienteRepository, ProductoRepository productoRepository)
        {
            InitializeComponent();
            _adminRepository = adminRepository ?? throw new ArgumentNullException(nameof(adminRepository));
            _clienteRepository = clienteRepository;
            _productoRepository = productoRepository;
        }

        private void ibtnBuscarCliente_Click(object sender, EventArgs e)
        {
            var formCLientes = new FormClientes(_clienteRepository);

            formCLientes.ClienteSeleccionado += cliente =>
            {
                txtNombreCliente.Text = cliente.NombreCliente;
                msktxtNumero.Text = cliente.TelefonoCliente;
            };

            formCLientes.ShowDialog();
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
            formProductos.ShowDialog();
        }

        private async void Cotización_Load(object sender, EventArgs e)
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
    }
}
