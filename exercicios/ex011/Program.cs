class Program
{
    static void Main()
    {

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write($"olá {nome}, você tem {idade} anos e ");
        if(idade >= 65)
        {
            Console.WriteLine("você é Idoso");
        }else if(idade < 18)
        {
            Console.WriteLine("você é Menor de idade");
        }
        else
        {
            Console.WriteLine("você é maior de idade");
        }
    }
}