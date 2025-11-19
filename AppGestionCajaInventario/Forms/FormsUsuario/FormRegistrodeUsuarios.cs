using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Models.Dto.Usuarios;
using AppGestionCajaInventario.Models.Repository.Interfaces;

namespace AppGestionCajaInventario.Forms.FormsUsuario
{
    public partial class FormRegistrodeUsuarios : Form
    {
        private readonly FormService formservice = new FormService();
        private readonly IAdminRepository _adminRepository;

        public FormRegistrodeUsuarios(IAdminRepository adminRepository)
        {
            InitializeComponent();
            formservice.CambiarColorIconButton(ibtnCerrar, ibtnCerrar.IconColor, Color.Red);
            _adminRepository = adminRepository ?? throw new ArgumentNullException(nameof(adminRepository));
        }

        private async void FormRegistrodeUsuarios_Load(object sender, EventArgs e)
        {
            await formservice.CargarUsuariosAsync(_adminRepository, dgvUsuarios);
            formservice.CargarComboBoxEstado(cmbEstado);
            await formservice.CargarRolesAsync(_adminRepository, cmbRoles);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var usuario = (UsuarioDto)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;
                txtNombreUsuario.Text = usuario.NombreUsuario;
                cmbEstado.SelectedValue = usuario.Estado;
                txtEmail.Text = usuario.Email;
            }
        }

        private async void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Algunos campos están vacíos. Por favor, rellénelos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (cmbRoles.SelectedIndex == -1 || cmbRoles.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un rol válido, por favor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = (UsuarioDto)dgvUsuarios.CurrentRow.DataBoundItem;

            var dto = new UsuarioUpdateDto
            {
                UsuarioID = usuario.UsuarioID,
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                RolID = (int)cmbRoles.SelectedValue,
                Email = txtEmail.Text.Trim(),
                Estado = Convert.ToBoolean(cmbEstado.SelectedValue),
            };

            await formservice.ActualizarUsuario(dto, _adminRepository, dgvUsuarios);
            formservice.LimpiarCampos(this);
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
