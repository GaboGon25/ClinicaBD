namespace ClinicaBD
{
    partial class frmIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlTitulo = new Panel();
            label1 = new Label();
            label2 = new Label();
            dtpInicio = new DateTimePicker();
            label3 = new Label();
            dtpFin = new DateTimePicker();
            btnVer = new Button();
            dgvIngresos = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnConsultar = new Button();
            dgvRanking = new DataGridView();
            label6 = new Label();
            lblIngresosTotales = new Label();
            label5 = new Label();
            label4 = new Label();
            cmbMeses = new ComboBox();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.None;
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(297, 40);
            pnlTitulo.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(19, 7);
            label1.Name = "label1";
            label1.Size = new Size(236, 33);
            label1.TabIndex = 0;
            label1.Text = "Manejo de ingresos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 44);
            label2.Name = "label2";
            label2.Size = new Size(170, 19);
            label2.TabIndex = 28;
            label2.Text = "VER INGRESOS DEL: ";
            // 
            // dtpInicio
            // 
            dtpInicio.Font = new Font("Times New Roman", 14.25F);
            dtpInicio.Location = new Point(203, 38);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(225, 29);
            dtpInicio.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(434, 44);
            label3.Name = "label3";
            label3.Size = new Size(30, 19);
            label3.TabIndex = 30;
            label3.Text = "AL";
            // 
            // dtpFin
            // 
            dtpFin.Font = new Font("Times New Roman", 14.25F);
            dtpFin.Location = new Point(474, 38);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(225, 29);
            dtpFin.TabIndex = 31;
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.None;
            btnVer.BackColor = Color.DarkGreen;
            btnVer.Font = new Font("Segoe UI", 15F);
            btnVer.ForeColor = Color.White;
            btnVer.Image = (Image)resources.GetObject("btnVer.Image");
            btnVer.ImageAlign = ContentAlignment.MiddleLeft;
            btnVer.Location = new Point(27, 79);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(145, 37);
            btnVer.TabIndex = 32;
            btnVer.Text = "VER";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // dgvIngresos
            // 
            dgvIngresos.Anchor = AnchorStyles.None;
            dgvIngresos.BackgroundColor = SystemColors.Control;
            dgvIngresos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.EnableHeadersVisualStyles = false;
            dgvIngresos.Location = new Point(20, 122);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvIngresos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvIngresos.Size = new Size(277, 172);
            dgvIngresos.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvIngresos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Controls.Add(btnVer);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Font = new Font("Times New Roman", 14.25F);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 327);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresos diarios por intervalos de fechas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnConsultar);
            groupBox2.Controls.Add(dgvRanking);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblIngresosTotales);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbMeses);
            groupBox2.Font = new Font("Times New Roman", 14.25F);
            groupBox2.Location = new Point(12, 410);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(707, 308);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingresos mensuales con ranking de procedimientos";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.None;
            btnConsultar.BackColor = Color.DarkGreen;
            btnConsultar.Font = new Font("Segoe UI", 15F);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(20, 73);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(145, 37);
            btnConsultar.TabIndex = 34;
            btnConsultar.Text = "VER";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvRanking
            // 
            dgvRanking.Anchor = AnchorStyles.None;
            dgvRanking.BackgroundColor = SystemColors.Control;
            dgvRanking.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRanking.EnableHeadersVisualStyles = false;
            dgvRanking.Location = new Point(264, 138);
            dgvRanking.Name = "dgvRanking";
            dgvRanking.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvRanking.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvRanking.Size = new Size(277, 172);
            dgvRanking.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(264, 108);
            label6.Name = "label6";
            label6.Size = new Size(200, 19);
            label6.TabIndex = 37;
            label6.Text = "Ranking de procedimientos:";
            // 
            // lblIngresosTotales
            // 
            lblIngresosTotales.AutoSize = true;
            lblIngresosTotales.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresosTotales.ForeColor = SystemColors.ControlDarkDark;
            lblIngresosTotales.Location = new Point(34, 185);
            lblIngresosTotales.Name = "lblIngresosTotales";
            lblIngresosTotales.Size = new Size(15, 19);
            lblIngresosTotales.TabIndex = 36;
            lblIngresosTotales.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 149);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 35;
            label5.Text = "Ingresos del mes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 37);
            label4.Name = "label4";
            label4.Size = new Size(144, 19);
            label4.TabIndex = 34;
            label4.Text = "INGRESE EL MES:";
            // 
            // cmbMeses
            // 
            cmbMeses.FormattingEnabled = true;
            cmbMeses.Location = new Point(169, 33);
            cmbMeses.Name = "cmbMeses";
            cmbMeses.Size = new Size(168, 29);
            cmbMeses.TabIndex = 0;
            // 
            // frmIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 730);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIngresos";
            Text = "frmIngresos";
            Load += frmIngresos_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpInicio;
        private Label label3;
        private DateTimePicker dtpFin;
        private Button btnVer;
        private DataGridView dgvIngresos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox cmbMeses;
        private Label lblIngresosTotales;
        private Label label5;
        private DataGridView dgvRanking;
        private Label label6;
        private Button btnConsultar;
    }
}