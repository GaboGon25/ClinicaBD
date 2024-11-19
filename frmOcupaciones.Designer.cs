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
            frmletrero = new Panel();
            pbxClose = new PictureBox();
            pnlTitulo = new Panel();
            label1 = new Label();
            pbxCerrar = new PictureBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            frmletrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // frmletrero
            // 
            frmletrero.BackColor = Color.Green;
            frmletrero.Controls.Add(pbxCerrar);
            frmletrero.Controls.Add(pbxClose);
            frmletrero.Dock = DockStyle.Top;
            frmletrero.Location = new Point(0, 0);
            frmletrero.Name = "frmletrero";
            frmletrero.Size = new Size(795, 40);
            frmletrero.TabIndex = 1;
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
            pnlTitulo.BackColor = Color.MediumTurquoise;
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 46);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(163, 54);
            pnlTitulo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15F);
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Ocupaciones";
            // 
            // pbxCerrar
            // 
            pbxCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxCerrar.Cursor = Cursors.Hand;
            pbxCerrar.Image = (Image)resources.GetObject("pbxCerrar.Image");
            pbxCerrar.Location = new Point(752, 3);
            pbxCerrar.Name = "pbxCerrar";
            pbxCerrar.Size = new Size(40, 29);
            pbxCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCerrar.TabIndex = 18;
            pbxCerrar.TabStop = false;
            pbxCerrar.Click += pbxCerrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(82, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(598, 168);
            dataGridView1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(179, 128);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 19;
            label2.Text = "Nombre:";
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(501, 185);
            button2.Name = "button2";
            button2.Size = new Size(155, 47);
            button2.TabIndex = 22;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(82, 185);
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
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).EndInit();
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