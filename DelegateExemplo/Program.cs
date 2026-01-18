class Program
{
    static void Main()
    {
        //Exemplo de Delegate + função Lambda
        // Func<parâmetro 1, parâmetro 2, valor de retorno>
        Func<int,int,int> soma = (a,b) => a+b;
        Console.Write(soma(10,20));
    }
}