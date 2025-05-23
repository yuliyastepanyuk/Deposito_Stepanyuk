// INCAPSULAMENTO //

// la classe deve essere per forza pubblica, però le proprietà e i metodi possono essere private
// get e set sono metodi normali, get esporre un dato, set prendere un dato, per ogni proprietà private ci vuole get e set
// protegge l'integrità dei dati e/o modifiche non autorizzate

// PRIVATE il più restrittivo
// PUBLIC il più open
// GET / SET proprietà per leggere e scrivere
// CONTROLLO DATI controlli per il metodo set
// SICUREZZA e MANUTENZIONE

using System.ComponentModel.Design.Serialization;

public class ContoBancario
{
    // Campo privato (non accessibile direttamente dall'esterno)
    private double saldo;

    // Proprietà per accedere al saldo in modo controllato
    public double Saldo
    {
        get
        {
            return saldo;
        } // permette la lettura del saldo
          // e restituzione del saldo
        set
        {
            if (value >= 0) // solo valori validi
                saldo = value; // imposta il valore solo se è valido
        }
    }



}

public class Programma
{
    public static void Main()
    {

        ContoBancario conto = new ContoBancario();

        conto.Saldo = 1000.50; // imposta il saldo tramite la proprietà
        Console.WriteLine(conto.Saldo); // legge il saldo tramite la proprietà

        conto.Saldo = -500; // non modifica il saldo che è negatico
        Console.WriteLine(conto.Saldo); // rimane 1000.50
    }
}

// VALUE è un valore intrinsico di una proprietà

// PER I MEMBRI DI UNA CLASSE

// PRIVATE solo all'interno del blocco della classe
// PUBLIC qualsiasi parte del progetto
// PROTECTED classe e figlie
// INTERNAL middleware tra hardware e software
// PROTECTED INTERNAL può essere accessbile solo assembly e classi derivate
// PRIVATE PROTECTED 