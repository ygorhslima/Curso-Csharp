namespace Aula052
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n1=0, n2=0, res=0;

            n1 = 10;
            n2 = 0;

            try
            {
                res = n1 / n2;
                Console.WriteLine(res);
            }
            catch (System.Exception ex)
            {
               Console.WriteLine($"ERRO! não é possível dividir por 0: {ex}");
            }


        }
    }
}