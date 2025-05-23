using System;
using System.ComponentModel.Design.Serialization;
using System.Reflection;

public class ContoCorrente
{
    private decimal Saldo;
    private int NumeroOperazioni;

    public decimal saldo
    {
        get
        {
            return Saldo;
        }
    }

    public int numeroOperazioni
    {
        get
        {
            return NumeroOperazioni;
        }
    }

    public decimal Versa(decimal importo) // creo il metodo per far aggiornare il saldo all'utente del suo conto corrente
    {
        Console.WriteLine("Inserisci l'importo da versare: ");
        importo = decimal.Parse(Console.ReadLine());
        Saldo += importo;                           // aggiorna il campo privato
        NumeroOperazioni++;                         // aggiorna il campo privato
        Console.WriteLine($"Il tuo saldo è di: {Saldo}");
        return Saldo;
    }

    public decimal Preleva(decimal importo)
    {
        if (Saldo >= importo)
        {
            Console.WriteLine("Quanto vuoi prelevare?");
            importo = importo = decimal.Parse(Console.ReadLine());
            Saldo -= importo;
            NumeroOperazioni--;
            Console.WriteLine($"Il tuo saldo è di: {Saldo}");
            return Saldo;
        }
        else
        {
            Console.WriteLine("Non hai fondi sufficienti!");
            return Saldo;
        }
    }
}

public class Programma
{
    public static void Main()
    {
        bool continua = true;
        ContoCorrente conto = new ContoCorrente(); // istanzio il conto
        do
        {
            Console.WriteLine("Benvenuto! Cosa vuoi fare: 1.Creare un conto corrente\n 2.Versare denaro\n 3.Prelevare denaro\n 5.Visulizzare il numero di operazioni effettuate\n 5.Visualizzare il saldo\n 6.Uscire");
            int scelta = int.Parse(Console.ReadLine());
            if (scelta >= 1 && scelta <= 5)
            {
                switch (scelta)
                {
                    case 1:
                        break;
                    case 2:
                        conto.Versa(0); // richiamo il metodo Versa
                        break;
                    case 3:
                        conto.Preleva(0); // richiamo il metodo Preleva
                        break;
                    case 4:
                         Console.WriteLine($"Numero operazioni: {conto.numeroOperazioni}");
                        break;
                    case 5:
                        Console.WriteLine($"Saldo attuale: {conto.saldo}");
                        break;    
                    case 6:
                        Console.WriteLine("Arrivederci!");
                        continua = false;
                        break;
                }

            }
            else
            {
                Console.WriteLine("Seleziona un'operazione valida!");
            }

        }
        while (continua);
    }

}
