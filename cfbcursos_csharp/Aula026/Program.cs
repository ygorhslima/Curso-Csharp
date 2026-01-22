namespace Aula025
{
    class Program{
        public static void Main(string[] args)
        {
            
        }
        static int Divite(int dividendo, int divisor, out int resto)
        {
            int quociente;
            
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            
            return quociente;
        }
    }
}