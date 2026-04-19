using AppGestionCajaInventario.Forms.FormsEntidadesExternas;
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

namespace AppGestionCajaInventario.Forms.FormDocumentos
{
    public partial class FormCotizacionesEmitidas : Form
    {
        private readonly IClienteRepository _clienteRepository;

        public FormCotizacionesEmitidas(ClienteRepository clienteRepository)
        {
            InitializeComponent();
            _clienteRepository = clienteRepository;
        }

        private void ibtnConsultaClientes_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes(_clienteRepository)
            {
                ModoSeleccion = true
            };

            formClientes.ClienteSeleccionado += cliente =>
            {
                txtCliente.Text = cliente.NombreCliente;
            };
            formClientes.Show();
        }
    }
}
