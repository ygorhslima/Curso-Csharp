using System;
using System.Security.Cryptography;

class URI
{

    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
        string linha1 = Console.ReadLine();
        string[] v1 = linha1.Split(' ');
        
        string linha2 = Console.ReadLine();
        string[] v2 = linha2.Split(' ');

        double x1 = double.Parse(v1[0]);
        double y1 = double.Parse(v1[1]);
        
        double x2 = double.Parse(v2[0]);
        double y2 = double.Parse(v2[1]);

        double valoresCalculados = Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2);
        double distancia = Math.Sqrt(valoresCalculados);
        Console.WriteLine($"{distancia:F4}");
    }

}