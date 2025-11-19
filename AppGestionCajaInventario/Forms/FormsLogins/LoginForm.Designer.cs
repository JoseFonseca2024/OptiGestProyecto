namespace AppGestionCajaInventario.Forms.FormsLogins
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            ibtnIngresar = new FontAwesome.Sharp.IconButton();
            ibtnCancelar = new FontAwesome.Sharp.IconButton();
            linklblCrearUsuario = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 269);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OptiGestLogo;
            pictureBox1.Location = new Point(12, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 32);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 99);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 1;
            label2.Text = "Clave:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(270, 54);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(316, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(270, 123);
            txtClave.Margin = new Padding(4, 3, 4, 3);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(316, 23);
            txtClave.TabIndex = 2;
            txtClave.UseSystemPasswordChar = true;
            // 
            // ibtnIngresar
            // 
            ibtnIngresar.BackColor = Color.CornflowerBlue;
            ibtnIngresar.Cursor = Cursors.Hand;
            ibtnIngresar.FlatAppearance.BorderColor = Color.LightGray;
            ibtnIngresar.FlatAppearance.BorderSize = 2;
            ibtnIngresar.FlatStyle = FlatStyle.Flat;
            ibtnIngresar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnIngresar.ForeColor = SystemColors.ButtonHighlight;
            ibtnIngresar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            ibtnIngresar.IconColor = Color.White;
            ibtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnIngresar.IconSize = 35;
            ibtnIngresar.Location = new Point(301, 166);
            ibtnIngresar.Margin = new Padding(4, 3, 4, 3);
            ibtnIngresar.Name = "ibtnIngresar";
            ibtnIngresar.Size = new Size(121, 47);
            ibtnIngresar.TabIndex = 3;
            ibtnIngresar.Text = "Ingresar";
            ibtnIngresar.TextAlign = ContentAlignment.MiddleRight;
            ibtnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnIngresar.UseVisualStyleBackColor = false;
            ibtnIngresar.Click += ibtnIngresar_Click;
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
            ibtnCancelar.IconSize = 35;
            ibtnCancelar.Location = new Point(448, 166);
            ibtnCancelar.Margin = new Padding(4, 3, 4, 3);
            ibtnCancelar.Name = "ibtnCancelar";
            ibtnCancelar.Size = new Size(127, 47);
            ibtnCancelar.TabIndex = 4;
            ibtnCancelar.Text = "Cancelar";
            ibtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            ibtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnCancelar.UseVisualStyleBackColor = false;
            ibtnCancelar.Click += ibtnCancelar_Click;
            // 
            // linklblCrearUsuario
            // 
            linklblCrearUsuario.AutoSize = true;
            linklblCrearUsuario.Location = new Point(318, 228);
            linklblCrearUsuario.Margin = new Padding(4, 0, 4, 0);
            linklblCrearUsuario.Name = "linklblCrearUsuario";
            linklblCrearUsuario.Size = new Size(234, 15);
            linklblCrearUsuario.TabIndex = 5;
            linklblCrearUsuario.TabStop = true;
            linklblCrearUsuario.Text = "¿No se ha registrado? Cree un nuevo usario";
            linklblCrearUsuario.LinkClicked += linklblCrearUsuario_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 269);
            Controls.Add(linklblCrearUsuario);
            Controls.Add(ibtnCancelar);
            Controls.Add(ibtnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private FontAwesome.Sharp.IconButton ibtnIngresar;
        private FontAwesome.Sharp.IconButton ibtnCancelar;
        private LinkLabel linklblCrearUsuario;
    }
}