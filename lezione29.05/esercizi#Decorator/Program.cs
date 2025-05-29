using System;


// Dice che ogni bevanda deve avere una descrizione e un costo
public interface IBevanda // intefaccia
{
    string Descrizione(); // Deve dire cosa è la bevanda
    double Costo();       // Deve dire quanto costa
}

// Questa è una classe che rappresenta un caffè vero e proprio
public class ConcreteCaffe : IBevanda
{
    public string Descrizione()
    {
        return "Questo è un caffè"; // Il caffè dice che è un caffè
    }

    public double Costo()
    {
        return 1.30; // Il caffè costa 1.30 euro
    }
}

// Questa è una classe che rappresenta un tè
public class ConcreteTe : IBevanda
{
    public string Descrizione()
    {
        return "Questo è un te"; // Il tè dice che è un tè
    }

    public double Costo()
    {
        return 1.70; // Il tè costa 1.70 euro
    }
}

// Questa classe è una decorazione base per le bevande
// Serve per aggiungere cose al caffè o al tè
public abstract class DecoratoreBevanda : IBevanda
{
    // Qui teniamo una bevanda dentro un'altra bevanda
    protected IBevanda _component;

    // Quando creiamo questo oggetto, gli diamo la bevanda da decorare
    protected DecoratoreBevanda(IBevanda component)
    {
        _component = component;
    }

    // Di solito, la descrizione è quella della bevanda originale
    public virtual string Descrizione()
    {
        return _component.Descrizione();
    }

    // Anche il costo è quello della bevanda originale
    public virtual double Costo()
    {
        return _component.Costo();
    }
}

// Questo è un "decoratore" che aggiunge il latte alla bevanda
public class ConcreteDecoratorConLatte : DecoratoreBevanda
{
    public ConcreteDecoratorConLatte(IBevanda _component)
        : base(_component) { }

    public override string Descrizione()
    {
        // Aggiunge "con latte" alla descrizione
        return base.Descrizione() + " con latte";
    }

    public override double Costo()
    {
        // Aggiunge 0.30 euro al costo
        return base.Costo() + 0.30;
    }
}

// Questo aggiunge cioccolato alla bevanda
public class ConcreteDecoratorConCioccolato : DecoratoreBevanda
{
    public ConcreteDecoratorConCioccolato(IBevanda _component)
        : base(_component) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " con ciccolato";
    }

    public override double Costo()
    {
        return base.Costo() + 0.90;
    }
}

// Questo aggiunge panna alla bevanda
public class ConcreteDecoratorConPanna : DecoratoreBevanda
{
    public ConcreteDecoratorConPanna(IBevanda _component)
        : base(_component) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " con panna";
    }

    public override double Costo()
    {
        return base.Costo() + 0.50;
    }
}


public class Programma
{
    public static void Main()
    {
        // Saluta l’utente e gli fa scegliere una bevanda
        Console.WriteLine("Benvenuto! Scegli una bevanda:");
        Console.WriteLine("1. Caffè");
        Console.WriteLine("2. Tè");
        Console.Write("Scelta: ");
        string scelta = Console.ReadLine(); // L'utente scrive la sua scelta

        IBevanda bevanda = null; // Per ora non abbiamo una bevanda

        // Se l'utente ha scelto 1, crea un caffè
        if (scelta == "1")
            bevanda = new ConcreteCaffe();
        // Se ha scelto 2, crea un tè
        else if (scelta == "2")
            bevanda = new ConcreteTe();
        else
        {
            // Se l'utente scrive qualcosa di sbagliato, mostriamo errore e usciamo
            Console.WriteLine("Scelta non valida.");
            return;
        }

        // Chiediamo se vuole aggiungere qualcosa
        bool aggiungi = true;
        while (aggiungi)
        {
            Console.WriteLine("Vuoi aggiungere qualcosa?");
            Console.WriteLine("1. Latte (+0.30)");
            Console.WriteLine("2. Cioccolato (+0.90)");
            Console.WriteLine("3. Panna (+0.50)");
            Console.WriteLine("0. Fine");
            Console.Write("Scelta: ");
            string extra = Console.ReadLine();

            // A seconda di quello che ha scritto, aggiungiamo l’ingrediente
            switch (extra)
            {
                case "1":
                    bevanda = new ConcreteDecoratorConLatte(bevanda);
                    break;
                case "2":
                    bevanda = new ConcreteDecoratorConCioccolato(bevanda);
                    break;
                case "3":
                    bevanda = new ConcreteDecoratorConPanna(bevanda);
                    break;
                case "0":
                    aggiungi = false; // Fine degli ingredienti
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }

        // risultato finale: descrizione e prezzo
        Console.WriteLine("La tua bevanda: " + bevanda.Descrizione());
        Console.WriteLine("Costo totale: " + bevanda.Costo().ToString("0.00") + " euro");
    }
}
