namespace AppGestionCajaInventario.Forms.FormsLogins
{
    partial class FormCrearUsuario
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
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblEmail = new Label();
            lblConfirmarClave = new Label();
            ibtnVerClave1 = new FontAwesome.Sharp.IconButton();
            ibtnVerClave2 = new FontAwesome.Sharp.IconButton();
            btnAceptar = new FontAwesome.Sharp.IconButton();
            txtNombreUsuario = new TextBox();
            txtEmail = new TextBox();
            txtConfirmarClave = new TextBox();
            txtClave = new TextBox();
            lblClave = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ibtnCerrar
            // 
            ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            ibtnCerrar.IconColor = Color.Black;
            ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCerrar.IconSize = 15;
            ibtnCerrar.Location = new Point(609, 11);
            ibtnCerrar.Margin = new Padding(4, 3, 4, 3);
            ibtnCerrar.Name = "ibtnCerrar";
            ibtnCerrar.Size = new Size(30, 27);
            ibtnCerrar.TabIndex = 8;
            ibtnCerrar.UseVisualStyleBackColor = true;
            ibtnCerrar.Click += ibtnCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 346);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OptiGestLogo;
            pictureBox1.Location = new Point(20, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("League Spartan SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(377, 23);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(148, 28);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "CREAR USUARIO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(286, 72);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(142, 18);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre de Usuario:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(286, 120);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 18);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblConfirmarClave
            // 
            lblConfirmarClave.AutoSize = true;
            lblConfirmarClave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarClave.Location = new Point(286, 221);
            lblConfirmarClave.Margin = new Padding(4, 0, 4, 0);
            lblConfirmarClave.Name = "lblConfirmarClave";
            lblConfirmarClave.Size = new Size(116, 18);
            lblConfirmarClave.TabIndex = 3;
            lblConfirmarClave.Text = "Confirmar clave:";
            // 
            // ibtnVerClave1
            // 
            ibtnVerClave1.Cursor = Cursors.Hand;
            ibtnVerClave1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ibtnVerClave1.IconColor = Color.Black;
            ibtnVerClave1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtnVerClave1.IconSize = 20;
            ibtnVerClave1.Location = new Point(609, 192);
            ibtnVerClave1.Margin = new Padding(4, 3, 4, 3);
            ibtnVerClave1.Name = "ibtnVerClave1";
            ibtnVerClave1.Size = new Size(30, 27);
            ibtnVerClave1.TabIndex = 4;
            ibtnVerClave1.UseVisualStyleBackColor = true;
            ibtnVerClave1.Click += ibtnVerClave1_Click;
            // 
            // ibtnVerClave2
            // 
            ibtnVerClave2.Cursor = Cursors.Hand;
            ibtnVerClave2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ibtnVerClave2.IconColor = Color.Black;
            ibtnVerClave2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtnVerClave2.IconSize = 20;
            ibtnVerClave2.Location = new Point(609, 245);
            ibtnVerClave2.Margin = new Padding(4, 3, 4, 3);
            ibtnVerClave2.Name = "ibtnVerClave2";
            ibtnVerClave2.Size = new Size(30, 27);
            ibtnVerClave2.TabIndex = 6;
            ibtnVerClave2.UseVisualStyleBackColor = true;
            ibtnVerClave2.Click += ibtnVerClave2_Click;
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
            btnAceptar.Location = new Point(387, 282);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(128, 47);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(290, 94);
            txtNombreUsuario.Margin = new Padding(4, 3, 4, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(349, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(290, 145);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(290, 245);
            txtConfirmarClave.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(312, 23);
            txtConfirmarClave.TabIndex = 5;
            txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(290, 194);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(312, 23);
            txtClave.TabIndex = 3;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(286, 170);
            lblClave.Margin = new Padding(4, 0, 4, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(49, 18);
            lblClave.TabIndex = 3;
            lblClave.Text = "Clave:";
            // 
            // FormCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 346);
            Controls.Add(txtConfirmarClave);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(ibtnVerClave2);
            Controls.Add(ibtnVerClave1);
            Controls.Add(lblConfirmarClave);
            Controls.Add(lblClave);
            Controls.Add(lblEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(ibtnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrearUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEmail;
        private Label lblConfirmarClave;
        private FontAwesome.Sharp.IconButton ibtnVerClave1;
        private FontAwesome.Sharp.IconButton ibtnVerClave2;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private TextBox txtNombreUsuario;
        private TextBox txtEmail;
        private TextBox txtConfirmarClave;
        private TextBox txtClave;
        private Label lblClave;
    }
}