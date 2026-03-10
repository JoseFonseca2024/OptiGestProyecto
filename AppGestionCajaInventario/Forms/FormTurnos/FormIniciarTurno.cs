using AppGestionCajaInventario.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCajaInventario.Forms.FormTurnos
{
    public partial class FormIniciarTurno : Form
    {
        FormService formService = new FormService();
        public FormIniciarTurno()
        {
            InitializeComponent();
            formService.CambiarColorIconButton(ibtnCerrar, ibtnCerrar.IconColor, Color.Red);
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
