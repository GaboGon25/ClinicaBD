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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTitulo = new Panel();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
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
            dataGridView1 = new DataGridView();
            pnlTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.None;
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(12, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(368, 57);
            pnlTitulo.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(42, 13);
            label1.Name = "label1";
            label1.Size = new Size(280, 33);
            label1.TabIndex = 0;
            label1.Text = "Registro de Expediente";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Times New Roman", 15F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(967, 386);
            button2.Name = "button2";
            button2.Size = new Size(203, 61);
            button2.TabIndex = 20;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Times New Roman", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(645, 386);
            button1.Name = "button1";
            button1.Size = new Size(203, 61);
            button1.TabIndex = 19;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Times New Roman", 11.25F);
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
            comboBox1.Location = new Point(94, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Font = new Font("Times New Roman", 11.25F);
            groupBox2.Location = new Point(967, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 180);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "CUIDADOS DE PIEL";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(207, 93);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(76, 21);
            checkBox7.TabIndex = 32;
            checkBox7.Text = "Ninguno";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(207, 66);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(116, 21);
            checkBox6.TabIndex = 32;
            checkBox6.Text = "Protector Solar";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(207, 39);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(66, 21);
            checkBox5.TabIndex = 32;
            checkBox5.Text = "Tonico";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(25, 120);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 21);
            checkBox4.TabIndex = 32;
            checkBox4.Text = "Aceites";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(25, 93);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 21);
            checkBox3.TabIndex = 32;
            checkBox3.Text = "Serum";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(25, 66);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 21);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Cremas";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 21);
            checkBox1.TabIndex = 32;
            checkBox1.Text = "Jabón Facial";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
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
            groupBox3.Font = new Font("Times New Roman", 11.25F);
            groupBox3.Location = new Point(12, 129);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(949, 192);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "HABITOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(697, 91);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 60;
            label8.Text = "Consumo Licor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 25);
            textBox1.TabIndex = 47;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(511, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 25);
            textBox4.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 147);
            label7.Name = "label7";
            label7.Size = new Size(141, 17);
            label7.TabIndex = 59;
            label7.Text = "Consumo Suplementos";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(173, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 25);
            textBox3.TabIndex = 49;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(510, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 25);
            textBox5.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 90);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 58;
            label6.Text = "Consumo Cafe";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 25);
            textBox2.TabIndex = 48;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(511, 143);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 25);
            textBox6.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 34);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 57;
            label5.Text = "Trasnoche";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(794, 87);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(137, 25);
            textBox7.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 34);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 54;
            label2.Text = "Vasos de agua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 91);
            label4.Name = "label4";
            label4.Size = new Size(110, 17);
            label4.TabIndex = 56;
            label4.Text = "Consumo Tabaco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 146);
            label3.Name = "label3";
            label3.Size = new Size(147, 17);
            label3.TabIndex = 55;
            label3.Text = "Consumo Medicamento";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.Font = new Font("Times New Roman", 11.25F);
            textBox8.Location = new Point(145, 345);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(332, 122);
            textBox8.TabIndex = 61;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 346);
            label9.Name = "label9";
            label9.Size = new Size(105, 19);
            label9.TabIndex = 61;
            label9.Text = "Historial Clinico";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.Controls.Add(radioButton8);
            groupBox4.Controls.Add(radioButton9);
            groupBox4.Font = new Font("Times New Roman", 11.25F);
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
            radioButton8.Size = new Size(44, 21);
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
            radioButton9.Size = new Size(37, 21);
            radioButton9.TabIndex = 25;
            radioButton9.TabStop = true;
            radioButton9.Text = "Si";
            radioButton9.UseVisualStyleBackColor = true;
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
            dataGridView1.Location = new Point(0, 492);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(124, 175, 70);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(1386, 238);
            dataGridView1.TabIndex = 62;
            // 
            // frmExpediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 730);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox4);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExpediente";
            Text = "frmExpediente";
            Load += frmExpediente_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Label label1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
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
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
    }
}