public class Program
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        Console.Write("digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());
        // OU para uma conversão mais específica
        // v2 = Convert.ToInt32(Console.ReadLine());

        soma = v1 + v2;

        Console.WriteLine($"seu nome é {nome}");
        Console.WriteLine($"A soma entre {v1} e {v2} é igual a {soma}");
    }
}