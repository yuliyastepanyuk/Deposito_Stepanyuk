using System;

public interface IGreeter
{
    void Greet(string name);
}

public class ConsoleGreeter : IGreeter
{
    public void Greet(string name)
    {
        Console.WriteLine($"Ciao, {name}!");
    }
}

public class GreetingService
{
    private readonly IGreeter _greeter;

    public GreetingService(IGreeter greeter)
    {
        _greeter = greeter;
    }

    public void Welcome(string name)
    {
        _greeter.Greet(name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IGreeter greeter = new ConsoleGreeter();
        GreetingService service = new GreetingService(greeter);

        service.Welcome("Mario");
    }
}

