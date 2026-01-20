using System.Diagnostics.Contracts;

class Program
{
    public static void Main()
    {
        int tamanho = 10;
        string[] nome = new string[tamanho];
        float[] n1 = new float[tamanho];
        float[] n2 = new float[tamanho];
        float[] n3 = new float[tamanho];
        float[] n4 = new float[tamanho];
        float[] media = new float[tamanho];
        int contador;

        for (contador = 0; contador < tamanho; contador++)
        {
            Console.Write("Informe o nome do aluno: ");
            nome[contador] = Console.ReadLine();

            Console.Write("nota 1: ");
            n1[contador] = float.Parse(Console.ReadLine());

            Console.Write("nota 2: ");
            n2[contador] = float.Parse(Console.ReadLine());
            
            Console.Write("nota 3: ");
            n3[contador] = float.Parse(Console.ReadLine());
            
            Console.Write("nota 4: ");
            n4[contador] = float.Parse(Console.ReadLine());
            
            media[contador] = (n1[contador] + n2[contador] + n3[contador] + n4[contador]) / 4;
        }
        for(contador = 0; contador < tamanho; contador++)
        {
            Console.WriteLine($"Aluno.: {nome[contador]}");
            Console.WriteLine($"nota 1: {n1[contador]}");
            Console.WriteLine($"nota 2: {n2[contador]}");
            Console.WriteLine($"nota 3: {n3[contador]}");
            Console.WriteLine($"nota 4: {n4[contador]}");
            Console.WriteLine($"Média.: {media[contador]}");
            
        }
    }
}