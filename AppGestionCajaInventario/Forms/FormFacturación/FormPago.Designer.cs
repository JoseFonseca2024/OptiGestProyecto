namespace AppGestionCajaInventario.Forms.FormFacturación
{
    partial class FormPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPago));
            panel1 = new Panel();
            btn200Cor = new Button();
            btn1000Cor = new Button();
            btn500Cor = new Button();
            btn20Cor = new Button();
            btn10cor = new Button();
            btn100Cor = new Button();
            btnAceptar = new Button();
            txtPago = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btn200Cor);
            panel1.Controls.Add(btn1000Cor);
            panel1.Controls.Add(btn500Cor);
            panel1.Controls.Add(btn20Cor);
            panel1.Controls.Add(btn10cor);
            panel1.Controls.Add(btn100Cor);
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(txtPago);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 350);
            panel1.TabIndex = 0;
            // 
            // btn200Cor
            // 
            btn200Cor.Image = (Image)resources.GetObject("btn200Cor.Image");
            btn200Cor.Location = new Point(206, 161);
            btn200Cor.Name = "btn200Cor";
            btn200Cor.Size = new Size(171, 78);
            btn200Cor.TabIndex = 3;
            btn200Cor.UseVisualStyleBackColor = true;
            // 
            // btn1000Cor
            // 
            btn1000Cor.Image = (Image)resources.GetObject("btn1000Cor.Image");
            btn1000Cor.Location = new Point(206, 245);
            btn1000Cor.Name = "btn1000Cor";
            btn1000Cor.Size = new Size(171, 78);
            btn1000Cor.TabIndex = 3;
            btn1000Cor.UseVisualStyleBackColor = true;
            // 
            // btn500Cor
            // 
            btn500Cor.Image = (Image)resources.GetObject("btn500Cor.Image");
            btn500Cor.Location = new Point(28, 245);
            btn500Cor.Name = "btn500Cor";
            btn500Cor.Size = new Size(171, 78);
            btn500Cor.TabIndex = 3;
            btn500Cor.UseVisualStyleBackColor = true;
            // 
            // btn20Cor
            // 
            btn20Cor.Image = (Image)resources.GetObject("btn20Cor.Image");
            btn20Cor.Location = new Point(206, 77);
            btn20Cor.Name = "btn20Cor";
            btn20Cor.Size = new Size(171, 78);
            btn20Cor.TabIndex = 3;
            btn20Cor.UseVisualStyleBackColor = true;
            // 
            // btn10cor
            // 
            btn10cor.Image = (Image)resources.GetObject("btn10cor.Image");
            btn10cor.Location = new Point(28, 77);
            btn10cor.Name = "btn10cor";
            btn10cor.Size = new Size(171, 78);
            btn10cor.TabIndex = 3;
            btn10cor.UseVisualStyleBackColor = true;
            // 
            // btn100Cor
            // 
            btn100Cor.Image = Properties.Resources.billete100cordobas__1_;
            btn100Cor.Location = new Point(28, 161);
            btn100Cor.Name = "btn100Cor";
            btn100Cor.Size = new Size(171, 78);
            btn100Cor.TabIndex = 3;
            btn100Cor.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(302, 27);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(148, 27);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(144, 23);
            txtPago.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Paga con:";
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(491, 390);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn100Cor;
        private Button btnAceptar;
        private TextBox txtPago;
        private Button btn200Cor;
        private Button btn1000Cor;
        private Button btn500Cor;
        private Button btn20Cor;
        private Button btn10cor;
    }
}