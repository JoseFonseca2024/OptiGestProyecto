using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
using AppGestionCajaInventario.Forms.FormCotización;
using AppGestionCajaInventario.Forms.FormDocumentos;
using AppGestionCajaInventario.Forms.FormFacturación;
using AppGestionCajaInventario.Forms.FormProductos;
using AppGestionCajaInventario.Forms.FormReportes;
using AppGestionCajaInventario.Forms.FormsCaja;
using AppGestionCajaInventario.Forms.FormsEmpresa;
using AppGestionCajaInventario.Forms.FormsEntidadesExternas;
using AppGestionCajaInventario.Forms.FormsUsuario;
using AppGestionCajaInventario.Forms.FormTurnos;
using AppGestionCajaInventario.Models.Dto;
using AppGestionCajaInventario.Models.Repository;
using AppGestionCajaInventario.Models.Repository.Interfaces;

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
        private readonly ReporteRepository _reporteRepository;
        private readonly UserRepository _userRepository;

        //Variable bandera
        private bool _empresaRegistrada = true;
        public LoginResponse LoginResponse { get; }

        public MainForm(ApiClient apiClient, string rol, string token, LoginResponse loginResponse)
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
            _reporteRepository = new ReporteRepository(_apiClient.HttpClientInstance);
            _userRepository = new UserRepository(_apiClient.HttpClientInstance, "Auth/login");

            LoginResponse = loginResponse;

            timerFechayHora.Start();
            _formService.ConfigurarMenuPorRol(rol, imiEmpresas, imiUsuarios, imiCajas, imiOperaciones);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var UsuarioID = LoginResponse.UsuarioID;
            await VerificarEmpresaUsuario();
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
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormRegistrodeUsuarios(_adminRepository);
            form.ShowDialog();
        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormRegistrarNuevoUsuario(_apiClient);
            form.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;

            var form = new FormProductos(_productoRepository)
            {
                ModoSeleccion = false
            };

            _formService.MostrarFormenPanel(form, panel1);
        }

        private void imiClientes_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormClientes(_clienteRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void imiProveedores_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormProveedores(_proveedorRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void iniciarNuevoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormIniciarTurno(_adminRepository, _cajasRepository, _turnoRepository);
            form.ShowDialog();
        }

        private void historialDeTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormVerRegistroTurnos();
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void verCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormRegistroCajas(_cajasRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }


        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormReportedeVentas(_reporteRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void imiCotizar_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new Cotización(_adminRepository, _clienteRepository, _productoRepository, _apiClient, LoginResponse);
            _formService.MostrarFormenPanel(form, panel1);
        }

        private async Task VerificarEmpresaUsuario()
        {
            try
            {
                var empresa = await _adminRepository.ObtenerEmpresaDelUsuarioAsync();

                if (empresa == null)
                {
                    _empresaRegistrada = false;

                    MessageBox.Show(
                        "¡Bienvenido a OptiGest!\n\nPara comenzar a realizar sus gestiones correspondites, registre la empresa a trabajar",
                        "Bienvenida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    _empresaRegistrada = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar empresa: {ex.Message}");
            }
        }

        private void FacturaContadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_formService.ValidarEmpresa(_empresaRegistrada)) return;
            var form = new FormFacturaAlContado(
                _adminRepository,
                _clienteRepository,
                _productoRepository,
                _apiClient,
                _userRepository,
                LoginResponse
            );
            _formService.MostrarFormenPanel(form, panel1);
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCotizacionesEmitidas(_clienteRepository);
            _formService.MostrarFormenPanel(form, panel1);
        }
    }
}
