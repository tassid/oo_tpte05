using System;
using System.Collections.Generic;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
}

class Biblioteca
{
    public List<Livro> Livros { get; set; } = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }

    public void RemoverLivro(Livro livro)
    {
        Livros.Remove(livro);
    }
}
