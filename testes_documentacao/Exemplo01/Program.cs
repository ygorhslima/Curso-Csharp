class Program
{
    public static void Main(string[] args)
    {

        var tupleProduct = (Name: "Widget", Price: 19.99M);
        Console.WriteLine($"Tuple: {tupleProduct.Name} costs ${tupleProduct.Price}");

    }
}