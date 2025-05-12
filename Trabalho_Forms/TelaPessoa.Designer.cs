namespace Trabalho_Forms
{
    partial class TelaPessoa
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
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            Leitor = new TabPage();
            label7 = new Label();
            listBox1 = new ListBox();
            Funcionario = new TabPage();
            label11 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            cargoFuncionario = new ComboBox();
            panel3 = new Panel();
            button1 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            Leitor.SuspendLayout();
            Funcionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 355);
            panel1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(3, 303);
            maskedTextBox2.Mask = "(00) 0000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(156, 27);
            maskedTextBox2.TabIndex = 11;
            maskedTextBox2.MaskInputRejected += telefonePessoa;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(3, 166);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(156, 27);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.MaskInputRejected += cpfPessoa;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(347, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += emailPessoa;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dataNascimentoPessoa;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += nomePessoa;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 280);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 4;
            label6.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 210);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 143);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 2;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 79);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(tabControl1);
            panel2.Location = new Point(401, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 355);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Leitor);
            tabControl1.Controls.Add(Funcionario);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(381, 349);
            tabControl1.TabIndex = 1;
            // 
            // Leitor
            // 
            Leitor.BackColor = Color.Transparent;
            Leitor.Controls.Add(label7);
            Leitor.Controls.Add(listBox1);
            Leitor.Location = new Point(4, 29);
            Leitor.Name = "Leitor";
            Leitor.Padding = new Padding(3);
            Leitor.Size = new Size(373, 316);
            Leitor.TabIndex = 0;
            Leitor.Text = "Leitor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 13);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 1;
            label7.Text = "Tipo";
            // 
            // listBox1
            // 
            listBox1.ForeColor = SystemColors.InfoText;
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Leitor Casual", "Leitor Avido", "Leitor de Ficcao", "Leitor de Nao Ficcao", "Leitor Critico", "Leitor de Best-sellers", "Leitor de Classicos", "Leitor de Genero Epscifico", "Leitor Academico", "Leitor Digital", "Leitor Tradicional", "Leitor de Livros de Bolso", "Leitor Multitarefa", "Outros" });
            listBox1.Location = new Point(18, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(337, 264);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listaLeitor;
            // 
            // Funcionario
            // 
            Funcionario.Controls.Add(label11);
            Funcionario.Controls.Add(textBox2);
            Funcionario.Controls.Add(label10);
            Funcionario.Controls.Add(label9);
            Funcionario.Controls.Add(numericUpDown2);
            Funcionario.Controls.Add(numericUpDown1);
            Funcionario.Controls.Add(label8);
            Funcionario.Controls.Add(cargoFuncionario);
            Funcionario.Location = new Point(4, 29);
            Funcionario.Name = "Funcionario";
            Funcionario.Padding = new Padding(3);
            Funcionario.Size = new Size(373, 316);
            Funcionario.TabIndex = 1;
            Funcionario.Text = "Funcionario";
            Funcionario.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 248);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 7;
            label11.Text = "Funcao";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += funcaoFuncionario;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 167);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 5;
            label10.Text = "Carga Horaria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 89);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 4;
            label9.Text = "Salario";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(21, 190);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDown2.ValueChanged += cargaHorariaFuncionario;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(21, 112);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.ValueChanged += salarioFuncionario;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 14);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 1;
            label8.Text = "Cargo";
            // 
            // cargoFuncionario
            // 
            cargoFuncionario.DisplayMember = "1";
            cargoFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cargoFuncionario.FormattingEnabled = true;
            cargoFuncionario.Items.AddRange(new object[] { "Gerente", "Atendente", "Caixa", "Estagiário" });
            cargoFuncionario.Location = new Point(21, 39);
            cargoFuncionario.Name = "cargoFuncionario";
            cargoFuncionario.Size = new Size(220, 28);
            cargoFuncionario.TabIndex = 0;
            cargoFuncionario.SelectedIndexChanged += cargaFuncionario;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(12, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 65);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(770, 59);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += botaoSalvarPessoa;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, -1);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Pessoa";
            // 
            // TelaPessoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TelaPessoa";
            Text = "TelaPessoa";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Leitor.ResumeLayout(false);
            Leitor.PerformLayout();
            Funcionario.ResumeLayout(false);
            Funcionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private PageSetupDialog pageSetupDialog1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TabControl tabControl1;
        private TabPage Leitor;
        private TabPage Funcionario;
        private ListBox listBox1;
        private Label label7;
        private Label label10;
        private Label label9;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private ComboBox cargoFuncionario;
        private Label label11;
        private TextBox textBox2;
    }
}