class Program
{
    static void Main()
    {
        //var multiply = delegate (int x, int y) {return x * y;};
        // OU
        var multiply = (int x, int y) => x * y;
        Run(multiply);

    }
    static void Run(Func<int,int,int> calc)
    {
        Console.WriteLine(calc(20,30));
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}