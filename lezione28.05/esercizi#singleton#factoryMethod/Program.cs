using System;

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

public sealed class RegistroVeicoli
{
    private static RegistroVeicoli istanza;
    private List<IVeicolo> veicoliCreati;

    private RegistroVeicoli()
    {
        veicoliCreati = new List<IVeicolo>();
    }

    public static RegistroVeicoli instance
    {
        get
        {
            if (istanza == null)
            {
                istanza = new RegistroVeicoli();
            }
            return istanza;
        }
    }

    public void Registra(IVeicolo veicolo)
    {
        veicoliCreati.Add(veicolo);
    }

    public void StampaTutti()
    {
        foreach (IVeicolo v in veicoliCreati)
        {
            v.Avvia();
            v.MostraTipo();
        }
    }
}

public class Menu
{
    public bool ShowMenu()
    {
        IVeicolo veicolo = null;

        Console.WriteLine("Cosa vuoi fare?\n 1.Scegliere un tipo di veicolo.\n 2.Stampare l'elenco dei veicoli registrati.\n 3.Uscire");
        int scelta = int.Parse(Console.ReadLine());
        if (scelta >= 1 && scelta <= 3)
        {
            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Scegli tra: 'auto', 'moto' e 'camion'");
                    string sceltaVeicolo = Console.ReadLine();
                    veicolo = VeicoloFactory.CreaVeicolo(sceltaVeicolo);
                    RegistroVeicoli.instance.Registra(veicolo); // REGISTRA il veicolo!
                    Console.WriteLine("Veicolo registrato!");
                    break;
                case 2:
                    RegistroVeicoli.instance.StampaTutti();
                    break;
                case 3:
                    Console.WriteLine("Uscita dal programma.");
                    return false; // Esci dal ciclo   
            }
        }
        else
        {
            Console.WriteLine("Scelta non valida!");
        }
        return true; // Continua il ciclo
    }
}

public class Programma
{
    public static void Main()
    {
        bool continua = true;
        Menu menu = new Menu();
        do
        {
            continua = menu.ShowMenu();
        }
        while (continua);


    }
}

// Devi scrivere continua = menu.ShowMenu(); perché il metodo ShowMenu() restituisce un valore booleano (true o false) che indica se il ciclo deve continuare oppure no.
// Se scrivi solo menu.ShowMenu();, il valore di ritorno viene ignorato e la variabile continua rimane sempre true, quindi il ciclo non si fermerà mai.

// Se vuoi chiamare ShowMenu() su un oggetto, NON deve essere statico.
// Se vuoi chiamarlo senza creare l'oggetto, deve essere statico e lo chiami così: Menu.ShowMenu();