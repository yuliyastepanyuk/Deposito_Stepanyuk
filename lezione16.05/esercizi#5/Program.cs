using System;
using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Inserisci il primo numero intero: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero intero: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Somma(a, b));

        Console.WriteLine("Inserisci il primo numero: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero: ");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine(Somma(c, d).ToString());

        Console.WriteLine("Inserisci il primo numero intero: ");
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero intero: ");
        int f = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il terzo numero intero: ");
        int g = int.Parse(Console.ReadLine());
        Console.WriteLine(Somma(e, f, g));

        Console.WriteLine("Inserisci una stringa: ");
        string testo = Console.ReadLine();
        Console.WriteLine(Analizza(testo));

        Console.WriteLine("Inserisci un carattere: ");
        char c1 = char.Parse(Console.ReadLine());
        Console.WriteLine(Analizza(testo, c1));

      
        Console.WriteLine("Vuoi contare le vocali? (true/false): ");
        bool contaVocali = bool.Parse(Console.ReadLine());
        Console.WriteLine(Analizza(testo, contaVocali));
    
    }

    private static int Somma(int a, int b)
    {
        int somma = a + b;
        return somma;
    }

    private static double Somma(double a, double b)
    {
        double somma = a + b;
        return somma;
    }

    private static int Somma(int a, int b, int c)
    {
        int somma = a + b + c;
        return somma;
    }

    private static int Analizza(string testo)
    {
        int totale = 0;
        foreach (char c in testo)
        {
            if(!char.IsWhiteSpace(c))
            {
                 totale++;
            }
           
        }
        return totale;
    }

    private static int Analizza(string testo, char c)
    {
        int totale = 0;
        foreach (char a in testo)
        {
            if (a == c)
            {
                totale++;
            }
        }
        return totale;
    }

    private static int Analizza(string testo, bool contaVocali)
    {
        string vocali = "aeiou";
        int totaleV = 0;
        int totaleC = 0;

        if (contaVocali == true)
        {

            foreach (char c in testo)
            {
                if (vocali.Contains(c))
                {
                    totaleV++;
                }
            }
        }
        else
        {

            foreach (char c in testo)
            {
                if (!vocali.Contains(c) && !char.IsWhiteSpace(c))
                {
                    totaleC++;
                }
            }
        }
        return contaVocali ? totaleV : totaleC;
    }
    
}

// variazione da applicare riciclare i due metodi precedenti di Analizza per fare gli altri
// si può anche compattare il terzo metodo Analizza