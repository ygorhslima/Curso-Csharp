using System;

class URI {
    // Algoritmo de Euclides para o MDC
    static int calcularMDC(int a, int b) {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0) {
            int resto = a % b;
            a = b;
            b = resto;
        }
        return a;
    }

    static void Main(string[] args) { 
        string linhaN = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(linhaN)) return;
        
        int n = int.Parse(linhaN.Trim());

        for(int i = 0; i < n; i++) {
            string linha = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(linha)) continue;

            // Dividindo por espaços e removendo entradas vazias se houver espaços duplos
            string[] entrada = linha.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            int n1 = int.Parse(entrada[0]);
            int d1 = int.Parse(entrada[2]);
            string op = entrada[3];
            int n2 = int.Parse(entrada[4]);
            int d2 = int.Parse(entrada[6]);

            int numFinal = 0; 
            int denFinal = 0;

            if (op == "+") {
                numFinal = n1 * d2 + n2 * d1;
                denFinal = d1 * d2;
            } else if (op == "-") {
                numFinal = n1 * d2 - n2 * d1;
                denFinal = d1 * d2;
            } else if (op == "*") {
                numFinal = n1 * n2;
                denFinal = d1 * d2;
            } else if (op == "/") {
                numFinal = n1 * d2;
                denFinal = n2 * d1;
            }

            int mdc = calcularMDC(numFinal, denFinal);
            
            // O resultado simplificado
            int numSimp = numFinal / mdc;
            int denSimp = denFinal / mdc;

            Console.WriteLine($"{numFinal}/{denFinal} = {numSimp}/{denSimp}");
        }
    }
}