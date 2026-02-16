using System; 
class URI {

    static void Main(string[] args) { 

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        double weightA = 2;
        double weightB = 3;
        double weightC = 5;
        
        double average = ((A * weightA) + (B * weightB) + (C * weightC)) / (weightA + weightB + weightC);

        Console.WriteLine($"MEDIA = {average:F1}");
    }

}