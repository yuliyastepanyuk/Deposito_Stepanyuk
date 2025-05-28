using System;
using System.Runtime.InteropServices.Marshalling;

public interface IVeicolo
{
    void Avvia();
    void MostraTipo();
}

public class ConcreteAuto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio dell'auto");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Auto");
    }
}

public class ConcreteMoto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio della moto");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Moto");
    }
}

public class ConcreteCamion : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio del camion");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Camion");
    }
}

public static class VeicoloFactory
{
    public static IVeicolo CreaVeicolo(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "auto":
                return new ConcreteAuto();
            case "moto":
                return new ConcreteMoto();
            case "camion":
                return new ConcreteCamion();
            default:
                Console.WriteLine("Tipo di veicolo non riconosciuto.");
                return null;
        }
    }
}

// Per evitare di creare più classi Creator diverse (una per ogni tipo di veicolo), puoi semplificare la tua logica rimuovendo l’uso del FactoryMethod() astratto e implementando un metodo statico dentro VeicoloFactory che restituisce direttamente l’istanza corretta.

public class Programma
{
    public static void Main()
    {
        Console.WriteLine("Quale veicolo vuoi creare?\n 1.Auto\n 2.Moto \n 3.Camion");
        int scelta = int.Parse(Console.ReadLine());

        IVeicolo veicolo = null; 

        switch (scelta)
        {
            case 1:
                veicolo = VeicoloFactory.CreaVeicolo("auto"); // utilizzo un oggetto che implementa quell'interfaccia
                break;
            case 2:
                veicolo = VeicoloFactory.CreaVeicolo("moto");
                break;
            case 3:
                veicolo = VeicoloFactory.CreaVeicolo("camion");
                break;
            default:
                Console.WriteLine("Scelta non valida!");
                break;
        }

        if (veicolo != null)
        {
            veicolo.Avvia();
            veicolo.MostraTipo();
        }
    }
}