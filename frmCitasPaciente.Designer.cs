namespace ClinicaBD
{
    partial class frmCitasPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitasPaciente));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlLetrero = new Panel();
            pbxCerrar = new PictureBox();
            pnlTitulo = new Panel();
            label1 = new Label();
            dgvPacientes = new DataGridView();
            pnlLetrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).BeginInit();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // pnlLetrero
            // 
            pnlLetrero.BackColor = Color.FromArgb(124, 175, 32);
            pnlLetrero.Controls.Add(pbxCerrar);
            pnlLetrero.Dock = DockStyle.Top;
            pnlLetrero.Location = new Point(0, 0);
            pnlLetrero.Name = "pnlLetrero";
            pnlLetrero.Size = new Size(779, 40);
            pnlLetrero.TabIndex = 0;
            pnlLetrero.MouseDown += pnlLetrero_MouseDown;
            // 
            // pbxCerrar
            // 
            pbxCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxCerrar.Cursor = Cursors.Hand;
            pbxCerrar.Image = (Image)resources.GetObject("pbxCerrar.Image");
            pbxCerrar.Location = new Point(751, 3);
            pbxCerrar.Name = "pbxCerrar";
            pbxCerrar.Size = new Size(25, 25);
            pbxCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCerrar.TabIndex = 20;
            pbxCerrar.TabStop = false;
            pbxCerrar.Click += pbxCerrar_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.None;
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 46);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(163, 54);
            pnlTitulo.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(104, 27);
            label1.TabIndex = 0;
            label1.Text = "Pacientes";
            // 
            // dgvPacientes
            // 
            dgvPacientes.Anchor = AnchorStyles.None;
            dgvPacientes.BackgroundColor = SystemColors.Control;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.Location = new Point(272, 121);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.Size = new Size(202, 197);
            dgvPacientes.TabIndex = 21;
            dgvPacientes.CellClick += dgvPacientes_CellClick;
            // 
            // frmCitasPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 379);
            Controls.Add(dgvPacientes);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlLetrero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCitasPaciente";
            Text = "frmCitasPaciente";
            Load += frmCitasPaciente_Load;
            pnlLetrero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLetrero;
        private Panel pnlTitulo;
        private Label label1;
        private PictureBox pbxCerrar;
        private DataGridView dgvPacientes;
    }
}