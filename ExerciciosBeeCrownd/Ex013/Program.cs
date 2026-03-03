using System;

class URI
{
    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
        string linha = Console.ReadLine();
        string[] valores = linha.Split(' ');

        int A = int.Parse(valores[0]);
        int B = int.Parse(valores[1]);
        int C = int.Parse(valores[2]);
        int maiorAb = (A + B + Math.Abs(A - B)) / 2;
        int maiorFinal = (maiorAb + C + Math.Abs(maiorAb - C)) / 2;
        Console.WriteLine($"{maiorFinal} eh o maior");
    }
}