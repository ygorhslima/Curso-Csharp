using System; 

class URI {

    static void Main(string[] args) { 

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
       
        string linha = Console.ReadLine();
        string[] valores = linha.Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);
        double pi = 3.14159;

        double triangulo = A * C / 2.0;
        double circulo = pi * Math.Pow(C,2);
        double trapezio = (A + B) * C / 2.0;
        double quadrado = B * B;
        double retangulo = A * B;

        Console.WriteLine($"TRIANGULO: {triangulo:F3}");
        Console.WriteLine($"CIRCULO: {circulo:F3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
        Console.WriteLine($"QUADRADO: {quadrado:F3}");
        Console.WriteLine($"RETANGULO: {retangulo:F3}");
    }
}