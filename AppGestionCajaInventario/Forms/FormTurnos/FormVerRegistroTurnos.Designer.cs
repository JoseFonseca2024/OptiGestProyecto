using System.Windows.Forms;

namespace AppGestionCajaInventario.Forms.FormTurnos
{
    partial class FormVerRegistroTurnos
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
            lblFondo = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            ibtnBuscarporFecha = new FontAwesome.Sharp.IconButton();
            ibtnBuscar = new FontAwesome.Sharp.IconButton();
            txtNombreUsuario = new TextBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox2 = new ComboBox();
            btnAplicar = new Button();
            rdbActivo = new RadioButton();
            rdbCerrado = new RadioButton();
            rdbGeneral = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblFondo
            // 
            lblFondo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFondo.BackColor = Color.WhiteSmoke;
            lblFondo.Font = new Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFondo.Location = new Point(136, 9);
            lblFondo.Margin = new Padding(4, 0, 4, 0);
            lblFondo.Name = "lblFondo";
            lblFondo.Size = new Size(678, 168);
            lblFondo.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ibtnBuscarporFecha);
            groupBox1.Controls.Add(ibtnBuscar);
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(152, 35);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(649, 71);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Por:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(358, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(358, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 16;
            label3.Text = "Busqueda por Fecha:";
            // 
            // ibtnBuscarporFecha
            // 
            ibtnBuscarporFecha.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnBuscarporFecha.IconColor = Color.Black;
            ibtnBuscarporFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBuscarporFecha.IconSize = 16;
            ibtnBuscarporFecha.Location = new Point(607, 29);
            ibtnBuscarporFecha.Name = "ibtnBuscarporFecha";
            ibtnBuscarporFecha.Size = new Size(22, 23);
            ibtnBuscarporFecha.TabIndex = 17;
            ibtnBuscarporFecha.UseVisualStyleBackColor = true;
            // 
            // ibtnBuscar
            // 
            ibtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            ibtnBuscar.IconColor = Color.Black;
            ibtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBuscar.IconSize = 16;
            ibtnBuscar.Location = new Point(302, 25);
            ibtnBuscar.Name = "ibtnBuscar";
            ibtnBuscar.Size = new Size(22, 23);
            ibtnBuscar.TabIndex = 17;
            ibtnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(132, 25);
            txtNombreUsuario.Margin = new Padding(4, 3, 4, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(163, 23);
            txtNombreUsuario.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Caja", "Usuario Operador" });
            comboBox1.Location = new Point(13, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(112, 23);
            comboBox1.TabIndex = 19;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(btnAplicar);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Location = new Point(186, 112);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(290, 53);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenar por:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(rdbGeneral);
            groupBox3.Controls.Add(rdbCerrado);
            groupBox3.Controls.Add(rdbActivo);
            groupBox3.Location = new Point(491, 112);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(290, 53);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Estado:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(889, 277);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("League Spartan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 27;
            label1.Text = "HISTORIAL DE TURNOS";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mas reciente", "Mas antiguo", "Mayor Monto Incial", "Menor Monto Inicial", "Mayor Monto Final", "Menor Monto Final", "Ninguno" });
            comboBox2.Location = new Point(7, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(154, 23);
            comboBox2.TabIndex = 28;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(171, 20);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(103, 22);
            btnAplicar.TabIndex = 29;
            btnAplicar.Text = "Aplicar Orden";
            btnAplicar.UseVisualStyleBackColor = true;
            // 
            // rdbGeneral
            // 
            rdbGeneral.AutoSize = true;
            rdbGeneral.Location = new Point(209, 21);
            rdbGeneral.Name = "rdbGeneral";
            rdbGeneral.Size = new Size(65, 19);
            rdbGeneral.TabIndex = 0;
            rdbGeneral.TabStop = true;
            rdbGeneral.Text = "General";
            rdbGeneral.UseVisualStyleBackColor = true;
            // 
            // rdbCerrado
            // 
            rdbCerrado.AutoSize = true;
            rdbCerrado.Location = new Point(101, 23);
            rdbCerrado.Name = "rdbCerrado";
            rdbCerrado.Size = new Size(67, 19);
            rdbCerrado.TabIndex = 0;
            rdbCerrado.TabStop = true;
            rdbCerrado.Text = "Cerrado";
            rdbCerrado.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            rdbActivo.AutoSize = true;
            rdbActivo.Location = new Point(7, 24);
            rdbActivo.Name = "rdbActivo";
            rdbActivo.Size = new Size(59, 19);
            rdbActivo.TabIndex = 0;
            rdbActivo.TabStop = true;
            rdbActivo.Text = "Activo";
            rdbActivo.UseVisualStyleBackColor = true;
            // 
            // FormVerRegistroTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(933, 479);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblFondo);
            Name = "FormVerRegistroTurnos";
            Text = "FormVerRegistroTurnos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFondo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnBuscar;
        private TextBox txtNombreUsuario;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private FontAwesome.Sharp.IconButton ibtnBuscarporFecha;
        private Button btnAplicar;
        private ComboBox comboBox2;
        private RadioButton rdbGeneral;
        private RadioButton rdbCerrado;
        private RadioButton rdbActivo;
    }
}