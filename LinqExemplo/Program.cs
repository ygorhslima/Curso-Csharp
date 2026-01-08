class Program
{
    static void Main()
    {
        int[] numbers = { 1, 4, 6, 10, 43 };
        // forma mais declarativa
        /*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
        /*var query = from number in numbers
                    where number < 10
                    select number;/*
        /*-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*/
        var valoresMenoresQue10 = numbers.Where(n => n < 10);
        var dobro = numbers.Select(n => n * 2);
        var valAsc = numbers.OrderBy(n => n);
        var valDesc = numbers.OrderByDescending(n => n);
        int primeiro = numbers.First();
        int primeiroOuZero = numbers.FirstOrDefault();
        bool existeValoresPares = numbers.Any(n => n % 2 == 0);
        bool todosPositivos = numbers.All(n => n > 0);

        Console.WriteLine("valores menores que 10");
        foreach (var val in valoresMenoresQue10){Console.WriteLine(val);}
    }
}