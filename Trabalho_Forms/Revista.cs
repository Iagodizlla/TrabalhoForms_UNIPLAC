﻿namespace Trabalho_Forms;

// Classe Revista
public class Revista : Exemplar
{
    public int Edicao { get; set; }
    public int Paginas { get; set; }
    public Revista(string titulo,
    string subTitulo,
    string escritor,
    string editora,
    int anoPublicacao,
    string genero,
    int status,
    int edicao,
    int paginas) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)

    {
        Edicao = edicao;
        Paginas = paginas;
    }
    public override string ToString()
    {
        return "";
    }
}
//Iago Henrique Schlemper