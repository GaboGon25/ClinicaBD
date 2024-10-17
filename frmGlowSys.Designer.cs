namespace ClinicaBD
{
    partial class frmGlowSys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlowSys));
            pnlLetrero = new Panel();
            pbOcultar = new PictureBox();
            pbRestaurar = new PictureBox();
            pbMaximizar = new PictureBox();
            pbCerrar = new PictureBox();
            pnlMenu = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            btnPacientes = new Button();
            pnlContenedor = new Panel();
            pnlLetrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrar).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLetrero
            // 
            pnlLetrero.BackColor = Color.LightSeaGreen;
            pnlLetrero.Controls.Add(pbOcultar);
            pnlLetrero.Controls.Add(pbRestaurar);
            pnlLetrero.Controls.Add(pbMaximizar);
            pnlLetrero.Controls.Add(pbCerrar);
            pnlLetrero.Dock = DockStyle.Top;
            pnlLetrero.Location = new Point(0, 0);
            pnlLetrero.Name = "pnlLetrero";
            pnlLetrero.Size = new Size(2430, 140);
            pnlLetrero.TabIndex = 0;
            // 
            // pbOcultar
            // 
            pbOcultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbOcultar.Cursor = Cursors.Hand;
            pbOcultar.Image = (Image)resources.GetObject("pbOcultar.Image");
            pbOcultar.Location = new Point(2204, 12);
            pbOcultar.Name = "pbOcultar";
            pbOcultar.Size = new Size(59, 59);
            pbOcultar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOcultar.TabIndex = 3;
            pbOcultar.TabStop = false;
            pbOcultar.Click += pbOcultar_Click;
            // 
            // pbRestaurar
            // 
            pbRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbRestaurar.Cursor = Cursors.Hand;
            pbRestaurar.Image = (Image)resources.GetObject("pbRestaurar.Image");
            pbRestaurar.Location = new Point(2283, 12);
            pbRestaurar.Name = "pbRestaurar";
            pbRestaurar.Size = new Size(59, 59);
            pbRestaurar.TabIndex = 2;
            pbRestaurar.TabStop = false;
            pbRestaurar.Visible = false;
            pbRestaurar.Click += pbRestaurar_Click;
            // 
            // pbMaximizar
            // 
            pbMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMaximizar.Cursor = Cursors.Hand;
            pbMaximizar.Image = (Image)resources.GetObject("pbMaximizar.Image");
            pbMaximizar.Location = new Point(2283, 12);
            pbMaximizar.Name = "pbMaximizar";
            pbMaximizar.Size = new Size(59, 59);
            pbMaximizar.TabIndex = 1;
            pbMaximizar.TabStop = false;
            pbMaximizar.Click += pbMaximizar_Click;
            // 
            // pbCerrar
            // 
            pbCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbCerrar.Cursor = Cursors.Hand;
            pbCerrar.Image = (Image)resources.GetObject("pbCerrar.Image");
            pbCerrar.Location = new Point(2359, 12);
            pbCerrar.Name = "pbCerrar";
            pbCerrar.Size = new Size(59, 59);
            pbCerrar.TabIndex = 0;
            pbCerrar.TabStop = false;
            pbCerrar.Click += pbCerrar_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Teal;
            pnlMenu.Controls.Add(panel4);
            pnlMenu.Controls.Add(button4);
            pnlMenu.Controls.Add(panel3);
            pnlMenu.Controls.Add(button3);
            pnlMenu.Controls.Add(panel2);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(btnPacientes);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 140);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(403, 1290);
            pnlMenu.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSeaGreen;
            panel4.Location = new Point(3, 696);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 77);
            panel4.TabIndex = 7;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(3, 696);
            button4.Name = "button4";
            button4.Size = new Size(397, 77);
            button4.TabIndex = 6;
            button4.Text = "PAGOS";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Location = new Point(3, 539);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 77);
            panel3.TabIndex = 5;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(3, 539);
            button3.Name = "button3";
            button3.Size = new Size(397, 77);
            button3.TabIndex = 4;
            button3.Text = "CITAS";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Location = new Point(3, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 77);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(3, 380);
            button2.Name = "button2";
            button2.Size = new Size(397, 77);
            button2.TabIndex = 2;
            button2.Text = "EXPEDIENTE";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Location = new Point(3, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 77);
            panel1.TabIndex = 1;
            // 
            // btnPacientes
            // 
            btnPacientes.Cursor = Cursors.Hand;
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Century Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacientes.ForeColor = SystemColors.ControlLightLight;
            btnPacientes.Location = new Point(3, 213);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(397, 77);
            btnPacientes.TabIndex = 0;
            btnPacientes.Text = "PACIENTES";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = SystemColors.Control;
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(403, 140);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(2027, 1290);
            pnlContenedor.TabIndex = 2;
            // 
            // frmGlowSys
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2430, 1430);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenu);
            Controls.Add(pnlLetrero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGlowSys";
            Text = "frmGlowSys";
            Load += frmGlowSys_Load;
            pnlLetrero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrar).EndInit();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLetrero;
        private Panel pnlMenu;
        private PictureBox pbCerrar;
        private Panel pnlContenedor;
        private PictureBox pbOcultar;
        private PictureBox pbRestaurar;
        private PictureBox pbMaximizar;
        private Button btnPacientes;
        private Panel panel1;
        private Panel panel3;
        private Button button3;
        private Panel panel2;
        private Button button2;
        private Panel panel4;
        private Button button4;
    }
}