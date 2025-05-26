public abstract class Animale // Classe astratta che rappresenta un animale, non può essere istanziata direttamente
{
    public abstract void FaiVerso(); // Metodo astratto che deve essere implementato dalle classi derivate
    public void Dormi() => Console.WriteLine("Zzz..."); // Metodo concreto che può essere usato da tutte le classi derivate

    public abstract void Muoviti(); // Nessun corpo, solo firma
}

public interface IVeicolo
{
    void Avvia(); // Metodo che deve essere implementato da qualsiasi classe che implementa questa interfaccia
}

public class Moto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("La moto è stata avviata.");
    }
}

public interface ILog
{
    void Scrivi(string messaggio) => Console.WriteLine(messaggio); // Metodo con implementazione di default
}



