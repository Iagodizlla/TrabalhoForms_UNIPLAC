namespace Trabalho_Forms;

public class Leitor : Pessoa
{
    public List<Exemplar> ExemplaresLeitor { get; set; }
    public List<Emprestimo> EmprestimosLeitor { get; set; }
    public string Tipo { get; set; }

    public Leitor(List<Exemplar> exemplaresLeitor, List<Emprestimo> emprestimosLeitor, string tipo, string nome, DateTime nascimento, string cpf, string email, string telefone)
        : base(nome, nascimento, cpf, email, telefone)
    {
        ExemplaresLeitor = exemplaresLeitor;
        EmprestimosLeitor = emprestimosLeitor;
        Tipo = tipo;
    }

    public override void ListaLeitor(Leitor leitor) { }
    public override void EditaLeitor(Leitor leitor) { }
    public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }

    public override string ToString() { return base.ToString(); }
}
