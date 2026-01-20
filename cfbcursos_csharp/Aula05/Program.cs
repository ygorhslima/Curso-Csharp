public class Program
{
    static void Main()
    {
        bool resE = (5 == 5) & (10 < 5); // false
        bool resOu = (5 > 3) | (10 < 5); // true
        Console.WriteLine(resE);
        Console.WriteLine(resOu);
    }
}