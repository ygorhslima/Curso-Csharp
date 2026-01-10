class Program
{
    static void Main()
    {
        Console.Write("digite um valor: ");
        int valor = int.Parse(Console.ReadLine());

        Console.WriteLine($"o Antecessor de {valor} é {valor - 1} e o sucessor é {valor + 1}");
    }
}