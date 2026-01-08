class Program
{
    static async Task Main()
    {

        Console.WriteLine("executando");
        // aguardando a task analisar
        // durante o await a thread principal não vai travar a aplicação, só será suspensa
        var task = Task.Run(() =>
        {
            Thread.Sleep(5000);
            Console.WriteLine("Acordou");
            return 42;
        });
        var result = await task;
        Console.WriteLine(result);
    }
}