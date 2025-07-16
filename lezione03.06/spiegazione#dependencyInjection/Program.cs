// SRP (single responsibility principle) ogni classe dovrebbe avere una sola responsabilità o ragione
// open/closed principle (OCP) le classi dovrebbero essere aperte all'estensione ma chiuse alla modifica
// Liskov substitution principle (LSP) le classi derivate dovrebbero essere sostituibili con le loro classi base senza alterare il comportamento
// Interface segregation principle (ISP) le classi non dovrebbero essere costrette a implementare interfacce che non utilizzano
// Dependency inversion principle (DIP) le classi dovrebbero dipendere da astrazioni e non da implementazioni concrete

public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}

public class UserService
{
    private readonly ILogger _logger;

    public UserService(ILogger logger)
    {
        _logger = logger;
    }

    public void CreateUser(string name)
    {
        _logger.Log($"User '{name}' created.");
    }
}

class Program
{
    static void Main()
    {
        ILogger logger = new ConsoleLogger();
        UserService userService = new UserService(logger);
        userService.CreateUser("Alice");
    }
}

