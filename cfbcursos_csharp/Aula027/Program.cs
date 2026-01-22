namespace Aula027
{
    class Program
    {
        public static void Main(string[] args)
        {
            soma(10,2);
        }
        // seria como o spread (...) do javascript 
        static void soma(params int[] n)
        {
            int res = 0;
            if (n.Length < 1)
            {
                Console.WriteLine("Não existem valores a serem somados");
            }
            else if (n.Length < 2)
            {
                Console.WriteLine("Valores insuficientes para soma");
            }
            else
            {
                for(int i=0; i<n.Length; i++)
                {
                    res += n[i];
                }
                Console.WriteLine($"Soma dos valores: {res}");
            }
            
        }
    }
}