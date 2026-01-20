public class Program
{
    public static void Soma(float x, float y)
    {
        float soma = x + y;
        Console.WriteLine($"a soma entre {x} e {y} é igual a {soma}");
    }
    public static void Subtracao(float x, float y)
    {
        float subtracao = x - y;
        Console.WriteLine($"a subtração entre {x} e {y} é igual a {subtracao}");
    }
    public static void Multiplicacao(float x, float y)
    {
        float multiplicacao = x * y;
        Console.WriteLine($"a multiplicação entre {x} e {y} é igual a {multiplicacao}");
    }
    public static void Divisao(float x, float y)
    {
        float divisao = x / y;
        Console.WriteLine($"a divisão entre {x} e {y} é igual a {divisao}");
    }

    public static void Main()
    {
        int opcao = 0;
        float n1, n2;

        while (opcao != 5)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Programa de cálculo aritmético");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair do Programa");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            opcao = int.Parse(Console.ReadLine());

            do
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o primeiro valor: ");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write("Informe o segundo valor: ");
                        n2 = float.Parse(Console.ReadLine());
                        Soma(n1,n2);
                        break;
                    case 2:
                        Console.Write("Informe o primeiro valor: ");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write("Informe o segundo valor: ");
                        n2 = float.Parse(Console.ReadLine());
                        Subtracao(n1,n2);
                        break;
                    case 3:
                        Console.Write("Informe o primeiro valor: ");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write("Informe o segundo valor: ");
                        n2 = float.Parse(Console.ReadLine());
                        Multiplicacao(n1,n2);
                        break;
                    case 4:
                        Console.Write("Informe o primeiro valor: ");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write("Informe o segundo valor: ");
                        n2 = float.Parse(Console.ReadLine());
                        Divisao(n1,n2);
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa");
                        break;
                    default:
                        Console.WriteLine("digite uma opção válida");
                        break;
                }
            } while (opcao < 1 && opcao > 5);
        }
    }
}