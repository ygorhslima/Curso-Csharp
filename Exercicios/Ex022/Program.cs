using System.Runtime.InteropServices;

class Program
{


    public static int Soma(int x)
    {
        int i;
        int total = 0;
        for (i = 1; i < x; i++)
        {
            total += i;
        }
        return total;
    }

    static void Main()
    {
        Console.Write("Informe um número: ");
        int n = int.Parse(Console.ReadLine());
        int resultado = Soma(n);
        Console.WriteLine($" o somatório é: {resultado}");
    }

}