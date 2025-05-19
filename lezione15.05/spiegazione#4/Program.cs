using System;
using System.Runtime.InteropServices;

class Program
{
    private int _x = 0; // dichiarazione globale all'interno della classe, accessibile a tutti i metodi all'interno della classe (che sia private o public, provate vale per l'accesso esterno alla classe)
    static int numero = 3; // dichiarazione globale all'interno della classe, accessibile a tutti i metodi all'interno della classe

    static string c = "ciao"; // dichiarazione globale all'interno della classe, accessibile a tutti i metodi all'interno della classe
    static void Main(string[] args)
    {
        var somma = Somma(1, 10);
        Console.WriteLine($"{somma}");
        //Somma(4, 5);
        //Somma(100, 120);
        //Somma(100, 1200);
        //Somma(457 , 101);

    //-------------------------------------------------
    
        while (true)
        {
            int numeroN = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numeroN} è pari? {IsEven(numeroN)}"); // cwl shortcut

            // if(IsEven(numero)) fai qualcosa, altrimenti fai un altra
        }
    //-------------------------------------------------
        Console.WriteLine($"{Input()}");

        Myclass myClassInst = new Myclass();
        myClassInst.numero = 19; // la copia ha come valore in numero 19
    //-------------------------------------------------

        int numero1 = 1;
        int numero2 = 2;
        Somma(numero1, numero2); // sto passando il valore di numero1, non la variabile stessa
    //-------------------------------------------------
        
        int n = 19;
        Console.WriteLine($"Valore originale: {n}"); // 19
        IncrementaValoreRef(ref n); // sto passando il riferimento alla variabile, non il valore
        Console.WriteLine($"Valore incrementato: {n}"); // 20

        // il valore non è legato prettamente alla variabile, ma al suo indirizzo di memoria
        // se io cambio il valore di una variabile, non cambia il valore della variabile originale
    //-------------------------------------------------
   
        int numero = 3;
        IncrementaValore(numero);
        Console.WriteLine($"Valore incrementato: {numero}"); // 3
    //-------------------------------------------------
   
        Console.WriteLine($"stringa: {c}");
        CostruisciFrase(c);
        Console.WriteLine($"stringa post funzione: {c}"); // c è una variabile statica, quindi posso accedervi anche da un metodo statico
    //-------------------------------------------------
   
        int risultato = 0; // dichiarazione di una variabile, ma non inizializzata
        Console.WriteLine($"Risultato: {risultato}"); // 0
        Calcola(out risultato); // out è un parametro di output, che restituisce un valore dalla funzione
        Console.WriteLine($"Risultato: {risultato}"); // 10
                                                      
     //-------------------------------------------------
   
        //int mioQuoziente;
        //int mioResto;

        int dividendo = 0;
        if (!int.TryParse(Console.ReadLine(), out dividendo))
        {
            Console.WriteLine("Errore");
        }
        else
        {
            Console.WriteLine($"Dividendo: {dividendo}");
        }


        DivisioneConResto(10, 2, out int mioQuoziente, out int mioResto);
        Console.WriteLine($"Quoziente: {mioQuoziente}"); // 5
        Console.WriteLine($"Resto: {mioResto}"); // 0 

        int risultatoDivisione;
        int risultatoResto;

        DivisioneConResto(10, 3, out risultatoDivisione, out risultatoResto);
        Console.WriteLine($"Quoziente: {risultatoDivisione}"); // 3
        Console.WriteLine($"Resto: {risultatoResto}"); // 1


    }

    static int Somma(int a, int b) // void
    {
        //Console.WriteLine($"Sooma = {a + b}");
        int somma = a + b;
        //a = a + b;
        return somma;
    }

    static bool IsEven(int numero)
    {
        return numero % 2 == 0;
    }

    static string Input()
    {
        return Console.ReadLine();
    }
    static void IncrementaValoreRef(ref int valore)
    {
        Console.WriteLine($"Valore originale: {valore}"); // 19
        valore++;
        Console.WriteLine($"Valore incrementato: {valore}"); // 20
    }

    static void IncrementaValore(int valore)
    {
        valore++;
    }

    static void CostruisciFrase(string parola)
    {
        parola += ", come stai?";
        Console.WriteLine(parola);
    }

    static void Calcola(out int risultato)
    {
        risultato = 10;
    }

    static void DivisioneConResto(int dividendo, int divisore, out int quoziente, out int resto)
    {
        quoziente = dividendo / divisore; // con out posso tornare "infiniti" valori
        resto = dividendo % divisore;
    }

    static int Divisione(int dividendo, int divisore)
    {
        return dividendo / divisore; // però la divisione può avere "due" risultati(quoziente e resto), quindi normalmente dovrei fare due funzioni
    }
    
    static int Resto(int dividendo, int divisore)
    {
        return dividendo % divisore; // però la divisione può avere "due" risultati(quoziente e resto), quindi normalmente dovrei fare due funzioni
    }
}

public class Myclass
{
    public int numero = 0;

    void MyMethod()
    {
       // Program._x;
    }
}

// nella programmazione ad oggetti, non vado a richiamare la classe ma una sua istanza, ovvero una copia
// static vuol dire che la proprietà(variabile della classe) è legata direttamente alla classe
// "dinamico" è lagato alla sua istanza