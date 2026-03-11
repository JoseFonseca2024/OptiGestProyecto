namespace AppGestionCajaInventario.Forms.FormFacturación
{
    partial class FormFacturación
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
            ibtPago = new FontAwesome.Sharp.IconButton();
            lblTotal = new Label();
            lblIVA = new Label();
            lblSubTotal = new Label();
            dgtvDetallesFactura = new DataGridView();
            gpbProducto = new GroupBox();
            ibtnEliminar = new FontAwesome.Sharp.IconButton();
            numericUpDown1 = new NumericUpDown();
            ibtnEditar = new FontAwesome.Sharp.IconButton();
            ibtnBuscarProducto = new FontAwesome.Sharp.IconButton();
            ibtnAgregar = new FontAwesome.Sharp.IconButton();
            txtDescuento = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombreProducto = new TextBox();
            lblDescuento = new Label();
            lblCantidad = new Label();
            lblStock = new Label();
            txtCodigoProducto = new TextBox();
            lblPrecio = new Label();
            lblNombreProducto = new Label();
            lblCodigoProducto = new Label();
            gpbInformación = new GroupBox();
            txtRUC = new TextBox();
            lblRUC = new Label();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            gpbCliente = new GroupBox();
            ibtnBuscarCliente = new FontAwesome.Sharp.IconButton();
            msktxtNumero = new MaskedTextBox();
            txtNombreCliente = new TextBox();
            lblNumero = new Label();
            lblNombreCliente = new Label();
            txtIVA = new TextBox();
            txtTotalaPagar = new TextBox();
            txtSubtotal = new TextBox();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgtvDetallesFactura).BeginInit();
            gpbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gpbInformación.SuspendLayout();
            gpbCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(ibtPago);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblIVA);
            panel1.Controls.Add(lblSubTotal);
            panel1.Controls.Add(dgtvDetallesFactura);
            panel1.Controls.Add(gpbProducto);
            panel1.Controls.Add(gpbInformación);
            panel1.Controls.Add(gpbCliente);
            panel1.Controls.Add(txtIVA);
            panel1.Controls.Add(txtTotalaPagar);
            panel1.Controls.Add(txtSubtotal);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(52, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 501);
            panel1.TabIndex = 0;
            // 
            // ibtPago
            // 
            ibtPago.BackColor = Color.CornflowerBlue;
            ibtPago.ForeColor = Color.White;
            ibtPago.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            ibtPago.IconColor = Color.White;
            ibtPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtPago.IconSize = 25;
            ibtPago.Location = new Point(746, 564);
            ibtPago.Name = "ibtPago";
            ibtPago.Size = new Size(111, 45);
            ibtPago.TabIndex = 7;
            ibtPago.Text = "Proceder al pago\r\n";
            ibtPago.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtPago.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(752, 501);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIVA.Location = new Point(752, 448);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(34, 20);
            lblIVA.TabIndex = 5;
            lblIVA.Text = "IVA:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(752, 390);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(68, 20);
            lblSubTotal.TabIndex = 5;
            lblSubTotal.Text = "Subtotal:";
            // 
            // dgtvDetallesFactura
            // 
            dgtvDetallesFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtvDetallesFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvDetallesFactura.Location = new Point(94, 353);
            dgtvDetallesFactura.Name = "dgtvDetallesFactura";
            dgtvDetallesFactura.Size = new Size(634, 251);
            dgtvDetallesFactura.TabIndex = 4;
            // 
            // gpbProducto
            // 
            gpbProducto.Controls.Add(ibtnEliminar);
            gpbProducto.Controls.Add(numericUpDown1);
            gpbProducto.Controls.Add(ibtnEditar);
            gpbProducto.Controls.Add(ibtnBuscarProducto);
            gpbProducto.Controls.Add(ibtnAgregar);
            gpbProducto.Controls.Add(txtDescuento);
            gpbProducto.Controls.Add(txtStock);
            gpbProducto.Controls.Add(txtPrecio);
            gpbProducto.Controls.Add(txtNombreProducto);
            gpbProducto.Controls.Add(lblDescuento);
            gpbProducto.Controls.Add(lblCantidad);
            gpbProducto.Controls.Add(lblStock);
            gpbProducto.Controls.Add(txtCodigoProducto);
            gpbProducto.Controls.Add(lblPrecio);
            gpbProducto.Controls.Add(lblNombreProducto);
            gpbProducto.Controls.Add(lblCodigoProducto);
            gpbProducto.Font = new Font("Segoe UI", 11.25F);
            gpbProducto.Location = new Point(103, 185);
            gpbProducto.Name = "gpbProducto";
            gpbProducto.Size = new Size(733, 146);
            gpbProducto.TabIndex = 3;
            gpbProducto.TabStop = false;
            gpbProducto.Text = "Información Producto:";
            // 
            // ibtnEliminar
            // 
            ibtnEliminar.BackColor = Color.Crimson;
            ibtnEliminar.Font = new Font("Segoe UI", 11.25F);
            ibtnEliminar.ForeColor = Color.White;
            ibtnEliminar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            ibtnEliminar.IconColor = Color.White;
            ibtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEliminar.IconSize = 20;
            ibtnEliminar.Location = new Point(435, 100);
            ibtnEliminar.Name = "ibtnEliminar";
            ibtnEliminar.Size = new Size(99, 33);
            ibtnEliminar.TabIndex = 20;
            ibtnEliminar.Text = "Eliminar";
            ibtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnEliminar.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 11.25F);
            numericUpDown1.Location = new Point(521, 56);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 27);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ibtnEditar
            // 
            ibtnEditar.BackColor = Color.CornflowerBlue;
            ibtnEditar.Font = new Font("Segoe UI", 11.25F);
            ibtnEditar.ForeColor = Color.White;
            ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            ibtnEditar.IconColor = Color.White;
            ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEditar.IconSize = 20;
            ibtnEditar.ImageAlign = ContentAlignment.BottomCenter;
            ibtnEditar.Location = new Point(337, 100);
            ibtnEditar.Name = "ibtnEditar";
            ibtnEditar.Size = new Size(92, 33);
            ibtnEditar.TabIndex = 20;
            ibtnEditar.Text = "Editar";
            ibtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnEditar.UseVisualStyleBackColor = false;
            // 
            // ibtnBuscarProducto
            // 
            ibtnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnBuscarProducto.IconColor = Color.Black;
            ibtnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBuscarProducto.IconSize = 16;
            ibtnBuscarProducto.Location = new Point(169, 58);
            ibtnBuscarProducto.Name = "ibtnBuscarProducto";
            ibtnBuscarProducto.Size = new Size(22, 28);
            ibtnBuscarProducto.TabIndex = 18;
            ibtnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // ibtnAgregar
            // 
            ibtnAgregar.BackColor = Color.Green;
            ibtnAgregar.Font = new Font("Segoe UI", 11.25F);
            ibtnAgregar.ForeColor = Color.White;
            ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            ibtnAgregar.IconColor = Color.White;
            ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtnAgregar.IconSize = 20;
            ibtnAgregar.ImageAlign = ContentAlignment.BottomCenter;
            ibtnAgregar.Location = new Point(222, 100);
            ibtnAgregar.Name = "ibtnAgregar";
            ibtnAgregar.Size = new Size(105, 33);
            ibtnAgregar.TabIndex = 20;
            ibtnAgregar.Text = "Agregar";
            ibtnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 11.25F);
            txtDescuento.Location = new Point(603, 57);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(84, 27);
            txtDescuento.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 11.25F);
            txtStock.Location = new Point(462, 58);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(39, 27);
            txtStock.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11.25F);
            txtPrecio.Location = new Point(376, 58);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(74, 27);
            txtPrecio.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 11.25F);
            txtNombreProducto.Location = new Point(197, 58);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.ReadOnly = true;
            txtNombreProducto.Size = new Size(170, 27);
            txtNombreProducto.TabIndex = 1;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 11.25F);
            lblDescuento.Location = new Point(593, 36);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(108, 20);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento (%):";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 11.25F);
            lblCantidad.Location = new Point(521, 36);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F);
            lblStock.Location = new Point(462, 37);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 0;
            lblStock.Text = "Stock:";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Font = new Font("Segoe UI", 11.25F);
            txtCodigoProducto.Location = new Point(7, 57);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(156, 27);
            txtCodigoProducto.TabIndex = 1;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 11.25F);
            lblPrecio.Location = new Point(376, 37);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio:";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 11.25F);
            lblNombreProducto.Location = new Point(197, 37);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(67, 20);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre:";
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.Font = new Font("Segoe UI", 11.25F);
            lblCodigoProducto.Location = new Point(7, 37);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(61, 20);
            lblCodigoProducto.TabIndex = 0;
            lblCodigoProducto.Text = "Codigo:";
            // 
            // gpbInformación
            // 
            gpbInformación.Controls.Add(txtRUC);
            gpbInformación.Controls.Add(lblRUC);
            gpbInformación.Controls.Add(lblFecha);
            gpbInformación.Controls.Add(dtpFecha);
            gpbInformación.Font = new Font("Segoe UI", 11.25F);
            gpbInformación.Location = new Point(79, 67);
            gpbInformación.Name = "gpbInformación";
            gpbInformación.Size = new Size(315, 101);
            gpbInformación.TabIndex = 2;
            gpbInformación.TabStop = false;
            gpbInformación.Text = "Información Factura";
            // 
            // txtRUC
            // 
            txtRUC.Font = new Font("Segoe UI", 11.25F);
            txtRUC.Location = new Point(6, 45);
            txtRUC.Name = "txtRUC";
            txtRUC.ReadOnly = true;
            txtRUC.Size = new Size(157, 27);
            txtRUC.TabIndex = 1;
            // 
            // lblRUC
            // 
            lblRUC.AutoSize = true;
            lblRUC.Font = new Font("Segoe UI", 11.25F);
            lblRUC.Location = new Point(6, 25);
            lblRUC.Name = "lblRUC";
            lblRUC.Size = new Size(40, 20);
            lblRUC.TabIndex = 0;
            lblRUC.Text = "RUC:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 11.25F);
            lblFecha.Location = new Point(170, 23);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 11.25F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(169, 44);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(140, 27);
            dtpFecha.TabIndex = 0;
            // 
            // gpbCliente
            // 
            gpbCliente.Controls.Add(ibtnBuscarCliente);
            gpbCliente.Controls.Add(msktxtNumero);
            gpbCliente.Controls.Add(txtNombreCliente);
            gpbCliente.Controls.Add(lblNumero);
            gpbCliente.Controls.Add(lblNombreCliente);
            gpbCliente.Font = new Font("Segoe UI", 11.25F);
            gpbCliente.Location = new Point(427, 67);
            gpbCliente.Name = "gpbCliente";
            gpbCliente.Size = new Size(454, 101);
            gpbCliente.TabIndex = 1;
            gpbCliente.TabStop = false;
            gpbCliente.Text = "Información del Cliente";
            // 
            // ibtnBuscarCliente
            // 
            ibtnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnBuscarCliente.IconColor = Color.Black;
            ibtnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBuscarCliente.IconSize = 16;
            ibtnBuscarCliente.Location = new Point(387, 50);
            ibtnBuscarCliente.Name = "ibtnBuscarCliente";
            ibtnBuscarCliente.Size = new Size(22, 27);
            ibtnBuscarCliente.TabIndex = 18;
            ibtnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // msktxtNumero
            // 
            msktxtNumero.Font = new Font("Segoe UI", 11.25F);
            msktxtNumero.Location = new Point(227, 50);
            msktxtNumero.Mask = "0000-0000";
            msktxtNumero.Name = "msktxtNumero";
            msktxtNumero.Size = new Size(154, 27);
            msktxtNumero.TabIndex = 2;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Segoe UI", 11.25F);
            txtNombreCliente.Location = new Point(12, 51);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(209, 27);
            txtNombreCliente.TabIndex = 1;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 11.25F);
            lblNumero.Location = new Point(227, 30);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(149, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero de Telefono:";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 11.25F);
            lblNombreCliente.Location = new Point(12, 30);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(142, 20);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // txtIVA
            // 
            txtIVA.Font = new Font("Segoe UI", 11.25F);
            txtIVA.Location = new Point(752, 471);
            txtIVA.Name = "txtIVA";
            txtIVA.ReadOnly = true;
            txtIVA.Size = new Size(101, 27);
            txtIVA.TabIndex = 1;
            // 
            // txtTotalaPagar
            // 
            txtTotalaPagar.Font = new Font("Segoe UI", 11.25F);
            txtTotalaPagar.Location = new Point(752, 524);
            txtTotalaPagar.Name = "txtTotalaPagar";
            txtTotalaPagar.ReadOnly = true;
            txtTotalaPagar.Size = new Size(84, 27);
            txtTotalaPagar.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Font = new Font("Segoe UI", 11.25F);
            txtSubtotal.Location = new Point(752, 413);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(101, 27);
            txtSubtotal.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(130, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Facturación";
            // 
            // FormFacturación
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1096, 538);
            Controls.Add(panel1);
            Name = "FormFacturación";
            Text = "FormFacturación";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgtvDetallesFactura).EndInit();
            gpbProducto.ResumeLayout(false);
            gpbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gpbInformación.ResumeLayout(false);
            gpbInformación.PerformLayout();
            gpbCliente.ResumeLayout(false);
            gpbCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private GroupBox gpbCliente;
        private GroupBox gpbInformación;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private TextBox txtRUC;
        private Label lblRUC;
        private Label lblNombreCliente;
        private TextBox txtNombreCliente;
        private Label lblNumero;
        private MaskedTextBox msktxtNumero;
        private FontAwesome.Sharp.IconButton ibtnBuscarCliente;
        private GroupBox gpbProducto;
        private Label lblCodigoProducto;
        private TextBox txtCodigoProducto;
        private FontAwesome.Sharp.IconButton ibtnBuscarProducto;
        private TextBox txtPrecio;
        private TextBox txtNombreProducto;
        private Label lblPrecio;
        private Label lblNombreProducto;
        private TextBox txtStock;
        private Label lblStock;
        private NumericUpDown numericUpDown1;
        private Label lblDescuento;
        private Label lblCantidad;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private TextBox txtDescuento;
        private GroupBox gpbControles;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private FontAwesome.Sharp.IconButton ibtnEliminar;
        private DataGridView dgtvDetallesFactura;
        private Label lblTotal;
        private Label lblIVA;
        private Label lblSubTotal;
        private TextBox txtIVA;
        private TextBox txtTotalaPagar;
        private TextBox txtSubtotal;
        private FontAwesome.Sharp.IconButton ibtPago;
    }
}