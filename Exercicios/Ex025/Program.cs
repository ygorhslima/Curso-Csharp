namespace Exercicios.Ex025
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria MinhaConta = new ContaBancaria("joão");
            Console.WriteLine($"Conta de {MinhaConta.Titular} criada.");
            MinhaConta.Sacar(50.00);
            MinhaConta.Depositar(150.00);
            MinhaConta.Sacar(50.00);
        }
    }
}