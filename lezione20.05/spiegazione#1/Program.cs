using System;


// il metodo Equals() è un metodo di confronto che verifica se due oggetti sono uguali
// di default confronta i riferimenti degli oggetti
// per confrontare il contenuto degli oggetti è necessario sovrascrivere il metodo Equals()

public class Punto
{
    public int x;
    public int y;

    // Sovrascrive Equals per confrontare le coordinate dei punti
    public override bool Equals(object obj)
    {
        if (obj is Punto altro) // obj is + nome della classe + nome della variabile
                                // verifica se l'oggetto passato è dello stesso tipo cioè Punto
                                // e lo assegna alla variabile altro
        {
            return this.x == altro.x && this.y == altro.y;
        }
        return false; // se l'oggetto non è dello stesso tipo ritorna false
    }
}

public class Programma
{
    public static void Main()
    {
        Punto a = new Punto { x = 1, y = 2 };
        Punto b = new Punto { x = 1, y = 2 };

        Console.WriteLine(a.Equals(b)); // True, perché le coordinate sono uguali
    }
}

// entra nell'if solo se a e b sono dello stesso tipo