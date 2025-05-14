using ProjetoFinalBiblioteca;
using System.Windows.Forms.VisualStyles;

namespace Trabalho_Forms
{
    public partial class TelaExemplar : Form
    {
        public List<Exemplar> exemplares;
        public TelaExemplar(List<Exemplar> exemplares)
        {
            InitializeComponent();
            // carrega os valores do Enum para o combobox/Listbox
            statusExemplar.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            statusExemplar.SelectedIndex = 0;
            listaGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listaGenerico.SelectedIndex = 0;
            this.exemplares = exemplares;
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
    }
}
//Iago Henrique Schlemper