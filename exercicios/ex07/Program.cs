class Program
{
    static void Main()
    {
        int quantidadeCarros;
        float valorLocacao, faturamentoMensal, faturamentoAnual;
        
        Console.Write("digite a quantidade de carros que tem em sua locadora: ");
        quantidadeCarros = int.Parse(Console.ReadLine());

        Console.Write("informe o valor da locação: ");
        valorLocacao = float.Parse(Console.ReadLine());

        faturamentoMensal = quantidadeCarros * valorLocacao;
        faturamentoAnual = ((quantidadeCarros * 0.8f) * valorLocacao)*12;

        Console.WriteLine($"o faturamento mensal é {faturamentoMensal}");
        Console.WriteLine($"o faturamento anual considerando a locação de 80% dos carros é {faturamentoAnual}");
    }
}