namespace AppGestionCajaInventario.Forms.FormReportes
{
    partial class FormReportedeVentas
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
            dgvVentas = new DataGridView();
            lblTitulo = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ibtnGenerar = new FontAwesome.Sharp.IconButton();
            ibtnExportar = new FontAwesome.Sharp.IconButton();
            formsPlot1 = new ScottPlot.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(12, 12);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.Size = new Size(530, 416);
            dgvVentas.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(698, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(194, 26);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Reporte de Ventas:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(682, 347);
            label1.Name = "label1";
            label1.Size = new Size(44, 19);
            label1.TabIndex = 3;
            label1.Text = "Año:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(732, 344);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(169, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // ibtnGenerar
            // 
            ibtnGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ibtnGenerar.BackColor = Color.Tan;
            ibtnGenerar.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            ibtnGenerar.IconColor = Color.Black;
            ibtnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGenerar.IconSize = 25;
            ibtnGenerar.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnGenerar.Location = new Point(682, 373);
            ibtnGenerar.Name = "ibtnGenerar";
            ibtnGenerar.Size = new Size(219, 28);
            ibtnGenerar.TabIndex = 5;
            ibtnGenerar.Text = "Generar Reporte";
            ibtnGenerar.UseVisualStyleBackColor = false;
            ibtnGenerar.Click += ibtnGenerar_Click;
            // 
            // ibtnExportar
            // 
            ibtnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ibtnExportar.BackColor = Color.MediumSeaGreen;
            ibtnExportar.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            ibtnExportar.IconColor = Color.Black;
            ibtnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnExportar.IconSize = 25;
            ibtnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnExportar.Location = new Point(682, 407);
            ibtnExportar.Name = "ibtnExportar";
            ibtnExportar.Size = new Size(219, 28);
            ibtnExportar.TabIndex = 5;
            ibtnExportar.Text = "Exportar reporte";
            ibtnExportar.UseVisualStyleBackColor = false;
            ibtnExportar.Click += ibtnExportar_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            formsPlot1.Location = new Point(549, 38);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(403, 297);
            formsPlot1.TabIndex = 6;
            // 
            // FormReportedeVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(952, 455);
            Controls.Add(formsPlot1);
            Controls.Add(ibtnExportar);
            Controls.Add(ibtnGenerar);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(dgvVentas);
            Name = "FormReportedeVentas";
            Text = "FormReportedeVentas";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Label lblTitulo;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton ibtnGenerar;
        private FontAwesome.Sharp.IconButton ibtnExportar;
        private ScottPlot.FormsPlot formsPlot1;
    }
}