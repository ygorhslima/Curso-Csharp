
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
        int tempoGasto = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());
        double litros = tempoGasto * velocidadeMedia / 12.0;
        Console.WriteLine($"{litros:F3}");
    }

}