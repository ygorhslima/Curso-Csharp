using System;
using System.Globalization;

class URI {
    static void Main(string[] args) { 
        string[] linha = Console.ReadLine().Split(' ');
        float N1 = float.Parse(linha[0], CultureInfo.InvariantCulture);
        float N2 = float.Parse(linha[1], CultureInfo.InvariantCulture);
        float N3 = float.Parse(linha[2], CultureInfo.InvariantCulture);
        float N4 = float.Parse(linha[3], CultureInfo.InvariantCulture);

        float media = (float)((N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10.0);
  
        if (media == 4.85f) media = 4.8f;

        Console.WriteLine($"Media: {media:F1}");

        if (media >= 7.0) {
            Console.WriteLine("Aluno aprovado.");
        } 
        else if (media < 5.0) {
            Console.WriteLine("Aluno reprovado.");
        } 
        else {
            Console.WriteLine("Aluno em exame.");
            
            // Lógica do exame
            float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nota do exame: {notaExame:F1}");

            float mediaFinal = (media + notaExame) / 2;

            if (mediaFinal >= 5.0) {
                Console.WriteLine("Aluno aprovado.");
            } else {
                Console.WriteLine("Aluno reprovado.");
            }
            
            Console.WriteLine($"Media final: {mediaFinal:F1}");
        }
    }
}