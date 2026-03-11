using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
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
using System.Windows.Navigation;

namespace AppGestionCajaInventario.Forms.FormTurnos
{
    public partial class FormIniciarTurno : Form
    {
        FormService formService = new FormService();
        private readonly IAdminRepository _adminRepository;
        private readonly ICajaRepository _cajaRepository;
        private readonly ITurnoRepository _turnoRepository;
        public FormIniciarTurno(IAdminRepository adminRepository, ICajaRepository cajaRepository, ITurnoRepository turnoRepository)
        {
            InitializeComponent();
            formService.CambiarColorIconButton(ibtnCerrar, ibtnCerrar.IconColor, Color.Red);
            _adminRepository = adminRepository ?? throw new ArgumentNullException(nameof(adminRepository));
            _cajaRepository = cajaRepository ?? throw new ArgumentNullException(nameof(cajaRepository));
            _turnoRepository = turnoRepository ?? throw new ArgumentNullException(nameof(turnoRepository));
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormIniciarTurno_Load(object sender, EventArgs e)
        {
            await formService.CargarUsuarioscmbAsync(_adminRepository, cmbUsuario);
            await formService.CargarCajascmbAsync(_cajaRepository, cmbCajas);
        }

        private void ibtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Esta seguro que quiere cancelar el proceso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Close();
                return;
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedValue == null || cmbCajas.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar usuario y caja.");
                return;
            }

            if (!decimal.TryParse(txtMontoIncial.Text, out var monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto inicial válido.");
                return;
            }

            var mensaje = await formService.AbrirTurnoAsync(_turnoRepository, cmbUsuario, cmbCajas, txtMontoIncial);

            if (mensaje.Contains("correctamente"))
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

