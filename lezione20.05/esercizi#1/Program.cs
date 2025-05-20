using System;

public class Libro
{
    public string Titolo;
    public string Autore;
    public int AnnoPubblicazione;

    public Libro(string titolo, string autore, int annoPubblicazione) // Costruttore
    {
        Titolo = titolo;
        Autore = autore;
        AnnoPubblicazione = annoPubblicazione;
    }

    public override string ToString() // Metodo ToString() per stampare le informazioni del libro
    {
        return $"{Titolo} di {Autore} ({AnnoPubblicazione})";
    }

    public override bool Equals(object obj) // Override del metodo Equals per confrontare due oggetti Libro
    {
        if (obj is Libro pippo)
        {
            return this.Titolo == pippo.Titolo && this.Autore == pippo.Autore;
        }
        return false;
    }

    public override int GetHashCode() // Override del metodo GetHashCode per generare un hash code unico per ogni libro
    {
        return HashCode.Combine(Titolo, Autore);
    }

    public Libro Clona()
    {
        return (Libro)this.MemberwiseClone(); // Crea una copia superficiale dell'oggetto corrente
    }
}

public class Programma
{
    public static void Main()
    {
        Libro libro1 = new Libro("Crash", "J.G. Ballard", 1973); // Creazione di un oggetto Libro
        Libro libro2 = new Libro("Crash", "J.G. Ballard", 1973);
        Libro libro3 = new Libro("Il condominio", "J.G. Ballard", 1975);

        Console.WriteLine(libro1); // Stampa delle informazioni del libro tramite il metodo ToString()
        Console.WriteLine(libro2);
        Console.WriteLine(libro3);

        Console.WriteLine(libro1.Equals(libro2)); // Confronto tra due oggetti Libro
        Console.WriteLine(libro1.Equals(libro3));

        Console.WriteLine(libro1.GetHashCode()); // Stampa dell'hash code del libro
        Console.WriteLine(libro2.GetHashCode());
        Console.WriteLine(libro3.GetHashCode());

        // Esercizio extra
        Console.WriteLine(libro1.GetType()); // Stampa del tipo dell'oggetto libro
        Console.WriteLine(libro2.GetType());
        Console.WriteLine(libro3.GetType());

        Console.WriteLine(Object.ReferenceEquals(libro1, libro2)); // statico si chiama tramite la classe non tramite l'oggetto per questo c'è Object.

        Libro libro4 = libro1.Clona();
        Console.WriteLine(libro4);

    }

}
 // ciao vuoi registrati o loggarti, loggati dammi il nickname e la password, una volta loggato puoi scegliere l'operazione da fare