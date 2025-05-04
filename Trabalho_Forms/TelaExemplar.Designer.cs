namespace Trabalho_Forms
{
    partial class TelaExemplar
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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 385);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 53);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(770, 60);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 367);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(402, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 367);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, -1);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "Exemplar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "SubTitulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Escritor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 154);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 7;
            label5.Text = "Editora";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 205);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 8;
            label6.Text = "Ano Publicacao";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 257);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 9;
            label7.Text = "Genero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 305);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 10;
            label8.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(326, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(326, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 275);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(326, 27);
            textBox5.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pendente", "Lido", "Emprestado", "Devolvido", "Perdido" });
            comboBox1.Location = new Point(3, 326);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 28);
            comboBox1.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(3, 227);
            numericUpDown1.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(165, 27);
            numericUpDown1.TabIndex = 17;
            numericUpDown1.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // TelaExemplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TelaExemplar";
            Text = "TelaExemplar";
            Load += TelaExemplar_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
    }
}