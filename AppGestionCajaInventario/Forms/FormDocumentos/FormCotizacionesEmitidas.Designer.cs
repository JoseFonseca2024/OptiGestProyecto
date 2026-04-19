namespace AppGestionCajaInventario.Forms.FormDocumentos
{
    partial class FormCotizacionesEmitidas
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
            ibtnBusquedaGeneral = new FontAwesome.Sharp.IconButton();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            ibtnBuscarPorFecha = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            ibtnConsultaClientes = new FontAwesome.Sharp.IconButton();
            ibtnBuscarPorCliente = new FontAwesome.Sharp.IconButton();
            txtCliente = new TextBox();
            label1 = new Label();
            dgvCotizaciones = new DataGridView();
            ibtnVistaPrevia = new FontAwesome.Sharp.IconButton();
            ibtnImprimir = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCotizaciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(ibtnBusquedaGeneral);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(102, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 176);
            panel1.TabIndex = 27;
            // 
            // ibtnBusquedaGeneral
            // 
            ibtnBusquedaGeneral.BackColor = Color.DodgerBlue;
            ibtnBusquedaGeneral.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnBusquedaGeneral.ForeColor = Color.White;
            ibtnBusquedaGeneral.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnBusquedaGeneral.IconColor = Color.White;
            ibtnBusquedaGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBusquedaGeneral.IconSize = 25;
            ibtnBusquedaGeneral.Location = new Point(280, 125);
            ibtnBusquedaGeneral.Name = "ibtnBusquedaGeneral";
            ibtnBusquedaGeneral.Size = new Size(186, 37);
            ibtnBusquedaGeneral.TabIndex = 17;
            ibtnBusquedaGeneral.Text = "Aplicar Busqueda";
            ibtnBusquedaGeneral.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnBusquedaGeneral.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(ibtnBuscarPorFecha);
            groupBox2.Location = new Point(539, 51);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(181, 65);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar por Fecha de Emisión:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(14, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(116, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // ibtnBuscarPorFecha
            // 
            ibtnBuscarPorFecha.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnBuscarPorFecha.IconColor = Color.Black;
            ibtnBuscarPorFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBuscarPorFecha.IconSize = 16;
            ibtnBuscarPorFecha.Location = new Point(136, 27);
            ibtnBuscarPorFecha.Name = "ibtnBuscarPorFecha";
            ibtnBuscarPorFecha.Size = new Size(22, 23);
            ibtnBuscarPorFecha.TabIndex = 17;
            ibtnBuscarPorFecha.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(ibtnConsultaClientes);
            groupBox1.Controls.Add(ibtnBuscarPorCliente);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Location = new Point(18, 51);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(513, 65);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Por Cliente:";
            // 
            // ibtnConsultaClientes
            // 
            ibtnConsultaClientes.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            ibtnConsultaClientes.IconColor = Color.Black;
            ibtnConsultaClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnConsultaClientes.IconSize = 20;
            ibtnConsultaClientes.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnConsultaClientes.Location = new Point(344, 22);
            ibtnConsultaClientes.Name = "ibtnConsultaClientes";
            ibtnConsultaClientes.Size = new Size(153, 23);
            ibtnConsultaClientes.TabIndex = 17;
            ibtnConsultaClientes.Text = "Consultar Registros";
            ibtnConsultaClientes.UseVisualStyleBackColor = true;
            ibtnConsultaClientes.Click += ibtnConsultaClientes_Click;
            // 
            // ibtnBuscarPorCliente
            // 
            ibtnBuscarPorCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnBuscarPorCliente.IconColor = Color.Black;
            ibtnBuscarPorCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBuscarPorCliente.IconSize = 16;
            ibtnBuscarPorCliente.Location = new Point(316, 22);
            ibtnBuscarPorCliente.Name = "ibtnBuscarPorCliente";
            ibtnBuscarPorCliente.Size = new Size(22, 23);
            ibtnBuscarPorCliente.TabIndex = 17;
            ibtnBuscarPorCliente.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(14, 22);
            txtCliente.Margin = new Padding(4, 3, 4, 3);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(295, 23);
            txtCliente.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 28;
            label1.Text = "COTIZACIONES EMITIDAS";
            // 
            // dgvCotizaciones
            // 
            dgvCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCotizaciones.Location = new Point(102, 214);
            dgvCotizaciones.Name = "dgvCotizaciones";
            dgvCotizaciones.Size = new Size(616, 309);
            dgvCotizaciones.TabIndex = 28;
            // 
            // ibtnVistaPrevia
            // 
            ibtnVistaPrevia.BackColor = Color.SeaGreen;
            ibtnVistaPrevia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnVistaPrevia.ForeColor = Color.White;
            ibtnVistaPrevia.IconChar = FontAwesome.Sharp.IconChar.File;
            ibtnVistaPrevia.IconColor = Color.White;
            ibtnVistaPrevia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnVistaPrevia.IconSize = 25;
            ibtnVistaPrevia.Location = new Point(724, 439);
            ibtnVistaPrevia.Name = "ibtnVistaPrevia";
            ibtnVistaPrevia.Size = new Size(186, 37);
            ibtnVistaPrevia.TabIndex = 17;
            ibtnVistaPrevia.Text = "Vsita Previa";
            ibtnVistaPrevia.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnVistaPrevia.UseVisualStyleBackColor = false;
            // 
            // ibtnImprimir
            // 
            ibtnImprimir.BackColor = Color.SeaGreen;
            ibtnImprimir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnImprimir.ForeColor = Color.White;
            ibtnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            ibtnImprimir.IconColor = Color.White;
            ibtnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnImprimir.IconSize = 25;
            ibtnImprimir.Location = new Point(724, 482);
            ibtnImprimir.Name = "ibtnImprimir";
            ibtnImprimir.Size = new Size(186, 37);
            ibtnImprimir.TabIndex = 17;
            ibtnImprimir.Text = "Imprimir";
            ibtnImprimir.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnImprimir.UseVisualStyleBackColor = false;
            // 
            // FormCotizacionesEmitidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(933, 548);
            Controls.Add(ibtnImprimir);
            Controls.Add(ibtnVistaPrevia);
            Controls.Add(dgvCotizaciones);
            Controls.Add(panel1);
            Name = "FormCotizacionesEmitidas";
            Text = "FormCotizacionesEmitidas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCotizaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton ibtnConsultaClientes;
        private FontAwesome.Sharp.IconButton ibtnBuscarPorCliente;
        private TextBox txtCliente;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton ibtnBuscarPorFecha;
        private FontAwesome.Sharp.IconButton ibtnBusquedaGeneral;
        private DataGridView dgvCotizaciones;
        private FontAwesome.Sharp.IconButton ibtnVistaPrevia;
        private FontAwesome.Sharp.IconButton ibtnImprimir;
    }
}