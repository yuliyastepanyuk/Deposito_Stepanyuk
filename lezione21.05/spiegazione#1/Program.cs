// stabilite, create e elargite!!
// l'astrazione è FONDAMENTALE per la programmazione orientata agli oggetti
// permette alle tre altre fondamentali regole di funzionare contemporanematente

// ogni regola fondamentale affronta un diverso aspetto della programmazione ad oggetti

// le tre regole base base
// incapsulamento nasconde i dati anche dalla classe stessa, nel codice e dal codice
// l'ereditarietà è la capacità di una classe di ereditare le proprietà e i metodi di un'altra classe, infiniti figli un solo padre, c# non accetta la pluri eriditarietà
// il polimorfismo la capacità di cambiare forma e/o comportamento ad un elemento, è gia presente intirinsicamente nel linguaggio, è la capacità di un oggetto di assumere più forme, ad esempio un oggetto può essere sia un'istanza della classe padre che di una classe figlia

// EREDITARIETA' !!

// tramite una classe generica (padre) posso andare poi a creare delle classi figlie che ereditano le proprietà e i metodi della classe padre
// posso fare override di un metodo della classe padre all'interno della classe figlia per modificarne il comportamento, specializzare il funzionamento, unicità

// gli elementi dell'EREDITARIETA' sono:
// -- CLASSE BASE
// -- CLASSE DERIVATA
// -- EREDITARIETA' SINGOLA
// -- PAROLA CHIAVE BASE permette di accedere ai membri della classe padre(base)
// -- OVERRIDE consente di redefinire metodi della classe padre(base)

public class Animale
{
    public void FaiVerso()
    {
        Console.WriteLine("L'animale fa un verso");
    }
}

// Classe derivata
public class Cane : Animale // Eredita da Animale usando " : " , quindi ha accesso al metodo FaiVerso()
{
    // Metodo specifico della classe derivata
    public void Scodinzola() // Metodo proprio
    {
        Console.WriteLine("Il cane scodinzola");
    }
}

// Programma principale
public class Programma
{
    public static void Main()
    {
        Cane mioCane = new Cane(); // Creazione di un oggetto della classe derivata
        mioCane.FaiVerso(); // Metodo ereditato dalla classe base
        mioCane.Scodinzola(); // Metodo definito nella classe derivata
    }
}

// VIRTUAL stai dicendo implicitamente che il metodo della classe padre(base) può essere sovrascritto per il figlio
// OVERRIDE stai dicendo che il metodo della classe padre(base) è stato sovrascritto per il figlio
// punti di contatto con il polimorfismo

// la parola chiave BASE permette di accedere ai membri della classe padre(base) da dentro la classe figlia

// la parola chiave NEW viene utilizzata per nascondere un membro della classe base, la classe figlia elimina il membro della classe padre(base) e lo sostituisce con un nuovo membro, non è un override, è un nascondere
// serve per creare comportamenti unici
// punti di contatto con l'incapsulamento

// la parola chiave SEALED viene utilizzata per impedire l'ereditarietà di una classe, non può essere ereditata, può usata per impredire l'override di un metodo in una classe derivata

// la parola chiave PROTECTED consente a un membro di essere accessibile all'interno della sua classe e dalle classi derivate, questa proprietà può essere vista solo da mio figlio

// PRIVATE il figlio non la vede!!

// In c# tutte le classi derivano implicitamente dalla classe Object, la classe Object è la classe base di tutte le classi in C#, quindi ogni classe in C# eredita implicitamente da Object
// la classe Object fornisce metodi di base come ToString(), Equals(), GetHashCode() e altri, che possono essere utilizzati da tutte le classi derivate
// qui vediamo collaborare l'ereditarietà con l'astrazione