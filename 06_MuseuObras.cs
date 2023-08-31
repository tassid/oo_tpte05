using System;
using System.Collections.Generic;

class Obra
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
}

class Museu
{
    public List<Obra> Exposicao { get; set; } = new List<Obra>();

    public void AdicionarObra(Obra obra)
    {
        Exposicao.Add(obra);
    }

    public void RemoverObra(Obra obra)
    {
        Exposicao.Remove(obra);
    }
}
