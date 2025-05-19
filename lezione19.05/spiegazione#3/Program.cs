using System;

public class Persona
{
    public string Nome;
    public int Eta;

    // Sovrascirve il metodo ToString per personalizare l'output
    public override string ToString()
    {
        return $"Nome: {Nome}, Età: {Eta}";
    }
}

public class Programma
{
    public static void Main()
    {
        Persona p = new Persona { Nome = "Mario", Eta = 25 };
        Console.WriteLine(p); // Stampa l'oggetto Persona
    }
}