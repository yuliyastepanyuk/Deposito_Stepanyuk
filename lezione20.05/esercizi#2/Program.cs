
using System;

public class Utente
{
    public string Password;
    public int Eta;
    public string NickName;

    public Utente(string password, int eta, string nickname) // Costruttore
    {
        Password = password;
        Eta = eta;
        NickName = nickname;
    }

    public void Registrazione() // Metodo per la registrazione dell'utente
    {
        Console.WriteLine("Inserisci una password: ");
        Password = Console.ReadLine();
        Console.WriteLine("Inserisci la tua età: ");
        Eta = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il tuo nickname: ");
        NickName = Console.ReadLine();
        Console.WriteLine("Registrazione completata con successo!");
    }

    public void Login() // Metodo per il login dell'utente
    {
        Console.WriteLine("Inserisci la password: ");
        Password = Console.ReadLine();
        Console.WriteLine("Inserisci il tuo nickname: ");
        NickName = Console.ReadLine();
    }

    public override bool Equals(object obj) // Override del metodo Equals per confrontare due oggetti Utente, registrato e loggato
    {
        if (obj is Utente utente)
        {
            return Password == utente.Password && NickName == utente.NickName;
        }
        return false;
    }

    public override int GetHashCode() // Override del metodo GetHashCode per renderlo compatibile con Equals
    {
        return HashCode.Combine(Password, NickName);
    }

}

public class Programma
{
    public static void Main()
    {
        Utente utenteRegistrato = null;

        Console.WriteLine("Benvenuto nella calcolatrice, vuoi registrarti(r) o loggarti(l) ?");
        string scelta = Console.ReadLine();

        if (scelta == "r")
        {
            utenteRegistrato = new Utente("", 0, ""); // devo creare un oggetto utente per registrarlo, altrimenti non posso accedere al metodo Registrazione
            utenteRegistrato.Registrazione(); // Chiamata al metodo di registrazione
            Utente utenteLogin = new Utente("", 0, "");
            utenteLogin.Login(); // Chiamata al metodo di login
            if (utenteLogin.Equals(utenteRegistrato)) //
            {
                Console.WriteLine("Login effettuato con successo!");
                Calcolatrice(0, 0, ""); // Chiamata al metodo Calcolatrice
            }
            else
            {
                Console.WriteLine("Login fallito. Controlla la password e il nickname.");
            }
            
        }
        else if (scelta == "l")
        {
            Utente utenteLogin = new Utente("", 0, ""); // Creazione di un oggetto utente per il login
            utenteLogin.Login(); // Chiamata al metodo di login

            if (utenteLogin.Equals(utenteRegistrato)) // Confronto tra i due oggetti Utente
            {
                Console.WriteLine("Login effettuato con successo!");
                Calcolatrice(0, 0, ""); // Chiamata al metodo Calcolatrice
            }
            else
            {
                Console.WriteLine("Login fallito. Controlla la password e il nickname.");
            }
        }
        else
        {
            Console.WriteLine("Scelta non valida. Riprova.");
        }

        

    }

    public static int Calcolatrice(int a, int b, string operazione) // Metodo per eseguire le operazioni matematiche
    {
        Console.WriteLine("Scegli l'operazione da eseguire (+, *, /): ");
        operazione = Console.ReadLine();
        Console.WriteLine("Inserisci il primo numero: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero: ");
        b = int.Parse(Console.ReadLine());
        switch (operazione)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                if (b != 0)
                    return a / b;
                else
                    throw new DivideByZeroException("Divisione per zero non consentita.");
            default:
                throw new InvalidOperationException("Operazione non valida.");
        }
        Console.WriteLine($"Il risultato è: {a} {operazione} {b} = {Calcolatrice(a, b, operazione)}");
    }
}
