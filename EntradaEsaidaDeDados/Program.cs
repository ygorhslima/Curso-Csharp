class Program
{
    static void Main()
    {
        Console.WriteLine("digite um valor: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("digite um outro valor: ");
        int n2 = int.Parse(Console.ReadLine());

        int soma = n1 + n2;

        Console.WriteLine($"a soma entre {n1} e {n2} é {soma}");
    }
}