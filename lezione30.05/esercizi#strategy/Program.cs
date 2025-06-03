using System;

public interface IStrategiaOperazione // interfaccia che definisce il metodo comune
{
    double Calcola(double a, double b);
}

public class ConcreteSommaStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a + b;
    }
}

public class ConcreteSottrazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a - b;
    }
}

public class ConcreteMoltiplicazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a * b;
    }
}

public class ConcreteDivisioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Impossibile dividere per zero.");
        return a / b;
    }
}

public class Calcolatrice 
{
    private IStrategiaOperazione _strategia;

    public void EseguiOperazione(double a, double b)
    {
        if (_strategia == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");
            return;
        }
        double risultato = _strategia.Calcola(a, b);
        Console.WriteLine($"Risultato dell'operazione: {risultato}");
    }

    public void ImpostaStrategia(IStrategiaOperazione strategia)
    {
        _strategia = strategia;
    }
}

public class Programma
{
    public static void Main()
    {
        Console.WriteLine("Inserisci un numero: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci un secondo numero: ");
        double b = double.Parse(Console.ReadLine());

        string scelta;
        bool sceltaValida = false;
        Calcolatrice calcola = new Calcolatrice();

        do
        {
            Console.WriteLine("Che operazione vorresti eseguire tra: '+', '-', '*' e '/'");
            scelta = Console.ReadLine();

            switch (scelta)
            {
                case "+":
                    calcola.ImpostaStrategia(new ConcreteSommaStrategia());
                    calcola.EseguiOperazione(a, b);
                    break;
                case "-":
                    calcola.ImpostaStrategia(new ConcreteSottrazioneStrategia());
                    calcola.EseguiOperazione(a, b);
                    break;
                case "*":
                    calcola.ImpostaStrategia(new ConcreteMoltiplicazioneStrategia());
                    calcola.EseguiOperazione(a, b);
                    break;
                case "/":
                    calcola.ImpostaStrategia(new ConcreteDivisioneStrategia());
                    calcola.EseguiOperazione(a, b);
                    break;
                default:
                    Console.WriteLine("Scelta non valida, riprova.");
                    sceltaValida = false;
                    break;
            }
            sceltaValida = true;
        } while (!sceltaValida);
    }
}

// più operatori