using System;

public interface ITorta
{
    string Descrizione();
}

public class ConcreteTortaCioccolato : ITorta
{
    public string Descrizione()
    {
        return "Torta al cioccolato";
    }
}

public class ConcreteTortaVaniglia : ITorta
{
    public string Descrizione()
    {
        return "Torta alla vaniglia";
    }
}

public class ConcreteTortaFrutta : ITorta
{
    public string Descrizione()
    {
        return "Torta alla frutta";
    }
}

public abstract class DecoratoreTorta : ITorta
{
    protected ITorta baseTorta;

    protected DecoratoreTorta(ITorta basetorta)
    {
        baseTorta = basetorta;
    }

    public virtual string Descrizione()
    {
        return "Torta con aggiunta di";
    }
}

public class ConcreteDecoratorConPanna : DecoratoreTorta
{
    public ConcreteDecoratorConPanna(ITorta basetorta) : base(basetorta)
    { }
    public override string Descrizione()
    {
        return base.Descrizione() + " panna";
    }
}

public class ConcreteDecoratorConFragole : DecoratoreTorta
{
    public ConcreteDecoratorConFragole(ITorta basetorta) : base(basetorta)
    { }
    public override string Descrizione()
    {
        return base.Descrizione() + " fragole";
    }
}

public class ConcreteDecoratorConGlassa : DecoratoreTorta
{
    public ConcreteDecoratorConGlassa(ITorta basetorta) : base(basetorta)
    { }
    public override string Descrizione()
    {
        return base.Descrizione() + " glassa";
    }
}

public static class TortaFactory
{
    public static ITorta CreaTortaBase(string tipo)
    {
        Console.WriteLine("Scegli la base della tua torta tra: 'cioccolato', 'vaniglia' o 'frutta'");
        tipo = Console.ReadLine();
        switch (tipo.ToLower())
        {
            case "cioccolato":
                Console.WriteLine("Hai scelto cioccolato");
                return new ConcreteTortaCioccolato();
            case "vaniglia":
                Console.WriteLine("Hai scelto vaniglia");
                return new ConcreteTortaVaniglia();
            case "frutta":
                Console.WriteLine("Hai scelto frutta");
                return new ConcreteTortaFrutta();
            default:
                Console.WriteLine("Non hai inserito una scelta valida. Riprova!");
                return null;
        }
    }
}

public class Programma
{
    public static void Main()
    {
        ITorta torta = null;

        Console.WriteLine("Benvenuto nella pasticceria! Qui puoi ordinare una torta. Per favore scegli la base:");

        while (torta == null)
        {
            torta = TortaFactory.CreaTortaBase(""); // il metodo chiede all'utente la base
        }
        Console.WriteLine("Hai scelto: " + torta.Descrizione());

      

        bool aggiungi = true;
        while (aggiungi)
        {
            Console.WriteLine("Adesso puoi scegliere le tue aggiunte alla torta base:\n 1.Panna\n 2.Fragole\n 3.Glassa\n o premi 4. per uscire!");
            int extra = int.Parse(Console.ReadLine());
            switch (extra)
            {
                case 1:
                    torta = new ConcreteDecoratorConPanna(torta);
                    break;
                case 2:
                    torta = new ConcreteDecoratorConFragole(torta);
                    break;
                case 3:
                    torta = new ConcreteDecoratorConGlassa(torta);
                    break;
                case 4:
                    Console.WriteLine("Hai finito di decorare la tua torta!");
                    aggiungi = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }

        Console.WriteLine($"Ecco la tua {torta.Descrizione()}"); // senza le parentesi giustamente mi restituisce solo il tipo del metodo e non il metodo stesso
    }
}