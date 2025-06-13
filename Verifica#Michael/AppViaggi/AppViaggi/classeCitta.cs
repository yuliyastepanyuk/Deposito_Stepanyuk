using System;

public class Citta
{
    public int CittaId { get; set; }
    public string NomeCitta { get; set; }
    public int PaeseId { get; set; }

    public Paese Paese { get; set; }
  
}
