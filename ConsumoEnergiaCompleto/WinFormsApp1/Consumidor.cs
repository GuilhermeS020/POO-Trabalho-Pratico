using System.Collections.Generic;

public class Consumidor
{
    public string Nome { get; set; }
    public string Documento { get; set; }
    public bool IsPessoaJuridica => Documento.Length > 11;
    public List<ContaEnergia> Contas { get; set; } = new();
}
