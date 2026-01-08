using System.Linq.Expressions;
using System.Security.Principal;

// PROGRAMA PRINCIPAL
class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();

        BankAccount account1 = new("Fredi", 100, logger);
        account1.Deposit(-100);

        BankAccount account2 = new("Joana", 500, logger);


        //List<BankAccount> accounts = new List<BankAccount>{account1, account2};
        // OU
        List<BankAccount> accounts = [account1, account2];
        DataStore<int> store = new DataStore<int>();
        store.value = 40;
        Console.WriteLine();


        foreach (var account in accounts)
        {
            Console.WriteLine(account.getBalance());
        }
    }
    static int Sum(int a, int b)
    {
        return a + b;
    }
}

// INTERFACE
interface ILogger
{
    void Log(string message);
}

// CLASSE IMPLEMENTANDO INTERFACE
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}

// generics no C#
class DataStore<T>
{
    public T value {get; set;}
}

/*CLASSE*/
class BankAccount
{
    private string name;
    private decimal balance;
    private ILogger logger;

    public string GetName()
    {
        return this.name;
    }
    public decimal getBalance()
    {
        return this.balance;
    }

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
