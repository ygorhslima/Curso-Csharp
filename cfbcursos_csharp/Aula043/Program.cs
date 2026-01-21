namespace Ex043
{
    public interface IVeiculo
    {
        void Ligar();
        void Desligar();
        void Info();
    }
    public interface ICombate
    {
        void Disparar();
    }

    class Carro : IVeiculo
    {
        public bool ligado;
        
        public Carro()
        {
            
        }

        public void Desligar()
        {
            this.ligado = false;
        }

        public void Info()
        {
            
        }

        public void Ligar()
        {
            this.ligado = true; 
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Carro c1 = new Carro();
        }
    }
}