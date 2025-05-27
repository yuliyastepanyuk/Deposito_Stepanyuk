// IL SINGLETON
// garantisce che una classe abbia una sola istanza e ne fornisca un punto di accesso globale
// controlla l'accesso u una risorsa condivisa

// mantiene il riferimenro alll'unica istanza
// INSTANCE proprietà statica che restituisce l'istanza unica della classe
// PRIVATE COSTRUTTORE per impedire la creazione di istanze al di fuori della classe stessa
// LOCK OBJECT per garantire la sicurezza dei thread durante la creazione dell'istanza



public sealed class Singleton // sealed impedisce l'ereditarietà della classe Singleton
{
    // Riferimento all’unica istanza (inizialmente null)
    private static Singleton _instance; // memorizza l'oggetto singleton variabile che può essere utilizzata 

    // Oggetto di lock per garantire il thread‑safety
    private static readonly object _lock = new object();

    // Costruttore privato: impedisce 'new Singleton()' dall’esterno
    private Singleton()
    {
        // Codice di inizializzazione (es. caricamento configurazione)
    }

    // Punto di accesso globale all’istanza
    public static Singleton Instance
    {
        get
        {
            // Primo controllo "senza lock" per performance
            if (_instance == null)
            {
                lock (_lock) // Se due thread arrivano qui, uno atterra nel lock
                {
                    // Secondo controllo dentro il lock per evitare doppia creazione
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

    // Metodo d’esempio che utilizza l’istanza singleton
    public void DoSomething()
    {
        Console.WriteLine("Metodo DoSomething chiamato sull'istanza Singleton.");
    }
}

// thread l'operazione che avviene per il clock dell'operazione, thread safety si intende la possibilità senza che questo provochi errori di cui non si ha il controllo