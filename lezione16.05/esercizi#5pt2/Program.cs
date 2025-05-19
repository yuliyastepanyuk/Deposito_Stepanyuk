using System;

class Program
{
    public static void Main(string[] args)
    {
        ChiediNumeri();
        Dividi();
        Somma();
    }

    private static void ChiediNumeri()
    {
        Console.WriteLine("Inserisci un numero:");
        Console.WriteLine("Inserisci un altro numero:");
        try
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Errore: inserisci un numero valido.");
        }
    }

    private static double Dividi()
    {
        Console.WriteLine("Inserisci un numero: ");
        Console.WriteLine("Inserisci un altro numero: ");
        try
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            return a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Errore: divisione per zero.");
            return 0;
        }
        catch (FormatException)
        {
            Console.WriteLine("Errore: inserisci un numero valido.");
            return 0;
        }
    }

    private static void Somma() // da finire perché non funziona
    {
        int[] numeri = new int[5];  
        int somma = 0; 
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Inserisci il numero {i + 1}: ");
            try
            {
                numeri[i] = int.Parse(Console.ReadLine());
               
            }
            catch
            {
                Console.WriteLine("Errore: inserisci un numero valido.");
                numeri[i] = 0; // assegna 0 in caso di errore
            }
            finally
            {
                 somma += numeri[i];
            }
        }
        Console.WriteLine($"La somma è: {somma}");
        
    }    
}
