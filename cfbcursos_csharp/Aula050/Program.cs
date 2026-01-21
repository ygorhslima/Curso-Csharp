using System;

namespace Aula050
{
    // Definição do Delegate
    delegate int Op(int n1, int n2);

    public class Program
    {
        public static int soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int mult(int n1, int n2)
        {
            return n1 * n2;
        }

        public static void Main(string[] args)
        {
            int res;

            // Apontando para a SOMA
            Op d1 = new Op(soma);
            res = d1(10, 50);
            Console.WriteLine($"Soma: {res}");

            // Alterando o ponteiro para a MULTIPLICAÇÃO
            d1 = new Op(mult);
            res = d1(10, 50); // Chamando o delegate novamente
            Console.WriteLine($"Multiplicação: {res}");
        }
    }
}