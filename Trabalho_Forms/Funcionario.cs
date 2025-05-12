namespace Trabalho_Forms;

public class Funcionario : Pessoa
{
    public string Cargo { get; set; }
    public decimal Salario { get; set; }
    public int CargaHoraria { get; set; }
    public string Funcao { get; set; }

    public Funcionario(string nome, DateTime nascimento, string cpf, string endereco, string telefone, string cargo, decimal salario, int cargaHoraria, string funcao)
        : base(nome, nascimento, cpf, endereco, telefone)
    {
        Cargo = cargo;
        Salario = salario;
        CargaHoraria = cargaHoraria;
        Funcao = funcao;
    }

    public override void ListaLeitor(Leitor leitor) { }
    public override void EditaLeitor(Leitor leitor) { }
    public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }

    public override string ToString() { return base.ToString()!; }
}
//Iago Henrique Schlemper