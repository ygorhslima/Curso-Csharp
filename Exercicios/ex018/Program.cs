/*
    escreva um algoritmo que leia um conjunto de pedidos e calcule o total da compra. O pedido possui os seguintes campos:
    número, data (dia,mês,ano) , preço unitário e quantidade. A entrada é encerrada quando o usuário informa 0 como número do pedido
*/


class Program
{
    static void Main()
    {
        int pedido, quantidade;
        string data, nomeDoProduto;
        float preco, total=0.0f;
        
        Console.Write("informe o número do pedido: ");
        pedido = int.Parse(Console.ReadLine());

        while(pedido != 0)
        {
            Console.Write("informe o nome do produto: ");
            nomeDoProduto = Console.ReadLine();

            Console.Write("informe o preço unitário: ");
            preco = float.Parse(Console.ReadLine());

            Console.Write("informe a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write("informe a data: ");
            data = Console.ReadLine();
            
            float valorCompra = preco * quantidade;

            total += valorCompra;
            
            Console.WriteLine($"o valor do/da {nomeDoProduto} é: R${valorCompra} feito no dia {data}");
            Console.WriteLine("Informe o número do novo pedido ou 0 para finalizar: ");
            pedido = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"o total da compra foi de R${total}");
    }
}