using ProjetoFinalBiblioteca;

namespace Trabalho_Forms;

public partial class TelaPessoa : Form
{
    public List<Funcionario> funcionarios;
    public List<Leitor> leitores;
    public TelaPessoa(List<Funcionario> funcionarios, List<Leitor> leitores)
    {
        InitializeComponent();

        // carrega os valores do Enum para o combobox/Listbox
        cargoFuncionario.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
        cargoFuncionario.SelectedIndex = 0;
        this.funcionarios = funcionarios;
        this.leitores = leitores;
    }

    public void Form2_Load(object sender, EventArgs e)
    {

    }

    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void listaLeitor(object sender, EventArgs e)
    {

    }

    private void nomePessoa(object sender, EventArgs e)
    {

    }

    private void dataNascimentoPessoa(object sender, EventArgs e)
    {

    }

    private void cpfPessoa(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void emailPessoa(object sender, EventArgs e)
    {

    }

    private void telefonePessoa(object sender, MaskInputRejectedEventArgs e)
    {

    }

    public void cargaFuncionario(object sender, EventArgs e)
    {

    }

    private void salarioFuncionario(object sender, EventArgs e)
    {

    }

    private void cargaHorariaFuncionario(object sender, EventArgs e)
    {

    }

    private void funcaoFuncionario(object sender, EventArgs e)
    {

    }

    private void botaoSalvarPessoa(object sender, EventArgs e)
    {
        // leitura dos valores dos campos
        string auxNome = textBoxNome.Text;
        DateTime auxData = dateTimePickeNascimento.Value;
        string auxCpf = maskedTextBoxCPF.Text;
        string auxEmail = textBoxEmail.Text;
        string auxTelefone = maskedTextBoxTelefone.Text;
        if (tabControlPessoa.SelectedIndex == 0)
        {
            // leitura dos valores dos campos
            string auxTipo = listBoxTipo.SelectedItem.ToString();
            // cria o objeto leitor
            var leitor = new Leitor(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxTipo);
            // adicionar no list
            leitores.Add(leitor);
        }
        else
        {
            // leitura dos valores dos campos
            int auxCargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), cargoFuncionario.Text);
            decimal auxSalario = numericUpDownSalario.Value;
            int auxCargaHoraria = Convert.ToInt32(numericUpDownHoraria.Value);
            string auxFuncao = textBoxFuncao.Text;
            // cria o objeto funcionário e já adiciona diretamente
            funcionarios.Add(new Funcionario(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxCargo, auxSalario, auxCargaHoraria, auxFuncao));
        }
        MessageBox.Show("Pessoa cadastrada com sucesso!");
        Close();
    }
}
//Iago Henrique Schlemper