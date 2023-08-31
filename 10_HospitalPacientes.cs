using System;
using System.Collections.Generic;

class Paciente
{
    public string Nome { get; set; }
    public string Doenca { get; set; }
}

class Hospital
{
    public List<Paciente> Pacientes { get; set; } = new List<Paciente>();

    public void AdmitirPaciente(Paciente paciente)
    {
        Pacientes.Add(paciente);
    }

    public void DarAltaPaciente(Paciente paciente)
    {
        Pacientes.Remove(paciente);
    }
}
