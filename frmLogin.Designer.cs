namespace ClinicaBD
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            frmletrero = new Panel();
            pbxClose = new PictureBox();
            pbxImage = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pnlUsername = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            btnAcceder = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            frmletrero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // frmletrero
            // 
            frmletrero.BackColor = Color.FromArgb(124, 175, 32);
            frmletrero.Controls.Add(pbxClose);
            frmletrero.Dock = DockStyle.Top;
            frmletrero.Location = new Point(0, 0);
            frmletrero.Name = "frmletrero";
            frmletrero.Size = new Size(811, 40);
            frmletrero.TabIndex = 0;
            frmletrero.MouseDown += frmletrero_MouseDown;
            // 
            // pbxClose
            // 
            pbxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxClose.Cursor = Cursors.Hand;
            pbxClose.Image = (Image)resources.GetObject("pbxClose.Image");
            pbxClose.Location = new Point(771, 3);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(40, 29);
            pbxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbxClose.TabIndex = 0;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
            // 
            // pbxImage
            // 
            pbxImage.Dock = DockStyle.Left;
            pbxImage.Image = (Image)resources.GetObject("pbxImage.Image");
            pbxImage.Location = new Point(0, 40);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(414, 417);
            pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImage.TabIndex = 1;
            pbxImage.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(104, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(561, 57);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 3;
            label1.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(468, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.Green;
            pnlUsername.Location = new Point(459, 193);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(300, 1);
            pnlUsername.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Location = new Point(459, 288);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(468, 252);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(124, 175, 32);
            btnAcceder.Font = new Font("Bahnschrift Condensed", 20F);
            btnAcceder.ForeColor = SystemColors.ButtonHighlight;
            btnAcceder.Image = (Image)resources.GetObject("btnAcceder.Image");
            btnAcceder.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcceder.Location = new Point(492, 338);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(225, 58);
            btnAcceder.TabIndex = 9;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(459, 135);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(459, 230);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(504, 164);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 23);
            txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(505, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 23);
            txtPassword.TabIndex = 13;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(811, 457);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAcceder);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pnlUsername);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pbxImage);
            Controls.Add(frmletrero);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            frmletrero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel frmletrero;
        private PictureBox pbxClose;
        private PictureBox pbxImage;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel pnlUsername;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Button btnAcceder;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}