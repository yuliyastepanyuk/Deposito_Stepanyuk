using System;

public class Film // Definizione della classe Film
{
    public string Titolo; // Attributi della classe
    public string Regista;
    public int Anno;
    public string Genere;

    public Film(string titolo, string regista, int anno, string genere) // Costruttore della classe
    {
        Titolo = titolo;
        Regista = regista;
        Anno = anno;
        Genere = genere;
    }

    public override string ToString() // Metodo per restituire una rappresentazione in formato stringa personalizzato dell'oggetto 
    {
        return $"Il film {Titolo} è stato diretto da {Regista} nel {Anno} ed è di genere {Genere}.";
    }

    public static Film InserisciFilm() // Metodo per inserire i dati di un film per creare un oggetto Film
    {
        Console.WriteLine("Inserisci il titolo del film: ");
        string titolo = Console.ReadLine();
        Console.WriteLine("Inserisci il regista del film: ");
        string regista = Console.ReadLine();
        Console.WriteLine("Inserisci l'anno di uscita del film: ");
        int anno = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il genere del film: ");
        string genere = Console.ReadLine();
        Film film = new Film(titolo, regista, anno, genere); // Creazione di un oggetto Film
        return film; // Restituzione dell'oggetto Film creato,  senza il metodo non passerebbe i dati al main
    }

    public static Film StampaPerGenere(string genere) // Metodo per stampare i film in base al genere
    {
        Console.WriteLine($"Ecco i film di genere {genere}:");
        return null; // Restituisce null poiché non è implementato
    }

    public static Film StampaPerAnno(int anno) // Metodo per stampare i film in base all'anno
    {
        Console.WriteLine($"Ecco i film usciti nel {anno}:");
        return null; // Restituisce null poiché non è implementato
    }

    public static Film StampaPerRegista(string regista) // Metodo per stampare i film in base al regista
    {
        Console.WriteLine($"Ecco i film diretti da {regista}:");
        return null; // Restituisce null poiché non è implementato
    }
    public static Film StampaPerTitolo(string titolo) // Metodo per stampare i film in base al titolo
    {
        Console.WriteLine($"Ecco i film con il titolo {titolo}:");
        return null; // Restituisce null poiché non è implementato
    }
}

public class Programma
{
    public static void Main(string[] args)
    {
        List<string> videoteca = new List<string>();  // Creazione di una lista per memorizzare i film
        Console.WriteLine("Benvenuto nella videoteca!\n Quanti film vuoi inserire(almeno tre)?"); // Messaggio di benvenuto
        int nInserimenti = int.Parse(Console.ReadLine()); // Lettura del numero di film da inserire
        if (nInserimenti < 3) // Controllo se il numero di film è minore di 3
        {
            Console.WriteLine("Devi inserire almeno tre film.");
            return;
        }
        for (int i = 0; i < nInserimenti; i++) // Ciclo per inserire i film
        {
            Film film = Film.InserisciFilm(); // Chiamata al metodo per inserire i film e ottenere un oggetto Film
            Console.WriteLine("Film inserito con successo!"); // Messaggio di conferma
            videoteca.Add(film.ToString()); // Aggiunta del film alla lista

        }

        Console.WriteLine("Ecco i film inseriti nella videoteca:"); // Messaggio per visualizzare i film
        foreach (string film in videoteca) // Ciclo per stampare i film
        {
            Console.WriteLine(film); // Stampa del film
        }

        Console.WriteLine("Come vuoi filtrare la ricerca tra 'genere', 'anno', 'regista' e 'titolo': "); // Messaggio per inserire il filtro
        string filtro = Console.ReadLine(); // Lettura del filtro

        switch (filtro.ToLower()) // Controllo del filtro scelto
        {
            case "genere":
                Console.WriteLine("Inserisci il genere: ");
                string genere = Console.ReadLine();
                Film.StampaPerGenere(genere); // Chiamata al metodo per stampare i film per genere
                break;
            case "anno":
                Console.WriteLine("Inserisci l'anno: ");
                int anno = int.Parse(Console.ReadLine());
                Film.StampaPerAnno(anno); // Chiamata al metodo per stampare i film per anno
                break;
            case "regista":
                Console.WriteLine("Inserisci il regista: ");
                string regista = Console.ReadLine();
                Film.StampaPerRegista(regista); // Chiamata al metodo per stampare i film per regista
                break;
            case "titolo":
                Console.WriteLine("Inserisci il titolo: ");
                string titolo = Console.ReadLine();
                Film.StampaPerTitolo(titolo); // Chiamata al metodo per stampare i film per titolo
                break;
            default:
                Console.WriteLine("Filtro non valido."); // Messaggio di errore se il filtro non è valido
                break;
        }

        Console.WriteLine("Prima di uscire vuoi rimuovere un film? (si/no)"); // Messaggio per chiedere se si vuole rimuovere un film
        string risposta = Console.ReadLine(); // Lettura della risposta

        if (risposta.ToLower() == "si") // Controllo se la risposta è "si"
        {
            Console.WriteLine("Inserisci il titolo del film da rimuovere: ");
            string titoloDaRimuovere = Console.ReadLine(); // Lettura del titolo del film da rimuovere
            if (videoteca.Remove(titoloDaRimuovere)) // Rimozione del film dalla lista
            {
                Console.WriteLine($"Il film {titoloDaRimuovere} è stato rimosso dalla videoteca."); // Messaggio di conferma
            }
            else
            {
                Console.WriteLine($"Il film {titoloDaRimuovere} non è stato trovato nella videoteca."); // Messaggio di errore se il film non è trovato
            }
        }
        else
        {
            Console.WriteLine("Grazie per aver utilizzato la videoteca!"); // Messaggio di chiusura
        }

    }
}
