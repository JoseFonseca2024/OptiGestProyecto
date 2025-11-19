namespace AppGestionCajaInventario.Forms.FormsUsuario
{
    partial class FormRegistrarNuevoUsuario
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
            pictureBox1 = new PictureBox();
            txtConfirmarClave = new TextBox();
            txtClave = new TextBox();
            txtEmail = new TextBox();
            txtNombreUsuario = new TextBox();
            ibtnVerClave2 = new FontAwesome.Sharp.IconButton();
            ibtnVerClave1 = new FontAwesome.Sharp.IconButton();
            lblConfirmarClave = new Label();
            lblClave = new Label();
            lblEmail = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            btnAceptar = new FontAwesome.Sharp.IconButton();
            lblRol = new Label();
            cmbRol = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 360);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OptiGestLogo;
            pictureBox1.Location = new Point(24, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(291, 270);
            txtConfirmarClave.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(312, 23);
            txtConfirmarClave.TabIndex = 20;
            txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(291, 223);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(312, 23);
            txtClave.TabIndex = 13;
            txtClave.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(291, 176);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(291, 76);
            txtNombreUsuario.Margin = new Padding(4, 3, 4, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(349, 23);
            txtNombreUsuario.TabIndex = 11;
            // 
            // ibtnVerClave2
            // 
            ibtnVerClave2.Cursor = Cursors.Hand;
            ibtnVerClave2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ibtnVerClave2.IconColor = Color.Black;
            ibtnVerClave2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtnVerClave2.IconSize = 20;
            ibtnVerClave2.Location = new Point(610, 270);
            ibtnVerClave2.Margin = new Padding(4, 3, 4, 3);
            ibtnVerClave2.Name = "ibtnVerClave2";
            ibtnVerClave2.Size = new Size(30, 27);
            ibtnVerClave2.TabIndex = 21;
            ibtnVerClave2.UseVisualStyleBackColor = true;
            // 
            // ibtnVerClave1
            // 
            ibtnVerClave1.Cursor = Cursors.Hand;
            ibtnVerClave1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ibtnVerClave1.IconColor = Color.Black;
            ibtnVerClave1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtnVerClave1.IconSize = 20;
            ibtnVerClave1.Location = new Point(610, 223);
            ibtnVerClave1.Margin = new Padding(4, 3, 4, 3);
            ibtnVerClave1.Name = "ibtnVerClave1";
            ibtnVerClave1.Size = new Size(30, 27);
            ibtnVerClave1.TabIndex = 19;
            ibtnVerClave1.UseVisualStyleBackColor = true;
            // 
            // lblConfirmarClave
            // 
            lblConfirmarClave.AutoSize = true;
            lblConfirmarClave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarClave.Location = new Point(291, 249);
            lblConfirmarClave.Margin = new Padding(4, 0, 4, 0);
            lblConfirmarClave.Name = "lblConfirmarClave";
            lblConfirmarClave.Size = new Size(116, 18);
            lblConfirmarClave.TabIndex = 14;
            lblConfirmarClave.Text = "Confirmar clave:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(291, 202);
            lblClave.Margin = new Padding(4, 0, 4, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(49, 18);
            lblClave.TabIndex = 15;
            lblClave.Text = "Clave:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(291, 155);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 18);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(291, 55);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(142, 18);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre de Usuario:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("League Spartan SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(337, 12);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 28);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "REGISTRAR NUEVO USUARIO";
            // 
            // ibtnCerrar
            // 
            ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            ibtnCerrar.IconColor = Color.Black;
            ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCerrar.IconSize = 15;
            ibtnCerrar.Location = new Point(610, 12);
            ibtnCerrar.Margin = new Padding(4, 3, 4, 3);
            ibtnCerrar.Name = "ibtnCerrar";
            ibtnCerrar.Size = new Size(30, 27);
            ibtnCerrar.TabIndex = 22;
            ibtnCerrar.UseVisualStyleBackColor = true;
            ibtnCerrar.Click += ibtnCerrar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.ForestGreen;
            btnAceptar.FlatAppearance.BorderColor = Color.LightGray;
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAceptar.IconColor = Color.White;
            btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAceptar.IconSize = 35;
            btnAceptar.Location = new Point(398, 306);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(128, 47);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_ClickAsync;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.Location = new Point(291, 102);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(35, 18);
            lblRol.TabIndex = 14;
            lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(291, 123);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(349, 23);
            cmbRol.TabIndex = 24;
            // 
            // FormRegistrarNuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 360);
            Controls.Add(cmbRol);
            Controls.Add(btnAceptar);
            Controls.Add(txtConfirmarClave);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(ibtnVerClave2);
            Controls.Add(ibtnVerClave1);
            Controls.Add(lblRol);
            Controls.Add(lblConfirmarClave);
            Controls.Add(lblClave);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(ibtnCerrar);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarNuevoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarNuevoUsuario";
            Load += FormRegistrarNuevoUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtConfirmarClave;
        private TextBox txtClave;
        private TextBox txtEmail;
        private TextBox txtNombreUsuario;
        private FontAwesome.Sharp.IconButton ibtnVerClave2;
        private FontAwesome.Sharp.IconButton ibtnVerClave1;
        private Label lblConfirmarClave;
        private Label lblClave;
        private Label lblEmail;
        private Label lblNombre;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private Label lblRol;
        private ComboBox cmbRol;
    }
}