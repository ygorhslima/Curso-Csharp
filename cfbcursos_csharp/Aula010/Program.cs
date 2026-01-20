class Program
{
    enum StatusPedido
    {
        AguardandoPagamento,
        Processando,
        Enviado,
        Entregue,
        Cancelado
    };
    static void Main(string[] args)
    {
        StatusPedido meuPedido = StatusPedido.AguardandoPagamento;
        
        Console.WriteLine($"O Status atual do pedido é:  {meuPedido} ");
        
        
        meuPedido = StatusPedido.Enviado;

        VerificarEntrega(meuPedido);
    }

    static void VerificarEntrega(StatusPedido status)
    {
        switch (status)
        {
            case StatusPedido.AguardandoPagamento:
                Console.WriteLine("Aguardando confirmação do banco");
                break;
            case StatusPedido.Enviado:
                Console.WriteLine("O produto já saiu do nosso centro de distribuição");
                break;
            case StatusPedido.Entregue:
                Console.WriteLine("O cliente já recebeu o produto");
                break;
            case StatusPedido.Cancelado:
                Console.WriteLine("o pedido foi anulado");
                break;
            default:
                Console.WriteLine("Status em processamento...");
                break;
        }
        
    }
}