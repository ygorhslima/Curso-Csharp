using System;

class Program
{
    static void Main()
    {
        // Arrays de teste
        string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Manga" };
        int[] numeros = { 10, 50, 30, 40, 20 };

        // --- 1. Sort ---
        // Ordena os elementos do array em ordem crescente.
        Array.Sort(numeros); 
        // Resultado: { 10, 20, 30, 40, 50 }

        // --- 2. BinarySearch ---
        // Procura um item em um array JÁ ORDENADO e retorna o índice.
        // Se não encontrar, retorna um número negativo.
        int indiceTrinta = Array.BinarySearch(numeros, 30);
        // Resultado: 2

        // --- 3. IndexOf ---
        // Retorna o índice da primeira ocorrência de um valor.
        int primeiraLaranja = Array.IndexOf(frutas, "Laranja");
        // Resultado: 2

        // --- 4. LastIndexOf ---
        // Retorna o índice da última ocorrência de um valor.
        string[] repetidos = { "A", "B", "A", "C" };
        int ultimaVezA = Array.LastIndexOf(repetidos, "A");
        // Resultado: 2

        // --- 5. Reverse ---
        // Inverte a ordem dos elementos no array.
        Array.Reverse(frutas);
        // Resultado: { "Manga", "Uva", "Laranja", "Banana", "Maçã" }

        // --- 6. Copy ---
        // Copia uma seção de um array para outro array.
        string[] destinoCopy = new string[3];
        Array.Copy(frutas, 0, destinoCopy, 0, 3);
        // Copia os 3 primeiros elementos de 'frutas' para 'destinoCopy'

        // --- 7. CopyTo ---
        // Método de instância que copia todos os elementos para outro array a partir de um índice.
        string[] destinoCopyTo = new string[10];
        frutas.CopyTo(destinoCopyTo, 0);

        // --- 8. GetLowerBound & GetUpperBound ---
        // GetLowerBound: Retorna o primeiro índice (geralmente 0).
        // GetUpperBound: Retorna o último índice (Length - 1).
        int inicio = frutas.GetLowerBound(0); // 0
        int fim = frutas.GetUpperBound(0);   // 4

        // --- 9. GetValue ---
        // Obtém o valor de um índice específico (útil em arrays multidimensionais ou tipagem dinâmica).
        object valor = frutas.GetValue(1); 
        // Resultado: "Uva" (devido ao Reverse feito anteriormente)

        // --- 10. SetValue ---
        // Define um valor em um índice específico.
        frutas.SetValue("Morango", 0);
        // Altera o índice 0 para "Morango"

        // Exibindo um resumo no console
        Console.WriteLine($"Busca binária (30 está no índice): {indiceTrinta}");
        Console.WriteLine($"Último índice de 'A': {ultimaVezA}");
        Console.WriteLine($"Limite superior do array: {fim}");
    }
}