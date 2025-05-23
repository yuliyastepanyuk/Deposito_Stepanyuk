using System;
using System.Net.Mail;
using System.Runtime.Versioning;

public class Veicolo // classe padre
{
    public string Targa;
    //extra
    public int RiparazioniEseguite;

    public Veicolo(string targa) // costruttore base
    {
        Targa = targa;
    }

    public virtual void Ripara() // metodo che richiama un console.writeline
    {
        Console.WriteLine("Il veicolo viene controllato.");
    }

    //extra
    public virtual int Ripara(int budget) // overload, sto facendo un metodo con lo stesso nome ma con parametro diverso, cioè budget dell'utente
    {
        if (RiparazioniEseguite >= 3) // il massimo delle riparzioni per veicolo è 3
        {
            Console.WriteLine("Limite di riparazioni raggiunto per questo veicolo.");
            return 0;
        }
        int costo = 50; // costo per una riparazione
        if (budget >= costo) // se ovviamente il budget è maggiore del costo permetto di eseguire un'operazione
        {
            budget -= costo; // quindi tolgo il costo dal bydget
            RiparazioniEseguite++; // incremento il numero delle riparazioni per quel veicolo
            Ripara(); // richiamo il ripara quello void che stampa il console.writeline
            Console.WriteLine($"Riparazione eseguita. Riparazioni totali: {RiparazioniEseguite}/3. Budget rimasto: {budget} euro.");
            return costo;
        }
        else
        {
            Console.WriteLine("Budget insufficiente per la riparazione."); // se non ci sono fonsi sufficienti 
            return 0;
        }
    }

    
}

public class Auto : Veicolo // classe derivata
{
    public Auto(string targa) : base(targa) // costruttore
    {

    }
    public override void Ripara() // overide personalizzato
    {
        Console.WriteLine("Controllo olio, freni e motore dell'auto.");
    }

    public static Auto AggiungiAuto() // creo un oggetto auto
    {
        Console.WriteLine("Inserisci la targa");
        string targa = Console.ReadLine();
        Auto auto = new Auto(targa);
        return auto;
    }
}

public class Moto : Veicolo // classe derivata
{
    public Moto(string targa) : base(targa) // costruttore
    {

    }
    public override void Ripara() // override con messaggio personalizzato
    {
        Console.WriteLine("Controllo catena. freni e gomme della moto.");
    }

    public static Moto AggiungiMoto() // creo oggetto moto
    {
        Console.WriteLine("Inserisci la targa");
        string targa = Console.ReadLine();
        Moto moto = new Moto(targa);
        return moto;
    }
}

public class Camion : Veicolo
{
    public Camion(string targa) : base(targa)
    {

    }

    public override void Ripara()
    {
        Console.WriteLine("Controllo sospensioni, freni rinforzati e carico del camion.");
    }

    public static Camion AggiungiCamion()
    {
        Console.WriteLine("Inserisci la targa");
        string targa = Console.ReadLine();
        Camion camion = new Camion(targa);
        return camion;
    }
}

public class Programma
{
    public static void Main()
    {
        int budget = 0; // inizializzo il budget come variabile
        bool continua = true; // la mia condizione per il menù
        List<Veicolo> veicoli = new List<Veicolo>(); // inizializzo la lista di tipo veicolo
        do
        {
            Console.WriteLine("Benvenuto in officina, cosa vuoi fare:\n 1.Inserire un 'Auto'\n 2.Inserire una 'Moto'\n 3.Inserire un 'Camion'\n 4.Inserire il tuo budget per le riparazioni\n 5.Su quale veicolo vuoi eseguire una riparazione?\n 6.Visulizzare la lista dei veicoli con le correspetive riparazioni\n 7.Esci");
            int scelta = int.Parse(Console.ReadLine());

            if (scelta >= 1 && scelta <= 7)
            {
                switch (scelta)
                {
                    case 1:
                        Auto auto = Auto.AggiungiAuto(); // richiamo il meotodo della classe auto
                        veicoli.Add(auto);
                        Console.WriteLine("Auto aggiunta con successo!");
                        break;
                    case 2:
                        Moto moto = Moto.AggiungiMoto(); // richiamo il metodo della classe moto
                        veicoli.Add(moto);
                        Console.WriteLine("Moto aggiunta con successo!");
                        break;
                    case 3:
                        Camion camion = Camion.AggiungiCamion(); // richiamo il metodo della classe camion
                        veicoli.Add(camion);
                        Console.WriteLine("Camion aggiunto con successo!");
                        break;
                    case 4:
                        budget = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Il tuo budget è {budget}");
                        break;
                    case 5:
                        if (veicoli.Count == 0) // controllo formale
                        {
                            Console.WriteLine("Nessun veicolo inserito.");
                            break;
                        }
                        Console.WriteLine("Scegli la targa del veicolo da riparare:");
                        for (int i = 0; i < veicoli.Count; i++) // visulizzo la lista dei veicoli col le rispettive targhe e le riparazioni eeguite su quel determinato veicolo
                        {
                            Console.WriteLine($"{i + 1}. {veicoli[i].Targa} (Riparazioni: {veicoli[i].RiparazioniEseguite}/3)");
                        }
                        int sceltaVeicolo = int.Parse(Console.ReadLine()) - 1;
                        if (sceltaVeicolo >= 0 && sceltaVeicolo < veicoli.Count)
                        {
                            veicoli[sceltaVeicolo].Ripara(budget); // richiamo il metodo ripara ma quello con il parametro budget
                        }
                        else
                        {
                            Console.WriteLine("Scelta non valida.");
                        }
                        break;
                    case 6:
                        foreach (Veicolo v in veicoli)
                        {
                            Console.WriteLine($"Traga veicolo: {v.Targa}\n Riparazioni eseguite:");v.Ripara();
                        }
                        break;
                    case 7:
                        Console.WriteLine("Arrevederci!");
                        continua = false;
                        break;

                }
            }
            else
            {
                Console.WriteLine("Scelta non valida. Riprova!");
            }
        }
        while (continua);
    }
}