using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Models.Dto.Proveedores;
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

namespace AppGestionCajaInventario.Forms.FormsEntidadesExternas
{
    public partial class FormProveedores : Form
    {
        private readonly FormService formService = new FormService();
        private readonly IProveedorRepository _proveedorRepository;

        public FormProveedores(IProveedorRepository proveedorRepository)
        {
            InitializeComponent();
            _proveedorRepository = proveedorRepository ?? throw new ArgumentNullException(nameof(proveedorRepository));
        }

        private async void FormProveedores_Load(object sender, EventArgs e)
        {
            await formService.CargarProveedoresAsync(_proveedorRepository, dgvProveedor);
        }

        private async void ibtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!formService.VerificarCamposVacios(this)) return;

            var dto = new ProveedorCreateDto
            {
                NombreProveedor = txtNombreProveedor.Text.Trim(),
                TelefonoProveedor = txtTelefono.Text.Trim()
            };

            bool creado = await formService.RegistrarProveedorAsync(_proveedorRepository, dto);
            if (creado)
            {
                MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formService.LimpiarCampos(this);
                await formService.CargarProveedoresAsync(_proveedorRepository, dgvProveedor);
            }
            else
            {
                MessageBox.Show("Error al registrar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentRow?.DataBoundItem is not ProveedorDto proveedorSeleccionado)
            {
                MessageBox.Show("Seleccione un proveedor para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!formService.VerificarCamposVacios(this)) return;

            var dto = new ProveedorUpdateDto
            {
                NombreProveedor = txtNombreProveedor.Text.Trim(),
                TelefonoProveedor = txtTelefono.Text.Trim()
            };

            bool actualizado = await formService.ActualizarProveedorAsync(_proveedorRepository, proveedorSeleccionado.ProveedorID, dto);
            if (actualizado)
            {
                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await formService.CargarProveedoresAsync(_proveedorRepository, dgvProveedor);
                formService.LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al actualizar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentRow?.DataBoundItem is not ProveedorDto proveedorSeleccionado)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"¿Está seguro de eliminar a '{proveedorSeleccionado.NombreProveedor}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            bool eliminado = await formService.EliminarProveedorAsync(_proveedorRepository, proveedorSeleccionado.ProveedorID);
            if (eliminado)
            {
                MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await formService.CargarProveedoresAsync(_proveedorRepository, dgvProveedor);
                formService.LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al eliminar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var proveedor = (ProveedorDto)dgvProveedor.Rows[e.RowIndex].DataBoundItem;
                txtNombreProveedor.Text = proveedor.NombreProveedor;
                txtTelefono.Text = proveedor.TelefonoProveedor;
            }
        }
    }
}
