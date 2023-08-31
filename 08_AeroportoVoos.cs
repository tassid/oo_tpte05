using System;
using System.Collections.Generic;

class Voo
{
    public string Numero { get; set; }
    public string Destino { get; set; }
}

class Aeroporto
{
    public List<Voo> Voos { get; set; } = new List<Voo>();

    public void AdicionarVoo(Voo voo)
    {
        Voos.Add(voo);
    }

    public void CancelarVoo(Voo voo)
    {
        Voos.Remove(voo);
    }
}
