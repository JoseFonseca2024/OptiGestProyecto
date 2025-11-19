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
    public partial class LoginForm : Form
    {
        FormService formService = new FormService();
        private readonly ApiClient _apiClient;
        public LoginForm()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private async void ibtnIngresar_Click(object sender, EventArgs e)
        {
            await formService.LoginAsync(this, _apiClient, txtUsuario, txtClave);
        }

        private void ibtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Esta seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void linklblCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCrearUsuario form = new FormCrearUsuario(this);
            form.Show();
            this.Hide();
        }
    }
}
