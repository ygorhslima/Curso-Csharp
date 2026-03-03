using System;

class URI {
    static void Main(string[] args) { 

        // Lê a primeira linha inteira e divide nos espaços
        string[] linha1 = Console.ReadLine().Split(' ');
        int codigo1 = int.Parse(linha1[0]);
        int qte1 = int.Parse(linha1[1]);
        double preco1 = double.Parse(linha1[2]);

        // Lê a segunda linha inteira e divide nos espaços
        string[] linha2 = Console.ReadLine().Split(' ');
        int codigo2 = int.Parse(linha2[0]);
        int qte2 = int.Parse(linha2[1]);
        double preco2 = double.Parse(linha2[2]);

        // O cálculo do total deve multiplicar a quantidade pelo preço
        double total = (qte1 * preco1) + (qte2 * preco2);

        // Saída formatada com 2 casas decimais
        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
    }
}