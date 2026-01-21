namespace Aula055
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // adicionando dados dentro do dicionário veículos
            // pode fazer assim

            /*
                Dictionary<int, string> veiculos = new Dictionary<int,string>();
                veiculos.Add(10,"Carro");
                veiculos.Add(5,"Moto");
                veiculos.Add(0,"Avião");
                veiculos.Add(20,"Navio");
                veiculos.Add(15,"patinete");
            */

            // OU
            Dictionary<int, string> veiculos = new Dictionary<int, string>
            {
                { 10, "Carro" },
                { 5, "Moto" },
                { 0, "Avião" },
                { 20, "Navio" },
                { 15, "patinete" }
            };


            //Limpando os dados do dicionário
            //veiculos.Clear();
            
            // verificando se o dicionário tem a chave que eu quero especificar
            int chave = 20;
            if (veiculos.ContainsKey(chave))
            {
                Console.WriteLine($"A Chave {chave} está na coleção");
            }
            else
            {
                Console.WriteLine($"A Chave {chave} não está na coleção");
            }
            
            Console.WriteLine($"Tamanho do dicionário: {veiculos.Count}");

            foreach (var v in veiculos)
            {
                Console.WriteLine(v);
            }

        }
    }
}