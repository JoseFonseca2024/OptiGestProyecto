namespace AppGestionCajaInventario.Forms.FormsUsuario
{
    partial class FormRegistrodeUsuarios
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
            groupBox1 = new GroupBox();
            ibtnEditar = new FontAwesome.Sharp.IconButton();
            cmbEstado = new ComboBox();
            txtEmail = new TextBox();
            txtNombreUsuario = new TextBox();
            lblEstado = new Label();
            lblEmail = new Label();
            lblNombreUsuario = new Label();
            lblDetalle = new Label();
            lblConfirmar = new Label();
            dgvUsuarios = new DataGridView();
            gpbBusqueda = new GroupBox();
            rdbTodo = new RadioButton();
            rdbInactivo = new RadioButton();
            rdbActivo = new RadioButton();
            label2 = new Label();
            ibtnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            label1 = new Label();
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            lblRol = new Label();
            cmbRoles = new ComboBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gpbBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblDetalle);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 512);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ibtnEditar);
            groupBox1.Controls.Add(cmbRoles);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblRol);
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblNombreUsuario);
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 367);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles Usuario";
            // 
            // ibtnEditar
            // 
            ibtnEditar.BackColor = Color.SteelBlue;
            ibtnEditar.Cursor = Cursors.Hand;
            ibtnEditar.FlatAppearance.BorderSize = 2;
            ibtnEditar.FlatStyle = FlatStyle.Flat;
            ibtnEditar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnEditar.ForeColor = Color.White;
            ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            ibtnEditar.IconColor = Color.White;
            ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEditar.IconSize = 20;
            ibtnEditar.Location = new Point(15, 277);
            ibtnEditar.Margin = new Padding(4, 3, 4, 3);
            ibtnEditar.Name = "ibtnEditar";
            ibtnEditar.Size = new Size(267, 35);
            ibtnEditar.TabIndex = 24;
            ibtnEditar.Text = "Editar";
            ibtnEditar.TextAlign = ContentAlignment.MiddleRight;
            ibtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnEditar.UseVisualStyleBackColor = false;
            ibtnEditar.Click += ibtnEditar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.Cursor = Cursors.Hand;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(15, 130);
            cmbEstado.Margin = new Padding(4, 3, 4, 3);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(265, 23);
            cmbEstado.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 230);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(18, 62);
            txtNombreUsuario.Margin = new Padding(4, 3, 4, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(265, 23);
            txtNombreUsuario.TabIndex = 14;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.WhiteSmoke;
            lblEstado.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(15, 107);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(48, 17);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.WhiteSmoke;
            lblEmail.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(13, 206);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.WhiteSmoke;
            lblNombreUsuario.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(14, 39);
            lblNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(128, 17);
            lblNombreUsuario.TabIndex = 10;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalle.Location = new Point(16, 38);
            lblDetalle.Margin = new Padding(4, 0, 4, 0);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(289, 23);
            lblDetalle.TabIndex = 25;
            lblDetalle.Text = "REGISTRO DE USUARIOS DE LA EMPRESA";
            // 
            // lblConfirmar
            // 
            lblConfirmar.Location = new Point(0, 0);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(100, 23);
            lblConfirmar.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(346, 195);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(575, 250);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // gpbBusqueda
            // 
            gpbBusqueda.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gpbBusqueda.BackColor = Color.Gainsboro;
            gpbBusqueda.Controls.Add(rdbTodo);
            gpbBusqueda.Controls.Add(rdbInactivo);
            gpbBusqueda.Controls.Add(rdbActivo);
            gpbBusqueda.Controls.Add(label2);
            gpbBusqueda.Controls.Add(ibtnBuscar);
            gpbBusqueda.Controls.Add(txtBusqueda);
            gpbBusqueda.Controls.Add(label1);
            gpbBusqueda.Location = new Point(346, 77);
            gpbBusqueda.Name = "gpbBusqueda";
            gpbBusqueda.Size = new Size(577, 100);
            gpbBusqueda.TabIndex = 3;
            gpbBusqueda.TabStop = false;
            gpbBusqueda.Text = "Busqueda de usuario";
            // 
            // rdbTodo
            // 
            rdbTodo.Anchor = AnchorStyles.None;
            rdbTodo.AutoSize = true;
            rdbTodo.Location = new Point(391, 66);
            rdbTodo.Name = "rdbTodo";
            rdbTodo.Size = new Size(56, 19);
            rdbTodo.TabIndex = 28;
            rdbTodo.TabStop = true;
            rdbTodo.Text = "Todos";
            rdbTodo.UseVisualStyleBackColor = true;
            // 
            // rdbInactivo
            // 
            rdbInactivo.Anchor = AnchorStyles.None;
            rdbInactivo.AutoSize = true;
            rdbInactivo.Location = new Point(318, 66);
            rdbInactivo.Name = "rdbInactivo";
            rdbInactivo.Size = new Size(67, 19);
            rdbInactivo.TabIndex = 28;
            rdbInactivo.TabStop = true;
            rdbInactivo.Text = "Inactivo";
            rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            rdbActivo.Anchor = AnchorStyles.None;
            rdbActivo.AutoSize = true;
            rdbActivo.Location = new Point(253, 66);
            rdbActivo.Name = "rdbActivo";
            rdbActivo.Size = new Size(59, 19);
            rdbActivo.TabIndex = 28;
            rdbActivo.TabStop = true;
            rdbActivo.Text = "Activo";
            rdbActivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(127, 68);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 27;
            label2.Text = "Filtrar por estado:";
            // 
            // ibtnBuscar
            // 
            ibtnBuscar.Anchor = AnchorStyles.None;
            ibtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnBuscar.IconColor = Color.Black;
            ibtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBuscar.IconSize = 16;
            ibtnBuscar.Location = new Point(517, 26);
            ibtnBuscar.Name = "ibtnBuscar";
            ibtnBuscar.Size = new Size(22, 23);
            ibtnBuscar.TabIndex = 17;
            ibtnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.None;
            txtBusqueda.Location = new Point(157, 26);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(354, 23);
            txtBusqueda.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 25;
            label1.Text = "Busqueda por nombre:";
            // 
            // ibtnCerrar
            // 
            ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            ibtnCerrar.IconColor = Color.Black;
            ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCerrar.IconSize = 15;
            ibtnCerrar.Location = new Point(905, 3);
            ibtnCerrar.Margin = new Padding(4, 3, 4, 3);
            ibtnCerrar.Name = "ibtnCerrar";
            ibtnCerrar.Size = new Size(25, 26);
            ibtnCerrar.TabIndex = 25;
            ibtnCerrar.UseVisualStyleBackColor = true;
            ibtnCerrar.Click += ibtnCerrar_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.WhiteSmoke;
            lblRol.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(15, 157);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(30, 17);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol:";
            // 
            // cmbRoles
            // 
            cmbRoles.Cursor = Cursors.Hand;
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(15, 180);
            cmbRoles.Margin = new Padding(4, 3, 4, 3);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(265, 23);
            cmbRoles.TabIndex = 18;
            // 
            // FormRegistrodeUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(933, 512);
            Controls.Add(ibtnCerrar);
            Controls.Add(gpbBusqueda);
            Controls.Add(dgvUsuarios);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrodeUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuarios";
            Load += FormRegistrodeUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gpbBusqueda.ResumeLayout(false);
            gpbBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDetalle;
        private GroupBox groupBox1;
        private Label lblConfirmar;
        private Label lblEmail;
        private Label lblEstado;
        private Label lblNombreUsuario;
        private TextBox txtEmail;
        private TextBox txtNombreUsuario;
        private ComboBox cmbEstado;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private DataGridView dgvUsuarios;
        private GroupBox gpbBusqueda;
        private FontAwesome.Sharp.IconButton ibtnBuscar;
        private TextBox txtBusqueda;
        private Label label1;
        private RadioButton rdbTodo;
        private RadioButton rdbInactivo;
        private RadioButton rdbActivo;
        private Label label2;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private ComboBox cmbRoles;
        private Label lblRol;
    }
}