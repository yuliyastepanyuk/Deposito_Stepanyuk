using System;
using System.Security.Authentication;

class Program
{
    public static void Main(string[] args)
    {
        string n = EsercizioMetodi("Yuliya");

        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"{numero} è pari? {VerificaPari(numero)}");

        Console.WriteLine("Inserisci la base:");
        double baseNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci l'esponente:");
        double esponente = double.Parse(Console.ReadLine());
        double risultato = CalcolaPotenza(baseNum, esponente);
        Console.WriteLine($"Il risultato di {baseNum} elevato a {esponente} è: {risultato}");
    }

    private static string EsercizioMetodi(string nome)
    {
        string saluto = $"Ciao {nome}";
        Console.WriteLine(saluto);
        return saluto;
    }

    private static bool VerificaPari(int numero)
    {
        return numero % 2 == 0;
    } 

    private static double CalcolaPotenza(double baseNum , double esponente)
    {
        return Math.Pow(baseNum, esponente);
    }
   
}