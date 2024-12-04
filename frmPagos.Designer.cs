namespace ClinicaBD
{
    partial class frmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtTotalDescuento = new TextBox();
            label12 = new Label();
            rbtnNo = new RadioButton();
            rbtnSi = new RadioButton();
            label11 = new Label();
            txtProcedimientos = new TextBox();
            label8 = new Label();
            txtApellidoPaciente = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtNombrePaciente = new TextBox();
            txtTotal = new TextBox();
            cmbPacientes = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            dtpFechaCita = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            pnlTitulo = new Panel();
            label1 = new Label();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvPago = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPago).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtProcedimientos);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtApellidoPaciente);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombrePaciente);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(cmbPacientes);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpFechaCita);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(53, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1302, 335);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "PAGO ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotalDescuento);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(rbtnNo);
            groupBox2.Controls.Add(rbtnSi);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Times New Roman", 14.25F);
            groupBox2.Location = new Point(29, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 100);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "DESCUENTO";
            // 
            // txtTotalDescuento
            // 
            txtTotalDescuento.Location = new Point(172, 57);
            txtTotalDescuento.Name = "txtTotalDescuento";
            txtTotalDescuento.Size = new Size(125, 29);
            txtTotalDescuento.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 14.25F);
            label12.Location = new Point(6, 65);
            label12.Name = "label12";
            label12.Size = new Size(160, 21);
            label12.TabIndex = 42;
            label12.Text = "Ingrese total a pagar";
            // 
            // rbtnNo
            // 
            rbtnNo.AutoSize = true;
            rbtnNo.Location = new Point(241, 21);
            rbtnNo.Name = "rbtnNo";
            rbtnNo.Size = new Size(51, 25);
            rbtnNo.TabIndex = 42;
            rbtnNo.TabStop = true;
            rbtnNo.Text = "No";
            rbtnNo.UseVisualStyleBackColor = true;
            rbtnNo.CheckedChanged += rbtnNo_CheckedChanged;
            // 
            // rbtnSi
            // 
            rbtnSi.AutoSize = true;
            rbtnSi.Location = new Point(193, 21);
            rbtnSi.Name = "rbtnSi";
            rbtnSi.Size = new Size(43, 25);
            rbtnSi.TabIndex = 42;
            rbtnSi.TabStop = true;
            rbtnSi.Text = "Si";
            rbtnSi.UseVisualStyleBackColor = true;
            rbtnSi.CheckedChanged += rbtnSi_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F);
            label11.Location = new Point(0, 25);
            label11.Name = "label11";
            label11.Size = new Size(174, 21);
            label11.TabIndex = 42;
            label11.Text = "¿Realizara descuento?";
            // 
            // txtProcedimientos
            // 
            txtProcedimientos.Location = new Point(1087, 35);
            txtProcedimientos.Multiline = true;
            txtProcedimientos.Name = "txtProcedimientos";
            txtProcedimientos.ReadOnly = true;
            txtProcedimientos.Size = new Size(209, 72);
            txtProcedimientos.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F);
            label8.Location = new Point(955, 83);
            label8.Name = "label8";
            label8.Size = new Size(126, 21);
            label8.TabIndex = 35;
            label8.Text = "Procedimientos";
            // 
            // txtApellidoPaciente
            // 
            txtApellidoPaciente.Location = new Point(387, 83);
            txtApellidoPaciente.Name = "txtApellidoPaciente";
            txtApellidoPaciente.ReadOnly = true;
            txtApellidoPaciente.Size = new Size(150, 29);
            txtApellidoPaciente.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F);
            label7.Location = new Point(293, 86);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 33;
            label7.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F);
            label5.Location = new Point(29, 86);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 32;
            label5.Text = "Nombre:";
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(110, 83);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.ReadOnly = true;
            txtNombrePaciente.Size = new Size(150, 29);
            txtNombrePaciente.TabIndex = 31;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(135, 251);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 29);
            txtTotal.TabIndex = 30;
            // 
            // cmbPacientes
            // 
            cmbPacientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Location = new Point(178, 32);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new Size(236, 29);
            cmbPacientes.TabIndex = 28;
            cmbPacientes.SelectedIndexChanged += cmbPacientes_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F);
            label6.Location = new Point(22, 254);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 21;
            label6.Text = "Total a pagar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(567, 86);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 18;
            label4.Text = "Fecha de cita:";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(686, 80);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(236, 29);
            dtpFechaCita.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(29, 168);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(29, 35);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 13;
            label2.Text = "Buscar Paciente:";
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.None;
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(333, 57);
            pnlTitulo.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(50, 12);
            label1.Name = "label1";
            label1.Size = new Size(217, 33);
            label1.TabIndex = 0;
            label1.Text = "Registro de Pagos";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.Font = new Font("Segoe UI", 15F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(699, 424);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(203, 61);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.Font = new Font("Segoe UI", 15F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(460, 424);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(203, 61);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPago
            // 
            dgvPago.Anchor = AnchorStyles.None;
            dgvPago.BackgroundColor = SystemColors.Control;
            dgvPago.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPago.EnableHeadersVisualStyles = false;
            dgvPago.Location = new Point(376, 503);
            dgvPago.Name = "dgvPago";
            dgvPago.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvPago.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvPago.Size = new Size(599, 227);
            dgvPago.TabIndex = 28;
            dgvPago.CellClick += dgvPago_CellClick;
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 730);
            Controls.Add(dgvPago);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPagos";
            Text = "frmPagos";
            Load += frmPagos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTotal;
        private ComboBox cmbPacientes;
        private Label label6;
        private Label label4;
        private DateTimePicker dtpFechaCita;
        private Label label3;
        private Label label2;
        private Panel pnlTitulo;
        private Label label1;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dgvPago;
        private TextBox txtProcedimientos;
        private Label label8;
        private TextBox txtApellidoPaciente;
        private Label label7;
        private Label label5;
        private TextBox txtNombrePaciente;
        private GroupBox groupBox2;
        private TextBox txtTotalDescuento;
        private Label label12;
        private RadioButton rbtnNo;
        private RadioButton rbtnSi;
        private Label label11;
    }
}