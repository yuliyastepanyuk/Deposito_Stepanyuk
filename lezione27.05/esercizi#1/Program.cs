using System;

public sealed class Logger // sealed impedisce l'ereditarietà della classe Logger
{
    private static Logger _instance;

    private Logger() // Costruttore privato per impedire la creazione di istanze
    {

    }

    public static Logger GetIstanza() // Devi inizializzare _instance con una nuova istanza di Logger la prima volta che viene richiesta.
    {
       if (_instance == null)  // Così facendo, la prima volta che chiami GetIstanza(), viene creata una nuova istanza e assegnata a _instance. Le chiamate successive restituiranno sempre la stessa istanza.
        {
            _instance = new Logger();
        }
        return _instance;
    }

    public string ScriviMessaggio(string messaggio) 
    {
        Console.WriteLine($"Messaggio: {messaggio} - Timestamp: {DateTime.Now}");
        return messaggio;
    }
}

public class Programma
{
    public static void Main()
    {
        Logger logger1 = Logger.GetIstanza();
        Logger logger2 = Logger.GetIstanza();
        // Creazione dell'istanza del logger
        logger1?.ScriviMessaggio("Ciao, questo è un messaggio di log!");
        logger2?.ScriviMessaggio("Questo è un altro messaggio di log!");

        // Verifica che entrambe le variabili puntino alla stessa istanza
        if (logger1 == logger2)
        {
            Console.WriteLine("logger1 e logger2 sono la stessa istanza.");
        }
        else
        {
            Console.WriteLine("logger1 e logger2 sono istanze diverse.");
        }
    }
}