public class Program
{
    public static void Main(string[] args)
    {
        double a = 3;
        double b = 4;

        Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");


        double CalculateHypotenute(double leg1, double leg2)
        {
            return Math.Sqrt(leg1 * leg1 + leg2 * leg2);
        }   

        Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenute(a,b)}");

        var date = new DateTime(2026, 01, 29);
        Console.WriteLine($"On {date:dddd, MMMM dd, yyyy}");
    }
}

