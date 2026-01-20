// Formule um algoritmo que leia e apresente as seguintes informações de uma pessoa: nome, idade, peso, altura e telefone

class Program
{
    static void Main()
    {
        // obtendo os dados
        Console.Write("digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("digite seu peso: ");
        float peso = float.Parse(Console.ReadLine());

        Console.Write("digite sua altura: ");
        float altura = float.Parse(Console.ReadLine());

        Console.Write("digite seu telefone: ");
        string telefone = Console.ReadLine();

        Console.WriteLine($"olá {nome} você tem {idade} anos, seu peso é {peso}kg e sua altura é {altura}m, e seu telefone é {telefone}");

    }
}