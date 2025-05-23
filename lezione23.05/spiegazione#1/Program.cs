// al livello logico override è un metodo nuovo, cambia la forma ma non il comportamento
// overloading avviene nella stessa classe più metodi con lo stesso nome me firme diverse, poliformismo statico, una classe diversa può fare il suo overload

public class Calcolatrice
{
    public int Somma(int a, int b) => a + b;
    public double Somma(double a, double b) => a + b;
    public int Somma(int a, int b, int c) => a + b + c;
}

public class Forma
{
    public virtual double CalcolaArea()
    {
        return 0;
    }
}

public class Rettangolo : Forma
{
    public double Base { get; set; }
    public double Altezza { get; set; }

    public override double CalcolaArea()
    {
        return Base * Altezza;
    }
}

public class Cerchio : Forma
{
    public double Raggio { get; set; }

    public override double CalcolaArea()
    {
        return Math.PI * Raggio * Raggio;
    }
}

public class Programma
{
    public static void Main()
    {
        List<Forma> forme = new List<Forma>
        {
            new Rettangolo { Base = 4,  Altezza = 5 },
            new Cerchio { Raggio = 3 }
        };

        foreach (Forma f in forme)
        {
            Console.WriteLine("Area: " + f.CalcolaArea());
        }
    }
}

// poliformismo RUNTIME
// ogni chiamata a CalcolaArea() invoca la versione corrispondente