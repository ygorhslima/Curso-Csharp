public class Program
{
    public static void Main()
    {
       int[] num = new int[10];

       for(int i=0; i<10; i++)
       {
            num[i] = 0;
       }
       for(int i=0; i<10; i++)
       {
            Console.WriteLine(num[i]);
       }
    }
}