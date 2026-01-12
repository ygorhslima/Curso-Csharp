class Program
{
    static void Main()
    {
        int cont,num,fat;

        Console.WriteLine("Digite um número para calcular o Fatorial: ");
        num = int.Parse(Console.ReadLine());
        
        fat = 1;
        for(cont = num; cont > 1; cont--)
        {
            fat = fat * cont;
        }
        Console.WriteLine($"o fatorial de {num} é igual a {fat}");
    }
}