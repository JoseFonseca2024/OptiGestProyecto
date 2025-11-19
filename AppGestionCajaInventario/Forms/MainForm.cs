using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
using AppGestionCajaInventario.Forms.FormsEmpresa;
using AppGestionCajaInventario.Forms.FormsUsuario;
using AppGestionCajaInventario.Models.Repository;

namespace AppGestionCajaInventario
{
    public partial class MainForm : Form
    {
        private readonly FormService _formService = new FormService();
        private readonly ApiClient _apiClient;
        private readonly AdminRepository _adminRepository;

        public MainForm(ApiClient apiClient, string rol, string token)
        {
            InitializeComponent();

            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
            _apiClient.SetAuthToken(token); 

            _adminRepository = new AdminRepository(_apiClient.HttpClientInstance);

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
    }
}
