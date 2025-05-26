using System;
using System.Collections.Generic;

public interface IPagamento // Interfaccia che definisce i metodi per i pagamenti
{
    void EseguiPagamento(decimal importo); // Metodo per eseguire un pagamento con un importo specificato
    void MostraMetodo(); // Metodo per mostrare il tipo di pagamento
}

public class PagamentoCarta : IPagamento // Classe che implementa l'interfaccia IPagamento per i pagamenti con carta di credito
{
    public string? Circuito { get; set; } // Proprietà per il circuito della carta di credito

    public void EseguiPagamento(decimal importo) // Metodo per eseguire il pagamento con carta di credito
    {
        Console.WriteLine($"Pagamento di {importo} euro con carta circuito {Circuito}.");
    }

    public void MostraMetodo() // Metodo per mostrare il tipo di pagamento
    {
        Console.WriteLine($"Metodo: Carta di credito");
    }

    public static PagamentoCarta CreaPagamento() // Metodo statico per creare un nuovo pagamento con carta di credito
    {
        PagamentoCarta pagamento = new PagamentoCarta();
        Console.Write("Inserisci il circuito della carta: ");
        pagamento.Circuito = Console.ReadLine();
        return pagamento;
    }
}

public class PagamentoContanti : IPagamento // Classe che implementa l'interfaccia IPagamento per i pagamenti in contanti
{
    public void EseguiPagamento(decimal importo) // Metodo per eseguire il pagamento in contanti
    {
        Console.WriteLine($"Pagamento di {importo} euro in contanti.");
    }

    public void MostraMetodo() // Metodo per mostrare il tipo di pagamento
    {
        Console.WriteLine($"Metodo: Contanti");
    }

    public static PagamentoContanti CreaPagamento() // Metodo statico per creare un nuovo pagamento in contanti
    {
        return new PagamentoContanti();
    }
}

public class PagamentoPayPal : IPagamento // Classe che implementa l'interfaccia IPagamento per i pagamenti tramite PayPal
{
    public string? EmailUtente { get; set; } // Proprietà per l'email dell'utente PayPal

    public void EseguiPagamento(decimal importo) // Metodo per eseguire il pagamento tramite PayPal
    {
        Console.WriteLine($"Pagamento di {importo} euro tramite PayPal da {EmailUtente}.");
    }

    public void MostraMetodo()  // Metodo per mostrare il tipo di pagamento
    {
        Console.WriteLine($"Metodo: PayPal");
    }

    public static PagamentoPayPal CreaPagamento() // Metodo statico per creare un nuovo pagamento tramite PayPal
    {
        PagamentoPayPal pagamento = new PagamentoPayPal();
        Console.Write("Inserisci l'email dell'utente PayPal: ");
        pagamento.EmailUtente = Console.ReadLine();
        return pagamento;
    }
}

public class Programma
{
    public static void Main()
    {
        bool continua = true; // Variabile per controllare il ciclo di esecuzione
        List<IPagamento> pagamenti = new List<IPagamento>(); // Lista per memorizzare i pagamenti

        Console.WriteLine("Crea un pagamento con carta di credito:"); // Inizializza un pagamento con carta di credito
        PagamentoCarta pagamentoCarta = PagamentoCarta.CreaPagamento();
        pagamenti.Add(pagamentoCarta);

        Console.WriteLine("Crea un pagamento in contanti:"); // Inizializza un pagamento in contanti
        PagamentoContanti pagamentoContanti = PagamentoContanti.CreaPagamento();
        pagamenti.Add(pagamentoContanti);

        Console.WriteLine("Crea un pagamento con PayPal:"); // Inizializza un pagamento tramite PayPal
        PagamentoPayPal pagamentoPayPal = PagamentoPayPal.CreaPagamento();
        pagamenti.Add(pagamentoPayPal);

        do // Ciclo per gestire le operazioni sui pagamenti
        {
            Console.WriteLine("Che cosa vuoi fare?\n 1.Creare un nuovo pagamento\n 2.Mostrare i tipi di pagamento\n 3.Eseguire un pagamento\n 4.Uscire");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Che tipo di pagamento vuoi creare?\n 1.Carta di credito\n 2.Contanti\n 3.Paypal"); // Chiede all'utente di scegliere il tipo di pagamento da creare
                    string tipoPagamento = Console.ReadLine();
                    if (tipoPagamento == "1")
                    {
                        pagamenti.Add(PagamentoCarta.CreaPagamento()); // Aggiunge un nuovo pagamento con carta di credito alla lista
                    }
                    else if (tipoPagamento == "2")
                    {
                        pagamenti.Add(PagamentoContanti.CreaPagamento()); // Aggiunge un nuovo pagamento in contanti alla lista
                    }
                    else if (tipoPagamento == "3")
                    {
                        pagamenti.Add(PagamentoPayPal.CreaPagamento()); // Aggiunge un nuovo pagamento tramite PayPal alla lista
                    }
                    else
                    {
                        Console.WriteLine("Tipo di pagamento non valido."); // Gestisce il caso in cui l'utente inserisce un tipo di pagamento non valido
                    }
                    break;
                case 2:
                    Console.WriteLine("Tipi di pagamento disponibili:"); // Mostra i tipi di pagamento disponibili
                    foreach (IPagamento pagamento in pagamenti)   // Itera attraverso la lista dei pagamenti
                    {
                        pagamento.MostraMetodo(); // Chiama il metodo per mostrare il tipo di pagamento per ogni pagamento nella lista
                    }
                    break;
                case 3:
                    Console.WriteLine("Scegli il tipo di pagamento che vuoi eseguire: "); // Chiede all'utente di scegliere il tipo di pagamento da eseguire
                    for (int i = 0; i < pagamenti.Count; i++) // Mostra l'elenco dei pagamenti disponibili attraverso un ciclo
                    {
                        Console.WriteLine($"{i + 1}. {pagamenti[i].GetType().Name}"); // Mostra il nome della classe del pagamento
                    }
                    int indicePagamento = int.Parse(Console.ReadLine()) - 1; // Converte l'input dell'utente in un indice (partendo da 0)
                    if (indicePagamento >= 0 && indicePagamento < pagamenti.Count) // Verifica se l'indice è valido
                    {
                        Console.Write("Inserisci l'importo del pagamento: "); // Chiede all'utente di inserire l'importo del pagamento
                        decimal importo = decimal.Parse(Console.ReadLine());
                        pagamenti[indicePagamento].EseguiPagamento(importo); // Chiama il metodo per eseguire il pagamento con l'importo specificato
                    }
                    else
                    {
                        Console.WriteLine("Pagamento non valido."); // Gestisce il caso in cui l'utente inserisce un indice non valido
                    }
                    break;
                case 4:
                    continua = false; // Esce dal ciclo
                    Console.WriteLine("Ciao!");
                    break;       
            }

        }
        while (continua);

    }
}