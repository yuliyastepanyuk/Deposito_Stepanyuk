using System;
using System.Dynamic;

public class Operatore // classe padre
{
    private string nome; // campi privati
    private string turno;

    public Operatore(string nome, string turno)
{
    Nome = nome;     // usa la proprietà
    Turno = turno;   // usa la proprietà (controllo su "giorno"/"notte")
}
    public string Nome // proprietà pubbliche per accedere ai campi privati
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }

    public string Turno // stessa cosa ma per il turno
    {
        get
        {
            return turno;
        }
        set
        {
            if (value == "giorno" || value == "notte")
            {
                turno = value;
            }
            else
            {
                Console.WriteLine("Turno non valido. Inserire solo 'giorno' o 'notte'.");
            }
        }
    }

    public virtual void EseguiCompito() // metodo generico
    {
        Console.WriteLine("Operatore generico in servizio.");
    }
}

public class OperatoreEmergenza : Operatore // classe derivata
{
    private int livelloUrgenza; // campo aggiuntico per la classe derivata

    public OperatoreEmergenza(string nome, string turno, int livellourgenza) : base(nome, turno) // costruttore
    {
        livelloUrgenza = livellourgenza;
    }

    public int livellourgenza // definisco l'accesso al campo aggiuntivo
    {
        get
        {
            return livelloUrgenza;
        }
        set
        {

            if (value >= 1 && value <= 5)
                livelloUrgenza = value;
            else
                Console.WriteLine("Il livello di urgenza deve essere tra 1 e 5.");
        }
    }

    public override void EseguiCompito() // override del metodo per personalizzarlo 
    {
        Console.WriteLine($"Gestione emergenza di livello {livelloUrgenza}.");
    }

    public static OperatoreEmergenza AggiungiEmergenza() // metodo per creare un oggetto operatoreemergenza
    {
        Console.WriteLine("Aggiungi il nome dell'emergenza: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Turno (giorno/notte):");
        string turno = Console.ReadLine();
        Console.WriteLine("Livello urgenza (1-5):");
        int livelloUrgenza = int.Parse(Console.ReadLine());
        return new OperatoreEmergenza(nome, turno, livelloUrgenza);

    }
}

public class OperatoreSicurezza : Operatore // classe derivata
{
    public string areaSorvegliata { get; set; }

    public OperatoreSicurezza(string nome, string turno, string areasorvegliata) : base(nome, turno)
    {
        areaSorvegliata = areasorvegliata;
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Sorveglianza dell'area {areaSorvegliata}");
    }

      public static OperatoreSicurezza AggiungiSicurezza() // meotodo per creare un oggetto operatoresicurezza
    {
        Console.WriteLine("Aggiungi il nome della sicurezza: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Turno (giorno/notte):");
        string turno = Console.ReadLine();
        Console.WriteLine("Area sorvegliata:");
        string areasorvegliata = Console.ReadLine();
        return new OperatoreSicurezza(nome, turno, areasorvegliata);

    }
}

public class OperatoreLogistica : Operatore // classe derivata
{
    private int numeroConsegne;

    public OperatoreLogistica(string nome, string turno, int numeroconsegne) : base(nome, turno)
    {
        numeroConsegne = numeroconsegne;
    }

    public int numeroconsegne
    {
        get
        {
            return numeroConsegne;
        }
        set //  Il set della proprietà deve accettare solo valori maggiore o uguale a 0.
        {
            if (value >= 0)
                numeroConsegne = value;
            else
                Console.WriteLine("Il numero di consegne deve essere maggiore o uguale a 0.");
        }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Coordinamento di {numeroConsegne} consegne");
    }

      public static OperatoreLogistica AggiungiLogistica() // metodo per creare un oggetto operatorelogistica
    {
        Console.WriteLine("Aggiungi il nome dell'emergenza: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Turno (giorno/notte):");
        string turno = Console.ReadLine();
        Console.WriteLine("Numero consegne(=>0):");
        int numeroconsegne = int.Parse(Console.ReadLine());
        return new OperatoreLogistica(nome, turno, numeroconsegne);

    }
}

public class Programma
{
    public static void Main()
    {
        bool continua = true; // condizione per far riapparire il menù
        List<Operatore> operatori = new List<Operatore>(); // istanzio la list degli operatori
        do
        {
            Console.WriteLine("Benvenuto!Cosa vuoi fare?\n 1.Aggiungere un nuovo operatore.\n 2.Stampare tutti gli operatori.\n 3.Chiamare EseguiCompito sugli operatori.\n 4.Uscire");
            int scelta = int.Parse(Console.ReadLine());
            if (scelta >= 1 && scelta <= 4)
            {
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Scegli tra:\n 1.OperatoreEmergenza.\n 2.OperatoreSicurezza\n 3.OperatoreLogistica");
                        int sceltaOperatore = int.Parse(Console.ReadLine());
                        if (scelta >= 1 && scelta <= 3)
                        {
                            switch (sceltaOperatore)
                            {
                                case 1:
                                    OperatoreEmergenza operatoreEmergenza = OperatoreEmergenza.AggiungiEmergenza(); // richiamo il metodo corrispondente
                                    operatori.Add(operatoreEmergenza);                                              // aiiungo alla lista
                                    Console.WriteLine("Opertore aggiunto con successo!");
                                    break;
                                case 2:
                                    OperatoreSicurezza operatoreSicurezza = OperatoreSicurezza.AggiungiSicurezza(); // richiamo il metodo corrispondente
                                    operatori.Add(operatoreSicurezza);
                                    Console.WriteLine("Opertore aggiunto con successo!");
                                    break;
                                case 3:
                                    OperatoreLogistica operatoreLogistica = OperatoreLogistica.AggiungiLogistica(); // richiamo il metodo corrispondente
                                    operatori.Add(operatoreLogistica);
                                    Console.WriteLine("Opertore aggiunto con successo!");
                                    break;
                                default:
                                    Console.WriteLine("Scelta non valida!");
                                    break;    
                            }
                        }
                        else
                        {
                            Console.WriteLine("Scelta non valida");
                        }
                        break;
                    case 2:
                        foreach (Operatore o in operatori) // stampo il nome degli operatori per ogni operatore nella lista
                        {
                            Console.WriteLine($"Gli operatori sono {o.Nome}");
                        }
                        break;
                    case 3:
                        foreach (Operatore o in operatori) // richiamo il metodo generico corrispondente per ogni tipo di oggetto
                        {
                            o.EseguiCompito();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Arrivederci!");
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida!");
                        break;           
                }
            }
            else
            {
                Console.WriteLine("Insrisci una scelta valida!");
            }
        }
        while (continua);
    }
}