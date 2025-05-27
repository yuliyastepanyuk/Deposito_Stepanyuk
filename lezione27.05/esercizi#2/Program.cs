using System;
using System.Reflection;

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

    public static void Log(string messaggio)
    {
        List<string> lista = new List<string>();
        Console.WriteLine("Scrivi il messaggio");
        messaggio = Console.ReadLine();
        lista.Add(messaggio);
        
    }
}

public class Programma
{
    public static void Main()
    {
        bool continua = true;
        do
        {
            Console.WriteLine("Cosa vuoi fare?\n 1.Chiamare un log.\n 2.Stampare le voci dei log.\n 3.Vedere se i log sono uguali.\n 4.uscire");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Logger logger1 = Logger.GetIstanza();
                    break;
                case 2:
                    Logger.Log("");
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Arrivederci!");
                    continua = false;
                    break;            

            }
        }
        while (continua);
    }
}