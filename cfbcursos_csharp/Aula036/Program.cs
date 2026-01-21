namespace Aula036
{

    class Veiculo
    {
        protected int VelMax;
        protected bool Ligado;

        protected int rodas;

        public void Ligar()
        {
            this.Ligado = true;
            Console.WriteLine("Ligado");
        }
        public void Desligar()
        {
            this.Ligado = false;
            Console.WriteLine("Desligado");
        }

        public void SetLigado(bool ligado)
        {
            this.Ligado=ligado;
        }

        public string GetLigado()
        {
            if (this.Ligado)
            {
                return "sim";
            }
            else
            {
                return "não";
            }
        }

        public void SetVelMax(int velMax)
        {
            this.VelMax = velMax;
        }
        public int GetVelMax()
        {
            return this.VelMax;
        }
        public void SetRodas(int rodas)
        {
            this.rodas = rodas;
        }
        public int GetRodas()
        {
            return this.rodas;
        }

    }

    class CarroBom : Veiculo
    {
        public string nome;
        public string cor;
        public CarroBom(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            CarroBom c1 = new CarroBom("Rapidão","Vermelho");
            c1.SetLigado(true);
            c1.SetVelMax(400);
            c1.SetRodas(4);

            Console.WriteLine(c1.GetLigado());
            Console.WriteLine(c1.GetRodas());
            Console.WriteLine(c1.GetVelMax());
        }
    }
}