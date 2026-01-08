// um quadrado é uma figura geométrica com quatro lados do mesmo comprimento (L) e quatro ângulos retos. Elabore um algoritmo para calcular a área e o perímetro de um quadrado. a área e dada pela superfície e o perímetro é a medida do contorno do objeto, ou seja a soma dos quatro lados
class Program
{
    static void Main()
    {

        float L, A, P;
        Console.WriteLine("Informe o valor do lado do quadrado: ");
        L = float.Parse(Console.ReadLine());

        P = 4 * L;
        A = L * L;
        Console.WriteLine($"o perímetro é {P}");
        Console.WriteLine($"A aŕea é {A}");
    }
}