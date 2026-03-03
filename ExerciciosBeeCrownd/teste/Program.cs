using System;

class URI {
    static void Main(string[] args) {
        decimal valor = decimal.Parse(Console.ReadLine());
   
        int centavosTotal = (int)(valor * 100);
        int[] notas = { 10000, 5000, 2000, 1000, 500, 200 };
        int[] moedas = { 100, 50, 25, 10, 5, 1 };

        Console.WriteLine("NOTAS:");
        for (int i = 0; i < notas.Length; i++) {
            int qtdNotas = centavosTotal / notas[i];
            Console.WriteLine($"{qtdNotas} nota(s) de R$ {notas[i] / 100}.00");
            centavosTotal %= notas[i];
        }

        Console.WriteLine("MOEDAS:");
        for (int i = 0; i < moedas.Length; i++) {
            int qtdMoedas = centavosTotal / moedas[i];
            decimal valorMoeda = (decimal)moedas[i] / 100;
            Console.WriteLine($"{qtdMoedas} moeda(s) de R$ {valorMoeda.ToString("F2")}");
            centavosTotal %= moedas[i];
        }
    }
}