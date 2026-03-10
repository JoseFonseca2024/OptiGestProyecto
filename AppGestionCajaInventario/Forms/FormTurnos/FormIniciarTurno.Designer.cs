namespace AppGestionCajaInventario.Forms.FormTurnos
{
    partial class FormIniciarTurno
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
            lblTitulo = new Label();
            lblNombre = new Label();
            lblEmail = new Label();
            label1 = new Label();
            lblFondo = new Label();
            pictureBox1 = new PictureBox();
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            cmbCajas = new ComboBox();
            cmbUsuario = new ComboBox();
            txtMontoIncial = new TextBox();
            btnAceptar = new FontAwesome.Sharp.IconButton();
            ibtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("League Spartan SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(270, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(140, 28);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "INICIAR TURNO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(188, 49);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(104, 18);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Caja a Operar:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(188, 97);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(131, 18);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Usuario Operador:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 152);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 18);
            label1.TabIndex = 8;
            label1.Text = "Monto Inicial:";
            // 
            // lblFondo
            // 
            lblFondo.BackColor = Color.CornflowerBlue;
            lblFondo.Dock = DockStyle.Left;
            lblFondo.Location = new Point(0, 0);
            lblFondo.Margin = new Padding(4, 0, 4, 0);
            lblFondo.Name = "lblFondo";
            lblFondo.Size = new Size(103, 271);
            lblFondo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OptiGestLogo;
            pictureBox1.Location = new Point(22, 45);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ibtnCerrar
            // 
            ibtnCerrar.Cursor = Cursors.Hand;
            ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            ibtnCerrar.IconColor = Color.Black;
            ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCerrar.IconSize = 15;
            ibtnCerrar.Location = new Point(515, 10);
            ibtnCerrar.Margin = new Padding(4, 3, 4, 3);
            ibtnCerrar.Name = "ibtnCerrar";
            ibtnCerrar.Size = new Size(30, 27);
            ibtnCerrar.TabIndex = 12;
            ibtnCerrar.UseVisualStyleBackColor = true;
            ibtnCerrar.Click += ibtnCerrar_Click;
            // 
            // cmbCajas
            // 
            cmbCajas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCajas.FormattingEnabled = true;
            cmbCajas.Location = new Point(188, 71);
            cmbCajas.Name = "cmbCajas";
            cmbCajas.Size = new Size(353, 23);
            cmbCajas.TabIndex = 14;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(191, 126);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(353, 23);
            cmbUsuario.TabIndex = 14;
            // 
            // txtMontoIncial
            // 
            txtMontoIncial.Location = new Point(192, 177);
            txtMontoIncial.Margin = new Padding(4, 3, 4, 3);
            txtMontoIncial.Name = "txtMontoIncial";
            txtMontoIncial.ReadOnly = true;
            txtMontoIncial.Size = new Size(349, 23);
            txtMontoIncial.TabIndex = 6;
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
            btnAceptar.Location = new Point(207, 211);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(128, 39);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // ibtnCancelar
            // 
            ibtnCancelar.BackColor = Color.Crimson;
            ibtnCancelar.Cursor = Cursors.Hand;
            ibtnCancelar.FlatAppearance.BorderColor = Color.LightGray;
            ibtnCancelar.FlatAppearance.BorderSize = 2;
            ibtnCancelar.FlatStyle = FlatStyle.Flat;
            ibtnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnCancelar.ForeColor = SystemColors.ButtonHighlight;
            ibtnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            ibtnCancelar.IconColor = Color.White;
            ibtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCancelar.IconSize = 25;
            ibtnCancelar.Location = new Point(356, 211);
            ibtnCancelar.Margin = new Padding(4, 3, 4, 3);
            ibtnCancelar.Name = "ibtnCancelar";
            ibtnCancelar.Size = new Size(127, 39);
            ibtnCancelar.TabIndex = 13;
            ibtnCancelar.Text = "Cancelar";
            ibtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            ibtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormIniciarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 271);
            Controls.Add(ibtnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtMontoIncial);
            Controls.Add(cmbUsuario);
            Controls.Add(cmbCajas);
            Controls.Add(ibtnCerrar);
            Controls.Add(label1);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(lblFondo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIniciarTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIniciarTurno";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEmail;
        private Label label1;
        private Label lblFondo;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private ComboBox cmbCajas;
        private ComboBox cmbUsuario;
        private TextBox txtMontoIncial;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton ibtnCancelar;
    }
}