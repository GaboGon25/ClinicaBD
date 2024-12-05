namespace ClinicaBD
{
    partial class frmCentral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCentral));
            pnlLetrero = new Panel();
            pbxOcultar = new PictureBox();
            pbxMinimizar = new PictureBox();
            pbxCerrar = new PictureBox();
            pbxRestauar = new PictureBox();
            pnlSideBar = new Panel();
            panel5 = new Panel();
            btnIngresos = new Button();
            panel4 = new Panel();
            btnPagos = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            btnCitas = new Button();
            panel1 = new Panel();
            btnExpediente = new Button();
            btnPacientes = new Button();
            pictureBox1 = new PictureBox();
            pnlContenedor = new Panel();
            btnCitasProgramadas = new Button();
            pnlLetrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxRestauar).BeginInit();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLetrero
            // 
            pnlLetrero.BackColor = Color.FromArgb(124, 175, 32);
            pnlLetrero.Controls.Add(pbxOcultar);
            pnlLetrero.Controls.Add(pbxMinimizar);
            pnlLetrero.Controls.Add(pbxCerrar);
            pnlLetrero.Controls.Add(pbxRestauar);
            pnlLetrero.Dock = DockStyle.Top;
            pnlLetrero.Location = new Point(0, 0);
            pnlLetrero.Name = "pnlLetrero";
            pnlLetrero.Size = new Size(1386, 59);
            pnlLetrero.TabIndex = 0;
            pnlLetrero.MouseDown += frmletrero_MouseDown;
            // 
            // pbxOcultar
            // 
            pbxOcultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxOcultar.Cursor = Cursors.Hand;
            pbxOcultar.Image = (Image)resources.GetObject("pbxOcultar.Image");
            pbxOcultar.Location = new Point(1239, 12);
            pbxOcultar.Name = "pbxOcultar";
            pbxOcultar.Size = new Size(44, 34);
            pbxOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxOcultar.TabIndex = 6;
            pbxOcultar.TabStop = false;
            pbxOcultar.Click += pbxOcultar_Click;
            // 
            // pbxMinimizar
            // 
            pbxMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMinimizar.Cursor = Cursors.Hand;
            pbxMinimizar.Image = (Image)resources.GetObject("pbxMinimizar.Image");
            pbxMinimizar.Location = new Point(1289, 12);
            pbxMinimizar.Name = "pbxMinimizar";
            pbxMinimizar.Size = new Size(44, 34);
            pbxMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxMinimizar.TabIndex = 4;
            pbxMinimizar.TabStop = false;
            pbxMinimizar.Click += pbxMinimizar_Click;
            // 
            // pbxCerrar
            // 
            pbxCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxCerrar.Cursor = Cursors.Hand;
            pbxCerrar.Image = (Image)resources.GetObject("pbxCerrar.Image");
            pbxCerrar.Location = new Point(1339, 12);
            pbxCerrar.Name = "pbxCerrar";
            pbxCerrar.Size = new Size(44, 34);
            pbxCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCerrar.TabIndex = 3;
            pbxCerrar.TabStop = false;
            pbxCerrar.Click += pbxCerrar_Click;
            // 
            // pbxRestauar
            // 
            pbxRestauar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxRestauar.Cursor = Cursors.Hand;
            pbxRestauar.Image = (Image)resources.GetObject("pbxRestauar.Image");
            pbxRestauar.Location = new Point(1289, 12);
            pbxRestauar.Name = "pbxRestauar";
            pbxRestauar.Size = new Size(44, 34);
            pbxRestauar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxRestauar.TabIndex = 5;
            pbxRestauar.TabStop = false;
            pbxRestauar.Click += pbxRestauar_Click;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.ForestGreen;
            pnlSideBar.Controls.Add(btnCitasProgramadas);
            pnlSideBar.Controls.Add(panel5);
            pnlSideBar.Controls.Add(btnIngresos);
            pnlSideBar.Controls.Add(panel4);
            pnlSideBar.Controls.Add(btnPagos);
            pnlSideBar.Controls.Add(panel3);
            pnlSideBar.Controls.Add(panel2);
            pnlSideBar.Controls.Add(btnCitas);
            pnlSideBar.Controls.Add(panel1);
            pnlSideBar.Controls.Add(btnExpediente);
            pnlSideBar.Controls.Add(btnPacientes);
            pnlSideBar.Controls.Add(pictureBox1);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 59);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(200, 729);
            pnlSideBar.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(124, 175, 32);
            panel5.Location = new Point(2, 598);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(11, 46);
            panel5.TabIndex = 8;
            // 
            // btnIngresos
            // 
            btnIngresos.Cursor = Cursors.Hand;
            btnIngresos.FlatAppearance.BorderSize = 0;
            btnIngresos.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnIngresos.FlatStyle = FlatStyle.Flat;
            btnIngresos.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresos.ForeColor = SystemColors.ControlLightLight;
            btnIngresos.Image = (Image)resources.GetObject("btnIngresos.Image");
            btnIngresos.ImageAlign = ContentAlignment.MiddleRight;
            btnIngresos.Location = new Point(2, 598);
            btnIngresos.Margin = new Padding(2, 1, 2, 1);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(198, 46);
            btnIngresos.TabIndex = 8;
            btnIngresos.Text = "Informe de Ingresos";
            btnIngresos.UseVisualStyleBackColor = true;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(124, 175, 32);
            panel4.Location = new Point(3, 530);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 46);
            panel4.TabIndex = 7;
            // 
            // btnPagos
            // 
            btnPagos.Cursor = Cursors.Hand;
            btnPagos.FlatAppearance.BorderSize = 0;
            btnPagos.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnPagos.FlatStyle = FlatStyle.Flat;
            btnPagos.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagos.ForeColor = SystemColors.ControlLightLight;
            btnPagos.Image = (Image)resources.GetObject("btnPagos.Image");
            btnPagos.ImageAlign = ContentAlignment.MiddleRight;
            btnPagos.Location = new Point(0, 530);
            btnPagos.Margin = new Padding(2, 1, 2, 1);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(198, 46);
            btnPagos.TabIndex = 6;
            btnPagos.Text = "PAGOS";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(124, 175, 32);
            panel3.Location = new Point(0, 381);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 46);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(124, 175, 32);
            panel2.Location = new Point(0, 272);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 46);
            panel2.TabIndex = 5;
            // 
            // btnCitas
            // 
            btnCitas.Cursor = Cursors.Hand;
            btnCitas.FlatAppearance.BorderSize = 0;
            btnCitas.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCitas.ForeColor = SystemColors.ControlLightLight;
            btnCitas.Image = (Image)resources.GetObject("btnCitas.Image");
            btnCitas.ImageAlign = ContentAlignment.MiddleRight;
            btnCitas.Location = new Point(0, 381);
            btnCitas.Margin = new Padding(2, 1, 2, 1);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(200, 46);
            btnCitas.TabIndex = 4;
            btnCitas.Text = "CITAS";
            btnCitas.UseVisualStyleBackColor = true;
            btnCitas.Click += btnCitas_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(124, 175, 32);
            panel1.Location = new Point(0, 177);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(11, 46);
            panel1.TabIndex = 3;
            // 
            // btnExpediente
            // 
            btnExpediente.Cursor = Cursors.Hand;
            btnExpediente.FlatAppearance.BorderSize = 0;
            btnExpediente.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnExpediente.FlatStyle = FlatStyle.Flat;
            btnExpediente.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpediente.ForeColor = SystemColors.ControlLightLight;
            btnExpediente.Image = (Image)resources.GetObject("btnExpediente.Image");
            btnExpediente.ImageAlign = ContentAlignment.MiddleRight;
            btnExpediente.Location = new Point(2, 272);
            btnExpediente.Margin = new Padding(2, 1, 2, 1);
            btnExpediente.Name = "btnExpediente";
            btnExpediente.Size = new Size(196, 46);
            btnExpediente.TabIndex = 4;
            btnExpediente.Text = "EXPEDIENTE";
            btnExpediente.UseVisualStyleBackColor = true;
            btnExpediente.Click += btnExpediente_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.Cursor = Cursors.Hand;
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacientes.ForeColor = SystemColors.ControlLightLight;
            btnPacientes.Image = (Image)resources.GetObject("btnPacientes.Image");
            btnPacientes.ImageAlign = ContentAlignment.MiddleRight;
            btnPacientes.Location = new Point(2, 177);
            btnPacientes.Margin = new Padding(2, 1, 2, 1);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(196, 46);
            btnPacientes.TabIndex = 2;
            btnPacientes.Text = "PACIENTES";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = SystemColors.ControlLight;
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(200, 59);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1186, 729);
            pnlContenedor.TabIndex = 2;
            // 
            // btnCitasProgramadas
            // 
            btnCitasProgramadas.Cursor = Cursors.Hand;
            btnCitasProgramadas.FlatAppearance.BorderSize = 0;
            btnCitasProgramadas.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnCitasProgramadas.FlatStyle = FlatStyle.Flat;
            btnCitasProgramadas.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCitasProgramadas.ForeColor = SystemColors.ControlLightLight;
            btnCitasProgramadas.Image = (Image)resources.GetObject("btnCitasProgramadas.Image");
            btnCitasProgramadas.ImageAlign = ContentAlignment.MiddleRight;
            btnCitasProgramadas.Location = new Point(-2, 451);
            btnCitasProgramadas.Margin = new Padding(2, 1, 2, 1);
            btnCitasProgramadas.Name = "btnCitasProgramadas";
            btnCitasProgramadas.Size = new Size(200, 46);
            btnCitasProgramadas.TabIndex = 9;
            btnCitasProgramadas.Text = "CITAS PROGRAMADAS";
            btnCitasProgramadas.UseVisualStyleBackColor = true;
            btnCitasProgramadas.Click += btnCitasProgramadas_Click;
            // 
            // frmCentral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 788);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlLetrero);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCentral";
            Text = "frmCentral";
            Load += frmCentral_Load;
            pnlLetrero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxRestauar).EndInit();
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLetrero;
        private Panel pnlSideBar;
        private Panel pnlContenedor;
        private PictureBox pbxMinimizar;
        private PictureBox pbxCerrar;
        private PictureBox pbxOcultar;
        private PictureBox pbxRestauar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnPacientes;
        private Panel panel4;
        private Button btnPagos;
        private Panel panel3;
        private Panel panel2;
        private Button btnCitas;
        private Button btnExpediente;
        private Button btnIngresos;
        private Panel panel5;
        private Button btnCitasProgramadas;
    }
}