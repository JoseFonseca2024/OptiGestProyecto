namespace AppGestionCajaInventario.Forms.FormProductos
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            ibtnEliminar = new FontAwesome.Sharp.IconButton();
            ibtnEditar = new FontAwesome.Sharp.IconButton();
            ibtnRegistrar = new FontAwesome.Sharp.IconButton();
            txtPrecio = new TextBox();
            txtCosto = new TextBox();
            txtNombrProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            lblCosto = new Label();
            lblNombre = new Label();
            lblPrecioUnitario = new Label();
            lblCodigo = new Label();
            lblDetalle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(352, 32);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(575, 487);
            dgvProductos.TabIndex = 4;
            dgvProductos.CellClick += dgvProductos_CellClick;
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
            panel1.Size = new Size(330, 548);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ibtnEliminar);
            groupBox1.Controls.Add(ibtnEditar);
            groupBox1.Controls.Add(ibtnRegistrar);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtCosto);
            groupBox1.Controls.Add(txtNombrProducto);
            groupBox1.Controls.Add(txtCodigoProducto);
            groupBox1.Controls.Add(lblCosto);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblPrecioUnitario);
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 477);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles Producto";
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
            ibtnEliminar.Location = new Point(12, 381);
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
            ibtnEditar.Location = new Point(12, 340);
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
            ibtnRegistrar.Location = new Point(12, 299);
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
            // txtPrecio
            // 
            txtPrecio.Location = new Point(7, 247);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(265, 23);
            txtPrecio.TabIndex = 19;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(7, 190);
            txtCosto.Margin = new Padding(4, 3, 4, 3);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(265, 23);
            txtCosto.TabIndex = 19;
            // 
            // txtNombrProducto
            // 
            txtNombrProducto.Location = new Point(7, 133);
            txtNombrProducto.Margin = new Padding(4, 3, 4, 3);
            txtNombrProducto.Name = "txtNombrProducto";
            txtNombrProducto.Size = new Size(265, 23);
            txtNombrProducto.TabIndex = 14;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(7, 71);
            txtCodigoProducto.Margin = new Padding(4, 3, 4, 3);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(265, 23);
            txtCodigoProducto.TabIndex = 14;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.BackColor = Color.WhiteSmoke;
            lblCosto.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCosto.Location = new Point(7, 170);
            lblCosto.Margin = new Padding(4, 0, 4, 0);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(106, 17);
            lblCosto.TabIndex = 11;
            lblCosto.Text = "Costo Promedio:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.WhiteSmoke;
            lblNombre.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(7, 113);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(117, 17);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre Producto:";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.BackColor = Color.WhiteSmoke;
            lblPrecioUnitario.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioUnitario.Location = new Point(7, 227);
            lblPrecioUnitario.Margin = new Padding(4, 0, 4, 0);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(97, 17);
            lblPrecioUnitario.TabIndex = 11;
            lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.WhiteSmoke;
            lblCodigo.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(7, 51);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(111, 17);
            lblCodigo.TabIndex = 10;
            lblCodigo.Text = "Codigo Producto:";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalle.Location = new Point(80, 9);
            lblDetalle.Margin = new Padding(4, 0, 4, 0);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(172, 23);
            lblDetalle.TabIndex = 25;
            lblDetalle.Text = "REGISTRO PRODUCTOS";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(933, 548);
            Controls.Add(dgvProductos);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProductos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Productos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Panel panel1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton ibtnEliminar;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private FontAwesome.Sharp.IconButton ibtnRegistrar;
        private TextBox txtCosto;
        private TextBox txtCodigoProducto;
        private Label lblCodigo;
        private Label lblDetalle;
        private TextBox txtNombrProducto;
        private TextBox txtPrecio;
        private Label lblPrecioUnitario;
        private Label lblNombre;
        private Label lblCosto;
    }
}