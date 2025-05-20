using System;

public class Macchina
{
    // Proprietà della classe Macchina
    public string Motore;
    public int SospensioniMax;
    public float VelocitaMac;
    public int NrModifiche;

    public Macchina(string motore, int sospensioniMax, float velocitaMac, int nrModifiche) // Costruttore della classe Macchina
    {
        Motore = motore;
        SospensioniMax = sospensioniMax;
        VelocitaMac = velocitaMac;
        NrModifiche = nrModifiche;
    }

    public float AumentoVelocita() // Metodo per aumentare la velocità della macchina
    {
        VelocitaMac += 10;
        return VelocitaMac;
    }

    public int AumentoSospensioni() // Metodo per aumentare le sospensioni della macchina
    {
        SospensioniMax += 1;
        return SospensioniMax;
    }

    public string CambioMotore(string motore) // Metodo per cambiare il motore della macchina
    {
        Motore = Console.ReadLine();
        return Motore;
    }

    
}

public class Utente
{
    // Proprietà della classe Utente
    public string Nome;
    public int Credito;

    public Utente(string nome, int credito) // Costruttore della classe Utente
    {
        Nome = nome;
        Credito = credito;
    }

    public static Utente CreaUtente() // Metodo statico per creare un nuovo utente, statico perché non ha bisogno di un'istanza della classe ma può essere chiamato direttamente dalla classe
    {
        Console.WriteLine("Inserisci il tuo nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Inserisci il tuo credito (max : 10): ");
        int credito = int.Parse(Console.ReadLine());
        return new Utente(nome, credito);
    }

    // Un metodo è statico quando non dipende da uno stato specifico di un oggetto, ma solo dalla classe stessa.
    // Se invece vuoi che il metodo lavori sui dati di un oggetto già esistente, non deve essere statico.
}

public class Programma
{
    public static void Main()
    {
        Utente utente = Utente.CreaUtente(); // classe + nome variabile = chiama il metodo statico CreaUtente della classe Utente, che chiede i dati all’utente e restituisce un nuovo oggetto Utente

        Macchina auto1 = new Macchina("V8", 4, 200.5f, 0); // creo i miei tre oggetti macchina
        Macchina auto2 = new Macchina("V6", 4, 180.0f, 0);
        Macchina auto3 = new Macchina("V8", 4, 200.5f, 0);

        Console.WriteLine("Scegli un'auto da modificare: auto1, auto2, auto3");
        string scelta = Console.ReadLine();

        for (int credito = 0; credito < utente.Credito; credito++) // ciclo for che si ripete finchè l'utente non ha esaurito il credito
        {
            switch (scelta) // switch per scegliere quale auto modificare
            {
                case "auto1":
                    Console.WriteLine("Hai scelto auto1");
                    Console.WriteLine("Scegli cosa modificare: velocità, sospensioni, motore");
                    string modifica1 = Console.ReadLine();
                    switch (modifica1)
                    {
                        case "velocità":
                            auto1.AumentoVelocita(); // richiamo il metodo AumentoVelocita() dell'oggetto Macchina
                            break;
                        case "sospensioni":
                            auto1.AumentoSospensioni(); // richiamo il metodo AumentoSospensioni() dell'oggetto Macchina
                            break;
                        case "motore":
                            Console.WriteLine("Inserisci il nuovo motore: ");
                            auto1.CambioMotore(auto1.Motore);       // richiamo il metodo CambioMotore() dell'oggetto Macchina
                            break;
                        default:
                            Console.WriteLine("Modifica non valida");
                            break;
                    }
                    break;
                case "auto2":
                    Console.WriteLine("Hai scelto auto2");
                    Console.WriteLine("Scegli cosa modificare: velocità, sospensioni, motore");
                    string modifica2 = Console.ReadLine();
                    switch (modifica2)
                    {
                        case "velocità":
                            auto2.AumentoVelocita();
                            break;
                        case "sospensioni":
                            auto2.AumentoSospensioni();
                            break;
                        case "motore":
                            Console.WriteLine("Inserisci il nuovo motore: ");
                            auto2.CambioMotore(auto2.Motore);
                            break;
                        default:
                            Console.WriteLine("Modifica non valida");
                            break;
                    }
                    break;
                case "auto3":
                    Console.WriteLine("Hai scelto auto3");
                    Console.WriteLine("Scegli cosa modificare: velocità, sospensioni, motore");
                    string modifica3 = Console.ReadLine();
                    switch (modifica3)
                    {
                        case "velocità":
                            auto3.AumentoVelocita();
                            break;
                        case "sospensioni":
                            auto3.AumentoSospensioni();
                            break;
                        case "motore":
                            Console.WriteLine("Inserisci il nuovo motore: ");
                            auto3.CambioMotore(auto3.Motore);
                            break;
                        default:
                            Console.WriteLine("Modifica non valida");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
        Console.WriteLine("Con le nuove modifiche la tua auto ha le seguenti caratteristiche:");
        switch (scelta) // switch per stampare le caratteristiche dell'auto scelta dopo le modifiche
        {
            case "auto1":
                Console.WriteLine("Motore: " + auto1.Motore);
                Console.WriteLine("Sospensioni: " + auto1.SospensioniMax);
                Console.WriteLine("Velocità: " + auto1.VelocitaMac);
                break;
            case "auto2":
                Console.WriteLine("Motore: " + auto2.Motore);
                Console.WriteLine("Sospensioni: " + auto2.SospensioniMax);
                Console.WriteLine("Velocità: " + auto2.VelocitaMac);
                break;
            case "auto3":
                Console.WriteLine("Motore: " + auto3.Motore);
                Console.WriteLine("Sospensioni: " + auto3.SospensioniMax);
                Console.WriteLine("Velocità: " + auto3.VelocitaMac);
                break;
            default:
                Console.WriteLine("Nessuna auto valida selezionata.");
                break;
        }
    }
}

