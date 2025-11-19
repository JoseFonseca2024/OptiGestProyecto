using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
using AppGestionCajaInventario.Forms.FormsLogins;
using AppGestionCajaInventario.Models.Dto.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppGestionCajaInventario.Forms.FormsUsuario
{
    public partial class FormConfirmarRegistro : Form
    {
        FormService formService = new FormService();
        private readonly UsuarioCreateDto _usuarioDto;
        private readonly string _codigoVerificacion;
        private readonly ApiClient _apiClient;
        private string? codigoEsperado;

        public FormConfirmarRegistro(UsuarioCreateDto usuarioDto, string codigoVerificacion, ApiClient apiClient)
        {
            InitializeComponent();
            formService.CambiarColorIconButton(ibtnCerrar, ibtnCerrar.IconColor, Color.Red);
            _usuarioDto = usuarioDto;
            _codigoVerificacion = codigoVerificacion;
            _apiClient = apiClient;

        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConfirmarRegistro_Load(object sender, EventArgs e)
        {
            codigoEsperado = _codigoVerificacion;

            if (timer1 != null)
            {
                timer1.Stop();
                timer1.Dispose();
            }

            timer1 = new System.Windows.Forms.Timer();
            formService.IniciarTemporizador(timer1, lblTemporizador, () =>
            {
                if (!this.Visible) return;
                btnAceptar.Enabled = false;
                MessageBox.Show("El código ha expirado. Por favor solicite uno nuevo usando el botón de reenvío.", "Código expirado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }, 180);
        }

        private void FormConfirmarRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (timer1 != null)
            {
                timer1.Stop();
                timer1.Dispose();
            }
        }

        private async void ibtnReenviarClave_Click(object sender, EventArgs e)
        {
            var nuevoCodigo = await formService.ReenviarCodigoAsync(_usuarioDto.Email, _apiClient, ibtnReenviarClave);

            if (!string.IsNullOrEmpty(nuevoCodigo))
            {
                codigoEsperado = nuevoCodigo;
                btnAceptar.Enabled = true;

                formService.IniciarTemporizador(timer1, lblTemporizador, () =>
                {
                    btnAceptar.Enabled = false;
                    MessageBox.Show("El nuevo código ha expirado. Por favor solicite otro.", "Código expirado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }, 180);
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            string codigoIngresado = txtClave.Text.Trim();

            if (codigoIngresado != codigoEsperado)
            {
                MessageBox.Show("El código ingresado es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool registrado = await _apiClient.Admin.RegistrarUsuarioAsync(_usuarioDto);
                if (registrado)
                {
                    MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
