namespace Aula034
{

    class Veiculo
    {
        private int VelMax;
        private bool Ligado;

        public void Ligar()
        {
            Ligado = true;
            Console.WriteLine("Ligado");
        }
        public void Desligar()
        {
            Ligado = false;
            Console.WriteLine("Desligado");
        }
    }

    class Carro : Veiculo
    {
        
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.Ligar();
        }
    }
}