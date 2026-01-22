namespace Aula025
{
    class Program{
        public static void Main(string[] args)
        {
            int num = 10;
            dobrar(ref num);
            Console.WriteLine(num);
        }
        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}