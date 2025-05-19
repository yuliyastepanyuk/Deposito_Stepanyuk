using System;
// overload dei metodi
class Program
{
    //static int stringtoInt;
    static void Main(string[] args)
    {
        Stampa(5);
        var a = Stampa("5");
        Stampa("Ciao", 54);

        //string stringa = "abc";
        if (int.TryParse("3", out int result) == true)
        {
            //stampi numero convertito
        }
        else
        {
            //stampa errore, conversione errata
        }


        try
        {
            int stringToInt = int.Parse(Console.ReadLine()); //eccezione
        }
        catch (Exception e) //aggiungi exception e per stampare l'errore, la classe padre di tutti gli errori
        {
            Console.WriteLine($"Errore: {e}");
        }
        finally
        {
            //questo codice viene eseguito sempre, anche se non ci sono errori
            Console.WriteLine("Fine del programma");
        }
     

        //Console.WriteLine($"{stringToInt}"); 


    }

    static void Stampa(int numero)
    {
        Console.WriteLine(numero);
    }

    static string Stampa(string testo)
    {
        Console.WriteLine(testo);
        return testo;
        
    }
    
//(commento xml che aggiungo per spiegare la funzione)
    /// <summary>
    /// Questa funzione stampa un testo e un numero. 
    /// </summary>
    /// <param name="testo"></param>
    /// <param name="numero"></param>
    static void Stampa(string testo, int numero)
    {
        Console.WriteLine(testo + numero);
    }


}
