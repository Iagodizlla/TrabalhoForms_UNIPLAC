namespace Trabalho_Forms;

// Classe Ebook (herda de Livro)
public class Ebook : Livro, Dados
{
    public string Formato { get; set; }
    public decimal Tamanho { get; set; }
    public string Url { get; set; }

    public Ebook(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, int status, string formato, decimal tamanho, string url, int paginas, string tipoCapa, string isbn)
        : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status, paginas, tipoCapa, isbn)
    {
        Formato = formato;
        Tamanho = tamanho;
        Url = url;
    }
    public override string ToString()
    {
        return $"[Ebook] {Titulo} - URL: {Url}";
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Titulo: {Titulo}, Subtitulo: {SubTitulo}, Escritor: {Escritor}, Editora: {Editora}, Ano de Publicacao: {AnoPublicacao}" +
            $", Genero: {Genero}, Status: {Status}, Formato: {Formato}, Tamanho: {Tamanho}, URL: {Url},Paginas: {Paginas}" +
            $", Tipo de Capa: {TipoCapa}, ISBN: {Isbn}");
    }
}
//Iago Henrique Schlemper