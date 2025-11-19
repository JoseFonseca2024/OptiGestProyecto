namespace AppGestionCajaInventario.Forms.FormsLogins
{
    partial class FormConfirmacióndeClave
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
            btnAceptar = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            txtClave = new TextBox();
            lblClave = new Label();
            label1 = new Label();
            ibtnReenviarClave = new FontAwesome.Sharp.IconButton();
            toolTip1 = new ToolTip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            lblTemporizador = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnAceptar.Location = new Point(302, 174);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(128, 34);
            btnAceptar.TabIndex = 12;
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
            lblTitulo.Location = new Point(255, 12);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 28);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "CLAVE DE CONFIRMACIÓN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OptiGestLogo;
            pictureBox1.Location = new Point(11, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 226);
            panel1.TabIndex = 14;
            // 
            // ibtnCerrar
            // 
            ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            ibtnCerrar.IconColor = Color.Black;
            ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCerrar.IconSize = 15;
            ibtnCerrar.Location = new Point(541, 12);
            ibtnCerrar.Margin = new Padding(4, 3, 4, 3);
            ibtnCerrar.Name = "ibtnCerrar";
            ibtnCerrar.Size = new Size(30, 27);
            ibtnCerrar.TabIndex = 13;
            ibtnCerrar.UseVisualStyleBackColor = true;
            ibtnCerrar.Click += ibtnCerrar_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(255, 74);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(217, 23);
            txtClave.TabIndex = 15;
            txtClave.TextAlign = HorizontalAlignment.Center;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(311, 53);
            lblClave.Margin = new Padding(4, 0, 4, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(119, 18);
            lblClave.TabIndex = 16;
            lblClave.Text = "Introduzca clave:";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(202, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(366, 35);
            label1.TabIndex = 16;
            label1.Text = "Información: Se le ha enviado una clave de confirmación  por medio del correo proporcionado\r\n\r\n\r\n";
            // 
            // ibtnReenviarClave
            // 
            ibtnReenviarClave.Cursor = Cursors.Hand;
            ibtnReenviarClave.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            ibtnReenviarClave.IconColor = Color.Black;
            ibtnReenviarClave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnReenviarClave.IconSize = 15;
            ibtnReenviarClave.Location = new Point(479, 76);
            ibtnReenviarClave.Name = "ibtnReenviarClave";
            ibtnReenviarClave.Size = new Size(27, 21);
            ibtnReenviarClave.TabIndex = 17;
            toolTip1.SetToolTip(ibtnReenviarClave, "¿No ha recibido la clave? Haga Click para Reenviar");
            ibtnReenviarClave.UseVisualStyleBackColor = true;
            ibtnReenviarClave.Click += ibtnReenviarClave_Click;
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Location = new Point(205, 109);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(95, 15);
            lblTemporizador.TabIndex = 18;
            lblTemporizador.Text = "Tiempo restante:";
            // 
            // FormConfirmacióndeClave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 226);
            Controls.Add(lblTemporizador);
            Controls.Add(ibtnReenviarClave);
            Controls.Add(txtClave);
            Controls.Add(label1);
            Controls.Add(lblClave);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(ibtnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfirmacióndeClave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfirmacióndeClave";
            FormClosed += FormConfirmacióndeClave_FormClosed;
            Load += FormConfirmacióndeClave_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAceptar;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private TextBox txtClave;
        private Label lblClave;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnReenviarClave;
        private ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private Label lblTemporizador;
    }
}