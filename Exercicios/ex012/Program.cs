class Program
{
    static void Main()
    {
        int idade;
        
        Console.Write("digite a idade: ");
        idade = int.Parse(Console.ReadLine());

        if(idade < 16)
        {
            Console.WriteLine("Não eleitor");
        }else if(idade > 65 || idade < 18)
        {
            Console.WriteLine("Eleitor Facultativo");
        }
        else
        {
            Console.WriteLine("Eleitor Obrigatório");
        }
    }
}