namespace Ex045
{
    struct Carro
    {
        public string modelo;
        public string cor;

        public Carro(string modelo, string cor)
        {
            this.modelo = modelo;
            this.cor = cor;
        }

        public void Info()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Modelo: {this.modelo}");
            Console.WriteLine($"Cor: {this.cor}");
            Console.WriteLine("---------------------------------");
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Carro[] c = new Carro[5];
            int i;
            for(i = 0; i < 2; i++)
            {
                Console.Write("Informe o modelo do carro: ");
                c[i].modelo = Console.ReadLine();
                Console.Write("Informe a cor do carro: ");
                c[i].cor = Console.ReadLine();
            }
            for(i=0; i < 2; i++)
            {
                c[i].Info();
            }
        }
    }
}