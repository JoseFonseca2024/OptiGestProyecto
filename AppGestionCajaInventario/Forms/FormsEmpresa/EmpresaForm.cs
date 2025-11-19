using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Models.Dto.Empresas;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Windows.Forms;

    namespace AppGestionCajaInventario.Forms.FormsEmpresa
    {
    public partial class EmpresaForm : Form
    {
        private readonly FormService _service = new FormService();
        private readonly IAdminRepository _adminRepository;

        public EmpresaForm(IAdminRepository adminRepository)
        {
            InitializeComponent();
            _adminRepository = adminRepository ?? throw new ArgumentNullException(nameof(adminRepository));
        }

        private async void EmpresaForm_Load(object sender, EventArgs e)
        {
            await _service.CargarEmpresaAsync(_adminRepository, dgvEmpresas, ibtnRegistrar, ibtnEditar);

            var empresa = await _adminRepository.ObtenerEmpresaDelUsuarioAsync();
            if (empresa != null)
            {
                txtNombreEmpresa.Text = empresa.NombreEmpresa;
                txtRUC.Text = empresa.RUC;
                txtDireccion.Text = empresa.Direccion;
                msk_Telefono.Text = empresa.Telefono;
                txtActividad.Text = empresa.Actividad;
            }
            else
            {
                _service.LimpiarCampos(this);
            }
        }

        private async void ibtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!_service.VerificarCamposVacios(this))
                return;

            string nombre = txtNombreEmpresa.Text.Trim();
            string ruc = txtRUC.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string telefono = msk_Telefono.Text.Trim();
            string actividad = txtActividad.Text.Trim();

            if (ruc.Length != 14)
            {
                MessageBox.Show("El RUC debe tener 14 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool existe = await _adminRepository.VerificarRucAsync(ruc);
            if (existe)
            {
                MessageBox.Show("Ya existe una empresa con ese RUC.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await _service.RegistrarEmpresa(nombre, ruc, direccion, telefono, actividad, _adminRepository);

            EmpresaForm_Load(sender, e); // recargar
            _service.LimpiarCampos(this);
        }

        private async void ibtnEditar_Click(object sender, EventArgs e)
        {
            var empresa = await _adminRepository.ObtenerEmpresaDelUsuarioAsync();
            if (empresa == null)
            {
                MessageBox.Show("No hay empresa registrada para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new EmpresaUpdateDto
            {
                EmpresaID = empresa.EmpresaID,
                NombreEmpresa = txtNombreEmpresa.Text,
                RUC = txtRUC.Text,
                Direccion = txtDireccion.Text,
                Telefono = msk_Telefono.Text,
                Actividad = txtActividad.Text
            };

            await _service.ActualizarEmpresa(dto, _adminRepository);

            EmpresaForm_Load(sender, e); // recargar
            _service.LimpiarCampos(this);
        }

        private void dgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var empresa = (EmpresaDto)dgvEmpresas.Rows[e.RowIndex].DataBoundItem;
                txtNombreEmpresa.Text = empresa.NombreEmpresa;
                txtRUC.Text = empresa.RUC;
                txtDireccion.Text = empresa.Direccion;
                msk_Telefono.Text = empresa.Telefono;
                txtActividad.Text = empresa.Actividad;
            }
        }
    }
}
