public static class Menu
{
    public static void MostraMenuPrincipale()
    {
        Console.WriteLine("Benvenuto nella nostra app viaggi!");
        Console.WriteLine("Per procedere devi prima [1] creare un account o [2] accedere con un account esistente o [3] uscire.");
    }

    public static void MostraMenuUtente()
    {
        Console.WriteLine("Menu Utente: [1] Prenota viaggio\n [2] Visualizza prenotazioni\n [3] Annulla prenotazione [0] Logout");
    }

    public static void MostraMenuPrenotazione()
    {
        Console.WriteLine("Menu Prenotazione: [1] Visualizza le destinazioni\n [2] Visualizza le attrazioni [0] Logout");
    }

    public static void MostraMenuAdmin()
    {
        Console.WriteLine("Menu Admin: [1] Aggungi utente\n [2] Elimina utente\n [3] Aggiungi destinazione\n [4] Elimina destinazione\n [5] Modifica destinazione\n [6] Aggungi attrazione\n [7] Elimina attrazione\n [8] Modifica attrazione  [0] Logout");
    }
}