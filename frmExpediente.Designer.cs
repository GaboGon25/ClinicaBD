namespace ClinicaBD
{
    partial class frmExpediente
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
            pnlTitulo = new Panel();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox7 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.MediumTurquoise;
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(368, 57);
            pnlTitulo.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(328, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de Expediente";
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(967, 386);
            button2.Name = "button2";
            button2.Size = new Size(203, 61);
            button2.TabIndex = 20;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(645, 386);
            button1.Name = "button1";
            button1.Size = new Size(203, 61);
            button1.TabIndex = 19;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 483);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1591, 247);
            dataGridView1.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(462, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 77);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "BIOTIPO CUTANEO";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(89, 19);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "Jabon Facial";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(34, 82);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cremas";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(34, 127);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(59, 19);
            radioButton3.TabIndex = 27;
            radioButton3.TabStop = true;
            radioButton3.Text = "Serum";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(164, 35);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(63, 19);
            radioButton4.TabIndex = 28;
            radioButton4.TabStop = true;
            radioButton4.Text = "Aceites";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(164, 82);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(60, 19);
            radioButton5.TabIndex = 29;
            radioButton5.TabStop = true;
            radioButton5.Text = "Tonico";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(164, 127);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(103, 19);
            radioButton6.TabIndex = 30;
            radioButton6.TabStop = true;
            radioButton6.Text = "Protector Solar";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(280, 82);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(72, 19);
            radioButton7.TabIndex = 31;
            radioButton7.TabStop = true;
            radioButton7.Text = "Ninguno";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Location = new Point(967, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 180);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "CUIDADOS DE PIEL";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(34, 129);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(891, 192);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "HABITOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(611, 91);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 60;
            label8.Text = "Consumo Licor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 47;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(428, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 160);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 59;
            label7.Text = "Consumo Suplementos";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 49;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(428, 83);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 91);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 58;
            label6.Text = "Consumo Cafe";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 48;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(474, 152);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 23);
            textBox6.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 33);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 57;
            label5.Text = "Trasnoche";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(708, 87);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(177, 23);
            textBox7.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 54;
            label2.Text = "Vasos de agua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 91);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 56;
            label4.Text = "Consumo Tabaco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 55;
            label3.Text = "Consumo Medicamento";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(188, 355);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(332, 122);
            textBox8.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 400);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 61;
            label9.Text = "Historial Clinico";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton8);
            groupBox4.Controls.Add(radioButton9);
            groupBox4.Location = new Point(967, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(373, 95);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            groupBox4.Text = "USO DE MARCAPASOS";
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(207, 45);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(41, 19);
            radioButton8.TabIndex = 28;
            radioButton8.TabStop = true;
            radioButton8.Text = "No";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(77, 45);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(34, 19);
            radioButton9.TabIndex = 25;
            radioButton9.TabStop = true;
            radioButton9.Text = "Si";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // frmExpediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 730);
            Controls.Add(groupBox4);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExpediente";
            Text = "frmExpediente";
            Load += frmExpediente_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox7;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBox8;
        private Label label9;
        private GroupBox groupBox4;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
    }
}