using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Models.Dto.Clientes;
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
    public partial class FormClientes : Form
    {
        private readonly FormService formService = new FormService();
        private readonly IClienteRepository _clienteRepository;
        public FormClientes(IClienteRepository clienteRepository)
        {
            InitializeComponent();
            _clienteRepository = clienteRepository;
        }

        private async void ibtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!formService.VerificarCamposVacios(this)) return;

            var dto = new ClienteCreateDto
            {
                NombreCliente = txtNombreCliente.Text.Trim(),
                TelefonoCliente = txtTelefono.Text.Trim()
            };

            bool creado = await formService.RegistrarClienteAsync(_clienteRepository, dto);
            if (creado)
            {
                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formService.LimpiarCampos(this);
                await formService.CargarClientesAsync(_clienteRepository, dgvCliente);
            }
            else
            {
                MessageBox.Show("Error al registrar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FormClientes_Load(object sender, EventArgs e)
        {
            await formService.CargarClientesAsync(_clienteRepository, dgvCliente);
        }

        private async void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow?.DataBoundItem is not ClienteDto clienteSeleccionado)
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!formService.VerificarCamposVacios(this)) return;

            var dto = new ClienteUpdateDto
            {
                NombreCliente = txtNombreCliente.Text.Trim(),
                TelefonoCliente = txtTelefono.Text.Trim()
            };

            bool actualizado = await formService.ActualizarClienteAsync(_clienteRepository, clienteSeleccionado.ClienteID, dto);
            if (actualizado)
            {
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await formService.CargarClientesAsync(_clienteRepository, dgvCliente);
                formService.LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow?.DataBoundItem is not ClienteDto clienteSeleccionado)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"¿Está seguro de eliminar a '{clienteSeleccionado.NombreCliente}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            bool eliminado = await formService.EliminarClienteAsync(_clienteRepository, clienteSeleccionado.ClienteID);
            if (eliminado)
            {
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await formService.CargarClientesAsync(_clienteRepository, dgvCliente);
                formService.LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cliente = (ClienteDto)dgvCliente.Rows[e.RowIndex].DataBoundItem;
                txtNombreCliente.Text = cliente.NombreCliente;
                txtTelefono.Text = cliente.TelefonoCliente;
            }
        }
    }
}
