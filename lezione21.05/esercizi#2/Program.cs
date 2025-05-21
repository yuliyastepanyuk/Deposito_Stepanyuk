using System;

public class Veicolo // classe BASE
{
    protected string Marca;
    protected string Modello;

    public Veicolo(string marca, string modello) // costruttore
    {
        Marca = marca;
        Modello = modello;
    }

    public virtual string StampaInfo() // metodo virtuale, cioè posso sovvrascriverlo dalle classi figlie
    {
        return $"Marca : {Marca}, Modello: {Modello}";
    }

    
}

public sealed class Auto : Veicolo // classe DERIVATA
{
    protected int NumeroPorte;

    public Auto(string marca, string modello, int numeroPorte) : base(marca, modello) // costruttore
    {
        NumeroPorte = numeroPorte;
    }
    /*Senza questa chiamata, i campi della classe base non vengono inizializzati con i valori che vuoi tu.
    In C#, quando una classe eredita da un'altra, il costruttore della classe figlia deve passare i parametri necessari al costruttore della classe base usando la sintassi : base(parametri).*/

    /*Devi rimettere marca e modello tra i parametri del costruttore di Auto perché il costruttore di Auto deve ricevere questi valori dall'esterno (quando crei un oggetto Auto).
    Il costruttore della classe base (Veicolo) ha bisogno di questi parametri per inizializzare i suoi campi, ma non li può inventare: devono essere passati dal costruttore della classe derivata.*/

    public override string StampaInfo()
    {
        return $"Marca : {Marca}, Modello: {Modello}, Numero Porte: {NumeroPorte}";
    }

    public static Auto InserimentoAuto()
    {
        Console.WriteLine("Inserisci la marca dell'auto: ");
        string marca = Console.ReadLine();
        Console.WriteLine("Inserisci il modello dell'auto: ");
        string modello = Console.ReadLine();
        Console.WriteLine("Inserisci il numero di porte dell'auto: ");
        int numeroPorte = int.Parse(Console.ReadLine());
        Auto auto = new Auto(marca, modello, numeroPorte); // Creazione di un oggetto Auto
        return auto; // Restituzione dell'oggetto Auto creato
    }
}

public sealed class Moto : Veicolo // classe DERIVATA
{
    protected string TipoManubrio;

    public Moto(string marca, string modello, string tipoManubrio) : base(marca, modello) // costruttore
    {
        TipoManubrio = tipoManubrio;
    }

    public override string StampaInfo()
    {
        return $"Marca : {Marca}, Modello: {Modello}, Tipo Manubrio: {TipoManubrio}";
    }

    public static Moto InserimentoMoto()
    {
        Console.WriteLine("Inserisci la marca della moto: ");
        string marca = Console.ReadLine();
        Console.WriteLine("Inserisci il modello della moto: ");
        string modello = Console.ReadLine();
        Console.WriteLine("Inserisci il tipo di manubrio della moto: ");
        string tipoManubrio = Console.ReadLine();
        Moto moto = new Moto(marca, modello, tipoManubrio); // Creazione di un oggetto Moto
        return moto; // Restituzione dell'oggetto Moto creato
    }
}

public class Programma
{
    public static void Main(string[] args)
    {
        bool continua = true;
        List<Veicolo> veicoli = new List<Veicolo>(); // lista di oggetti di tipo Veicolo


        while (continua) //ciclo per richiamare il menù dopo ogni azione
        {
            int scelta = Menu(); // chiama il menù

            if (scelta <= 4)
            {
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Cosa vuoi aggiungere?\n 1) Auto \n 2) Moto");
                        int sceltaVeicolo = int.Parse(Console.ReadLine());
                        if (sceltaVeicolo == 1)
                        {
                            Auto auto = Auto.InserimentoAuto();
                            veicoli.Add(auto);
                            Console.WriteLine("Auto aggiunta con successo!");

                        }
                        else if (sceltaVeicolo == 2)
                        {
                            Moto moto = Moto.InserimentoMoto();
                            veicoli.Add(moto);
                            Console.WriteLine("Moto aggiunta con successo!");

                        }
                        else
                        {
                            Console.WriteLine("Scelta non valida, riprova.");

                        }
                        break;
                    case 2:
                        Console.WriteLine("Ecco i veicoli nel garage:");
                        if (veicoli.Count == 0)
                        {
                            Console.WriteLine("Nessun veicolo presente nel garage.");
                            break;
                        }
                        else
                        {
                            foreach (var veicolo in veicoli)
                            {
                                Console.WriteLine(veicolo.StampaInfo()); // stampa le informazioni del veicolo grazie al polimorfismo
                            }

                        }
                        break;
                    case 3:
                        Console.WriteLine("Grazie per aver utilizzato il programma!");
                        continua = false; // esce dal ciclo
                        break;
                }
            }
            else
            {
                Console.WriteLine("Scelta non valida, riprova.");
                scelta = int.Parse(Console.ReadLine());
            }
        }
    }

    public static int Menu()
    {
        Console.WriteLine("Benvenuto nel Garage! \n Cosa vuoi fare?\n 1) Aggiungere un veicolo \n 2) Visualizzare i veicoli \n 3) Uscire");
        int scelta = int.Parse(Console.ReadLine());
        return scelta; // restituisce la scelta dell'utente
    }

}