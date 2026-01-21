namespace Aula056
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
                List<string> carros = new List<string>();
                carros.Add("Golf");
                carros.Add("HRV");
                carros.Add("focus");
            */

            //OU

            //List<string> carros = new List<string>{"golf","HRV","Focus"};
             
            //OU
            List<string> carros = ["Golf", "HRV", "Focus", "Gol"];

            // 1. Adicionando em posição específica
            carros.Insert(0, "Ferrari");

            // 2. Ordenando a lista
            carros.Sort();

            // 3. Verificando posição e removendo
            if (carros.Contains("Gol"))
            {
                int indice = carros.IndexOf("Gol");
                Console.WriteLine($"Gol encontrado na posição {indice}. Removendo...");
                carros.RemoveAt(indice);
            }

            // 4. Exibindo contagem final
            Console.WriteLine($"Total de carros: {carros.Count}");
            foreach (var c in carros)
            {
                Console.WriteLine(c);
            }
        }
    }
}