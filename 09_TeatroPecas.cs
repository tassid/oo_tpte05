using System;
using System.Collections.Generic;

class Peca
{
    public string Titulo { get; set; }
    public string Diretor { get; set; }
}

class Teatro
{
    public List<Peca> Programacao { get; set; } = new List<Peca>();

    public void AgendarPeca(Peca peca)
    {
        Programacao.Add(peca);
    }

    public void CancelarPeca(Peca peca)
    {
        Programacao.Remove(peca);
    }
}
