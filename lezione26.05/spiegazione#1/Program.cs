// a livello logico non sempre possimo saspere cosa c'è diteri ad una struttura 
// non è detto che noi dobbiamo utilizzare forza tutti i concetti insieme

// nel mommento in cui andiamo a lavorare con concetto di astrazione, vogliamo che le strutture con cui andiamo a lavorare funzionino ma non come 
// dobbiamo usare solo ciò che è direttamente spiegato, direttamente esplecitato

// non può essere istanziata, un metodo senza corpo, cosa fa un oggetto e non come lo fa

// Classe astratta
public abstract class Veicolo // non può diventare oggetto in nessun modo
{
    public abstract void Avvia(); // per mettere in correlazioni più classi, di riferimento agli altri
                                  // qualsiasi suo figli dovrà andrà a strutturare questi elementi, per forza
                                  // mai andrò a stanziare la classe astratta perché non ha senso, ma posso creare un riferimento ad essa
    // può avere anche metodi concreti, ma non è obbligatorio
}

// Classe concreta che eredita dalla classe astratta
public class Auto : Veicolo
{
    public override void Avvia()
    {
        Console.WriteLine("L'auto è stata avviata.");
    }
}

// Interfaccia  mette in comune dei metodi che posso usare in più classi
public interface IVeicoloElettrico // le interfacce non contano l'ereditarietà
{
    void Ricarica();
} // le due classi non sono collegate ma tramite i metodi che implementano l'interfaccia posso farle comunicare

// Classe che implementa l'interfaccia
public class ScooterElettrico : IVeicoloElettrico
{
    public void Ricarica()
    {
        Console.WriteLine("Lo scooter elettrico è in ricarica.");
    }
}

public class Programma
{
    public static void Main(string[] args)
    {
        // Creazione di un'istanza della classe concreta
        Veicolo miaAuto = new Auto();
        miaAuto.Avvia(); // Output: L'auto è stata avviata.

        // Creazione di un'istanza della classe che implementa l'interfaccia
        IVeicoloElettrico mioScooter = new ScooterElettrico();
        mioScooter.Ricarica(); // Output: Lo scooter elettrico è in ricarica.
    }
}
