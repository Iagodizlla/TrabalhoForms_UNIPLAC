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
            generoExemplar = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            statusExemplar = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            Livro = new TabPage();
            painalEbook = new Panel();
            textBox7 = new TextBox();
            label19 = new Label();
            numericUpDown6 = new NumericUpDown();
            label18 = new Label();
            comboBox4 = new ComboBox();
            label17 = new Label();
            checkEBook = new CheckBox();
            textBox5 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            comboBox3 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            label9 = new Label();
            Revista = new TabPage();
            label13 = new Label();
            numericUpDown4 = new NumericUpDown();
            label12 = new Label();
            numericUpDown3 = new NumericUpDown();
            HQ = new TabPage();
            textBox6 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            numericUpDown5 = new NumericUpDown();
            Generico = new TabPage();
            listaGenerico = new ListBox();
            label16 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            Livro.SuspendLayout();
            painalEbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            Revista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            HQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            Generico.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 39);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(770, 33);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += botaoSalvarExemplar;
            // 
            // panel2
            // 
            panel2.Controls.Add(generoExemplar);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(statusExemplar);
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
            panel2.Size = new Size(384, 405);
            panel2.TabIndex = 1;
            // 
            // generoExemplar
            // 
            generoExemplar.DropDownStyle = ComboBoxStyle.DropDownList;
            generoExemplar.FormattingEnabled = true;
            generoExemplar.Items.AddRange(new object[] { "Romance", "Novela", "Conto", "Crônica", "Poema", "Canção", "Drama histórico", "Teatro de vanguarda" });
            generoExemplar.Location = new Point(3, 274);
            generoExemplar.Name = "generoExemplar";
            generoExemplar.Size = new Size(219, 28);
            generoExemplar.TabIndex = 18;
            generoExemplar.SelectedIndexChanged += GeneroExemplar;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(3, 227);
            numericUpDown1.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(165, 27);
            numericUpDown1.TabIndex = 17;
            numericUpDown1.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDown1.ValueChanged += AnoPublicacaoExemplar;
            // 
            // statusExemplar
            // 
            statusExemplar.DropDownStyle = ComboBoxStyle.DropDownList;
            statusExemplar.FormattingEnabled = true;
            statusExemplar.Items.AddRange(new object[] { "Pendente", "Lido", "Emprestado", "Devolvido", "Perdido" });
            statusExemplar.Location = new Point(3, 326);
            statusExemplar.Name = "statusExemplar";
            statusExemplar.Size = new Size(219, 28);
            statusExemplar.TabIndex = 16;
            statusExemplar.SelectedIndexChanged += StatusExemplar;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(326, 27);
            textBox4.TabIndex = 14;
            textBox4.TextChanged += EditoraExemplar;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(326, 27);
            textBox3.TabIndex = 13;
            textBox3.TextChanged += EscritorExemplar;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 27);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += SubTituloExemplar;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += TituloExemplar;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 257);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 9;
            label7.Text = "Genero";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 154);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 7;
            label5.Text = "Editora";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "SubTitulo";
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
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Location = new Point(402, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 405);
            panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Livro);
            tabControl1.Controls.Add(Revista);
            tabControl1.Controls.Add(HQ);
            tabControl1.Controls.Add(Generico);
            tabControl1.Location = new Point(3, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(380, 395);
            tabControl1.TabIndex = 0;
            // 
            // Livro
            // 
            Livro.Controls.Add(painalEbook);
            Livro.Controls.Add(checkEBook);
            Livro.Controls.Add(textBox5);
            Livro.Controls.Add(label11);
            Livro.Controls.Add(label10);
            Livro.Controls.Add(comboBox3);
            Livro.Controls.Add(numericUpDown2);
            Livro.Controls.Add(label9);
            Livro.Location = new Point(4, 29);
            Livro.Name = "Livro";
            Livro.Padding = new Padding(3);
            Livro.Size = new Size(372, 362);
            Livro.TabIndex = 0;
            Livro.Text = "Livro";
            Livro.UseVisualStyleBackColor = true;
            // 
            // painalEbook
            // 
            painalEbook.CausesValidation = false;
            painalEbook.Controls.Add(textBox7);
            painalEbook.Controls.Add(label19);
            painalEbook.Controls.Add(numericUpDown6);
            painalEbook.Controls.Add(label18);
            painalEbook.Controls.Add(comboBox4);
            painalEbook.Controls.Add(label17);
            painalEbook.Location = new Point(6, 191);
            painalEbook.Name = "painalEbook";
            painalEbook.Size = new Size(360, 165);
            painalEbook.TabIndex = 21;
            painalEbook.Paint += painalEbook_Paint;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 143);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(354, 27);
            textBox7.TabIndex = 19;
            textBox7.TextChanged += URLEbook;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 115);
            label19.Name = "label19";
            label19.Size = new Size(35, 20);
            label19.TabIndex = 20;
            label19.Text = "URL";
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(3, 79);
            numericUpDown6.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(165, 27);
            numericUpDown6.TabIndex = 19;
            numericUpDown6.ValueChanged += TamanhoEbook;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 58);
            label18.Name = "label18";
            label18.Size = new Size(69, 20);
            label18.TabIndex = 18;
            label18.Text = "Tamanho";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Portable Document Format (PDF)", "Electronic Publication (ePUB)", "Mobipocket (MOBI)", "Kindle Package Format (KPF)", "Outros" });
            comboBox4.Location = new Point(3, 30);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(354, 28);
            comboBox4.TabIndex = 6;
            comboBox4.SelectedIndexChanged += FormatoEbook;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 8);
            label17.Name = "label17";
            label17.Size = new Size(65, 20);
            label17.TabIndex = 5;
            label17.Text = "Formato";
            // 
            // checkEBook
            // 
            checkEBook.AutoSize = true;
            checkEBook.Location = new Point(6, 165);
            checkEBook.Name = "checkEBook";
            checkEBook.Size = new Size(73, 24);
            checkEBook.TabIndex = 20;
            checkEBook.Text = "EBook";
            checkEBook.UseVisualStyleBackColor = true;
            checkEBook.CheckedChanged += TelaExemplar_Load;
            checkEBook.Paint += painalEbook_Paint;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(326, 27);
            textBox5.TabIndex = 19;
            textBox5.TextChanged += ISBNLivro;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 110);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 4;
            label11.Text = "ISBN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 56);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 3;
            label10.Text = "Tipo de capa";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Capa Dura", "Capa Flexível ou Brochura", "Capa de Papel Cartão", "Capa com Sobrecapa (Jacket) • Capa com Relevo", "Capa com Verniz UV", "Capa Metalizada", "Capa de Tecido", "Capa com Janela", "Capa Transparente", "Capa Digital" });
            comboBox3.Location = new Point(6, 79);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += TipoCapaLivro;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(6, 26);
            numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.ValueChanged += PaginasLivro;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 0;
            label9.Text = "Paginas";
            // 
            // Revista
            // 
            Revista.Controls.Add(label13);
            Revista.Controls.Add(numericUpDown4);
            Revista.Controls.Add(label12);
            Revista.Controls.Add(numericUpDown3);
            Revista.Location = new Point(4, 29);
            Revista.Name = "Revista";
            Revista.Padding = new Padding(3);
            Revista.Size = new Size(372, 362);
            Revista.TabIndex = 1;
            Revista.Text = "Revista";
            Revista.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 90);
            label13.Name = "label13";
            label13.Size = new Size(59, 20);
            label13.TabIndex = 21;
            label13.Text = "Paginas";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(6, 111);
            numericUpDown4.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(150, 27);
            numericUpDown4.TabIndex = 20;
            numericUpDown4.ValueChanged += PaginasRevista;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 18);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 19;
            label12.Text = "Edicao";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(6, 39);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(150, 27);
            numericUpDown3.TabIndex = 0;
            numericUpDown3.ValueChanged += EdicaoRevista;
            // 
            // HQ
            // 
            HQ.Controls.Add(textBox6);
            HQ.Controls.Add(label15);
            HQ.Controls.Add(label14);
            HQ.Controls.Add(numericUpDown5);
            HQ.Location = new Point(4, 29);
            HQ.Name = "HQ";
            HQ.Size = new Size(372, 362);
            HQ.TabIndex = 2;
            HQ.Text = "HQ";
            HQ.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(3, 111);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(326, 27);
            textBox6.TabIndex = 19;
            textBox6.TextChanged += IlustradorHQ;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 90);
            label15.Name = "label15";
            label15.Size = new Size(72, 20);
            label15.TabIndex = 23;
            label15.Text = "Ilustrador";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 18);
            label14.Name = "label14";
            label14.Size = new Size(54, 20);
            label14.TabIndex = 21;
            label14.Text = "Edicao";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(3, 39);
            numericUpDown5.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(150, 27);
            numericUpDown5.TabIndex = 20;
            numericUpDown5.ValueChanged += EdicaoHQ;
            // 
            // Generico
            // 
            Generico.Controls.Add(listaGenerico);
            Generico.Controls.Add(label16);
            Generico.Location = new Point(4, 29);
            Generico.Name = "Generico";
            Generico.Size = new Size(372, 362);
            Generico.TabIndex = 3;
            Generico.Text = "Generico";
            Generico.UseVisualStyleBackColor = true;
            // 
            // listaGenerico
            // 
            listaGenerico.FormattingEnabled = true;
            listaGenerico.Items.AddRange(new object[] { "Jornais", "Calendários e Agendas", "Mapas e Atlas", "Postais e Cartões de Saudação", "Papéis de Presente e Material de Embalagem", "DVDs e Blu-rays", "CDs e Vinis", "K7", "Jogos de Tabuleiro e Quebra-Cabeças", "Material de Papelaria e Escritório", "Produtos Relacionados à Cultura Pop", "Audiolivros", "Outros" });
            listaGenerico.Location = new Point(17, 41);
            listaGenerico.Name = "listaGenerico";
            listaGenerico.Size = new Size(335, 264);
            listaGenerico.TabIndex = 25;
            listaGenerico.SelectedIndexChanged += TipoGenerico;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 18);
            label16.Name = "label16";
            label16.Size = new Size(39, 20);
            label16.TabIndex = 24;
            label16.Text = "Tipo";
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
            // TelaExemplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
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
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Livro.ResumeLayout(false);
            Livro.PerformLayout();
            painalEbook.ResumeLayout(false);
            painalEbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            Revista.ResumeLayout(false);
            Revista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            HQ.ResumeLayout(false);
            HQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            Generico.ResumeLayout(false);
            Generico.PerformLayout();
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private ComboBox statusExemplar;
        private ComboBox generoExemplar;
        private TabControl tabControl1;
        private TabPage Livro;
        private Label label10;
        private ComboBox comboBox3;
        private NumericUpDown numericUpDown2;
        private Label label9;
        private TabPage Revista;
        private TabPage HQ;
        private TabPage Generico;
        private TextBox textBox5;
        private Label label11;
        private Label label13;
        private NumericUpDown numericUpDown4;
        private Label label12;
        private NumericUpDown numericUpDown3;
        private TextBox textBox6;
        private Label label15;
        private Label label14;
        private NumericUpDown numericUpDown5;
        private Label label16;
        private ListBox listaGenerico;
        private ComboBox comboBox4;
        private Label label17;
        private CheckBox checkEBook;
        private TextBox textBox7;
        private Label label19;
        private NumericUpDown numericUpDown6;
        private Label label18;
        public Panel painalEbook;
    }
}