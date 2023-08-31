using System;
using System.Collections.Generic;

class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
}

class Empresa
{
    public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

    public void Contratar(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void Demitir(Funcionario funcionario)
    {
        Funcionarios.Remove(funcionario);
    }
}
