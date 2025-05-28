using System;

public sealed class ConfigurazioneSistema
{
    private static ConfigurazioneSistema istanza;    // Campo privato statico per l'istanza Singleton

    private Dictionary<string, string> configurazioni; // Dizionario configurazioni, il nome che stai dando alla variabile (cioè al campo) che contiene il tuo oggetto Dictionary<string, string>.

    private ConfigurazioneSistema()
    {

    }

    public static ConfigurazioneSistema GetInstance() // Proprietà pubblica per accedere all'istanza Singleton
    {
        if (istanza == null)
        {
            istanza = new ConfigurazioneSistema();
        }
        return istanza;
    }

    public void Imposta(string chiave, string valore)
    {
        configurazioni[chiave] = valore; // la sintassi dell'indicizzatore del dizionario. 
                                         // Questo approccio consente di assegnare un valore a una chiave specifica: 
                                         // se la chiave esiste, il valore viene aggiornato; se non esiste, viene aggiunta una nuova coppia chiave-valore.
    }

    public string Leggi(string chiave)
    {
        return configurazioni[chiave]; // Genera un'eccezione se la chiave non esiste
    }

    public void Stampa()
    {
        Console.WriteLine($"Ecco le configurazioni salvate {ConfigurazioneSistema.istanza.configurazioni}");

    }

    // !! Stai cercando di accedere a configurazioni come se fosse un membro statico della classe ConfigurazioneSistema. Tuttavia, se configurazioni è un campo o una proprietà non statica, devi accedervi attraverso un'istanza della classe.


}

public class Programma
{
    public static void Main()
    {
        bool continua = true;
       // ConfigurazioneSistema ModuloA = ("Ambiente", "Produzione");
        ConfigurazioneSistema ModuloB;

        Console.WriteLine("Cosa vuoi fare?\n 1.Impostare le configurazioni del sistema.\n 2.Lggere le configurazioni di sistema.\n 3.Verificare le impostazioni di sistema.\n 4.Stampare tutte le configurazioni di sistema.");
        int scelta = int.Parse(Console.ReadLine());

        do
        {
            if (scelta >= 1 && scelta <= 4)
            {
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Quale configurazione vuoi impostare?\n 1.ModuloA\n 2.ModuloB");
                        int sceltaconf = int.Parse(Console.ReadLine());
                        if (sceltaconf == 1)
                        {
                            Console.WriteLine("Imposta la chiave: ");
                            string chiave = Console.ReadLine();
                            Console.WriteLine("Imposta il valore: ");
                            string valore = Console.ReadLine();
                            ModuloA.Imposta(chiave, valore);
                            Console.WriteLine("Impostato correttamente!");
                        }
                        else if (sceltaconf == 2)
                        {
                            Console.WriteLine("Imposta la chiave: ");
                            string chiave = Console.ReadLine();
                            Console.WriteLine("Imposta il valore: ");
                            string valore = Console.ReadLine();
                            //ModuloB.Imposta(chiave, valore);
                            Console.WriteLine("Impostato correttamente!");
                        }
                        break;

                }
            }
            else
            {
                Console.WriteLine("Inserisci un valore valido!");
            }

        }
        while (continua);

        
        
    }
}