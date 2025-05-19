using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserisci un numero: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Il numero inserito è: {numero}");
        Raddoppia(ref numero);
        Console.WriteLine($"Il numero raddoppiato è: {numero}");

        Console.WriteLine("Inserisci una data (giorno mese anno): ");
        string[] dataInput = Console.ReadLine().Split(' ');
        int giorno = int.Parse(dataInput[0]);
        int mese = int.Parse(dataInput[1]);
        int anno = int.Parse(dataInput[2]);

        Console.WriteLine($"Data inserita: {giorno}/{mese}/{anno}");
        AggiustaData(ref giorno, ref mese, ref anno);
        Console.WriteLine($"Data corretta: {giorno}/{mese}/{anno}");

    }

    private static void Raddoppia(ref int numero)
    {
        numero *= 2;
        //return numero; non serve il return perchè stiamo passando il riferimento alla variabile
    }

    private static void AggiustaData(ref int giorno, ref int mese, ref int anno)
    {
        if (giorno > 30)
        {
            giorno = 1;
            mese++;
        }
        if (mese > 12)
        {
            mese = 1;
            anno++;
        }
    }
}
