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
            label1 = new Label();
            dgvPacientes = new DataGridView();
            btnAgregarP = new Button();
            btnEditarP = new Button();
            pnlTitulo = new Panel();
            groupBox1 = new GroupBox();
            txtCorreo = new TextBox();
            label9 = new Label();
            txtPacienteID = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            pnlTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(290, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de Paciente";
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(113, 458);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(1245, 290);
            dgvPacientes.TabIndex = 13;
            dgvPacientes.CellClick += dgvPacientes_CellClick;
            // 
            // btnAgregarP
            // 
            btnAgregarP.BackColor = Color.DarkGreen;
            btnAgregarP.Font = new Font("Segoe UI", 15F);
            btnAgregarP.Location = new Point(556, 382);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(203, 61);
            btnAgregarP.TabIndex = 14;
            btnAgregarP.Text = "AGREGAR";
            btnAgregarP.UseVisualStyleBackColor = false;
            btnAgregarP.Click += btnAgregarP_Click;
            // 
            // btnEditarP
            // 
            btnEditarP.BackColor = Color.DodgerBlue;
            btnEditarP.Font = new Font("Segoe UI", 15F);
            btnEditarP.Location = new Point(786, 382);
            btnEditarP.Name = "btnEditarP";
            btnEditarP.Size = new Size(203, 61);
            btnEditarP.TabIndex = 15;
            btnEditarP.Text = "EDITAR";
            btnEditarP.UseVisualStyleBackColor = false;
            btnEditarP.Click += btnEditarP_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(33, 22);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(333, 57);
            pnlTitulo.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPacienteID);
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
            groupBox1.Controls.Add(txtNombreP);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(38, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1320, 282);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(151, 228);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(236, 29);
            txtCorreo.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F);
            label9.Location = new Point(54, 233);
            label9.Name = "label9";
            label9.Size = new Size(61, 18);
            label9.TabIndex = 28;
            label9.Text = "Correo";
            // 
            // txtPacienteID
            // 
            txtPacienteID.Location = new Point(151, 28);
            txtPacienteID.Name = "txtPacienteID";
            txtPacienteID.Size = new Size(100, 29);
            txtPacienteID.TabIndex = 26;
            txtPacienteID.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1117, 78);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(189, 21);
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
            label7.Font = new Font("Verdana", 12F);
            label7.Location = new Point(834, 163);
            label7.Name = "label7";
            label7.Size = new Size(89, 18);
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
            label6.Font = new Font("Verdana", 12F);
            label6.Location = new Point(837, 80);
            label6.Name = "label6";
            label6.Size = new Size(99, 18);
            label6.TabIndex = 21;
            label6.Text = "Ocupacion:";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(577, 158);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(236, 29);
            txtCelular.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(407, 163);
            label5.Name = "label5";
            label5.Size = new Size(148, 18);
            label5.TabIndex = 19;
            label5.Text = "Celular/Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(393, 77);
            label4.Name = "label4";
            label4.Size = new Size(186, 18);
            label4.TabIndex = 18;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(585, 77);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(236, 29);
            dtpFechaNacimiento.TabIndex = 17;
            // 
            // txtApellidoP
            // 
            txtApellidoP.Location = new Point(151, 158);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(236, 29);
            txtApellidoP.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(54, 163);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 15;
            label3.Text = "Apellido:";
            // 
            // txtNombreP
            // 
            txtNombreP.Location = new Point(151, 77);
            txtNombreP.Name = "txtNombreP";
            txtNombreP.Size = new Size(236, 29);
            txtNombreP.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(54, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 769);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(btnEditarP);
            Controls.Add(btnAgregarP);
            Controls.Add(dgvPacientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPaciente";
            Text = "frmPaciente";
            Load += frmPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvPacientes;
        private Button btnAgregarP;
        private Button btnEditarP;
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
        private TextBox txtPacienteID;
        private Label label9;
        private TextBox txtCorreo;
    }
}