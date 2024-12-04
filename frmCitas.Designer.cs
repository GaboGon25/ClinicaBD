namespace ClinicaBD
{
    partial class frmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            txtNombrePaciente = new TextBox();
            label2 = new Label();
            txtApellidoPaciente = new TextBox();
            label8 = new Label();
            txtValor = new TextBox();
            label9 = new Label();
            label5 = new Label();
            cmbProcedimientos = new ComboBox();
            txtMotivo = new TextBox();
            label7 = new Label();
            cmbEstado = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            pnlTitulo = new Panel();
            label1 = new Label();
            btnEditar = new Button();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            cbxProcedimientoAdicional = new CheckBox();
            cmbProcedimientos2 = new ComboBox();
            txtValor2 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            dtpHora = new DateTimePicker();
            dgvCitas = new DataGridView();
            groupBox1.SuspendLayout();
            pnlTitulo.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(txtNombrePaciente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtApellidoPaciente);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 187);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paciente";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(6, 148);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(268, 19);
            linkLabel1.TabIndex = 64;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Seleccione al paciente para registrar su cita";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Anchor = AnchorStyles.None;
            txtNombrePaciente.Font = new Font("Times New Roman", 14.25F);
            txtNombrePaciente.Location = new Point(105, 26);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(236, 29);
            txtNombrePaciente.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(8, 34);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // txtApellidoPaciente
            // 
            txtApellidoPaciente.Anchor = AnchorStyles.None;
            txtApellidoPaciente.Font = new Font("Times New Roman", 14.25F);
            txtApellidoPaciente.Location = new Point(105, 83);
            txtApellidoPaciente.Name = "txtApellidoPaciente";
            txtApellidoPaciente.Size = new Size(236, 29);
            txtApellidoPaciente.TabIndex = 30;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F);
            label8.Location = new Point(8, 91);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 29;
            label8.Text = "Apellido:";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Times New Roman", 14.25F);
            txtValor.Location = new Point(135, 96);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(236, 29);
            txtValor.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F);
            label9.Location = new Point(76, 102);
            label9.Name = "label9";
            label9.Size = new Size(53, 21);
            label9.TabIndex = 65;
            label9.Text = "Valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F);
            label5.Location = new Point(7, 48);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 27;
            label5.Text = "Procedimiento:";
            // 
            // cmbProcedimientos
            // 
            cmbProcedimientos.Font = new Font("Times New Roman", 14.25F);
            cmbProcedimientos.FormattingEnabled = true;
            cmbProcedimientos.Location = new Point(135, 45);
            cmbProcedimientos.Name = "cmbProcedimientos";
            cmbProcedimientos.Size = new Size(236, 29);
            cmbProcedimientos.TabIndex = 26;
            cmbProcedimientos.SelectedIndexChanged += cmbProcedimientos_SelectedIndexChanged;
            // 
            // txtMotivo
            // 
            txtMotivo.Anchor = AnchorStyles.None;
            txtMotivo.Font = new Font("Times New Roman", 14.25F);
            txtMotivo.Location = new Point(108, 204);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(323, 109);
            txtMotivo.TabIndex = 24;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F);
            label7.Location = new Point(15, 207);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 23;
            label7.Text = "Motivo:";
            // 
            // cmbEstado
            // 
            cmbEstado.Anchor = AnchorStyles.None;
            cmbEstado.Font = new Font("Times New Roman", 14.25F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(85, 140);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(236, 29);
            cmbEstado.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F);
            label6.Location = new Point(20, 148);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 21;
            label6.Text = "Estado:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(20, 94);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 18;
            label4.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Font = new Font("Times New Roman", 14.25F);
            dtpFecha.Location = new Point(85, 88);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(236, 29);
            dtpFecha.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(20, 37);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 15;
            label3.Text = "Hora:";
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
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(49, 11);
            label1.Name = "label1";
            label1.Size = new Size(231, 36);
            label1.TabIndex = 0;
            label1.Text = "Registro de Citas";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.Font = new Font("Times New Roman", 14.25F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(208, 295);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(187, 61);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.Font = new Font("Times New Roman", 14.25F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(12, 295);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(187, 61);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(cbxProcedimientoAdicional);
            groupBox2.Controls.Add(cmbProcedimientos2);
            groupBox2.Controls.Add(txtValor2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cmbProcedimientos);
            groupBox2.Controls.Add(txtValor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(401, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 256);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            groupBox2.Text = "Procedimiento a realizar";
            // 
            // cbxProcedimientoAdicional
            // 
            cbxProcedimientoAdicional.AutoSize = true;
            cbxProcedimientoAdicional.Font = new Font("Times New Roman", 12F);
            cbxProcedimientoAdicional.Location = new Point(7, 131);
            cbxProcedimientoAdicional.Name = "cbxProcedimientoAdicional";
            cbxProcedimientoAdicional.Size = new Size(196, 23);
            cbxProcedimientoAdicional.TabIndex = 71;
            cbxProcedimientoAdicional.Text = "Agregar otro procedimiento";
            cbxProcedimientoAdicional.UseVisualStyleBackColor = true;
            cbxProcedimientoAdicional.CheckedChanged += cbxProcedimientoAdicional_CheckedChanged;
            // 
            // cmbProcedimientos2
            // 
            cmbProcedimientos2.Font = new Font("Times New Roman", 14.25F);
            cmbProcedimientos2.FormattingEnabled = true;
            cmbProcedimientos2.Location = new Point(135, 158);
            cmbProcedimientos2.Name = "cmbProcedimientos2";
            cmbProcedimientos2.Size = new Size(236, 29);
            cmbProcedimientos2.TabIndex = 67;
            cmbProcedimientos2.SelectedIndexChanged += cmbProcedimientos2_SelectedIndexChanged;
            // 
            // txtValor2
            // 
            txtValor2.Font = new Font("Times New Roman", 14.25F);
            txtValor2.Location = new Point(135, 209);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(236, 29);
            txtValor2.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F);
            label10.Location = new Point(7, 161);
            label10.Name = "label10";
            label10.Size = new Size(122, 21);
            label10.TabIndex = 68;
            label10.Text = "Procedimiento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F);
            label11.Location = new Point(76, 215);
            label11.Name = "label11";
            label11.Size = new Size(53, 21);
            label11.TabIndex = 69;
            label11.Text = "Valor:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(dtpHora);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(dtpFecha);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cmbEstado);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtMotivo);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(823, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(454, 333);
            groupBox3.TabIndex = 67;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalles de Cita";
            // 
            // dtpHora
            // 
            dtpHora.Anchor = AnchorStyles.None;
            dtpHora.Font = new Font("Times New Roman", 14.25F);
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(85, 29);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(236, 29);
            dtpHora.TabIndex = 25;
            // 
            // dgvCitas
            // 
            dgvCitas.Anchor = AnchorStyles.None;
            dgvCitas.BackgroundColor = SystemColors.Control;
            dgvCitas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.EnableHeadersVisualStyles = false;
            dgvCitas.Location = new Point(177, 402);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCitas.Size = new Size(887, 267);
            dgvCitas.TabIndex = 68;
            dgvCitas.CellClick += dgvCitas_CellClick;
            // 
            // frmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 730);
            Controls.Add(dgvCitas);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCitas";
            Text = "frmCitas";
            Load += frmCitas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbProcedimientos;
        private TextBox txtMotivo;
        private Label label7;
        private ComboBox cmbEstado;
        private Label label6;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Label label2;
        private Panel pnlTitulo;
        private Label label1;
        private Button btnEditar;
        private Button btnAgregar;
        private Label label5;
        private TextBox txtApellidoPaciente;
        private Label label8;
        private TextBox txtNombrePaciente;
        private LinkLabel linkLabel1;
        private TextBox txtValor;
        private Label label9;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgvCitas;
        private ComboBox cmbProcedimientos2;
        private TextBox txtValor2;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpHora;
        private CheckBox cbxProcedimientoAdicional;
    }
}