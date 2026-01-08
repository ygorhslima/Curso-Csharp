using System;

class Program
{
    static void Main()
    {
        decimal valorPorHora, salarioBruto, salarioLiquido, INSS, FGTS, horasTrabalhadas, horaExtra;
        decimal porcentagemHoraExtra = 100m; // Alterado para decimal

        Console.Write("Informe o número de horas trabalhadas: ");
        horasTrabalhadas = decimal.Parse(Console.ReadLine());

        Console.Write("Informe o número de hora extra: ");
        horaExtra = decimal.Parse(Console.ReadLine());

        Console.Write("Informe o valor da hora: ");
        valorPorHora = decimal.Parse(Console.ReadLine());

        // LOGICA CORRIGIDA:
        // 1. Calculamos o valor total das horas normais
        // 2. Calculamos o valor das horas extras com o adicional
        decimal valorHoraNormalTotal = horasTrabalhadas * valorPorHora;
        decimal valorAdicionalExtra = (porcentagemHoraExtra / 100m) * valorPorHora;
        decimal valorHoraExtraTotal = horaExtra * (valorPorHora + valorAdicionalExtra);

        salarioBruto = valorHoraNormalTotal + valorHoraExtraTotal;

        // Cálculo dos descontos usando 'm' para evitar que o resultado vire zero
        INSS = salarioBruto * (9m / 100m);
        FGTS = salarioBruto * (8m / 100m);
        salarioLiquido = salarioBruto - INSS;

        // Saída
        Console.WriteLine($"\nO salário bruto é: {salarioBruto:N2}");
        Console.WriteLine($"O valor do INSS: {INSS:N2}");
        Console.WriteLine($"O valor do FGTS: {FGTS:N2}");
        Console.WriteLine($"O salário líquido é: {salarioLiquido:N2}");
    }
}