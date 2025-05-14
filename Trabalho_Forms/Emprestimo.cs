namespace Trabalho_Forms;

public class Emprestimo
{
    public Leitor Origem { get; set; }
    public Leitor Destino { get; set; }
    public Exemplar Item { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }
    public Emprestimo(Leitor origem,
    Leitor destino,
    Exemplar item,
    DateTime dataEmprestimo,
    DateTime dataDevolucao)
    {
        Origem = origem;
        Destino = destino;
        Item = item;
        DataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao;
    }
}
//Iago Henrique Schlemper