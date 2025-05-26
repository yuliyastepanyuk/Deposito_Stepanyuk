using System;
using System.Collections.Generic;

public abstract class DispositivoElettronico // Classe astratta che rappresenta un dispositivo elettronico
{
    public string Modello { get; set; }

    public abstract void Accendi(); // Metodo astratto che deve essere implementato dalle classi derivate
    public abstract void Spegni(); // Metodo astratto che deve essere implementato dalle classi derivate

    public virtual void MostraInfo() // Metodo virtuale che può essere sovrascritto dalle classi derivate
    {
        Console.WriteLine($"Modello: {Modello}"); // Mostra il modello del dispositivo
    }
 

    

}

public class Computer : DispositivoElettronico // Classe concreta che rappresenta un computer, eredita da DispositivoElettronico
{
    public override void Accendi() // Implementazione del metodo Accendi per il computer
    {
        Console.WriteLine("Il computer si avvia...");
    }

    public override void Spegni() // Implementazione del metodo Spegni per il computer
    {
        Console.WriteLine("Il computer si spegne.");
    }

    public static Computer AggiungiComputer() // Metodo statico per aggiungere un nuovo computer
    {
        Computer computer = new Computer();
        Console.Write("Inserisci il modello del computer: ");
        computer.Modello = Console.ReadLine();
        return computer;
    }

}

public class Stampante : DispositivoElettronico // Classe concreta che rappresenta una stampante, eredita da DispositivoElettronico
{
    public override void Accendi() // Implementazione del metodo Accendi per la stampante
    {
        Console.WriteLine("La stampante si accende.");
    }

    public override void Spegni()  // Implementazione del metodo Spegni per la stampante
    {
        Console.WriteLine("La stampante va in standby.");
    }

    public static Stampante AggiungiStampante() // Metodo statico per aggiungere una nuova stampante
    {
        Stampante stampante = new Stampante();
        Console.Write("Inserisci il modello della stampante: ");
        stampante.Modello = Console.ReadLine();
        return stampante;
    }
}

public class Programma // Classe principale che gestisce l'interazione con l'utente e i dispositivi elettronici
{
    public static void Main() // Metodo principale che avvia il programma
    {
        bool continua = true;
        List<DispositivoElettronico> dispositivi = new List<DispositivoElettronico>(); // Lista per memorizzare i dispositivi elettronici

        Console.WriteLine("Gestione dei dispositivi elettronici. Che cosa vuoi fare?\n 1. Aggiungere un dispositivo\n 2. Accendere un dispositivo\n 3. Spegnere un dispositivo\n 4. Mostrare informazioni su un dispositivo\n 5. Uscire");
        int scelta = int.Parse(Console.ReadLine());

        do
        {
            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Che tipo di dispositivo vuoi aggiungere? (1. Computer, 2. Stampante)"); // Chiede all'utente di scegliere il tipo di dispositivo da aggiungere
                    string tipoDispositivo = Console.ReadLine();
                    if (tipoDispositivo == "1")
                    {
                        dispositivi.Add(Computer.AggiungiComputer()); // Aggiunge un nuovo computer alla lista dei dispositivi
                    }
                    else if (tipoDispositivo == "2")
                    {
                        dispositivi.Add(Stampante.AggiungiStampante()); // Aggiunge una nuova stampante alla lista dei dispositivi
                    }
                    else
                    {
                        Console.WriteLine("Tipo di dispositivo non valido.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Seleziona il dispositivo da accendere (inserisci il numero corrispondente):"); // Chiede all'utente di scegliere il dispositivo da accendere
                    for (int i = 0; i < dispositivi.Count; i++) // Mostra l'elenco dei dispositivi disponibili
                    {
                        Console.WriteLine($"{i + 1}. {dispositivi[i].Modello}"); // Mostra il modello di ogni dispositivo
                    }
                    int indiceAccensione = int.Parse(Console.ReadLine()) - 1; // converto l'input dell'utente in un indice
                    if (indiceAccensione >= 0 && indiceAccensione < dispositivi.Count) // Verifica se l'indice è valido
                    {
                        dispositivi[indiceAccensione].Accendi(); // Chiama il metodo Accendi del dispositivo selezionato
                    }
                    else
                    {
                        Console.WriteLine("Dispositivo non valido.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Seleziona il dispositivo da spegnere (inserisci il numero corrispondente):"); // Chiede all'utente di scegliere il dispositivo da spegnere
                    for (int i = 0; i < dispositivi.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {dispositivi[i].Modello}"); // Mostra l'elenco dei dispositivi disponibili
                    }
                    int indiceSpegnimento = int.Parse(Console.ReadLine()) - 1; // converto l'input dell'utente in un indice
                    if (indiceSpegnimento >= 0 && indiceSpegnimento < dispositivi.Count) // Verifica se l'indice è valido
                    {
                        dispositivi[indiceSpegnimento].Spegni(); // Chiama il metodo Spegni del dispositivo selezionato
                    }
                    else
                    {
                        Console.WriteLine("Dispositivo non valido.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Seleziona il dispositivo di cui vuoi mostrare le informazioni (inserisci il numero corrispondente):"); // Chiede all'utente di scegliere il dispositivo di cui mostrare le informazioni
                    for (int i = 0; i < dispositivi.Count; i++) // Mostra l'elenco dei dispositivi disponibili
                    {
                        Console.WriteLine($"{i + 1}. {dispositivi[i].Modello}"); // Mostra il modello di ogni dispositivo
                    }
                    int indiceInfo = int.Parse(Console.ReadLine()) - 1; // converto l'input dell'utente in un indice
                    if (indiceInfo >= 0 && indiceInfo < dispositivi.Count) // Verifica se l'indice è valido
                    {
                        dispositivi[indiceInfo].MostraInfo(); // Chiama il metodo MostraInfo del dispositivo selezionato
                    }
                    else
                    {
                        Console.WriteLine("Dispositivo non valido.");
                    }
                    break;
                case 5:
                    continua = false;
                    Console.WriteLine("Uscita dal programma.");
                    break;              
            }

        }
        while (continua);
    }
}


// oppure potevi fare un foreach per mostrare i dispositivi
// foreach (var dispositivo in dispositivi)
// e richiamare il metodo MostraInfo() su ciascun dispositivo, Accendi() o Spegni() a seconda della scelta dell'utente