using System; 
public class Ruolo
{
    public int RuoloId { get; set; }
    public string TipoRuolo { get; set; }

    public Ruolo() { }

    public Ruolo(string tipoRuolo)
    {
        TipoRuolo = tipoRuolo;
    }

}