﻿namespace ClinicaBD
{
    partial class frmPagos
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            pnlTitulo = new Panel();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(290, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(847, 248);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(570, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 29);
            textBox1.TabIndex = 30;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(151, 152);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(236, 29);
            comboBox4.TabIndex = 29;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(151, 72);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(236, 29);
            comboBox3.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F);
            label6.Location = new Point(417, 157);
            label6.Name = "label6";
            label6.Size = new Size(154, 18);
            label6.TabIndex = 21;
            label6.Text = "Cantidad Pagada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(502, 77);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 18;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(570, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 29);
            dateTimePicker1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(6, 163);
            label3.Name = "label3";
            label3.Size = new Size(143, 18);
            label3.TabIndex = 15;
            label3.Text = "Numero de Cita:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(54, 82);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 13;
            label2.Text = "Paciente:";
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(124, 175, 32);
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Location = new Point(285, 12);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(333, 57);
            pnlTitulo.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de Pagos";
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(818, 362);
            button2.Name = "button2";
            button2.Size = new Size(203, 61);
            button2.TabIndex = 25;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(589, 362);
            button1.Name = "button1";
            button1.Size = new Size(203, 61);
            button1.TabIndex = 24;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 429);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1245, 290);
            dataGridView1.TabIndex = 23;
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 730);
            Controls.Add(groupBox1);
            Controls.Add(pnlTitulo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPagos";
            Text = "frmPagos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label6;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Panel pnlTitulo;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}