class Program
{
    static void Main()
    {
        int numerosDeProvas, codigo, aprovados=0, reprovados=0;
        float nota=0.0f, soma=0.0f, media=0.0f;

        Console.WriteLine("informe o número de notas de cada disciplina: ");
        numerosDeProvas = int.Parse(Console.ReadLine());

        Console.WriteLine("informe o código do aluno [0 para encerrar o programa]: ");
        codigo = int.Parse(Console.ReadLine());

        while (codigo != 0)
        {
            for(int cont = 1; cont < numerosDeProvas; cont++)
            {
                Console.WriteLine($"Informe a {cont}° nota: ");
                nota = float.Parse(Console.ReadLine());
                soma += nota;
            }
    
            media = soma / numerosDeProvas;

            if(media >= 7.0)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }
    
            Console.WriteLine("informe o código do aluno [0 para encerrar o programa]: ");
            codigo = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"o número de aprovados foi {aprovados}");
        Console.WriteLine($"o número de reprovados foi {reprovados}");
    }
}