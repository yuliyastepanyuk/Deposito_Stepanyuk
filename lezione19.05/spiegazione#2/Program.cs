using System;

public class Persona
{
    public string Nome;
    public int Eta;

    //Construttore con parametri
    public Persona(string nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }

    public void Presentati()
    {
        Console.WriteLine($"Ciao, sono {Nome} e ho {Eta} anni.");
    }
}

public class Programma()
{
    public static void Main()
    {
        //Creazione dell'oggetto con costruttore
        Persona p = new Persona("Anna", 30);

        //Chiamata al metodo
        p.Presentati(); // chiamata al metodo Presentati dell'oggetto p
    }
}