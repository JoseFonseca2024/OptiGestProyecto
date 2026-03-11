using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Models.Dto.Cajas;
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

namespace AppGestionCajaInventario.Forms.FormsCaja
{
    public partial class FormRegistroCajas : Form
    {
        private readonly FormService formService = new FormService();
        private readonly ICajaRepository _cajaRepository;
        public FormRegistroCajas(ICajaRepository cajaRepository)
        {
            InitializeComponent();
            _cajaRepository = cajaRepository ?? throw new ArgumentNullException(nameof(cajaRepository));
        }

        private async void FormRegistroCajas_Load(object sender, EventArgs e)
        {
            await formService.CargarCajasporEmpresasAsync(_cajaRepository, dgvCajas);
        }

        private void dgvCajas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var Caja = (CajasDto)dgvCajas.Rows[e.RowIndex].DataBoundItem;
                txtNombreCaja.Text = Caja.NombreCaja;
            }
        }

        private async void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCajas.CurrentRow == null || dgvCajas.CurrentRow?.DataBoundItem is not CajasDto CajaSeleccionada)
            {
                MessageBox.Show("Seleccione una caja para actualizar", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtNombreCaja.Text))
            {
                MessageBox.Show("Por favor rellene los campos correspondientes", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var dto = new CajaUpdateDto { NombreCaja = txtNombreCaja.Text };

            bool actualizado = await formService.ActualizarCajaAsync(_cajaRepository, CajaSeleccionada.CajaID, dto);
            if (actualizado)
            {
                MessageBox.Show("Caja actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await formService.CargarCajasporEmpresasAsync(_cajaRepository, dgvCajas);
                formService.LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ibtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCaja.Text))
            {
                MessageBox.Show("Por favor rellene los campos correspondientes", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var dto = new CajaCreateDto { NombreCaja = txtNombreCaja.Text };

            bool creado = await formService.RegistrarCajaAsync(_cajaRepository, dto);

            if (creado)
            {
                MessageBox.Show("Caja registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await formService.CargarCajasporEmpresasAsync(_cajaRepository, dgvCajas);
                formService.LimpiarCampos(this);
            }
            else
            {
                MessageBox.Show("Error al registrar la caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
