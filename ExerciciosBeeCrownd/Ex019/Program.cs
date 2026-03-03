using System; 

class URI {
    static void Main(string[] args) { 
        // Lendo o valor total de segundos
        int tempoTotal = int.Parse(Console.ReadLine() ?? "0");
        
        // 1. Horas: Quantos grupos de 3600 segundos existem?
        int horas = tempoTotal / 3600;
        
        // 2. O RESTO: Quantos segundos sobraram que não completam 1 hora?
        int resto = tempoTotal % 3600;
        
        // 3. Minutos: Desses segundos que sobraram, quantos grupos de 60 existem?
        int minutos = resto / 60;
        
        // 4. Segundos: O que sobrou dos minutos são os segundos finais
        int segundos = resto % 60;

        // Imprime no formato H:M:S
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}