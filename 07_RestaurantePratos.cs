using System;
using System.Collections.Generic;

class Prato
{
    public string Nome { get; set; }
    public List<string> Ingredientes { get; set; } = new List<string>();
}

class Restaurante
{
    public List<Prato> Menu { get; set; } = new List<Prato>();

    public void AdicionarPrato(Prato prato)
    {
        Menu.Add(prato);
    }

    public void RemoverPrato(Prato prato)
    {
        Menu.Remove(prato);
    }
}
