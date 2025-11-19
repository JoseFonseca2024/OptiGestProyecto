using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
using AppGestionCajaInventario.Models.Dto.Usuarios;
using AppGestionCajaInventario.Models.Repository.Interfaces;


namespace AppGestionCajaInventario.Forms.FormsUsuario
{
    public partial class FormRegistrarNuevoUsuario : Form
    {
        FormService formService = new FormService();
        private readonly ApiClient _apiClient;
        public FormRegistrarNuevoUsuario(ApiClient apiClient)
        {
            InitializeComponent();
            formService.CambiarColorIconButton(ibtnCerrar, ibtnCerrar.IconColor, Color.Red);
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }
        private async void FormRegistrarNuevoUsuario_Load(object sender, EventArgs e)
        {
            await formService.CargarRolesAsync(_apiClient.Admin, cmbRol);
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void btnAceptar_ClickAsync(object sender, EventArgs e)
        {
            if (!formService.VerificarCamposVacios(this)) return;

            string nombre = txtNombreUsuario.Text.Trim();
            string email = txtEmail.Text.Trim();
            string clave = txtClave.Text;
            string confirmar = txtConfirmarClave.Text;

            if (!formService.EsCorreoValido(email))
            {
                MessageBox.Show("Correo inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clave != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clave.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool yaExiste = await _apiClient.LoginUsers.VerificarDisponibilidadAsync(nombre, email);
            if (yaExiste)
            {
                MessageBox.Show("Usuario o correo ya registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRol.SelectedIndex == -1 || cmbRol.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un rol antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new UsuarioCreateDto
            {
                NombreUsuario = nombre,
                Email = email,
                Clave = clave,
                RolID = (int)cmbRol.SelectedValue,
            };

            string codigo = formService.GenerarCodigoVerificacion();
            bool enviado = await _apiClient.LoginUsers.EnviarCodigoVerificacionAsync(email, codigo);
            if (!enviado)
            {
                MessageBox.Show("No se pudo enviar el código de verificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var formConfirmarRegistro = new FormConfirmarRegistro(dto, codigo, _apiClient);
            formConfirmarRegistro.ShowDialog();
        }
    }
}
