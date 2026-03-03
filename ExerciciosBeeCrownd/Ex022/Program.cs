/*

beecrowd | 1036
Fórmula de Bhaskara
Adaptado por Neilor Tonin, URI  Brasil

Timelimit: 1
Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

Exemplos de Entrada	Exemplos de Saída
10.0 20.1 5.1

R1 = -0.29788
R2 = -1.71212

0.0 20.0 5.0

Impossivel calcular

10.3 203.0 5.0

R1 = -0.02466
R2 = -19.68408

10.0 3.0 5.0

Impossivel calcular
*/

using System; 

class URI {

        // Calcular as raízes (\(x\)): Substitua \(a,b\) e \(\Delta \) na fórmula \(x=\frac{-b\pm \sqrt{\Delta }}{2a}\)
    static void Main(string[] args) { 

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
        string[] linha = Console.ReadLine().Split(' ');
        // 10.0 20.1 5.1
        // R1 = -0.29788
        // R2 = -1.71212
        
        double A = double.Parse(linha[0]);
        double B = double.Parse(linha[1]);
        double C = double.Parse(linha[2]);

        double delta = Math.Pow(B,2) - (4 * A * C);
        
        if(A == 0 || delta < 0)
        {
            Console.WriteLine("Impossível Calcular");
        }
        else
        {
            double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double R2 = (-B - Math.Sqrt(delta)) / (2 * A);
            
            Console.WriteLine($"R1 = {R1:F5}");
            Console.WriteLine($"R2 = {R2:F5}");
        }
    }

}