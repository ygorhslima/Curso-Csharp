using System;
using System.Security.Cryptography.X509Certificates;

class URI
{

    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
        double[] preco = { 4.00, 4.50, 5.00, 2.00, 1.50};
        string[] linha = Console.ReadLine().Split(' ');
        int id = int.Parse(linha[0]);
        int quantidade = int.Parse(linha[1]);
        double total = preco[id - 1] * quantidade;


        Console.WriteLine($"Total: R$ {total:F2}");

    }

}