using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("digite o primeiro valor: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("digite o segundo valor: ");
        int b = int.Parse(Console.ReadLine());

        int resultado = Soma(a,b);
        Console.WriteLine($"a soma entre {a} e {b} é igual a {resultado}");
    }
    static int Soma(int n1, int n2)
    {
        int res = n1 + n2;
        return res;
    }
}