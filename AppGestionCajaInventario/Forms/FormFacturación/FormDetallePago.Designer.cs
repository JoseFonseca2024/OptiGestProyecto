namespace AppGestionCajaInventario.Forms.FormFacturación
{
    partial class FormDetallePago
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
            lblFondoSubtotal = new Label();
            lblFondoIVA = new Label();
            lblFondoTotal = new Label();
            lblFondoCambio = new Label();
            label1 = new Label();
            lblSubtotal = new Label();
            lblIVA = new Label();
            lblTotal = new Label();
            lblCambio = new Label();
            btnAceptar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblFondoSubtotal
            // 
            lblFondoSubtotal.BackColor = Color.MintCream;
            lblFondoSubtotal.BorderStyle = BorderStyle.Fixed3D;
            lblFondoSubtotal.FlatStyle = FlatStyle.Flat;
            lblFondoSubtotal.Location = new Point(22, 69);
            lblFondoSubtotal.Name = "lblFondoSubtotal";
            lblFondoSubtotal.Size = new Size(359, 49);
            lblFondoSubtotal.TabIndex = 0;
            // 
            // lblFondoIVA
            // 
            lblFondoIVA.BackColor = Color.MintCream;
            lblFondoIVA.BorderStyle = BorderStyle.Fixed3D;
            lblFondoIVA.FlatStyle = FlatStyle.Flat;
            lblFondoIVA.Location = new Point(22, 133);
            lblFondoIVA.Name = "lblFondoIVA";
            lblFondoIVA.Size = new Size(359, 50);
            lblFondoIVA.TabIndex = 0;
            // 
            // lblFondoTotal
            // 
            lblFondoTotal.BackColor = Color.MintCream;
            lblFondoTotal.BorderStyle = BorderStyle.Fixed3D;
            lblFondoTotal.FlatStyle = FlatStyle.Flat;
            lblFondoTotal.Location = new Point(22, 203);
            lblFondoTotal.Name = "lblFondoTotal";
            lblFondoTotal.Size = new Size(359, 52);
            lblFondoTotal.TabIndex = 0;
            // 
            // lblFondoCambio
            // 
            lblFondoCambio.BackColor = Color.MintCream;
            lblFondoCambio.BorderStyle = BorderStyle.Fixed3D;
            lblFondoCambio.FlatStyle = FlatStyle.Flat;
            lblFondoCambio.Location = new Point(22, 273);
            lblFondoCambio.Name = "lblFondoCambio";
            lblFondoCambio.Size = new Size(359, 52);
            lblFondoCambio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Honeydew;
            label1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 1;
            label1.Text = "Detalles del Pago:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.Honeydew;
            lblSubtotal.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(41, 84);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(104, 21);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "SUB-TOTAL: ";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.BackColor = Color.Honeydew;
            lblIVA.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIVA.Location = new Point(41, 148);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(108, 21);
            lblIVA.TabIndex = 1;
            lblIVA.Text = "IVA cobrado:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Honeydew;
            lblTotal.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(41, 220);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(63, 21);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "TOTAL:";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.BackColor = Color.Honeydew;
            lblCambio.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCambio.Location = new Point(41, 288);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(77, 21);
            lblCambio.TabIndex = 1;
            lblCambio.Text = "CAMBIO:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.ForestGreen;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderColor = Color.LightGray;
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAceptar.IconColor = Color.White;
            btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAceptar.IconSize = 25;
            btnAceptar.Location = new Point(133, 345);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(128, 34);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormDetallePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(405, 396);
            Controls.Add(btnAceptar);
            Controls.Add(lblCambio);
            Controls.Add(lblTotal);
            Controls.Add(lblIVA);
            Controls.Add(lblSubtotal);
            Controls.Add(label1);
            Controls.Add(lblFondoCambio);
            Controls.Add(lblFondoTotal);
            Controls.Add(lblFondoIVA);
            Controls.Add(lblFondoSubtotal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDetallePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDetallePago";
            Load += FormDetallePago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFondoSubtotal;
        private Label lblFondoIVA;
        private Label lblFondoTotal;
        private Label lblFondoCambio;
        private Label label1;
        private Label lblSubtotal;
        private Label lblIVA;
        private Label lblTotal;
        private Label lblCambio;
        private FontAwesome.Sharp.IconButton btnAceptar;
    }
}