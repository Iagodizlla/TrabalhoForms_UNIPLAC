namespace Trabalho_Forms;

public partial class Biblioteca : Form
{
    public List<Funcionario> funcionarios;
    public List<Leitor> leitores;
    public List<Exemplar> exemplares;

    public Biblioteca()
    {
        InitializeComponent();
        funcionarios = new List<Funcionario>();
        leitores = new List<Leitor>();
        exemplares = new List<Exemplar>();
        CargaInicial();
    }
    private void CargaInicial()
    {
        leitores.Add(new Leitor("leitor 1", DateTime.Today, "cpf1", "email1", "tel1", "tipo1"));
        leitores.Add(new Leitor("leitor 2", DateTime.Today, "cpf2", "email2", "tel2", "tipo2"));
        leitores.Add(new Leitor("leitor 3", DateTime.Today, "cpf3", "email3", "tel3", "tipo3"));
        leitores.Add(new Leitor("leitor 4", DateTime.Today, "cpf3", "email4", "tel4", "tipo4"));
        leitores.Add(new Leitor("leitor 5", DateTime.Today, "cpf3", "email5", "tel5", "tipo5"));
        funcionarios.Add(new Funcionario("funcionário 1", DateTime.Today, "cpf1", "email1", "tel1", 0, 9999.99M, 8, "fun1"));
        funcionarios.Add(new Funcionario("funcionário 2", DateTime.Today, "cpf2", "email2", "tel2", 1, 3333.33M, 8, "fun1"));
        funcionarios.Add(new Funcionario("funcionário 3", DateTime.Today, "cpf3", "email3", "tel3", 3, 1024.00M, 6, "fun1"));
        funcionarios.Add(new Funcionario("funcionário 4", DateTime.Today, "cpf3", "email4", "tel4", 3, 1024.00M, 6, "fun1"));
        funcionarios.Add(new Funcionario("funcionário 5", DateTime.Today, "cpf3", "email5", "tel5", 2, 2222.22M, 8, "fun1"));
        exemplares.Add(new Livro("livro 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 100, "tipoCapa1", "isbn1"));
        exemplares.Add(new Livro("livro 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 112, "tipoCapa2", "isbn2"));
        exemplares.Add(new Livro("livro 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 132, "tipoCapa3", "isbn3"));
        exemplares.Add(new Livro("livro 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 234, "tipoCapa4", "isbn4"));
        exemplares.Add(new Livro("livro 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 432, "tipoCapa5", "isbn5"));
        exemplares.Add(new Ebook("ebook 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 123, "tipoCapa1", "isbn1", "formato1", 1, "url1"));
        exemplares.Add(new Ebook("ebook 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 321, "tipoCapa2", "isbn2", "formato2", 1, "url2"));
        exemplares.Add(new Ebook("ebook 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 987, "tipoCapa3", "isbn3", "formato3", 1, "url3"));
        exemplares.Add(new Ebook("ebook 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 31, "tipoCapa4", "isbn4", "formato4", 1, "url4"));
        exemplares.Add(new Ebook("ebook 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 909, "tipoCapa5", "isbn5", "formato5", 1, "url5"));
        exemplares.Add(new Revista("revista 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 324, 1));
        exemplares.Add(new Revista("revista 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 123, 1));
        exemplares.Add(new Revista("revista 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 654, 1));
        exemplares.Add(new Revista("revista 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 764, 1));
        exemplares.Add(new Revista("revista 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 234, 1));
        exemplares.Add(new Hq("hq 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 432, "ilustrador1"));
        exemplares.Add(new Hq("hq 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 542, "ilustrador2"));
        exemplares.Add(new Hq("hq 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 298, "ilustrador3"));
        exemplares.Add(new Hq("hq 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 342, "ilustrador4"));
        exemplares.Add(new Hq("hq 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 98, "ilustrador5"));
        exemplares.Add(new Generico("genérico 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 0));
        exemplares.Add(new Generico("genérico 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 1));
        exemplares.Add(new Generico("genérico 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 2));
        exemplares.Add(new Generico("genérico 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 3));
        exemplares.Add(new Generico("genérico 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 4));
    }

    private void AtualizarDataGridView()
    {
        // listar funcionarios no datagridview
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = funcionarios;
        // listar leitores no datagridview
        dataGridView2.DataSource = null;
        dataGridView2.DataSource = leitores;
        // listar exemplares no datagridview
        dataGridView3.DataSource = null;
        dataGridView3.DataSource = exemplares;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    #region Cadastrar
    private void button1_Click(object sender, EventArgs e)
    {
        var aux = new TelaPessoa(funcionarios, leitores);
        aux.StartPosition = FormStartPosition.CenterParent;
        aux.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var aux = new TelaExemplar(exemplares);
        aux.StartPosition = FormStartPosition.CenterParent;
        aux.ShowDialog();
    }
    #endregion
    #region Editar/Excluir
    private void dataGridViewFuncionarios(object sender, DataGridViewCellEventArgs e)
    {
        var funcionario = dataGridView1.CurrentRow.DataBoundItem as Funcionario;

        // validar se o objeto é nulo
        if (funcionario == null)

        {
            MessageBox.Show("Selecione um funcionário");
            return;
        }

        MessageBox.Show($"{ funcionario.GetType().Name }, {funcionario.Nome}");
        // abre a tela de edição de funcionário com o objeto selecionado
        var form = new TelaPessoa(funcionarios, funcionario);
        form.StartPosition = FormStartPosition.CenterParent;
        form.ShowDialog();
    }

    private void dataGridViewLeitores(object sender, DataGridViewCellEventArgs e)
    {
        var leitor = dataGridView2.CurrentRow.DataBoundItem as Leitor;

        // validar se o objeto é nulo
        if (leitor == null)
        {
            MessageBox.Show("Selecione um leitor");
            return;
        }
        MessageBox.Show($"{ leitor.GetType().Name }, {leitor.Nome}");
        // abre a tela de edição de leitor com o objeto selecionado
        var form = new TelaPessoa(leitores, leitor);
        form.StartPosition = FormStartPosition.CenterParent;
        form.ShowDialog();
    }

    private void dataGridViewExemplares(object sender, DataGridViewCellEventArgs e)
    {
        // armazena o objeto selecionado

        var exemplar = dataGridView3.CurrentRow.DataBoundItem as Exemplar;

        // validar se o objeto é nulo

        if (exemplar == null)

        {
            MessageBox.Show("Selecione um exemplar");
            return;
        }
        // como teste, mostra o tipo do objeto e o nome

        MessageBox.Show($"{exemplar.GetType().Name}, {exemplar.Titulo}");
        // abre a tela de edição de exemplar com o objeto selecionado
        var form = new TelaExemplar(exemplares, exemplar);
        form.StartPosition = FormStartPosition.CenterParent;
        form.ShowDialog();
    }
    #endregion

    private void Biblioteca_Activated(object sender, EventArgs e)
    {
        AtualizarDataGridView();
    }
}