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
        string linha;
        while((linha = Console.ReadLine()) != null)
        {
            string[] valores = linha.Split(' ');
            uint A = uint.Parse(valores[0]);
            uint B = uint.Parse(valores[1]);
            uint res = A ^ B;
            Console.WriteLine(res);
        }
    }
}