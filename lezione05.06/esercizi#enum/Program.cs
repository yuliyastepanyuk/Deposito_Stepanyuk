using System;

public enum GiorniSettimana
{
    Lunedì,
    Martedì,
    Mercoledì,
    Giovedì,
    Venerdì,
    Sabato,
    Domenica
}

public class Program
{
    public static void Main()
    {
        GiorniSettimana giorno;

        Console.WriteLine("Scegli un giorno della settimana:");
        foreach (GiorniSettimana g in Enum.GetValues(typeof(GiorniSettimana)))
        {
            Console.WriteLine(g);
        }
        string input = Console.ReadLine();

        switch(input)
        {
            case "Lunedì":
                giorno = GiorniSettimana.Lunedì;
                Console.WriteLine("Hai scelto Lunedì.");
                break;
            case "Martedì":
                giorno = GiorniSettimana.Martedì;
                Console.WriteLine("Hai scelto Martedì.");
                break;
            case "Mercoledì":
                giorno = GiorniSettimana.Mercoledì;
                Console.WriteLine("Hai scelto Mercoledì.");
                break;
            case "Giovedì":
                giorno = GiorniSettimana.Giovedì;
                Console.WriteLine("Hai scelto Giovedì.");
                break;
            case "Venerdì":
                giorno = GiorniSettimana.Venerdì;
                Console.WriteLine("Hai scelto Venerdì.");
                break;
            case "Sabato":
                giorno = GiorniSettimana.Sabato;
                Console.WriteLine("Hai scelto Sabato.");
                break;
            case "Domenica":
                giorno = GiorniSettimana.Domenica;
                Console.WriteLine("Hai scelto Domenica.");
                break;
            default:
                Console.WriteLine("Giorno non valido.");
                return;    
        } 

    }
}