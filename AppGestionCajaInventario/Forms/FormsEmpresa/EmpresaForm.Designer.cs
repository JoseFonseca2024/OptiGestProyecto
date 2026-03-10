using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace AppGestionCajaInventario.Forms.FormsEmpresa
{
    partial class EmpresaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            gpbDetalles = new GroupBox();
            msk_Telefono = new MaskedTextBox();
            txtNombreEmpresa = new TextBox();
            ibtnEditar = new FontAwesome.Sharp.IconButton();
            ibtnRegistrar = new FontAwesome.Sharp.IconButton();
            txtActividad = new TextBox();
            txtDireccion = new TextBox();
            txtRUC = new TextBox();
            lblActividad = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblRUC = new Label();
            lblNombreUsuario = new Label();
            lblTitulo = new Label();
            dgvEmpresas = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            gpbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(gpbDetalles);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 528);
            panel1.TabIndex = 2;
            // 
            // gpbDetalles
            // 
            gpbDetalles.Controls.Add(msk_Telefono);
            gpbDetalles.Controls.Add(txtNombreEmpresa);
            gpbDetalles.Controls.Add(ibtnEditar);
            gpbDetalles.Controls.Add(ibtnRegistrar);
            gpbDetalles.Controls.Add(txtActividad);
            gpbDetalles.Controls.Add(txtDireccion);
            gpbDetalles.Controls.Add(txtRUC);
            gpbDetalles.Controls.Add(lblActividad);
            gpbDetalles.Controls.Add(lblDireccion);
            gpbDetalles.Controls.Add(lblTelefono);
            gpbDetalles.Controls.Add(lblRUC);
            gpbDetalles.Controls.Add(lblNombreUsuario);
            gpbDetalles.Location = new Point(22, 60);
            gpbDetalles.Name = "gpbDetalles";
            gpbDetalles.Size = new Size(318, 438);
            gpbDetalles.TabIndex = 27;
            gpbDetalles.TabStop = false;
            gpbDetalles.Text = "Detalles de Empresa";
            // 
            // msk_Telefono
            // 
            msk_Telefono.Location = new Point(19, 218);
            msk_Telefono.Margin = new Padding(4, 3, 4, 3);
            msk_Telefono.Mask = "0000-0000";
            msk_Telefono.Name = "msk_Telefono";
            msk_Telefono.Size = new Size(265, 23);
            msk_Telefono.TabIndex = 26;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(19, 54);
            txtNombreEmpresa.Margin = new Padding(4, 3, 4, 3);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(269, 23);
            txtNombreEmpresa.TabIndex = 14;
            // 
            // ibtnEditar
            // 
            ibtnEditar.BackColor = Color.SteelBlue;
            ibtnEditar.Cursor = Cursors.Hand;
            ibtnEditar.FlatAppearance.BorderSize = 2;
            ibtnEditar.FlatStyle = FlatStyle.Flat;
            ibtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnEditar.ForeColor = Color.White;
            ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            ibtnEditar.IconColor = Color.White;
            ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEditar.IconSize = 20;
            ibtnEditar.Location = new Point(23, 382);
            ibtnEditar.Margin = new Padding(4, 3, 4, 3);
            ibtnEditar.Name = "ibtnEditar";
            ibtnEditar.Size = new Size(261, 35);
            ibtnEditar.TabIndex = 24;
            ibtnEditar.Text = "Editar";
            ibtnEditar.TextAlign = ContentAlignment.MiddleRight;
            ibtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnEditar.UseVisualStyleBackColor = false;
            ibtnEditar.Click += ibtnEditar_Click;
            // 
            // ibtnRegistrar
            // 
            ibtnRegistrar.BackColor = Color.SeaGreen;
            ibtnRegistrar.Cursor = Cursors.Hand;
            ibtnRegistrar.FlatAppearance.BorderSize = 2;
            ibtnRegistrar.FlatStyle = FlatStyle.Flat;
            ibtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnRegistrar.ForeColor = Color.White;
            ibtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            ibtnRegistrar.IconColor = Color.White;
            ibtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnRegistrar.IconSize = 20;
            ibtnRegistrar.Location = new Point(23, 341);
            ibtnRegistrar.Margin = new Padding(4, 3, 4, 3);
            ibtnRegistrar.Name = "ibtnRegistrar";
            ibtnRegistrar.Size = new Size(261, 35);
            ibtnRegistrar.TabIndex = 24;
            ibtnRegistrar.Text = "Registrar";
            ibtnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            ibtnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnRegistrar.UseVisualStyleBackColor = false;
            ibtnRegistrar.Click += ibtnRegistrar_Click;
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(19, 284);
            txtActividad.Margin = new Padding(4, 3, 4, 3);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(265, 23);
            txtActividad.TabIndex = 20;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(19, 165);
            txtDireccion.Margin = new Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(265, 23);
            txtDireccion.TabIndex = 14;
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(19, 111);
            txtRUC.Margin = new Padding(4, 3, 4, 3);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(269, 23);
            txtRUC.TabIndex = 14;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.BackColor = Color.WhiteSmoke;
            lblActividad.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActividad.Location = new Point(19, 264);
            lblActividad.Margin = new Padding(4, 0, 4, 0);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(64, 17);
            lblActividad.TabIndex = 13;
            lblActividad.Text = "Actividad:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.WhiteSmoke;
            lblDireccion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(19, 145);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(65, 17);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.WhiteSmoke;
            lblTelefono.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(19, 198);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(62, 17);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono:";
            // 
            // lblRUC
            // 
            lblRUC.AutoSize = true;
            lblRUC.BackColor = Color.WhiteSmoke;
            lblRUC.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRUC.Location = new Point(19, 91);
            lblRUC.Margin = new Padding(4, 0, 4, 0);
            lblRUC.Name = "lblRUC";
            lblRUC.Size = new Size(36, 17);
            lblRUC.TabIndex = 16;
            lblRUC.Text = "RUC:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.WhiteSmoke;
            lblNombreUsuario.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(19, 34);
            lblNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(148, 17);
            lblNombreUsuario.TabIndex = 10;
            lblNombreUsuario.Text = "Nombre de la empresa:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(22, 22);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 23);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "REGISTRO DE EMPRESAS";
            // 
            // dgvEmpresas
            // 
            dgvEmpresas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpresas.Location = new Point(390, 60);
            dgvEmpresas.Name = "dgvEmpresas";
            dgvEmpresas.ReadOnly = true;
            dgvEmpresas.Size = new Size(506, 402);
            dgvEmpresas.TabIndex = 3;
            dgvEmpresas.CellClick += dgvEmpresas_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(390, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 25;
            label1.Text = "EMPRESAS:";
            // 
            // EmpresaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(933, 528);
            Controls.Add(dgvEmpresas);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "EmpresaForm";
            Text = "Empresas";
            Load += EmpresaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gpbDetalles.ResumeLayout(false);
            gpbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpresas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox msk_Telefono;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private FontAwesome.Sharp.IconButton ibtnRegistrar;
        private TextBox txtActividad;
        private TextBox txtDireccion;
        private TextBox txtRUC;
        private Label lblActividad;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblRUC;
        private Label lblNombreUsuario;
        private DataGridView dgvEmpresas;
        private GroupBox gpbDetalles;
        private TextBox txtNombreEmpresa;
        private Label label1;
    }
}