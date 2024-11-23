namespace ClinicaBD
{
    partial class frmOcupaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOcupaciones));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            frmletrero = new Panel();
            pbxCerrar = new PictureBox();
            pbxClose = new PictureBox();
            pnlTitulo = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            frmletrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // frmletrero
            // 
            frmletrero.BackColor = Color.FromArgb(124, 175, 32);
            frmletrero.Controls.Add(pbxCerrar);
            frmletrero.Controls.Add(pbxClose);
            frmletrero.Dock = DockStyle.Top;
            frmletrero.Location = new Point(0, 0);
            frmletrero.Name = "frmletrero";
            frmletrero.Size = new Size(795, 40);
            frmletrero.TabIndex = 1;
            frmletrero.MouseDown += frmletrero_MouseDown;
            // 
            // pbxCerrar
            // 
            pbxCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxCerrar.Cursor = Cursors.Hand;
            pbxCerrar.Image = (Image)resources.GetObject("pbxCerrar.Image");
            pbxCerrar.Location = new Point(759, 6);
            pbxCerrar.Name = "pbxCerrar";
            pbxCerrar.Size = new Size(25, 25);
            pbxCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCerrar.TabIndex = 18;
            pbxCerrar.TabStop = false;
            pbxCerrar.Click += pbxCerrar_Click;
            // 
            // pbxClose
            // 
            pbxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxClose.Cursor = Cursors.Hand;
            pbxClose.Image = (Image)resources.GetObject("pbxClose.Image");
            pbxClose.Location = new Point(1366, 3);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(40, 29);
            pbxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbxClose.TabIndex = 0;
            pbxClose.TabStop = false;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.None;
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 46);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(163, 54);
            pnlTitulo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(136, 27);
            label1.TabIndex = 0;
            label1.Text = "Ocupaciones";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(40, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(717, 168);
            dataGridView1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(316, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 22);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 120);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 19;
            label2.Text = "Nombre:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Times New Roman", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(458, 159);
            button2.Name = "button2";
            button2.Size = new Size(155, 47);
            button2.TabIndex = 22;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Times New Roman", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(179, 159);
            button1.Name = "button1";
            button1.Size = new Size(155, 47);
            button1.TabIndex = 21;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmOcupaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 418);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pnlTitulo);
            Controls.Add(frmletrero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOcupaciones";
            Text = "frmOcupaciones";
            frmletrero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel frmletrero;
        private PictureBox pbxClose;
        private Panel pnlTitulo;
        private Label label1;
        private PictureBox pbxCerrar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}