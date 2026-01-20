class Program
{
    static void Main()
    {
        int cargo;
        double salario, reajuste, aumento;

        Console.WriteLine("---------------------------");
        Console.WriteLine("[1] Serviços gerais");
        Console.WriteLine("[2] Vigia");
        Console.WriteLine("[3] Recepcionista");
        Console.WriteLine("[4] Vendedor");        
        Console.WriteLine("---------------------------");

        Console.WriteLine("Digite o cargo: ");
        cargo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o salário: ");
        salario = double.Parse(Console.ReadLine());


        if(cargo == 1)
        {
            Console.WriteLine("Serviços Gerais");
            aumento = salario * (50.0/100.0);
            reajuste = salario + aumento;

            Console.WriteLine($"O aumento é de: {aumento}");
            Console.WriteLine($"O reajuste é de: {reajuste}");
        }
        if(cargo == 2)
        {
            Console.WriteLine("Vigia");
            aumento = salario * (30.0/100.0);
            reajuste = salario + aumento;

            Console.WriteLine($"O aumento é de: {aumento}");
            Console.WriteLine($"O reajuste é de: {reajuste}");
        }
        if(cargo == 3)
        {
            Console.WriteLine("Recepcionista");
            aumento = salario * (25.0/100.0);
            reajuste = salario + aumento;

            Console.WriteLine($"O aumento é de: {aumento}");
            Console.WriteLine($"O reajuste é de: {reajuste}");
        }
        if(cargo == 4)
        {
            Console.WriteLine("Vendedor");
            aumento = salario * (15.0/100.0);
            reajuste = salario + aumento;

            Console.WriteLine($"O aumento é de: {aumento}");
            Console.WriteLine($"O reajuste é de: {reajuste}");
        }
    }
}