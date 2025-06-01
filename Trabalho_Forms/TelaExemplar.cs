using ProjetoFinalBiblioteca;
using System.Windows.Forms.VisualStyles;

namespace Trabalho_Forms
{
    public partial class TelaExemplar : Form
    {
        public List<Exemplar> exemplares;
        Exemplar exemplar;

        public TelaExemplar(List<Exemplar> exemplares)
        {
            InitializeComponent();
            // atribui o objeto recebido à variável com escopo de classe
            this.exemplares = exemplares;
            // carrega os valores do Enum para o combobox
            statusExemplar.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            statusExemplar.SelectedIndex = 0;
            listaGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listaGenerico.SelectedIndex = 0;
        }
        public TelaExemplar(List<Exemplar> exemplares, Exemplar exemplar)
        {
            InitializeComponent();
            // atribui a lista de exemplares recebida à variável com escopo de classe
            this.exemplares = exemplares;
            this.exemplar = exemplar;
            checkEBook.Enabled = false;
            // carrega os valores do Enum para o combobox/listbox
            statusExemplar.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            statusExemplar.SelectedIndex = 0;
            listaGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listaGenerico.SelectedIndex = 0;
            // verifica o tipo do exemplar, e carrega os valores nos campos da tela
            if (exemplar is Livro || exemplar is Ebook)
            {
                // livro e ebook
                textBoxTitulo.Text = exemplar.Titulo;
                textBoxSubTitulo.Text = exemplar.SubTitulo;
                textBoxEscritor.Text = exemplar.Escritor;
                textBoxEditora.Text = exemplar.Editora;
                numericUpDownPublicacao.Value = exemplar.AnoPublicacao;
                generoExemplar.Text = exemplar.Genero;
                statusExemplar.Text = "" + (EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), exemplar.Status.ToString());
                numericUpDownPaginas.Value = ((Livro)exemplar).Paginas;
                comboBoxCapa.Text = ((Livro)exemplar).TipoCapa;
                textBoxISBN.Text = ((Livro)exemplar).Isbn;
                checkEBook.Checked = false;
                if (exemplar is Ebook)
                {
                    checkEBook.Checked = true;
                    comboBoxFormato.Text = ((Ebook)exemplar).Formato;
                    numericUpDownTamanho.Value = ((Ebook)exemplar).Tamanho;
                    textBoxURL.Text = ((Ebook)exemplar).Url;
                }
            }
            else if (exemplar is Revista revista)
            {
                numericUpDownEdicao.Value = revista.Edicao;
                numericUpDownPagina.Value = revista.Paginas;
            }
            else if (exemplar is Hq hq)
            {
                numericUpDownEdicao2.Value = hq.Edicao;
                textBoxIlustrador.Text = hq.Ilustrador;
            }
            else if (exemplar is Generico)
            {
                listaGenerico.Text = "" + (EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), ((Generico)exemplar).Tipo.ToString());
            }
        }

        private void TelaExemplar_Load(object sender, EventArgs e)
        {
            painalEbook.Enabled = checkEBook.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TipoCapaLivro(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoSalvarExemplar(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxTitulo = textBoxTitulo.Text;
            string auxSubTitulo = textBoxSubTitulo.Text;
            string auxEscritor = textBoxEscritor.Text;
            string auxEditora = textBoxEditora.Text;
            int auxAnoPublicacao = Convert.ToInt32(numericUpDownPublicacao.Value);
            string auxGenero = generoExemplar.Text;
            int auxStatus = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), statusExemplar.Text);
            if (tabControlExemplar.SelectedIndex == 0)
            {
                // livro e ebook
                // leitura dos valores dos campos
                int auxPaginas = Convert.ToInt32(numericUpDownPaginas.Value);
                string auxTipoCapa = comboBoxCapa.Text;
                string auxIsbn = textBoxISBN.Text;
                if (!checkEBook.Checked)
                {
                    // livro
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Livro(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn));
                }
                else
                {
                    // ebook
                    // leitura dos valores dos campos
                    string auxFormato = comboBoxFormato.Text;
                    decimal auxTamanho = numericUpDownTamanho.Value;
                    string auxUrl = textBoxURL.Text;
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new Ebook(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn, auxFormato, auxTamanho, auxUrl));
                }
            }
            else if (tabControlExemplar.SelectedIndex == 1)
            {
                // revista
                // leitura dos valores dos campos
                int auxEdicaoRevista = Convert.ToInt32(numericUpDownEdicao.Value);
                int auxPaginasRevista = Convert.ToInt32(numericUpDownPagina.Value);
                // cria o objeto e já adiciona no List
                exemplares.Add(new Revista(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoRevista, auxPaginasRevista));
            }
            else if (tabControlExemplar.SelectedIndex == 2)
            {
                // hq
                // leitura dos valores dos campos
                int auxEdicaoHq = Convert.ToInt32(numericUpDownEdicao2.Value);
                string auxIlustrador = textBoxIlustrador.Text;
                // cria o objeto e já adiciona no List
                exemplares.Add(new Hq(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoHq, auxIlustrador));
            }
            else if (tabControlExemplar.SelectedIndex == 3)
            {
                // generico
                // leitura dos valores dos campos
                int auxTipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), listaGenerico.Text);
                // cria o objeto e já adiciona no List
                exemplares.Add(new Generico(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxTipo));
            }
            MessageBox.Show("Exemplar cadastrado com sucesso!");
            Close();
        }

        private void painalEbook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StatusExemplar(object sender, EventArgs e)
        {

        }

        private void GeneroExemplar(object sender, EventArgs e)
        {

        }

        private void TituloExemplar(object sender, EventArgs e)
        {

        }

        private void SubTituloExemplar(object sender, EventArgs e)
        {

        }

        private void EscritorExemplar(object sender, EventArgs e)
        {

        }

        private void EditoraExemplar(object sender, EventArgs e)
        {

        }

        private void AnoPublicacaoExemplar(object sender, EventArgs e)
        {

        }

        private void PaginasLivro(object sender, EventArgs e)
        {

        }

        private void ISBNLivro(object sender, EventArgs e)
        {

        }

        private void FormatoEbook(object sender, EventArgs e)
        {

        }

        private void TamanhoEbook(object sender, EventArgs e)
        {

        }

        private void URLEbook(object sender, EventArgs e)
        {

        }

        private void EdicaoRevista(object sender, EventArgs e)
        {

        }

        private void PaginasRevista(object sender, EventArgs e)
        {

        }

        private void EdicaoHQ(object sender, EventArgs e)
        {

        }

        private void IlustradorHQ(object sender, EventArgs e)
        {

        }

        private void TipoGenerico(object sender, EventArgs e)
        {

        }

        private void Livro_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            exemplar.Titulo = textBoxTitulo.Text;
            exemplar.SubTitulo = textBoxSubTitulo.Text;
            exemplar.Escritor = textBoxEscritor.Text;
            exemplar.Editora = textBoxEditora.Text;
            exemplar.AnoPublicacao = Convert.ToInt32(numericUpDownPublicacao.Value);
            exemplar.Genero = generoExemplar.Text;
            exemplar.Status = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), statusExemplar.Text);
            if (exemplar is Livro livro)
            {
                livro.Paginas = Convert.ToInt32(numericUpDownPaginas.Value);
                livro.TipoCapa = comboBoxCapa.Text;
                livro.Isbn = textBoxISBN.Text;
            }
            else if (exemplar is Ebook ebook)
            {
                ebook.Paginas = Convert.ToInt32(numericUpDownPaginas.Value);
                ebook.TipoCapa = comboBoxCapa.Text;
                ebook.Isbn = textBoxISBN.Text;
                ebook.Formato = comboBoxFormato.Text;
                ebook.Tamanho = numericUpDownTamanho.Value;
                ebook.Url = textBoxURL.Text;
            }
            else if (exemplar is Revista revista)
            {
                revista.Edicao = Convert.ToInt32(numericUpDownEdicao.Value);
                revista.Paginas = Convert.ToInt32(numericUpDownPagina.Value);
            }
            else if (exemplar is Hq hq)
            {
                hq.Edicao = Convert.ToInt32(numericUpDownEdicao2.Value);
                hq.Ilustrador = textBoxIlustrador.Text;
            }
            else if (exemplar is Generico generico)
            {
                generico.Tipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), listaGenerico.Text);
            }
            MessageBox.Show("Exemplar editado com sucesso!");
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exemplares.Remove(exemplar);
            MessageBox.Show("Exemplar excluido com sucesso!");
            Close();
        }
    }
}
//Iago Henrique Schlemper