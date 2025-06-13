using System;

public class PrenotazioneDestinazione
{
    public int PrenotazioneId { get; set; }
    public int DestinazioneId { get; set; }

    public Prenotazione Prenotazione { get; set; }
    public Destinazione Destinazione { get; set; }
}