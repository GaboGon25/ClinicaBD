namespace ClinicaBD
{
    partial class frmRegistrosPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrosPacientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            frmLetrero = new Panel();
            pbxCerrar = new PictureBox();
            pnlTitulo = new Panel();
            label1 = new Label();
            dgvPacientes = new DataGridView();
            label2 = new Label();
            frmLetrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).BeginInit();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // frmLetrero
            // 
            frmLetrero.BackColor = Color.FromArgb(124, 175, 32);
            frmLetrero.Controls.Add(pbxCerrar);
            frmLetrero.Dock = DockStyle.Top;
            frmLetrero.Location = new Point(0, 0);
            frmLetrero.Name = "frmLetrero";
            frmLetrero.Size = new Size(779, 40);
            frmLetrero.TabIndex = 0;
            frmLetrero.MouseDown += frmLetrero_MouseDown;
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
            pbxCerrar.TabIndex = 19;
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
            pnlTitulo.TabIndex = 18;
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
            dgvPacientes.Location = new Point(250, 138);
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
            dgvPacientes.TabIndex = 19;
            dgvPacientes.CellClick += dgvPacientes_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 235);
            label2.Name = "label2";
            label2.Size = new Size(309, 15);
            label2.TabIndex = 20;
            label2.Text = "a la izquieda de este label esta el datagrid, es transparente";
            // 
            // frmRegistrosPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 379);
            Controls.Add(label2);
            Controls.Add(dgvPacientes);
            Controls.Add(pnlTitulo);
            Controls.Add(frmLetrero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistrosPacientes";
            Text = "frmRegistrosPacientes";
            Load += frmRegistrosPacientes_Load;
            frmLetrero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel frmLetrero;
        private PictureBox pbxCerrar;
        private Panel pnlTitulo;
        private Label label1;
        private DataGridView dgvPacientes;
        private Label label2;
    }
}