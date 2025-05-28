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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            generoExemplar = new ComboBox();
            numericUpDownPublicacao = new NumericUpDown();
            statusExemplar = new ComboBox();
            textBoxEditora = new TextBox();
            textBoxEscritor = new TextBox();
            textBoxSubTitulo = new TextBox();
            textBoxTitulo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            tabControlExemplar = new TabControl();
            Livro = new TabPage();
            painalEbook = new Panel();
            textBoxURL = new TextBox();
            label19 = new Label();
            numericUpDownTamanho = new NumericUpDown();
            label18 = new Label();
            comboBoxFormato = new ComboBox();
            label17 = new Label();
            checkEBook = new CheckBox();
            textBoxISBN = new TextBox();
            label11 = new Label();
            label10 = new Label();
            comboBoxCapa = new ComboBox();
            numericUpDownPaginas = new NumericUpDown();
            label9 = new Label();
            Revista = new TabPage();
            label13 = new Label();
            numericUpDownPagina = new NumericUpDown();
            label12 = new Label();
            numericUpDownEdicao = new NumericUpDown();
            HQ = new TabPage();
            textBoxIlustrador = new TextBox();
            label15 = new Label();
            label14 = new Label();
            numericUpDownEdicao2 = new NumericUpDown();
            Generico = new TabPage();
            listaGenerico = new ListBox();
            label16 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPublicacao).BeginInit();
            panel3.SuspendLayout();
            tabControlExemplar.SuspendLayout();
            Livro.SuspendLayout();
            painalEbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginas).BeginInit();
            Revista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicao).BeginInit();
            HQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicao2).BeginInit();
            Generico.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 76);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Location = new Point(594, 3);
            button3.Name = "button3";
            button3.Size = new Size(175, 70);
            button3.TabIndex = 2;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(389, 3);
            button2.Name = "button2";
            button2.Size = new Size(199, 70);
            button2.TabIndex = 1;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(4, 3);
            button1.Name = "button1";
            button1.Size = new Size(380, 70);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += botaoSalvarExemplar;
            // 
            // panel2
            // 
            panel2.Controls.Add(generoExemplar);
            panel2.Controls.Add(numericUpDownPublicacao);
            panel2.Controls.Add(statusExemplar);
            panel2.Controls.Add(textBoxEditora);
            panel2.Controls.Add(textBoxEscritor);
            panel2.Controls.Add(textBoxSubTitulo);
            panel2.Controls.Add(textBoxTitulo);
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
            // numericUpDownPublicacao
            // 
            numericUpDownPublicacao.Location = new Point(3, 227);
            numericUpDownPublicacao.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDownPublicacao.Name = "numericUpDownPublicacao";
            numericUpDownPublicacao.Size = new Size(165, 27);
            numericUpDownPublicacao.TabIndex = 17;
            numericUpDownPublicacao.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDownPublicacao.ValueChanged += AnoPublicacaoExemplar;
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
            // textBoxEditora
            // 
            textBoxEditora.Location = new Point(3, 175);
            textBoxEditora.Name = "textBoxEditora";
            textBoxEditora.Size = new Size(326, 27);
            textBoxEditora.TabIndex = 14;
            textBoxEditora.TextChanged += EditoraExemplar;
            // 
            // textBoxEscritor
            // 
            textBoxEscritor.Location = new Point(3, 124);
            textBoxEscritor.Name = "textBoxEscritor";
            textBoxEscritor.Size = new Size(326, 27);
            textBoxEscritor.TabIndex = 13;
            textBoxEscritor.TextChanged += EscritorExemplar;
            // 
            // textBoxSubTitulo
            // 
            textBoxSubTitulo.Location = new Point(3, 75);
            textBoxSubTitulo.Name = "textBoxSubTitulo";
            textBoxSubTitulo.Size = new Size(326, 27);
            textBoxSubTitulo.TabIndex = 12;
            textBoxSubTitulo.TextChanged += SubTituloExemplar;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(3, 24);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(326, 27);
            textBoxTitulo.TabIndex = 11;
            textBoxTitulo.TextChanged += TituloExemplar;
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
            panel3.Controls.Add(tabControlExemplar);
            panel3.Location = new Point(402, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 405);
            panel3.TabIndex = 2;
            // 
            // tabControlExemplar
            // 
            tabControlExemplar.Controls.Add(Livro);
            tabControlExemplar.Controls.Add(Revista);
            tabControlExemplar.Controls.Add(HQ);
            tabControlExemplar.Controls.Add(Generico);
            tabControlExemplar.Location = new Point(3, 7);
            tabControlExemplar.Name = "tabControlExemplar";
            tabControlExemplar.SelectedIndex = 0;
            tabControlExemplar.Size = new Size(380, 395);
            tabControlExemplar.TabIndex = 0;
            // 
            // Livro
            // 
            Livro.Controls.Add(painalEbook);
            Livro.Controls.Add(checkEBook);
            Livro.Controls.Add(textBoxISBN);
            Livro.Controls.Add(label11);
            Livro.Controls.Add(label10);
            Livro.Controls.Add(comboBoxCapa);
            Livro.Controls.Add(numericUpDownPaginas);
            Livro.Controls.Add(label9);
            Livro.Location = new Point(4, 29);
            Livro.Name = "Livro";
            Livro.Padding = new Padding(3);
            Livro.Size = new Size(372, 362);
            Livro.TabIndex = 0;
            Livro.Text = "Livro";
            Livro.UseVisualStyleBackColor = true;
            Livro.Click += Livro_Click;
            // 
            // painalEbook
            // 
            painalEbook.CausesValidation = false;
            painalEbook.Controls.Add(textBoxURL);
            painalEbook.Controls.Add(label19);
            painalEbook.Controls.Add(numericUpDownTamanho);
            painalEbook.Controls.Add(label18);
            painalEbook.Controls.Add(comboBoxFormato);
            painalEbook.Controls.Add(label17);
            painalEbook.Location = new Point(6, 191);
            painalEbook.Name = "painalEbook";
            painalEbook.Size = new Size(360, 165);
            painalEbook.TabIndex = 21;
            painalEbook.Paint += painalEbook_Paint;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(3, 143);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(354, 27);
            textBoxURL.TabIndex = 19;
            textBoxURL.TextChanged += URLEbook;
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
            // numericUpDownTamanho
            // 
            numericUpDownTamanho.Location = new Point(3, 79);
            numericUpDownTamanho.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDownTamanho.Name = "numericUpDownTamanho";
            numericUpDownTamanho.Size = new Size(165, 27);
            numericUpDownTamanho.TabIndex = 19;
            numericUpDownTamanho.ValueChanged += TamanhoEbook;
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
            // comboBoxFormato
            // 
            comboBoxFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormato.FormattingEnabled = true;
            comboBoxFormato.Items.AddRange(new object[] { "Portable Document Format (PDF)", "Electronic Publication (ePUB)", "Mobipocket (MOBI)", "Kindle Package Format (KPF)", "Outros" });
            comboBoxFormato.Location = new Point(3, 30);
            comboBoxFormato.Name = "comboBoxFormato";
            comboBoxFormato.Size = new Size(354, 28);
            comboBoxFormato.TabIndex = 6;
            comboBoxFormato.SelectedIndexChanged += FormatoEbook;
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
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(6, 133);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(326, 27);
            textBoxISBN.TabIndex = 19;
            textBoxISBN.TextChanged += ISBNLivro;
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
            // comboBoxCapa
            // 
            comboBoxCapa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCapa.FormattingEnabled = true;
            comboBoxCapa.Items.AddRange(new object[] { "Capa Dura", "Capa Flexível ou Brochura", "Capa de Papel Cartão", "Capa com Sobrecapa (Jacket) • Capa com Relevo", "Capa com Verniz UV", "Capa Metalizada", "Capa de Tecido", "Capa com Janela", "Capa Transparente", "Capa Digital" });
            comboBoxCapa.Location = new Point(6, 79);
            comboBoxCapa.Name = "comboBoxCapa";
            comboBoxCapa.Size = new Size(151, 28);
            comboBoxCapa.TabIndex = 2;
            comboBoxCapa.SelectedIndexChanged += TipoCapaLivro;
            // 
            // numericUpDownPaginas
            // 
            numericUpDownPaginas.Location = new Point(6, 26);
            numericUpDownPaginas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPaginas.Name = "numericUpDownPaginas";
            numericUpDownPaginas.Size = new Size(150, 27);
            numericUpDownPaginas.TabIndex = 1;
            numericUpDownPaginas.ValueChanged += PaginasLivro;
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
            Revista.Controls.Add(numericUpDownPagina);
            Revista.Controls.Add(label12);
            Revista.Controls.Add(numericUpDownEdicao);
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
            // numericUpDownPagina
            // 
            numericUpDownPagina.Location = new Point(6, 111);
            numericUpDownPagina.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPagina.Name = "numericUpDownPagina";
            numericUpDownPagina.Size = new Size(150, 27);
            numericUpDownPagina.TabIndex = 20;
            numericUpDownPagina.ValueChanged += PaginasRevista;
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
            // numericUpDownEdicao
            // 
            numericUpDownEdicao.Location = new Point(6, 39);
            numericUpDownEdicao.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownEdicao.Name = "numericUpDownEdicao";
            numericUpDownEdicao.Size = new Size(150, 27);
            numericUpDownEdicao.TabIndex = 0;
            numericUpDownEdicao.ValueChanged += EdicaoRevista;
            // 
            // HQ
            // 
            HQ.Controls.Add(textBoxIlustrador);
            HQ.Controls.Add(label15);
            HQ.Controls.Add(label14);
            HQ.Controls.Add(numericUpDownEdicao2);
            HQ.Location = new Point(4, 29);
            HQ.Name = "HQ";
            HQ.Size = new Size(372, 362);
            HQ.TabIndex = 2;
            HQ.Text = "HQ";
            HQ.UseVisualStyleBackColor = true;
            // 
            // textBoxIlustrador
            // 
            textBoxIlustrador.Location = new Point(3, 111);
            textBoxIlustrador.Name = "textBoxIlustrador";
            textBoxIlustrador.Size = new Size(326, 27);
            textBoxIlustrador.TabIndex = 19;
            textBoxIlustrador.TextChanged += IlustradorHQ;
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
            // numericUpDownEdicao2
            // 
            numericUpDownEdicao2.Location = new Point(3, 39);
            numericUpDownEdicao2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownEdicao2.Name = "numericUpDownEdicao2";
            numericUpDownEdicao2.Size = new Size(150, 27);
            numericUpDownEdicao2.TabIndex = 20;
            numericUpDownEdicao2.ValueChanged += EdicaoHQ;
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
            ClientSize = new Size(798, 511);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownPublicacao).EndInit();
            panel3.ResumeLayout(false);
            tabControlExemplar.ResumeLayout(false);
            Livro.ResumeLayout(false);
            Livro.PerformLayout();
            painalEbook.ResumeLayout(false);
            painalEbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanho).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginas).EndInit();
            Revista.ResumeLayout(false);
            Revista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPagina).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicao).EndInit();
            HQ.ResumeLayout(false);
            HQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicao2).EndInit();
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
        private TextBox textBoxEditora;
        private TextBox textBoxEscritor;
        private TextBox textBoxSubTitulo;
        private TextBox textBoxTitulo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDownPublicacao;
        private ComboBox statusExemplar;
        private ComboBox generoExemplar;
        private TabControl tabControlExemplar;
        private TabPage Livro;
        private Label label10;
        private ComboBox comboBoxCapa;
        private NumericUpDown numericUpDownPaginas;
        private Label label9;
        private TabPage Revista;
        private TabPage HQ;
        private TabPage Generico;
        private TextBox textBoxISBN;
        private Label label11;
        private Label label13;
        private NumericUpDown numericUpDownPagina;
        private Label label12;
        private NumericUpDown numericUpDownEdicao;
        private TextBox textBoxIlustrador;
        private Label label15;
        private Label label14;
        private NumericUpDown numericUpDownEdicao2;
        private Label label16;
        private ListBox listaGenerico;
        private ComboBox comboBoxFormato;
        private Label label17;
        private CheckBox checkEBook;
        private TextBox textBoxURL;
        private Label label19;
        private NumericUpDown numericUpDownTamanho;
        private Label label18;
        public Panel painalEbook;
        private Button button3;
        private Button button2;
    }
}