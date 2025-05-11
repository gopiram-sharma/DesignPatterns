using Trading.Model.Interfaces;
namespace Trading.Model;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"{DateTime.Now:T}: {message}");
    }
}
