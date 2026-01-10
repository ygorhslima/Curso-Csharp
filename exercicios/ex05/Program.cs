/*
escreva um algoritmo que calcule a área de um triângulo
objetivo da entrada: calcular a área do triângulo
Entrada: obter o valor da base e da altura do triângulo
Processamento: Calcular o valor da área que é dado por A = (base * altura) / 2
Saída: imprimir o valor da área
*/

using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main()
    {
        float Area,Base,Altura;
        Console.WriteLine("-=-=-=-=-=-=- Calculo da área do triângulo =-=-=-=-==-=");
        
        Console.Write("Valor da base: ");
        Base = float.Parse(Console.ReadLine());
        
        Console.Write("Valor da Altura: ");
        Altura = float.Parse(Console.ReadLine());

        Area = (Base * Altura) / 2;
        Console.WriteLine($"A área do triângulo é: {Area}");
    }
}
