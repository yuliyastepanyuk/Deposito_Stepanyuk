using System;

public class Persona
{
    public string Nome;
    public string Cognome;
    public int AnnoNascita;

    // Costruttore con parametri
    public Persona(string nome, string cognome, int annoNascita)
    {
        Nome = nome;
        Cognome = cognome;
        AnnoNascita = annoNascita;
    }
}

public class Programma
{
    public static void Main()
    {
        Persona p1 = null; ; // Dichiarazione della variabile p1
        Persona p2 = null; // Dichiarazione della variabile p2
        int numeroPersone = 0; // Inizializzazione del contatore a 2

        while (numeroPersone < 2) // Ciclo per inserire i dati di 2 persone
        {
            string nome = ""; // Inizializzazione della variabile nome
            string cognome = ""; // Inizializzazione della variabile cognome
            int annoNascita = 0; // Inizializzazione della variabile annoNascita

            // Inizio del ciclo per l'inserimento dei dati
            Console.WriteLine("Inserisci il nome della persona: ");
            try
            {
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome) || nome.Any(char.IsDigit)) // Controllo se il nome è vuoto o contiene numeri
                {
                    throw new Exception("Il nome non può essere vuoto."); // Lancia un'eccezione se il nome è vuoto
                }
            }
            catch (Exception e) // Gestione dell'eccezione
            {
                Console.WriteLine(e.Message); // Stampa il messaggio di errore
                continue; // Salta l'iterazione corrente del ciclo e riparte dall'inizio
            }
            // Se il nome è valido, continua a chiedere gli altri dati
            Console.WriteLine("Inserisci il cognome della persona: ");
            cognome = Console.ReadLine();
            Console.WriteLine("Inserisci l'anno di nascita della persona: ");
            annoNascita = int.Parse(Console.ReadLine());

            if (numeroPersone == 1) // se il ciclo è alla prima iterazione
            {
                p1 = new Persona(nome, cognome, annoNascita); // crea un nuovo oggetto Persona
            }
            else // se il ciclo è alla seconda iterazione
            {
                p2 = new Persona(nome, cognome, annoNascita); // crea un nuovo oggetto Persona

            }
            numeroPersone++; // incrementa il contatore
        }
            Console.WriteLine($"Nome: {p1.Nome}, Cognome: {p1.Cognome}, Anno di Nascita: {p1.AnnoNascita}");
            Console.WriteLine($"Nome: {p2.Nome}, Cognome: {p2.Cognome}, Anno di Nascita: {p2.AnnoNascita}");
    }
}
