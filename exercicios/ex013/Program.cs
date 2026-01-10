class Program
{
    static void Main()
    {
        float peso, altura, IMC;
        
        Console.Write("Digite o peso: ");
        peso = float.Parse(Console.ReadLine());
        
        Console.Write("Digite a altura: ");
        altura = float.Parse(Console.ReadLine());

        IMC = peso / (altura * altura);

        if (IMC < 20)
        {
            Console.Write("Abaixo do peso");
        }
        else if (IMC <= 25)
        {
            Console.Write("Normal");
        }
        else if (IMC <= 30)
        {
            Console.Write("excesso de peso");
        }
        else if (IMC <= 35)
        {
            Console.Write("obesidade");
        }
        else
        {
            Console.Write("obsedidade Mórbida");
        }

    }
}