namespace ClinicaBD
{
    partial class frmCitasProgramadas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitasProgramadas));
            pnlTitulo = new Panel();
            label1 = new Label();
            dgvCitasProgramadas = new DataGridView();
            label2 = new Label();
            txtBuscarNombre = new TextBox();
            label3 = new Label();
            dtpBuscarFecha = new DateTimePicker();
            btnBuscar = new Button();
            btnRestaurar = new Button();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitasProgramadas).BeginInit();
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
            pnlTitulo.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(49, 11);
            label1.Name = "label1";
            label1.Size = new Size(248, 36);
            label1.TabIndex = 0;
            label1.Text = "Citas programadas";
            // 
            // dgvCitasProgramadas
            // 
            dgvCitasProgramadas.Anchor = AnchorStyles.None;
            dgvCitasProgramadas.BackgroundColor = SystemColors.Control;
            dgvCitasProgramadas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCitasProgramadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCitasProgramadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasProgramadas.EnableHeadersVisualStyles = false;
            dgvCitasProgramadas.Location = new Point(358, 245);
            dgvCitasProgramadas.Name = "dgvCitasProgramadas";
            dgvCitasProgramadas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvCitasProgramadas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCitasProgramadas.Size = new Size(652, 473);
            dgvCitasProgramadas.TabIndex = 69;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(188, 97);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 70;
            label2.Text = "Filtrado por Nombre:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Anchor = AnchorStyles.None;
            txtBuscarNombre.Font = new Font("Times New Roman", 14.25F);
            txtBuscarNombre.Location = new Point(363, 94);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(236, 29);
            txtBuscarNombre.TabIndex = 71;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(675, 97);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 72;
            label3.Text = "Filtrado por Fecha:";
            // 
            // dtpBuscarFecha
            // 
            dtpBuscarFecha.Anchor = AnchorStyles.None;
            dtpBuscarFecha.Font = new Font("Times New Roman", 14.25F);
            dtpBuscarFecha.Location = new Point(846, 89);
            dtpBuscarFecha.Name = "dtpBuscarFecha";
            dtpBuscarFecha.Size = new Size(230, 29);
            dtpBuscarFecha.TabIndex = 73;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.DarkGreen;
            btnBuscar.Font = new Font("Times New Roman", 14.25F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(456, 178);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(187, 61);
            btnBuscar.TabIndex = 74;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.None;
            btnRestaurar.BackColor = Color.DodgerBlue;
            btnRestaurar.Font = new Font("Times New Roman", 14.25F);
            btnRestaurar.ForeColor = Color.White;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestaurar.Location = new Point(684, 178);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(187, 61);
            btnRestaurar.TabIndex = 75;
            btnRestaurar.Text = "RESTAURAR";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // frmCitasProgramadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 730);
            Controls.Add(btnRestaurar);
            Controls.Add(btnBuscar);
            Controls.Add(dtpBuscarFecha);
            Controls.Add(label3);
            Controls.Add(txtBuscarNombre);
            Controls.Add(label2);
            Controls.Add(dgvCitasProgramadas);
            Controls.Add(pnlTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCitasProgramadas";
            Text = "frmCitasProgramadas";
            Load += frmCitasProgramadas_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitasProgramadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private DataGridView dgvCitasProgramadas;
        private Label label2;
        private TextBox txtBuscarNombre;
        private Label label3;
        private DateTimePicker dtpBuscarFecha;
        private Button btnBuscar;
        private Button btnRestaurar;
    }
}