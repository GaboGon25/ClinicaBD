namespace ClinicaBD
{
    partial class frmHora
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
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            lblFecha = new Label();
            HoraFecha = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 100F);
            lblHora.ForeColor = Color.DodgerBlue;
            lblHora.Location = new Point(505, 130);
            lblHora.Name = "lblHora";
            lblHora.RightToLeft = RightToLeft.No;
            lblHora.Size = new Size(428, 177);
            lblHora.TabIndex = 0;
            lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 70F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(354, 307);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(302, 125);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "label1";
            // 
            // HoraFecha
            // 
            HoraFecha.Enabled = true;
            HoraFecha.Tick += HoraFecha_Tick;
            // 
            // frmHora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 691);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHora";
            Text = "frmHora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
    }
}