public class ContaEnergia
{
    public string Tipo { get; set; }
    public double LeituraAnterior { get; set; }
    public double LeituraAtual { get; set; }

    public double Consumo => LeituraAtual - LeituraAnterior;

    public double ValorConsumo()
    {
        double tarifa = Tipo == "Residencial" ? 0.40 : 0.35;
        return Consumo * tarifa;
    }

    public double ValorComContribuicao() => ValorConsumo() + 9.25;

    public double ValorTotal()
    {
        double imposto = Tipo == "Residencial" ? 0.30 : 0.18;
        return ValorComContribuicao() * (1 + imposto);
    }
}
