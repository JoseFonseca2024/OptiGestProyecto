using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCajaInventario.Forms.FormsLogins
{
    public partial class FormConfirmacióndeClave : Form
    {
        private readonly string nombreUsuario;
        private readonly string email;
        private readonly string clave;
        private string codigoEsperado;
        private readonly ApiClient _apiClient;
        private readonly FormService formService = new FormService();
        private readonly FormCrearUsuario _formPadre;
        private readonly LoginForm _loginForm;


        public FormConfirmacióndeClave(string nombre, string correo, string claveUsuario, string codigo, ApiClient apiClient, FormCrearUsuario padre, LoginForm loginForm)
        {
            InitializeComponent();
            formService.CambiarColorIconButton(ibtnCerrar, ibtnCerrar.IconColor, Color.Red);
            nombreUsuario = nombre;
            email = correo;
            clave = claveUsuario;
            codigoEsperado = codigo;
            _apiClient = apiClient;
            _formPadre = padre;
            _loginForm = loginForm;
        }


        private void FormConfirmacióndeClave_Load(object sender, EventArgs e)
        {
            if (timer1 != null)
            {
                timer1.Stop();
                timer1.Dispose();
            }

            timer1 = new System.Windows.Forms.Timer();
            formService.IniciarTemporizador(timer1, lblTemporizador, () =>
            {
                if (!this.Visible) return; // Evita mostrar si el form ya no está activo
                btnAceptar.Enabled = false;
                MessageBox.Show("El código ha expirado. Por favor solicite uno nuevo usando el botón de reenvío.", "Código expirado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }, 180);
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            string codigoIngresado = txtClave.Text.Trim();

            if (codigoIngresado != codigoEsperado)
            {
                MessageBox.Show("El código ingresado es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool registrado = await formService.RegistrarUsuarioAsync(nombreUsuario, email, clave, _apiClient);
            if (registrado)
            {
                _formPadre.Close();
                _loginForm.Show();
                _loginForm.WindowState = FormWindowState.Normal;
                _loginForm.BringToFront();
                _loginForm.Activate();
                Close();
            }



        }

        private async void ibtnReenviarClave_Click(object sender, EventArgs e)
        {
            var nuevoCodigo = await formService.ReenviarCodigoAsync(email, _apiClient, ibtnReenviarClave);

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

        private void FormConfirmacióndeClave_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (timer1 != null)
            {
                timer1.Stop();
                timer1.Dispose();
            }
        }
    }
}
