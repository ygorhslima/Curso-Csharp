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
        int dias = int.Parse(Console.ReadLine());
        int ano = dias / 365;
        int resto = dias % 365;

        int mes = resto / 30;
        int dia = resto % 30;

        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dia} dia(s)");
    }
}