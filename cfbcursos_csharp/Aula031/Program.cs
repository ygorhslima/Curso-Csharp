namespace Aula031{
    public static class Jogador
    {
        public static int Energia;
        public static bool Vivo;
        public static string Nome;


        public static void Iniciar(string nome)
        {
            Nome = nome;
            Energia = 100;
            Vivo = true;
        }

        public static void InfoJogador()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Energia: {Energia}");
            Console.WriteLine($"Está vivo?: {Vivo}");
            Console.WriteLine("----------------------");
        }
    }

    class Inimigo
    {
        public static bool Alerta;
        public string Nome;

        public Inimigo(string nome)
        {
            Alerta = false;
            Nome = nome;
        }
        public void InfoInimigo()
        {

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Alerta: {Alerta}");
            Console.WriteLine("----------------------------");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Jogador.Iniciar("João");
            Jogador.InfoJogador();

            Inimigo i1 = new Inimigo("Doidão");
            Inimigo i2 = new Inimigo("Pirata");
            Inimigo i3 = new Inimigo("Aranha");
            Inimigo.Alerta = true;

            i1.InfoInimigo();
            i2.InfoInimigo();
            i3.InfoInimigo();
        }
    }
}