/*
    Construa um algoritmo que leia o preço de um produto, o percentual de desconto e calcule o valor a pagar e o valor do desconto
*/

class Program
{
    static void Main()
    {
        float preco, desconto;

        Console.Write("Digite o preço do produto: ");
        preco = float.Parse(Console.ReadLine());

        Console.Write("digite o valor de desconto: ");
        desconto = float.Parse(Console.ReadLine());

        float valorDeDesconto = (preco * desconto) / 100;
        float valorAPagar = preco - valorDeDesconto;

        Console.WriteLine($"o valor de desconto foi de {valorDeDesconto}%");
        Console.WriteLine($"e o valor da pagar é de R${valorAPagar}");
    }
}