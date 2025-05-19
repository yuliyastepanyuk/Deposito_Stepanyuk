using System;

public class Studente
{
    public string Nome;
    public int Matricola;
    public double MediaVoti;

    public Studente(string nome, int matricola, double mediaVoti)
    {
        Nome = nome;
        Matricola = matricola;
        MediaVoti = mediaVoti;
    }
}

/*public class Programma
{
    public static void Main()
    {
        int numeroStudenti = 1;

        for (int i = 0; i < numeroStudenti; i++)
        {
            Console.WriteLine("Inserisci il nome dello studente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci la matricola dello studente: ");
            int matricola = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la media voti dello studente: ");
            double mediaVoti = double.Parse(Console.ReadLine());
            Studente studente;
            studente = new Studente(nome, matricola, mediaVoti);
            Console.WriteLine($"Nome: {studente.Nome}, Matricola: {studente.Matricola}, Media Voti: {studente.MediaVoti}");
        }

        for (int i = 0; i < numeroStudenti; i++)
        {
            Console.WriteLine("Inserisci il nome dello studente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci la matricola dello studente: ");
            int matricola = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la media voti dello studente: ");
            double mediaVoti = double.Parse(Console.ReadLine());
            Studente studente;
            studente = new Studente(nome, matricola, mediaVoti);
            Console.WriteLine($"Nome: {studente.Nome}, Matricola: {studente.Matricola}, Media Voti: {studente.MediaVoti}");
        }

    }
}*/

// Esercizio extra
/*public class Programma1
{
    public static void Main()
    {
        int numeroStudenti = 1;

        for (int i = 0; i < numeroStudenti; i++)
        {
            string nome = "";
            int matricola = 0;
            double mediaVoti = 0;

            Console.WriteLine("Inserisci il nome dello studente: ");
            try
            {
                nome = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);
            }

            Console.WriteLine("Inserisci la matricola dello studente: ");
            try
            {
                matricola = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Errore: " + e.Message);
            }

            Console.WriteLine("Inserisci la media voti dello studente: ");
            try
            {
                mediaVoti = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Errore: " + e.Message);
            }

            Studente studente = new Studente(nome, matricola, mediaVoti);
            Console.WriteLine($"Nome: {studente.Nome}, Matricola: {studente.Matricola}, Media Voti: {studente.MediaVoti}");
        }
    }

}*/

public class Programma2
{
    public static void Main()
    {
        int numeroStudenti = 0;

        while (numeroStudenti < 2)
        {
            string nome = "";
            int matricola = 0;
            double mediaVoti = 0;

            Console.WriteLine("Inserisci il nome dello studente: ");
            try
            {
                nome = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);
            }

            Console.WriteLine("Inserisci la matricola dello studente: ");
            try
            {
                matricola = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Errore: " + e.Message);
            }

            Console.WriteLine("Inserisci la media voti dello studente: ");
            try
            {
                mediaVoti = double.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Errore: " + e.Message);
            }

            Studente studente = new Studente(nome, matricola, mediaVoti);
            Console.WriteLine($"Nome: {studente.Nome}, Matricola: {studente.Matricola}, Media Voti: {studente.MediaVoti}");

            numeroStudenti++;
        }
    }
}

// sto sbagliando perché non sto creando due oggetti diversi ma sto riscrivendo lo stesso oggetto
// quindi devo istanziare prima il primo oggetto e poi il secondo
// e poi fare il ciclo 
// e un if else per assegnare i valori