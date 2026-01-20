class Program
{
    static void Main()
    {
        double raizQuadrada, num, quadrado;

        Console.WriteLine("Informe o número inteiro: ");
        num = float.Parse(Console.ReadLine());

        raizQuadrada = Math.Sqrt(num);
        quadrado = num * num;

        Console.WriteLine($"A raiz quadrada é {raizQuadrada}");
        Console.WriteLine($"O número elevado ao quadrado é {quadrado}");
    }
}