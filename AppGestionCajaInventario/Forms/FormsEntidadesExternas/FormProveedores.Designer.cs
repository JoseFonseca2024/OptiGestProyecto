namespace AppGestionCajaInventario.Forms.FormsEntidadesExternas
{
    partial class FormProveedores
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
            dgvProveedor = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            ibtnEliminar = new FontAwesome.Sharp.IconButton();
            ibtnEditar = new FontAwesome.Sharp.IconButton();
            ibtnRegistrar = new FontAwesome.Sharp.IconButton();
            txtTelefono = new TextBox();
            txtNombreProveedor = new TextBox();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblDetalle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProveedor
            // 
            dgvProveedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(355, 32);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.Size = new Size(575, 353);
            dgvProveedor.TabIndex = 10;
            dgvProveedor.CellClick += dgvProveedor_CellClick;
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
            panel1.Size = new Size(330, 422);
            panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ibtnEliminar);
            groupBox1.Controls.Add(ibtnEditar);
            groupBox1.Controls.Add(ibtnRegistrar);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtNombreProveedor);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 326);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles Proveedor";
            // 
            // ibtnEliminar
            // 
            ibtnEliminar.BackColor = Color.Crimson;
            ibtnEliminar.Cursor = Cursors.Hand;
            ibtnEliminar.FlatAppearance.BorderSize = 2;
            ibtnEliminar.FlatStyle = FlatStyle.Flat;
            ibtnEliminar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnEliminar.ForeColor = Color.White;
            ibtnEliminar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            ibtnEliminar.IconColor = Color.White;
            ibtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEliminar.IconSize = 20;
            ibtnEliminar.Location = new Point(15, 247);
            ibtnEliminar.Margin = new Padding(4, 3, 4, 3);
            ibtnEliminar.Name = "ibtnEliminar";
            ibtnEliminar.Size = new Size(267, 35);
            ibtnEliminar.TabIndex = 24;
            ibtnEliminar.Text = "Eliminar";
            ibtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            ibtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnEliminar.UseVisualStyleBackColor = false;
            ibtnEliminar.Click += ibtnEliminar_Click;
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
            ibtnEditar.Location = new Point(15, 206);
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
            ibtnRegistrar.Location = new Point(15, 165);
            ibtnRegistrar.Margin = new Padding(4, 3, 4, 3);
            ibtnRegistrar.Name = "ibtnRegistrar";
            ibtnRegistrar.Size = new Size(267, 35);
            ibtnRegistrar.TabIndex = 24;
            ibtnRegistrar.Text = "Registrar";
            ibtnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            ibtnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnRegistrar.UseVisualStyleBackColor = false;
            ibtnRegistrar.Click += ibtnRegistrar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(17, 121);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(265, 23);
            txtTelefono.TabIndex = 14;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(17, 59);
            txtNombreProveedor.Margin = new Padding(4, 3, 4, 3);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(265, 23);
            txtNombreProveedor.TabIndex = 14;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.WhiteSmoke;
            lblNombre.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(17, 101);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 17);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Telefono";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.WhiteSmoke;
            lblCodigo.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(17, 39);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(144, 17);
            lblCodigo.TabIndex = 10;
            lblCodigo.Text = "Nombre del Proveedor";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalle.Location = new Point(53, 21);
            lblDetalle.Margin = new Padding(4, 0, 4, 0);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(208, 23);
            lblDetalle.TabIndex = 25;
            lblDetalle.Text = "REGISTRO DE PROVEEDORES";
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(933, 422);
            Controls.Add(dgvProveedor);
            Controls.Add(panel1);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProveedor;
        private Panel panel1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton ibtnEliminar;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private FontAwesome.Sharp.IconButton ibtnRegistrar;
        private TextBox txtTelefono;
        private TextBox txtNombreProveedor;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblDetalle;
    }
}