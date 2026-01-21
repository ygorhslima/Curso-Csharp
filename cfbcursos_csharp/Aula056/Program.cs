namespace Aula056
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<string> transp = new LinkedList<string>();
            transp.AddFirst("Carro");
            transp.AddFirst("Avião");
            transp.AddFirst("Navio");
            transp.AddFirst("Motocicleta");
            transp.AddLast("Bicicleta");

            LinkedListNode<string> no;
            no = transp.FindLast("Navio");
            transp.AddAfter(no,"Patinete");

            foreach (var item in transp)
            {
                Console.WriteLine($"Transporte: {item}");
            }
        }
    }
}