using System;

class URI {
    static void Main(string[] args) { 
        // O ?? "0" evita o warning de valor nulo no terminal
        string input = Console.ReadLine() ?? "0";
        int valorTotal = int.Parse(input);

        // O Beecrowd exige que a primeira linha da saída seja o valor lido
        Console.WriteLine(valorTotal);

        int resto = valorTotal;
        int[] cedulas = {100, 50, 20, 10, 5, 2, 1};

        foreach (var nota in cedulas)
        {
            int quantidade = resto / nota;
            // Note que o formato deve ser exatamente: X nota(s) de R$ Y,00
            Console.WriteLine($"{quantidade} nota(s) de R$ {nota},00");
            resto %= nota;
        }
    }
}