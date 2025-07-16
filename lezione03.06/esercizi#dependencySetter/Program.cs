using System;

public interface ILogger // Interfaccia per il logger
{
    void Log(); // Metodo per eseguire il log
}

public class ConsoleLogger : ILogger // Implementazione del logger che stampa su console
{
    public void Log() // Implementazione del metodo Log
    {
        Console.WriteLine("Stampa su console."); // Log su console
    }
}

public class Printer // Classe che utilizza il logger
{
    public ILogger Logger { get; set; } // Proprietà per impostare il logger
    // Il logger può essere impostato tramite questa proprietà, rendendo la classe Printer flessibile e facilmente testabile

    public void Print() // Metodo per stampare, che utilizza il logger
    {
        if (Logger == null) // Controlla se il logger è stato impostato
        {
            Console.WriteLine("Logger non impostato."); // Se il logger non è stato impostato, stampa un messaggio di errore
            return;
        }
        Logger.Log(); // Chiama il metodo Log del logger per eseguire il log
        Console.WriteLine("Stampa in corso..."); // Stampa un messaggio di stampa in corso

    }
}

public class Program
{
    public static void Main()
    {
        var printer = new Printer(); // Crea un'istanza della classe Printer
        printer.Logger = new ConsoleLogger(); // Imposta il logger utilizzando la proprietà Logger
        printer.Print(); // Chiama il metodo Print per eseguire la stampa
    }
}