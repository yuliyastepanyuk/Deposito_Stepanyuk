using System;

// il metodo GetHashCode() è un metodo che restituisce un codice hash per l'oggetto
// il codice hash è un numero intero che rappresenta l'oggetto

// se si sovrascrive il metodo Equals() è necessario sovrascrivere anche il metodo GetHashCode()
// oggetti uguali devono avere lo stesso codice hash
// il codice hash deve essere coerente con i dati significativi dell'oggetto
public class Prodotto
{
    public string Nome;
    public double Prezzo;

    // HashCode coerente con i dati significativi
    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Prezzo);
    }
}

public class Programma
{
    public static void Main()
    {
        Prodotto p1 = new Prodotto { Nome = "Penna", Prezzo = 1.50 };
        Prodotto p2 = new Prodotto { Nome = "Penna", Prezzo = 1.50 };

        Console.WriteLine(p1.GetHashCode()); // Stampa il codice hash del primo prodotto
        Console.WriteLine(p2.GetHashCode()); // Stampa il codice hash del secondo prodotto
        // Uguale se i valori sono uguali
    }
}
