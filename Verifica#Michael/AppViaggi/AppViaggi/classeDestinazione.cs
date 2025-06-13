using System;

public class Destinazione
{
    public int DestinazioneId { get; set; }
    public string NomeDestinazione { get; set; }
    public string? Descrizione { get; set; }
    public int CittaId { get; set; }

    public Citta Citta { get; set; }
 
}