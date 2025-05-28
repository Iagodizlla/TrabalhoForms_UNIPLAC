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
            maskedTextBoxTelefone = new MaskedTextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            textBoxEmail = new TextBox();
            dateTimePickeNascimento = new DateTimePicker();
            textBoxNome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            tabControlPessoa = new TabControl();
            Leitor = new TabPage();
            panel4 = new Panel();
            button3 = new Button();
            label7 = new Label();
            listBoxTipo = new ListBox();
            button2 = new Button();
            Funcionario = new TabPage();
            label11 = new Label();
            textBoxFuncao = new TextBox();
            label10 = new Label();
            label9 = new Label();
            numericUpDownHoraria = new NumericUpDown();
            numericUpDownSalario = new NumericUpDown();
            label8 = new Label();
            cargoFuncionario = new ComboBox();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControlPessoa.SuspendLayout();
            Leitor.SuspendLayout();
            Funcionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoraria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(maskedTextBoxTelefone);
            panel1.Controls.Add(maskedTextBoxCPF);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(dateTimePickeNascimento);
            panel1.Controls.Add(textBoxNome);
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
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(3, 303);
            maskedTextBoxTelefone.Mask = "(00) 0000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(156, 27);
            maskedTextBoxTelefone.TabIndex = 11;
            maskedTextBoxTelefone.MaskInputRejected += telefonePessoa;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(3, 166);
            maskedTextBoxCPF.Mask = "000,000,000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(156, 27);
            maskedTextBoxCPF.TabIndex = 10;
            maskedTextBoxCPF.MaskInputRejected += cpfPessoa;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(3, 233);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(347, 27);
            textBoxEmail.TabIndex = 8;
            textBoxEmail.TextChanged += emailPessoa;
            // 
            // dateTimePickeNascimento
            // 
            dateTimePickeNascimento.Location = new Point(3, 102);
            dateTimePickeNascimento.Name = "dateTimePickeNascimento";
            dateTimePickeNascimento.Size = new Size(347, 27);
            dateTimePickeNascimento.TabIndex = 6;
            dateTimePickeNascimento.ValueChanged += dataNascimentoPessoa;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(3, 38);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(347, 27);
            textBoxNome.TabIndex = 5;
            textBoxNome.TextChanged += nomePessoa;
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
            panel2.Controls.Add(tabControlPessoa);
            panel2.Location = new Point(401, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 355);
            panel2.TabIndex = 1;
            // 
            // tabControlPessoa
            // 
            tabControlPessoa.Controls.Add(Leitor);
            tabControlPessoa.Controls.Add(Funcionario);
            tabControlPessoa.Location = new Point(3, 3);
            tabControlPessoa.Name = "tabControlPessoa";
            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.Size = new Size(940, 349);
            tabControlPessoa.TabIndex = 1;
            // 
            // Leitor
            // 
            Leitor.BackColor = Color.Transparent;
            Leitor.Controls.Add(panel4);
            Leitor.Controls.Add(button3);
            Leitor.Controls.Add(label7);
            Leitor.Controls.Add(listBoxTipo);
            Leitor.Controls.Add(button2);
            Leitor.Location = new Point(4, 29);
            Leitor.Name = "Leitor";
            Leitor.Padding = new Padding(3);
            Leitor.Size = new Size(932, 316);
            Leitor.TabIndex = 0;
            Leitor.Text = "Leitor";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Location = new Point(383, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(543, 229);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(699, 272);
            button3.Name = "button3";
            button3.Size = new Size(111, 29);
            button3.TabIndex = 4;
            button3.Text = "Del Exemplar";
            button3.UseVisualStyleBackColor = true;
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
            // listBoxTipo
            // 
            listBoxTipo.ForeColor = SystemColors.InfoText;
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.Items.AddRange(new object[] { "Leitor Casual", "Leitor Avido", "Leitor de Ficcao", "Leitor de Nao Ficcao", "Leitor Critico", "Leitor de Best-sellers", "Leitor de Classicos", "Leitor de Genero Epscifico", "Leitor Academico", "Leitor Digital", "Leitor Tradicional", "Leitor de Livros de Bolso", "Leitor Multitarefa", "Outros" });
            listBoxTipo.Location = new Point(18, 37);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(359, 264);
            listBoxTipo.TabIndex = 0;
            listBoxTipo.SelectedIndexChanged += listaLeitor;
            // 
            // button2
            // 
            button2.Location = new Point(467, 272);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 3;
            button2.Text = "Add Exemplar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Funcionario
            // 
            Funcionario.Controls.Add(label11);
            Funcionario.Controls.Add(textBoxFuncao);
            Funcionario.Controls.Add(label10);
            Funcionario.Controls.Add(label9);
            Funcionario.Controls.Add(numericUpDownHoraria);
            Funcionario.Controls.Add(numericUpDownSalario);
            Funcionario.Controls.Add(label8);
            Funcionario.Controls.Add(cargoFuncionario);
            Funcionario.Location = new Point(4, 29);
            Funcionario.Name = "Funcionario";
            Funcionario.Padding = new Padding(3);
            Funcionario.Size = new Size(932, 316);
            Funcionario.TabIndex = 1;
            Funcionario.Text = "Funcionario";
            Funcionario.UseVisualStyleBackColor = true;
            Funcionario.Click += Funcionario_Click;
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
            // textBoxFuncao
            // 
            textBoxFuncao.Location = new Point(21, 271);
            textBoxFuncao.Name = "textBoxFuncao";
            textBoxFuncao.Size = new Size(125, 27);
            textBoxFuncao.TabIndex = 6;
            textBoxFuncao.TextChanged += funcaoFuncionario;
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
            // numericUpDownHoraria
            // 
            numericUpDownHoraria.Location = new Point(21, 190);
            numericUpDownHoraria.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHoraria.Name = "numericUpDownHoraria";
            numericUpDownHoraria.Size = new Size(150, 27);
            numericUpDownHoraria.TabIndex = 3;
            numericUpDownHoraria.Value = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDownHoraria.ValueChanged += cargaHorariaFuncionario;
            // 
            // numericUpDownSalario
            // 
            numericUpDownSalario.DecimalPlaces = 2;
            numericUpDownSalario.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownSalario.Location = new Point(21, 112);
            numericUpDownSalario.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownSalario.Name = "numericUpDownSalario";
            numericUpDownSalario.Size = new Size(150, 27);
            numericUpDownSalario.TabIndex = 2;
            numericUpDownSalario.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSalario.ValueChanged += salarioFuncionario;
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
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(12, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(1335, 65);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(1095, 3);
            button5.Name = "button5";
            button5.Size = new Size(237, 59);
            button5.TabIndex = 2;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGreen;
            button4.Location = new Point(779, 3);
            button4.Name = "button4";
            button4.Size = new Size(310, 59);
            button4.TabIndex = 1;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            ClientSize = new Size(1359, 450);
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
            tabControlPessoa.ResumeLayout(false);
            Leitor.ResumeLayout(false);
            Leitor.PerformLayout();
            Funcionario.ResumeLayout(false);
            Funcionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoraria).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).EndInit();
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
        private TextBox textBoxEmail;
        private DateTimePicker dateTimePickeNascimento;
        private TextBox textBoxNome;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCPF;
        private TabControl tabControlPessoa;
        private TabPage Leitor;
        private TabPage Funcionario;
        private ListBox listBoxTipo;
        private Label label7;
        private Label label10;
        private Label label9;
        private NumericUpDown numericUpDownHoraria;
        private NumericUpDown numericUpDownSalario;
        private Label label8;
        private ComboBox cargoFuncionario;
        private Label label11;
        private TextBox textBoxFuncao;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
    }
}