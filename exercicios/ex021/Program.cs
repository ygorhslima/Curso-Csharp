//método sequencial no C#

class Program
{
    static void Main()
    {
        int[] vnum = new int[20];
        int num;
        bool acha;
        int i;

        for (i = 1; i < 20; i++)
        {
            Console.Write("Informe um número: ");
            vnum[i] = int.Parse(Console.ReadLine());
        }
        
        Console.Write("Informe o número que deseja encontrar: ");
        num = int.Parse(Console.ReadLine());

        i = 1;
        acha = false;

        while (i <= 20 && acha == false)
        {
            if (num == vnum[i])
            {
                acha = true;
            }
            else
            {
                i++;
            }
        }
        if (acha == true)
        {
            Console.WriteLine($"O elemento foi encontrado na posição {i}");
        }
        else
        {
            Console.WriteLine("o elemento não foi encontrado");
        }
    }
}