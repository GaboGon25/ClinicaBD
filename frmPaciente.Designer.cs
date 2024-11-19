namespace ClinicaBD
{
    partial class frmPaciente
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            pnlTitulo = new Panel();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(290, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de Paciente";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 428);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1245, 290);
            dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(557, 361);
            button1.Name = "button1";
            button1.Size = new Size(203, 61);
            button1.TabIndex = 14;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(786, 361);
            button2.Name = "button2";
            button2.Size = new Size(203, 61);
            button2.TabIndex = 15;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.MediumTurquoise;
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(33, 22);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(333, 57);
            pnlTitulo.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(38, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1320, 248);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(929, 129);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 109);
            textBox4.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F);
            label7.Location = new Point(834, 163);
            label7.Name = "label7";
            label7.Size = new Size(89, 18);
            label7.TabIndex = 23;
            label7.Text = "Direccion:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(940, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 29);
            comboBox1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F);
            label6.Location = new Point(837, 80);
            label6.Name = "label6";
            label6.Size = new Size(99, 18);
            label6.TabIndex = 21;
            label6.Text = "Ocupacion:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(577, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 29);
            textBox3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(407, 163);
            label5.Name = "label5";
            label5.Size = new Size(148, 18);
            label5.TabIndex = 19;
            label5.Text = "Celular/Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(393, 77);
            label4.Name = "label4";
            label4.Size = new Size(186, 18);
            label4.TabIndex = 18;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(585, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 29);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 29);
            textBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(54, 163);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 15;
            label3.Text = "Apellido:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 29);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(54, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1117, 78);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(189, 21);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Agregar mas ocupaciones";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 769);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPaciente";
            Text = "frmPaciente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Panel pnlTitulo;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label7;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}