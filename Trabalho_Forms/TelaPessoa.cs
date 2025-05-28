using ProjetoFinalBiblioteca;
using System.Numerics;

namespace Trabalho_Forms;

public partial class TelaPessoa : Form
{
    public List<Funcionario> funcionarios;
    public List<Leitor> leitores;
    Funcionario funcionario;
    Leitor leitor;


    public TelaPessoa(List<Funcionario> funcionarios, List<Leitor> leitores)
    {
        InitializeComponent();
        // atribui o objeto recebido à variável com escopo de classe
        this.funcionarios = funcionarios;
        // carrega os valores do Enum para o combobox
        cargoFuncionario.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
        cargoFuncionario.SelectedIndex = 0;

    }

    public TelaPessoa(List<Leitor> leitores, Leitor leitor)
    {
        InitializeComponent();
        // atribui o objeto recebido à variável com escopo de classe
        this.leitores = leitores;
        this.leitor = leitor;
        // carrega os valores do objeto recebido
        listBoxTipo.SelectedIndex = 0;
        // carrega os valores do Enum para o combobox
        textBoxNome.Text = leitor.Nome;
        dateTimePickeNascimento.Value = leitor.Nascimento;
        maskedTextBoxCPF.Text = leitor.Cpf;
        textBoxEmail.Text = leitor.Email;
        maskedTextBoxTelefone.Text = leitor.Telefone;
        listBoxTipo.SelectedItem = leitor.Tipo;
        tabControlPessoa.SelectedIndex = 0;
        tabControlPessoa.TabPages[1].Enabled = false;
        button1.Enabled = false;

    }

    public TelaPessoa(List<Funcionario> funcionarios, Funcionario funcionario)
    {
        InitializeComponent();
        // atribui o objeto recebido à variável com escopo de classe
        this.funcionarios = funcionarios;
        this.funcionario = funcionario;
        // carrega os valores do Enum para o combobox
        cargoFuncionario.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
        cargoFuncionario.SelectedIndex = 0;
        // carrega os valores do objeto recebido
        textBoxNome.Text = funcionario.Nome;
        dateTimePickeNascimento.Value = funcionario.Nascimento;
        maskedTextBoxCPF.Text = funcionario.Cpf;
        textBoxEmail.Text = funcionario.Email;
        maskedTextBoxTelefone.Text = funcionario.Telefone;
        cargoFuncionario.Text = "" + (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), funcionario.Cargo.ToString());
        numericUpDownSalario.Value = funcionario.Salario;
        numericUpDownHoraria.Value = funcionario.CargaHoraria;
        textBoxFuncao.Text = funcionario.Funcao;
        tabControlPessoa.SelectedIndex = 1;
        tabControlPessoa.TabPages[0].Enabled = false;
        button1.Enabled = false;
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

    private void Funcionario_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (tabControlPessoa.SelectedIndex == 0)
        {
            // atualiza os dados no objeto
            leitor.Nome = textBoxNome.Text;
            leitor.Nascimento = dateTimePickeNascimento.Value;
            leitor.Cpf = maskedTextBoxCPF.Text;
            leitor.Email = textBoxEmail.Text;
            leitor.Telefone = maskedTextBoxTelefone.Text;
            leitor.Tipo = listBoxTipo.SelectedItem.ToString();
        }
        else
        {
            // atualiza os dados no objeto
            funcionario.Nome = textBoxNome.Text;
            funcionario.Nascimento = dateTimePickeNascimento.Value;
            funcionario.Cpf = maskedTextBoxCPF.Text;
            funcionario.Email = textBoxEmail.Text;
            funcionario.Telefone = maskedTextBoxTelefone.Text;
            funcionario.Cargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), cargoFuncionario.Text);
            funcionario.Salario = numericUpDownSalario.Value;
            funcionario.CargaHoraria = Convert.ToInt32(numericUpDownHoraria.Value);
            funcionario.Funcao = textBoxFuncao.Text;
        }
        MessageBox.Show("Pessoa editada com sucesso!");
        Close();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (tabControlPessoa.SelectedIndex == 0)
        {
            // exclui o objeto
            leitores.Remove(leitor);
        }
        else
        {
            // exclui o objeto
            funcionarios.Remove(funcionario);
        }
        MessageBox.Show("Pessoa excluída com sucesso!");
        Close();
    }
}
//Iago Henrique Schlemper