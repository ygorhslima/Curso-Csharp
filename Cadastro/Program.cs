class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();

        BankAccount account1 = new("Fredi", 100, logger);
        account1.Deposit(-100);

        BankAccount account2 = new("Joana", 500, logger);


        //List<BankAccount> accounts = new List<BankAccount>{account1, account2};
        List<BankAccount> accounts = [account1, account2];

        foreach (var account in accounts)
        {
            Console.WriteLine(account);
        }
    }
}

interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}


class BankAccount
{
    private string name;
    private decimal balance;
    private ILogger logger;

    public BankAccount(string name, decimal balance, ILogger logger)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Nome inválido", nameof(name));

        if (balance < 0)
            throw new ArgumentException("Saldo não pode ser negativo");

        this.name = name;
        this.balance = balance;
        this.logger = logger;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            logger.Log($"Não é possível depositar {amount} na conta de {name}");
            return;
        }

        balance += amount;
        logger.Log($"Depósito de {amount} realizado para {name}");
    }

    public override string ToString()
    {
        return $"Titular: {name} | Saldo: {balance:C}";
    }
}
