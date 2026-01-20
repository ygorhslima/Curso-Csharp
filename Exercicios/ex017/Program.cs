class Program
{
    static void Main()
    {
        int numero, quantidadeNumero=0;
        Console.Write("Digite um valor: ");
        numero = int.Parse(Console.ReadLine());

        while(numero > 0)
        {
            quantidadeNumero++;
            Console.Write("Digite um valor: ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"quantidade de valores digitados {quantidadeNumero}");

    }
}
