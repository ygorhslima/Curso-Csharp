public class Program
{
    static void Main()
    {
       Formatacao02();
    }

    static void Formatacao01()
    {
        int n1=10,n2=20,n3=30;
        // formas de formatação
        //forma antiga
        //Console.Write("n1={0}, n2={1}, n3={2}",n1,n2,n3);
        //forma nova
        Console.Write($" \n n1=\t{n1} \n n2=\t{n2}\n n3=\t{n3}\n");
    }
    static void Formatacao02()
    {
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine($"Produto......:{produto}");
        Console.WriteLine($"Val.Compra...:{valorCompra:C}"); // para dinheiro
        Console.WriteLine($"Lucro........:{lucro:P0}"); // porcentagem
        Console.WriteLine($"Val.Venda....:{valorVenda:C}"); // para dinheiro
    }
}