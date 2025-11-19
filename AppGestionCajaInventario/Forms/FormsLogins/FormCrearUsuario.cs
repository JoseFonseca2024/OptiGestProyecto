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
    public partial class FormCrearUsuario : Form
    {
        FormService formService = new FormService();
        private readonly ApiClient _apiClient;
        private readonly LoginForm loginForm;


        public FormCrearUsuario(LoginForm login)
        {
            InitializeComponent();
            loginForm = login;
            formService.CambiarColorIconButton(ibtnCerrar, ibtnCerrar.IconColor, Color.Red);
            _apiClient = new ApiClient();
        }


        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void ibtnVerClave1_Click(object sender, EventArgs e)
        {
            formService.AlternarVisibilidad(txtClave, ibtnVerClave1);
        }

        private void ibtnVerClave2_Click(object sender, EventArgs e)
        {
            formService.AlternarVisibilidad(txtConfirmarClave, ibtnVerClave2);
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!formService.VerificarCamposVacios(this))
                return;

            string nombre = txtNombreUsuario.Text.Trim();
            string email = txtEmail.Text.Trim();
            string clave = txtClave.Text;
            string confirmar = txtConfirmarClave.Text;

            if (!formService.EsCorreoValido(email))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("El nombre de usuario o correo ya están registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await formService.EnviarCodigoYMostrarFormularioAsync(nombre, email, clave, _apiClient, this, loginForm);
        }
    }
}
