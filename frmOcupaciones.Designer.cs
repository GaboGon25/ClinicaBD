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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            frmletrero = new Panel();
            pbxCerrar = new PictureBox();
            pbxClose = new PictureBox();
            pnlTitulo = new Panel();
            label1 = new Label();
            dgvOcupaciones = new DataGridView();
            txtNombreOcupacion = new TextBox();
            label2 = new Label();
            btnEditar = new Button();
            btnAgregar = new Button();
            txtOcupacionID = new TextBox();
            btnEliminar = new Button();
            frmletrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOcupaciones).BeginInit();
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
            // dgvOcupaciones
            // 
            dgvOcupaciones.Anchor = AnchorStyles.None;
            dgvOcupaciones.BackgroundColor = SystemColors.Control;
            dgvOcupaciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(82, 116, 21);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvOcupaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvOcupaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOcupaciones.EnableHeadersVisualStyles = false;
            dgvOcupaciones.Location = new Point(305, 224);
            dgvOcupaciones.Name = "dgvOcupaciones";
            dgvOcupaciones.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvOcupaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvOcupaciones.Size = new Size(168, 168);
            dgvOcupaciones.TabIndex = 18;
            dgvOcupaciones.CellClick += dgvOcupaciones_CellClick;
            // 
            // txtNombreOcupacion
            // 
            txtNombreOcupacion.Anchor = AnchorStyles.None;
            txtNombreOcupacion.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreOcupacion.Location = new Point(316, 121);
            txtNombreOcupacion.Name = "txtNombreOcupacion";
            txtNombreOcupacion.Size = new Size(240, 22);
            txtNombreOcupacion.TabIndex = 20;
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
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.Font = new Font("Times New Roman", 12F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(553, 159);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 47);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.BackColor = Color.DarkGreen;
            btnAgregar.Font = new Font("Times New Roman", 12F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(88, 159);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 47);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtOcupacionID
            // 
            txtOcupacionID.Location = new Point(316, 77);
            txtOcupacionID.Name = "txtOcupacionID";
            txtOcupacionID.Size = new Size(100, 23);
            txtOcupacionID.TabIndex = 23;
            txtOcupacionID.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Times New Roman", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(318, 159);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 47);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmOcupaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 418);
            Controls.Add(btnEliminar);
            Controls.Add(txtOcupacionID);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreOcupacion);
            Controls.Add(label2);
            Controls.Add(dgvOcupaciones);
            Controls.Add(pnlTitulo);
            Controls.Add(frmletrero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOcupaciones";
            Text = "frmOcupaciones";
            Load += frmOcupaciones_Load;
            frmletrero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOcupaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel frmletrero;
        private PictureBox pbxClose;
        private Panel pnlTitulo;
        private Label label1;
        private PictureBox pbxCerrar;
        private DataGridView dgvOcupaciones;
        private TextBox txtNombreOcupacion;
        private Label label2;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtOcupacionID;
        private Button btnEliminar;
    }
}