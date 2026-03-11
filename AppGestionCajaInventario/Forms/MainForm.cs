using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
using AppGestionCajaInventario.Forms.FormProductos;
using AppGestionCajaInventario.Forms.FormsCaja;
using AppGestionCajaInventario.Forms.FormsEmpresa;
using AppGestionCajaInventario.Forms.FormsEntidadesExternas;
using AppGestionCajaInventario.Forms.FormsUsuario;
using AppGestionCajaInventario.Forms.FormTurnos;
using AppGestionCajaInventario.Models.Repository;

namespace AppGestionCajaInventario
{
    public partial class MainForm : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly ApiClient _apiClient;
        private readonly AdminRepository _adminRepository;
        private readonly ProductoRepository _productoRepository;
        private readonly ClienteRepository _clienteRepository;
        private readonly ProveedorRepository _proveedorRepository;
        private readonly CajasRepository _cajasRepository;
        private readonly TurnoRepository _turnoRepository;

        public MainForm(ApiClient apiClient, string rol, string token)
        {
            InitializeComponent();

            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
            _apiClient.SetAuthToken(token);

            _adminRepository = new AdminRepository(_apiClient.HttpClientInstance);
            _productoRepository = new ProductoRepository(_apiClient.HttpClientInstance);
            _clienteRepository = new ClienteRepository(_apiClient.HttpClientInstance);
            _proveedorRepository = new ProveedorRepository(_apiClient.HttpClientInstance);
            _cajasRepository = new CajasRepository(_apiClient.HttpClientInstance);
            _turnoRepository = new TurnoRepository(_apiClient.HttpClientInstance);


            timerFechayHora.Start();
            _formService.ConfigurarMenuPorRol(rol, imiEmpresas, imiUsuarios, imiCajas, imiOperaciones);
        }

        private void correrReloj(object sender, EventArgs e)
        {
            lblFechayHora.Text = DateTime.Now.ToString();
        }

        private void imiCerrarSesion_Click(object sender, EventArgs e)
        {
            _formService.CerrarSesion(this, _apiClient);
        }

        private void imiEmpresas_Click(object sender, EventArgs e)
        {
            _formService.MostrarFormenPanel(new EmpresaForm(_adminRepository), panel1);
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrodeUsuarios(_adminRepository);
            form.ShowDialog();
        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarNuevoUsuario(_apiClient);
            form.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormProductos(_productoRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void imiClientes_Click(object sender, EventArgs e)
        {
            var form = new FormClientes(_clienteRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void imiProveedores_Click(object sender, EventArgs e)
        {
            var form = new FormProveedores(_proveedorRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void iniciarNuevoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormIniciarTurno(_adminRepository, _cajasRepository, _turnoRepository);
            form.ShowDialog();
        }

        private void historialDeTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormVerRegistroTurnos();
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void verCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormRegistroCajas(_cajasRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }
    }
}
