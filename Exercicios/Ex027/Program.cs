namespace Aula056
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> carros = [];
            for(int i = 0; i<4; i++)
            {
                Console.Write($"Digite o {i + 1}° carro: ");
                string entrada = Console.ReadLine();

                carros.Add(entrada);
            }
            Console.WriteLine("Carros cadastrados");
            foreach (var c in carros)
            {
                Console.WriteLine(c);
            }
        }
    }
}