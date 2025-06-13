using System;


public class Prenotazione
{
    public int PrenotazioneId { get; set; }
    public DateTime DataPrenotazione { get; set; } = DateTime.Now;
    public string? StatoPrenotazione { get; set; }
    public int UtenteId { get; set; }

    public Utente Utente { get; set; }
    public Pagamento Pagamento { get; set; }

    public Prenotazione() { }

    public Prenotazione(int utenteId, string statoPrenotazione)
    {
        UtenteId = utenteId;
        StatoPrenotazione = statoPrenotazione;
        DataPrenotazione = DateTime.Now;
    }
}
