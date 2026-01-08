class Program
{
    static void Main()
    {
        string frase = " C-sharp é incrível! ";
        string limpa = frase.Trim();
        Console.WriteLine($"Trim: {limpa}");
        Console.WriteLine($"ToUpper: {limpa.ToUpper()}");
        Console.WriteLine($"ToLower: {limpa.ToLower()}");
        Console.WriteLine($"contains: {limpa.Contains("C-sharp")}");
        Console.WriteLine($"startsWith: {limpa.StartsWith("A")}");
        Console.WriteLine($"indexOf: {limpa.IndexOf("incrivel")}");
        Console.WriteLine($"subtring: {limpa.Substring(0,2)}");
        Console.WriteLine($"replace: {limpa.Replace("incrivel","poderoso")}");
    }
}