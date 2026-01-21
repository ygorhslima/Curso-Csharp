namespace Aula028{
    public class Jogador
    {
        public int Energia;
        public bool Vivo;
        public string Nome;


        public Jogador(string nome)
        {
            Nome = nome;
            Energia = 100;
            Vivo = true;
        }

        public void InfoJogador()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Energia: {Energia}");
            Console.WriteLine($"Está vivo?: {Vivo}");
            Console.WriteLine("----------------------");
        }

        public void InfoJogador(string nome)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine("----------------------");
        }


        public void InfoJogador(int energia)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Energia: {Energia}");
            Console.WriteLine("----------------------");
        }


        public void InfoJogador(bool vivo)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Vivo: {vivo}");
            Console.WriteLine("----------------------");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Digite o nome do primeiro Jogador: ");
            string nome1 = Console.ReadLine();

            Console.Write("Digite o nome do segundo Jogador: ");
            string nome2 = Console.ReadLine();

            
            Jogador j1 = new Jogador(nome1);
            Jogador j2 = new Jogador(nome2);

            j1.InfoJogador();
            j1.InfoJogador(nome1);
            j1.InfoJogador(j1.Energia);
            j1.InfoJogador(j1.Vivo);


            j2.InfoJogador();

        }
    }
}