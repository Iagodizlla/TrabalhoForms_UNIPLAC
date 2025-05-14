namespace Trabalho_Forms;

public class Leitor : Pessoa
{
    public List<Exemplar> ExemplaresLeitor { get; set; }
    public List<Emprestimo> EmprestimosLeitor { get; set; }
    public string Tipo { get; set; }
    public Leitor(string nome,
    DateTime nascimento,
    string cpf,
    string email,
    string telefone,
    string tipo) : base(nome, nascimento, cpf, email, telefone)

    {
        Tipo = tipo;
        ExemplaresLeitor = new List<Exemplar>();
        EmprestimosLeitor = new List<Emprestimo>();
    }
    public bool EmprestaItem(Exemplar exemplar, Leitor destino) { return false; }
    public bool DevolucaoItem(Exemplar exemplar, Leitor destino) { return false; }
    public bool DoaExemplar(Exemplar exemplar, Leitor destino) { return false; }
    public bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem) { return false; }
    public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
}
//Iago Henrique Schlemper