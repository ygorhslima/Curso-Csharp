class Program
{
    static void Main()
    {
        float area,perimetro,raio;
        double pi = 3.14;
        
        Console.WriteLine("informe o valor do raio: ");
        raio = float.Parse(Console.ReadLine());

        area = pi * Math.Sqrt(raio);
        perimetro = 2 * pi * raio;

        Console.WriteLine($"A área é: {area}");
        Console.WriteLine($"O perímetro é: {perimetro}");
    }
}