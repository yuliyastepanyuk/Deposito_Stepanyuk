using System;

// il tipo di un oggetto è il nome della classe a cui appartiene
// es. Operazioni op = new Operazioni(); // op è un oggetto di tipo Operazioni
// op.Somma, op.Moltiplica, op.StampaRisultato sono metodi della classe Operazioni

// la classe va a definire come è strutturato l'oggetto DEFINIZIONE ASTRATTA
// l'oggetto stabilisce i valori reali e può essere usato per accedere ai metodi e alle proprietà della classe ISTANZA REALE
// l'oggetto è un'istanza della classe

// quattro principi che danno vita alla programmazione orientata agli oggetti:
// 1. incapsulamento: nascondere i dettagli di implementazione e mostrare solo le funzionalità necessarie
// 2. astrazione: semplificare la complessità del sistema
// 3. ereditarietà: creare una nuova classe a partire da una classe esistente
// 4. polimorfismo: usare lo stesso nome per metodi diversi in classi diverse

// una classe per tipo e infiniti oggetti che ne derivano

// github sistema di versionamento, condiviso che permette di avere uan specie di salvataggi, punti di versione

// blocchi statici sono metodi per la classe ma non per l'oggetto, appartengono solo alla classe
public class Cane // definizione della classe Cane
{
    // Proprrità
    public string nome;
    public int eta;

    // Metodo
    public void Abbaia() // metodo della classe Cane
    {
        Console.WriteLine(nome + " dice: Bau!");
    }


}

public class Programma
{
    public static void Main()
    {
        // Creazione di un oggetto (istanza della classe Cane)
        Cane mioCane = new Cane(); // creazione di un oggetto di tipo Cane

        // Assegnazione dei valori alle proprietà
        mioCane.nome = "Fido"; // assegnazione del valore alla proprietà nome
        mioCane.eta = 3; // assegnazione del valore alla proprietà eta

        // Chiamata al metodo
        mioCane.Abbaia(); // chiamata al metodo Abbaia dell'oggetto mioCane
    }
}

// il costruttore è predefinito o personalizzato
// il costruttore predefinito è quello che non ha parametri


