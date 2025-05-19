using System;

class Operazioni
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Inserisci il primo numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero: ");
        int b = int.Parse(Console.ReadLine());

        Somma(a, b); // Chiamo la funzione somma
        Moltiplica(a, b); // Chiamo la funzione moltiplica
        Console.WriteLine(StampaRisultato("somma", Somma(a, b))); // Chiamo la funzione StampaRisultato per stampare il risultato della somma
        Console.WriteLine(StampaRisultato("moltiplicazione", Moltiplica(a, b))); // Chiamo la funzione StampaRisultato per stampare il risultato della moltiplicazione

        // Esercizio extra
        int c = 0;
        int d = 0;
        bool isValidInput = false; // variabile booleana per eseguire il ciclo finché non sono stati inseriti due numeri validi
        do
        {
            try
            {
                Console.WriteLine("Inserisci il primo numero: ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero: ");
                d = int.Parse(Console.ReadLine());
                isValidInput = true;
            }
            catch
            {
                Console.WriteLine("Errore: uno dei numeri non è valido. Riprova.");
                isValidInput = false;
            }
        }
        while (!isValidInput); // Ciclo infinito per continuare a chiedere i numeri

        Console.WriteLine(StampaRisultato("somma", Somma(c, d)));
        Console.WriteLine(StampaRisultato("moltiplicazione", Moltiplica(c, d)));

    }

    private static int Somma(int a, int b) // dichiaro la funzione somma con due parametri interi 
    {
        int somma; // dichiaro la varuabile somma 
        somma = a + b;
        return somma; // restituisco il valore della somma
    }

    private static int Moltiplica(int a, int b) // dichiaro la funzione moltiplica con due parametri interi
    {
        int prodotto;   // dichiaro la variabile prodotto
        prodotto = a * b;
        return prodotto; // restituisco il valore del prodotto
    }

    private static string StampaRisultato(string operazione, int risultato) // dichiaro la funzione StampaRisultato con due parametri string e intero
    {
        string messaggio; // dichiaro la variabile messaggio
        messaggio = $"Il risultato della {operazione} è: {risultato}";
        return messaggio; // restituisco il messaggio
    }

    private static double Divisione(double a, double b) // dichiaro la funzione Divisione con due parametri double
    {
        try
        {
            double quoziente; // dichiaro la variabile quoziente
            quoziente = a / b;
            return quoziente; // restituisco il valore del quoziente
        }
        catch (DivideByZeroException) // gestisco l'eccezione di divisione per zero
        {
            Console.WriteLine("Errore: divisione per zero non consentita.");
            return 0; // restituisco 0 in caso di errore
        }
    }
}
