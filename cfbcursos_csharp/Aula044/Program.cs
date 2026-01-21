namespace Ex044
{
    struct Carro
    {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Carro c1;
            c1.marca = "VW";
            c1.cor = "Branco";
            c1.modelo = "Golf";

            Console.WriteLine(c1.marca);
            Console.WriteLine(c1.cor);
            Console.WriteLine(c1.modelo);
        }
    }
}