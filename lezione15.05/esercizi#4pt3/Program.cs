using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserisci una frase: "):
        string frase = Console.ReadLine();
        AnalizzaParola(frase, out int numeroVocali, out int numeroConsonanti, out int numeroSpazi);
        Console.WriteLine($"Numero di vocali: {numeroVocali}");
        Console.WriteLine($"Numero di consonanti: {numeroConsonanti}");
        Console.WriteLine($"Numero di spazi: {numeroSpazi}");
    //--------------------------------------------------------------

        Console.WriteLine("Inserisci il primo numero: ");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero: ");
        double numero2 = double.Parse(Console.ReadLine());
        Dividi(numero1, numero2, out quoziente,  out resto);
        Console.WriteLine($"Quoziente: {quoziente}");
        Console.WriteLine($"Resto: {resto}");
    }

    private static void AnalizzaParola(string frase, out int numeroVocali, out int numeroConsonanti, out int numeroSpazi)
    {
        numeroVocali = 0;
        numeroConsonanti = 0;
        numeroSpazi = 0;

        foreach (char c in frase)
        {
            if (char.IsLetter(c))
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    numeroVocali++;
                }
                else
                {
                    numeroConsonanti++;
                }
            }
            else if (char.IsWhiteSpace(c))
            {
                numeroSpazi++;
            }
        }
    }
    
    private static void Dividi(double numero1, double numero2, out double quoziente, out double resto)
    {
        quoziente = numero1 / numero2;
        resto = numero1 % numero2;
    }
}
