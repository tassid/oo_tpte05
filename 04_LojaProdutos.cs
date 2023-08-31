using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Loja
{
    public List<Produto> Inventario { get; set; } = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        Inventario.Add(produto);
    }

    public void RemoverProduto(Produto produto)
    {
        Inventario.Remove(produto);
    }
}
