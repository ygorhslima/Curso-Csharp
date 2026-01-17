using System.Reflection;

public class Program
{
    public static void Main()
    {
        string greeting = "     Hello world     ";
        Console.WriteLine($"[{greeting}]");

        string trimGreeting = greeting.TrimStart();
        Console.WriteLine($"[{trimGreeting}]");

        string trimGreeting2 = greeting.TrimEnd();
        Console.WriteLine($"[{trimGreeting2}]");
    }
}