namespace AppGestionCajaInventario.Forms.FormsCaja
{
    partial class FormRegistroCajas
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
            txtNombreCaja = new TextBox();
            lblCodigo = new Label();
            lblDetalle = new Label();
            dgvCajas = new DataGridView();
            gpbBusqueda = new GroupBox();
            rdbTodo = new RadioButton();
            rdbInactivo = new RadioButton();
            rdbActivo = new RadioButton();
            label2 = new Label();
            ibtnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusquedaNombre = new TextBox();
            label1 = new Label();
            ibtnRegistrar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCajas).BeginInit();
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
            panel1.Size = new Size(330, 495);
            panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ibtnRegistrar);
            groupBox1.Controls.Add(ibtnEditar);
            groupBox1.Controls.Add(txtNombreCaja);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Location = new Point(12, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 184);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de Caja";
            // 
            // ibtnEditar
            // 
            ibtnEditar.BackColor = Color.SteelBlue;
            ibtnEditar.Cursor = Cursors.Hand;
            ibtnEditar.FlatAppearance.BorderSize = 2;
            ibtnEditar.FlatStyle = FlatStyle.Flat;
            ibtnEditar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnEditar.ForeColor = Color.White;
            ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            ibtnEditar.IconColor = Color.White;
            ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEditar.IconSize = 20;
            ibtnEditar.Location = new Point(19, 134);
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
            // txtNombreCaja
            // 
            txtNombreCaja.Location = new Point(19, 57);
            txtNombreCaja.Margin = new Padding(4, 3, 4, 3);
            txtNombreCaja.Name = "txtNombreCaja";
            txtNombreCaja.Size = new Size(265, 23);
            txtNombreCaja.TabIndex = 14;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.WhiteSmoke;
            lblCodigo.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(19, 32);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(119, 17);
            lblCodigo.TabIndex = 10;
            lblCodigo.Text = "Nombre de la Caja";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalle.Location = new Point(85, 86);
            lblDetalle.Margin = new Padding(4, 0, 4, 0);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(151, 23);
            lblDetalle.TabIndex = 25;
            lblDetalle.Text = "REGISTRO DE CAJAS";
            // 
            // dgvCajas
            // 
            dgvCajas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvCajas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCajas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCajas.Location = new Point(346, 168);
            dgvCajas.Name = "dgvCajas";
            dgvCajas.ReadOnly = true;
            dgvCajas.Size = new Size(636, 315);
            dgvCajas.TabIndex = 9;
            dgvCajas.CellClick += dgvCajas_CellClick;
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
            gpbBusqueda.Controls.Add(txtBusquedaNombre);
            gpbBusqueda.Controls.Add(label1);
            gpbBusqueda.Location = new Point(346, 22);
            gpbBusqueda.Name = "gpbBusqueda";
            gpbBusqueda.Size = new Size(638, 133);
            gpbBusqueda.TabIndex = 10;
            gpbBusqueda.TabStop = false;
            gpbBusqueda.Text = "Busqueda de Caja";
            // 
            // rdbTodo
            // 
            rdbTodo.Anchor = AnchorStyles.None;
            rdbTodo.AutoSize = true;
            rdbTodo.Location = new Point(403, 95);
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
            rdbInactivo.Location = new Point(330, 95);
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
            rdbActivo.Location = new Point(265, 95);
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
            label2.Location = new Point(160, 97);
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
            ibtnBuscar.Location = new Point(563, 46);
            ibtnBuscar.Name = "ibtnBuscar";
            ibtnBuscar.Size = new Size(22, 23);
            ibtnBuscar.TabIndex = 17;
            ibtnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaNombre
            // 
            txtBusquedaNombre.Anchor = AnchorStyles.None;
            txtBusquedaNombre.Location = new Point(161, 47);
            txtBusquedaNombre.Name = "txtBusquedaNombre";
            txtBusquedaNombre.Size = new Size(396, 23);
            txtBusquedaNombre.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 25;
            label1.Text = "Busqueda por nombre:";
            // 
            // ibtnRegistrar
            // 
            ibtnRegistrar.BackColor = Color.SeaGreen;
            ibtnRegistrar.Cursor = Cursors.Hand;
            ibtnRegistrar.FlatAppearance.BorderSize = 2;
            ibtnRegistrar.FlatStyle = FlatStyle.Flat;
            ibtnRegistrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnRegistrar.ForeColor = Color.White;
            ibtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            ibtnRegistrar.IconColor = Color.White;
            ibtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnRegistrar.IconSize = 20;
            ibtnRegistrar.Location = new Point(18, 93);
            ibtnRegistrar.Margin = new Padding(4, 3, 4, 3);
            ibtnRegistrar.Name = "ibtnRegistrar";
            ibtnRegistrar.Size = new Size(267, 35);
            ibtnRegistrar.TabIndex = 25;
            ibtnRegistrar.Text = "Registrar";
            ibtnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            ibtnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnRegistrar.UseVisualStyleBackColor = false;
            ibtnRegistrar.Click += ibtnRegistrar_Click;
            // 
            // FormRegistroCajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(994, 495);
            Controls.Add(gpbBusqueda);
            Controls.Add(dgvCajas);
            Controls.Add(panel1);
            Name = "FormRegistroCajas";
            Text = "Registro de Cajas";
            Load += FormRegistroCajas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCajas).EndInit();
            gpbBusqueda.ResumeLayout(false);
            gpbBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private TextBox txtNombreCaja;
        private Label lblCodigo;
        private Label lblDetalle;
        private DataGridView dgvCajas;
        private GroupBox gpbBusqueda;
        private RadioButton rdbTodo;
        private RadioButton rdbInactivo;
        private RadioButton rdbActivo;
        private Label label2;
        private FontAwesome.Sharp.IconButton ibtnBuscar;
        private TextBox txtBusquedaNombre;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnRegistrar;
    }
}