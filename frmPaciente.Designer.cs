namespace ClinicaBD
{
    partial class frmPaciente
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            pnlTitulo = new Panel();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            txtDireccion = new TextBox();
            label7 = new Label();
            cmbOcupacion = new ComboBox();
            label6 = new Label();
            txtCelular = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtApellidoP = new TextBox();
            label3 = new Label();
            txtNombreP = new TextBox();
            label2 = new Label();
            dgvPacientes = new DataGridView();
            label8 = new Label();
            txtCorreo = new TextBox();
            txtPacienteID = new TextBox();
            pnlTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 10);
            label1.Name = "label1";
            label1.Size = new Size(274, 36);
            label1.TabIndex = 0;
            label1.Text = "Registro de Paciente";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Times New Roman", 15.75F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(379, 361);
            button1.Name = "button1";
            button1.Size = new Size(203, 61);
            button1.TabIndex = 14;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Times New Roman", 15.75F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(797, 361);
            button2.Name = "button2";
            button2.Size = new Size(203, 61);
            button2.TabIndex = 15;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.None;
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(333, 57);
            pnlTitulo.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbOcupacion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCelular);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(txtApellidoP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPacienteID);
            groupBox1.Controls.Add(txtNombreP);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1306, 248);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(1133, 82);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(165, 19);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Agregar mas ocupaciones";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(929, 129);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(323, 109);
            txtDireccion.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F);
            label7.Location = new Point(834, 163);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 23;
            label7.Text = "Direccion:";
            // 
            // cmbOcupacion
            // 
            cmbOcupacion.FormattingEnabled = true;
            cmbOcupacion.Location = new Point(940, 77);
            cmbOcupacion.Name = "cmbOcupacion";
            cmbOcupacion.Size = new Size(163, 29);
            cmbOcupacion.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F);
            label6.Location = new Point(837, 80);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 21;
            label6.Text = "Ocupacion:";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(564, 163);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(236, 29);
            txtCelular.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F);
            label5.Location = new Point(394, 168);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 19;
            label5.Text = "Celular/Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(372, 111);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 18;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(564, 111);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(236, 29);
            dtpFechaNacimiento.TabIndex = 17;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(130, 163);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(236, 29);
            txtApellidoP.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(33, 168);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 15;
            label3.Text = "Apellido:";
            // 
            // txtNombreP
            // 
            txtNombreP.Location = new Point(130, 111);
            txtNombreP.Name = "txtNombreP";
            txtNombreP.Size = new Size(236, 29);
            txtNombreP.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(33, 116);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // dgvPacientes
            // 
            dgvPacientes.Anchor = AnchorStyles.None;
            dgvPacientes.BackgroundColor = SystemColors.Control;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.Location = new Point(45, 479);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPacientes.Size = new Size(1299, 267);
            dgvPacientes.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F);
            label8.Location = new Point(467, 60);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 13;
            label8.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(564, 55);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(236, 29);
            txtCorreo.TabIndex = 14;
            // 
            // txtPacienteID
            // 
            txtPacienteID.Location = new Point(295, 60);
            txtPacienteID.Name = "txtPacienteID";
            txtPacienteID.Size = new Size(71, 29);
            txtPacienteID.TabIndex = 14;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 769);
            Controls.Add(dgvPacientes);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPaciente";
            Text = "frmPaciente";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel pnlTitulo;
        private GroupBox groupBox1;
        private TextBox txtDireccion;
        private Label label7;
        private ComboBox cmbOcupacion;
        private Label label6;
        private TextBox txtCelular;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtApellidoP;
        private Label label3;
        private TextBox txtNombreP;
        private Label label2;
        private LinkLabel linkLabel1;
        private DataGridView dgvPacientes;
        private TextBox txtCorreo;
        private Label label8;
        private TextBox txtPacienteID;
    }
}