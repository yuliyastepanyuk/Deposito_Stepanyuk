using System;


public class Attrazione
{
    public int AttrazioneId { get; set; }
    public string NomeAttrazione { get; set; }
    public string? Descrizione { get; set; }
    public decimal Prezzo { get; set; }
    public int DestinazioneId { get; set; }

    public Destinazione Destinazione { get; set; }

}