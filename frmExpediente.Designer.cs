namespace ClinicaBD
{
    partial class frmExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpediente));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTitulo = new Panel();
            label1 = new Label();
            btnEditar = new Button();
            btnAgregar = new Button();
            groupBox1 = new GroupBox();
            cmbBiotipoCutaneo = new ComboBox();
            groupBox2 = new GroupBox();
            checkBoxNinguno = new CheckBox();
            checkBoxProtectorSolar = new CheckBox();
            checkBoxTonico = new CheckBox();
            checkBoxAceites = new CheckBox();
            checkBoxSerum = new CheckBox();
            checkBoxCremas = new CheckBox();
            checkBoxJabonFacial = new CheckBox();
            groupBox3 = new GroupBox();
            label8 = new Label();
            txtVasosAgua = new TextBox();
            txtTrasnoche = new TextBox();
            label7 = new Label();
            txtConsumoMedicamento = new TextBox();
            txtConsumoCafe = new TextBox();
            label6 = new Label();
            txtConsumoTabaco = new TextBox();
            txtConsumoSuplementos = new TextBox();
            label5 = new Label();
            txtConsumoLicor = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtHistorialMedico = new TextBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            radioButtonNo = new RadioButton();
            radioButtonSi = new RadioButton();
            dgvExpediente = new DataGridView();
            linkLabel1 = new LinkLabel();
            txtNombrePaciente = new TextBox();
            txtApellidoPaciente = new TextBox();
            label10 = new Label();
            label11 = new Label();
            groupBox5 = new GroupBox();
            label12 = new Label();
            label13 = new Label();
            txtPacienteID = new TextBox();
            txtExpedienteID = new TextBox();
            pnlTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpediente).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.None;
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(333, 57);
            pnlTitulo.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 11);
            label1.Name = "label1";
            label1.Size = new Size(280, 33);
            label1.TabIndex = 0;
            label1.Text = "Registro de Expediente";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.Font = new Font("Times New Roman", 15F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(1137, 386);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(203, 61);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.Font = new Font("Times New Roman", 15F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(928, 386);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(203, 61);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(cmbBiotipoCutaneo);
            groupBox1.Font = new Font("Times New Roman", 11.25F);
            groupBox1.Location = new Point(588, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 95);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "BIOTIPO CUTANEO";
            // 
            // cmbBiotipoCutaneo
            // 
            cmbBiotipoCutaneo.FormattingEnabled = true;
            cmbBiotipoCutaneo.Location = new Point(94, 32);
            cmbBiotipoCutaneo.Name = "cmbBiotipoCutaneo";
            cmbBiotipoCutaneo.Size = new Size(204, 25);
            cmbBiotipoCutaneo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(checkBoxNinguno);
            groupBox2.Controls.Add(checkBoxProtectorSolar);
            groupBox2.Controls.Add(checkBoxTonico);
            groupBox2.Controls.Add(checkBoxAceites);
            groupBox2.Controls.Add(checkBoxSerum);
            groupBox2.Controls.Add(checkBoxCremas);
            groupBox2.Controls.Add(checkBoxJabonFacial);
            groupBox2.Font = new Font("Times New Roman", 11.25F);
            groupBox2.Location = new Point(967, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 192);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "CUIDADOS DE PIEL";
            // 
            // checkBoxNinguno
            // 
            checkBoxNinguno.AutoSize = true;
            checkBoxNinguno.Location = new Point(207, 93);
            checkBoxNinguno.Name = "checkBoxNinguno";
            checkBoxNinguno.Size = new Size(76, 21);
            checkBoxNinguno.TabIndex = 32;
            checkBoxNinguno.Text = "Ninguno";
            checkBoxNinguno.UseVisualStyleBackColor = true;
            // 
            // checkBoxProtectorSolar
            // 
            checkBoxProtectorSolar.AutoSize = true;
            checkBoxProtectorSolar.Location = new Point(207, 66);
            checkBoxProtectorSolar.Name = "checkBoxProtectorSolar";
            checkBoxProtectorSolar.Size = new Size(116, 21);
            checkBoxProtectorSolar.TabIndex = 32;
            checkBoxProtectorSolar.Text = "Protector Solar";
            checkBoxProtectorSolar.UseVisualStyleBackColor = true;
            // 
            // checkBoxTonico
            // 
            checkBoxTonico.AutoSize = true;
            checkBoxTonico.Location = new Point(207, 39);
            checkBoxTonico.Name = "checkBoxTonico";
            checkBoxTonico.Size = new Size(66, 21);
            checkBoxTonico.TabIndex = 32;
            checkBoxTonico.Text = "Tonico";
            checkBoxTonico.UseVisualStyleBackColor = true;
            // 
            // checkBoxAceites
            // 
            checkBoxAceites.AutoSize = true;
            checkBoxAceites.Location = new Point(25, 120);
            checkBoxAceites.Name = "checkBoxAceites";
            checkBoxAceites.Size = new Size(72, 21);
            checkBoxAceites.TabIndex = 32;
            checkBoxAceites.Text = "Aceites";
            checkBoxAceites.UseVisualStyleBackColor = true;
            // 
            // checkBoxSerum
            // 
            checkBoxSerum.AutoSize = true;
            checkBoxSerum.Location = new Point(25, 93);
            checkBoxSerum.Name = "checkBoxSerum";
            checkBoxSerum.Size = new Size(65, 21);
            checkBoxSerum.TabIndex = 32;
            checkBoxSerum.Text = "Serum";
            checkBoxSerum.UseVisualStyleBackColor = true;
            // 
            // checkBoxCremas
            // 
            checkBoxCremas.AutoSize = true;
            checkBoxCremas.Location = new Point(25, 66);
            checkBoxCremas.Name = "checkBoxCremas";
            checkBoxCremas.Size = new Size(73, 21);
            checkBoxCremas.TabIndex = 32;
            checkBoxCremas.Text = "Cremas";
            checkBoxCremas.UseVisualStyleBackColor = true;
            // 
            // checkBoxJabonFacial
            // 
            checkBoxJabonFacial.AutoSize = true;
            checkBoxJabonFacial.Location = new Point(25, 39);
            checkBoxJabonFacial.Name = "checkBoxJabonFacial";
            checkBoxJabonFacial.Size = new Size(100, 21);
            checkBoxJabonFacial.TabIndex = 32;
            checkBoxJabonFacial.Text = "Jabón Facial";
            checkBoxJabonFacial.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtVasosAgua);
            groupBox3.Controls.Add(txtTrasnoche);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtConsumoMedicamento);
            groupBox3.Controls.Add(txtConsumoCafe);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtConsumoTabaco);
            groupBox3.Controls.Add(txtConsumoSuplementos);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtConsumoLicor);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Times New Roman", 11.25F);
            groupBox3.Location = new Point(12, 120);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(949, 192);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "HABITOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(697, 91);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 60;
            label8.Text = "Consumo Licor";
            // 
            // txtVasosAgua
            // 
            txtVasosAgua.Location = new Point(173, 31);
            txtVasosAgua.Name = "txtVasosAgua";
            txtVasosAgua.Size = new Size(177, 25);
            txtVasosAgua.TabIndex = 47;
            // 
            // txtTrasnoche
            // 
            txtTrasnoche.Location = new Point(511, 31);
            txtTrasnoche.Name = "txtTrasnoche";
            txtTrasnoche.Size = new Size(177, 25);
            txtTrasnoche.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 147);
            label7.Name = "label7";
            label7.Size = new Size(141, 17);
            label7.TabIndex = 59;
            label7.Text = "Consumo Suplementos";
            // 
            // txtConsumoMedicamento
            // 
            txtConsumoMedicamento.Location = new Point(173, 143);
            txtConsumoMedicamento.Name = "txtConsumoMedicamento";
            txtConsumoMedicamento.Size = new Size(177, 25);
            txtConsumoMedicamento.TabIndex = 49;
            // 
            // txtConsumoCafe
            // 
            txtConsumoCafe.Location = new Point(510, 87);
            txtConsumoCafe.Name = "txtConsumoCafe";
            txtConsumoCafe.Size = new Size(177, 25);
            txtConsumoCafe.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 90);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 58;
            label6.Text = "Consumo Cafe";
            // 
            // txtConsumoTabaco
            // 
            txtConsumoTabaco.Location = new Point(173, 87);
            txtConsumoTabaco.Name = "txtConsumoTabaco";
            txtConsumoTabaco.Size = new Size(177, 25);
            txtConsumoTabaco.TabIndex = 48;
            // 
            // txtConsumoSuplementos
            // 
            txtConsumoSuplementos.Location = new Point(511, 143);
            txtConsumoSuplementos.Name = "txtConsumoSuplementos";
            txtConsumoSuplementos.Size = new Size(177, 25);
            txtConsumoSuplementos.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 34);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 57;
            label5.Text = "Trasnoche";
            // 
            // txtConsumoLicor
            // 
            txtConsumoLicor.Location = new Point(794, 87);
            txtConsumoLicor.Name = "txtConsumoLicor";
            txtConsumoLicor.Size = new Size(137, 25);
            txtConsumoLicor.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 34);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 54;
            label2.Text = "Vasos de agua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 91);
            label4.Name = "label4";
            label4.Size = new Size(110, 17);
            label4.TabIndex = 56;
            label4.Text = "Consumo Tabaco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 146);
            label3.Name = "label3";
            label3.Size = new Size(147, 17);
            label3.TabIndex = 55;
            label3.Text = "Consumo Medicamento";
            // 
            // txtHistorialMedico
            // 
            txtHistorialMedico.Anchor = AnchorStyles.None;
            txtHistorialMedico.Font = new Font("Times New Roman", 11.25F);
            txtHistorialMedico.Location = new Point(588, 318);
            txtHistorialMedico.Multiline = true;
            txtHistorialMedico.Name = "txtHistorialMedico";
            txtHistorialMedico.Size = new Size(332, 122);
            txtHistorialMedico.TabIndex = 61;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(477, 319);
            label9.Name = "label9";
            label9.Size = new Size(105, 19);
            label9.TabIndex = 61;
            label9.Text = "Historial Clinico";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.Controls.Add(radioButtonNo);
            groupBox4.Controls.Add(radioButtonSi);
            groupBox4.Font = new Font("Times New Roman", 11.25F);
            groupBox4.Location = new Point(967, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(373, 95);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            groupBox4.Text = "USO DE MARCAPASOS";
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Location = new Point(207, 45);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(44, 21);
            radioButtonNo.TabIndex = 28;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "No";
            radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSi
            // 
            radioButtonSi.AutoSize = true;
            radioButtonSi.Location = new Point(77, 45);
            radioButtonSi.Name = "radioButtonSi";
            radioButtonSi.Size = new Size(37, 21);
            radioButtonSi.TabIndex = 25;
            radioButtonSi.TabStop = true;
            radioButtonSi.Text = "Si";
            radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // dgvExpediente
            // 
            dgvExpediente.Anchor = AnchorStyles.None;
            dgvExpediente.BackgroundColor = SystemColors.Control;
            dgvExpediente.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExpediente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExpediente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpediente.EnableHeadersVisualStyles = false;
            dgvExpediente.Location = new Point(0, 492);
            dgvExpediente.Name = "dgvExpediente";
            dgvExpediente.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvExpediente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvExpediente.Size = new Size(1386, 238);
            dgvExpediente.TabIndex = 62;
            dgvExpediente.CellClick += dgvExpediente_CellClick;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Left;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(176, 458);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(295, 19);
            linkLabel1.TabIndex = 63;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Seleccione al paciente para llenar su expediente";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(112, 24);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(177, 25);
            txtNombrePaciente.TabIndex = 61;
            // 
            // txtApellidoPaciente
            // 
            txtApellidoPaciente.Location = new Point(112, 84);
            txtApellidoPaciente.Name = "txtApellidoPaciente";
            txtApellidoPaciente.Size = new Size(177, 25);
            txtApellidoPaciente.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 27);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 63;
            label10.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 87);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 64;
            label11.Text = "Apellido";
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.None;
            groupBox5.Controls.Add(txtNombrePaciente);
            groupBox5.Controls.Add(txtApellidoPaciente);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label11);
            groupBox5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(12, 319);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(459, 136);
            groupBox5.TabIndex = 65;
            groupBox5.TabStop = false;
            groupBox5.Text = "PACIENTE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 94);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 61;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(322, 94);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 66;
            // 
            // txtPacienteID
            // 
            txtPacienteID.Location = new Point(185, 91);
            txtPacienteID.Name = "txtPacienteID";
            txtPacienteID.Size = new Size(85, 23);
            txtPacienteID.TabIndex = 67;
            txtPacienteID.Visible = false;
            // 
            // txtExpedienteID
            // 
            txtExpedienteID.Location = new Point(354, 44);
            txtExpedienteID.Name = "txtExpedienteID";
            txtExpedienteID.Size = new Size(46, 23);
            txtExpedienteID.TabIndex = 68;
            txtExpedienteID.Visible = false;
            // 
            // frmExpediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 730);
            Controls.Add(txtExpedienteID);
            Controls.Add(txtPacienteID);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(groupBox5);
            Controls.Add(linkLabel1);
            Controls.Add(dgvExpediente);
            Controls.Add(groupBox4);
            Controls.Add(label9);
            Controls.Add(txtHistorialMedico);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExpediente";
            Text = "frmExpediente";
            Load += frmExpediente_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpediente).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private Button btnEditar;
        private Button btnAgregar;
        private GroupBox groupBox1;
        private ComboBox cmbBiotipoCutaneo;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox txtVasosAgua;
        private TextBox txtTrasnoche;
        private Label label7;
        private TextBox txtConsumoMedicamento;
        private TextBox txtConsumoCafe;
        private Label label6;
        private TextBox txtConsumoTabaco;
        private TextBox txtConsumoSuplementos;
        private Label label5;
        private TextBox txtConsumoLicor;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtHistorialMedico;
        private Label label9;
        private GroupBox groupBox4;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonSi;
        private CheckBox checkBoxNinguno;
        private CheckBox checkBoxProtectorSolar;
        private CheckBox checkBoxTonico;
        private CheckBox checkBoxAceites;
        private CheckBox checkBoxSerum;
        private CheckBox checkBoxCremas;
        private CheckBox checkBoxJabonFacial;
        private DataGridView dgvExpediente;
        private LinkLabel linkLabel1;
        private TextBox txtNombrePaciente;
        private TextBox txtApellidoPaciente;
        private Label label10;
        private Label label11;
        private GroupBox groupBox5;
        private Label label12;
        private Label label13;
        private TextBox txtPacienteID;
        private TextBox txtExpedienteID;
    }
}