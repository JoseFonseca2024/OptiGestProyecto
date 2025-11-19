namespace AppGestionCajaInventario.Forms.FormsUsuario
{
    partial class FormConfirmarRegistro
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
            components = new System.ComponentModel.Container();
            lblTemporizador = new Label();
            ibtnReenviarClave = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lblClave = new Label();
            btnAceptar = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            txtClave = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Location = new Point(209, 109);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(95, 15);
            lblTemporizador.TabIndex = 27;
            lblTemporizador.Text = "Tiempo restante:";
            // 
            // ibtnReenviarClave
            // 
            ibtnReenviarClave.Cursor = Cursors.Hand;
            ibtnReenviarClave.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            ibtnReenviarClave.IconColor = Color.Black;
            ibtnReenviarClave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnReenviarClave.IconSize = 15;
            ibtnReenviarClave.Location = new Point(483, 76);
            ibtnReenviarClave.Name = "ibtnReenviarClave";
            ibtnReenviarClave.Size = new Size(27, 21);
            ibtnReenviarClave.TabIndex = 26;
            ibtnReenviarClave.UseVisualStyleBackColor = true;
            ibtnReenviarClave.Click += ibtnReenviarClave_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(206, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(366, 35);
            label1.TabIndex = 24;
            label1.Text = "Información: Se le ha enviado una clave de confirmación  por medio del correo proporcionado\r\n\r\n\r\n";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(315, 53);
            lblClave.Margin = new Padding(4, 0, 4, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(119, 18);
            lblClave.TabIndex = 25;
            lblClave.Text = "Introduzca clave:";
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
            btnAceptar.Location = new Point(306, 174);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(128, 34);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("League Spartan SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(259, 12);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 28);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "CLAVE DE CONFIRMACIÓN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OptiGestLogo;
            pictureBox1.Location = new Point(15, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 226);
            panel1.TabIndex = 23;
            // 
            // ibtnCerrar
            // 
            ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            ibtnCerrar.IconColor = Color.Black;
            ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCerrar.IconSize = 15;
            ibtnCerrar.Location = new Point(545, 12);
            ibtnCerrar.Margin = new Padding(4, 3, 4, 3);
            ibtnCerrar.Name = "ibtnCerrar";
            ibtnCerrar.Size = new Size(30, 27);
            ibtnCerrar.TabIndex = 22;
            ibtnCerrar.UseVisualStyleBackColor = true;
            ibtnCerrar.Click += ibtnCerrar_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(259, 74);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(217, 23);
            txtClave.TabIndex = 28;
            txtClave.TextAlign = HorizontalAlignment.Center;
            txtClave.UseSystemPasswordChar = true;
            // 
            // FormConfirmarRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 226);
            Controls.Add(txtClave);
            Controls.Add(lblTemporizador);
            Controls.Add(ibtnReenviarClave);
            Controls.Add(label1);
            Controls.Add(lblClave);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(ibtnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfirmarRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfirmarRegistro";
            FormClosed += FormConfirmarRegistro_FormClosed;
            Load += FormConfirmarRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTemporizador;
        private FontAwesome.Sharp.IconButton ibtnReenviarClave;
        private Label label1;
        private Label lblClave;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private TextBox txtClave;
        private System.Windows.Forms.Timer timer1;
    }
}