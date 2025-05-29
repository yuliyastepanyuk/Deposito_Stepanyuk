using System;
using System.Collections.Generic;

// Interfaccia Observer: chi vuole ricevere notifiche deve implementare questo metodo
public interface IObserver
{
    void NotificaCreazione(string nomeUtente);
}

// Interfaccia del soggetto osservabile (Subject)
public interface ISoggetto
{
    void Registra(IObserver o);                // Registra un nuovo observer
    void Rimuovi(IObserver o);                 // Rimuove un observer
    void Notifica(string nomeUtente);          // Notifica tutti gli observer
}

// Implementazione concreta del soggetto osservabile
public class GestoreCreazioneUtente : ISoggetto
{
    private readonly List<IObserver> osservatori = new List<IObserver>(); // Lista degli observer registrati

    public void Registra(IObserver o)
    {
        osservatori.Add(o); // Aggiunge un observer
    }

    public void Rimuovi(IObserver o)
    {
        osservatori.Remove(o); // Rimuove un observer
    }

    public void Notifica(string nomeUtente)
    {
        // Notifica ciascun observer registrato passando il nome del nuovo utente
        foreach (var o in osservatori)
        {
            o.NotificaCreazione(nomeUtente);
        }
    }

    public void CreaUtente(string nome)
    {
        // Usa la factory per creare un nuovo utente
        var utente = UserFactory.Crea(nome);
        
        // Notifica tutti gli observer del nuovo utente
        Notifica(utente.Nome);
    }
}

// Factory per creare istanze di Utente
public static class UserFactory
{
    public static Utente Crea(string nome)
    {
        // Crea e restituisce un nuovo utente
        return new Utente(nome);
    }
}

// Classe semplice che rappresenta un utente
public class Utente
{
    public string Nome;

    public Utente(string nome)
    {
        Nome = nome; // Inizializza il nome
    }

    public override string ToString()
    {
        return $"Il nome dell'utente è {Nome}"; // Rappresentazione in stringa
    }
}

// Modulo che reagisce alla creazione dell'utente (observer)
public class ModuloLog : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"[ModuloLog] Utente creato: {nomeUtente}");
    }
}

// Altro modulo observer, es. marketing
public class ModuloMarketing : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"[ModuloMarketing] Benvenuto a {nomeUtente}");
    }
}

// Programma principale
public class Programma
{
    public static void Main()
    {
        var gestore = new GestoreCreazioneUtente(); // Crea il soggetto osservabile

        var log = new ModuloLog();                  // Crea observer Log
        var marketing = new ModuloMarketing();      // Crea observer Marketing

        gestore.Registra(log);                      // Registra gli observer
        gestore.Registra(marketing);

        while (true)
        {
            Console.WriteLine("Inserisci il nome dell'utente da creare (invio per uscire): ");
            string nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))    // Se vuoto, esce dal ciclo
                break;
            gestore.CreaUtente(nome);               // Crea utente e notifica gli observer
        }
    }
}
