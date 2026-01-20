class Program
{
    static void Main()
    {
        float valorAula, numeroDeAulasNoMes, INSS, salarioBruto, salarioLiquido;

        Console.Write("digite o valor da hora-aula: ");
        valorAula = float.Parse(Console.ReadLine());
        
        Console.Write("informe o número de horas-aulas dadas no mês: ");
        numeroDeAulasNoMes = float.Parse(Console.ReadLine());

        Console.Write("informe o percentual de desconto do INSS: ");
        INSS = float.Parse(Console.ReadLine());

        salarioBruto = (numeroDeAulasNoMes * valorAula);
        salarioLiquido = salarioBruto - (salarioBruto * INSS) / 100;

        Console.WriteLine($"o valor do salário bruto é:   {salarioBruto}");
        Console.WriteLine($"O valor do salário líquido é: {salarioLiquido}");
    }
}