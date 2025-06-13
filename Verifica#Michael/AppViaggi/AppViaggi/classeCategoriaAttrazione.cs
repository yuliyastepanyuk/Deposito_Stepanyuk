using System;

public class CategoriaAttrazione
{
    public int AttrazioneId { get; set; }
    public int CategoriaId { get; set; }

    public Attrazione Attrazione { get; set; }
    public Categoria Categoria { get; set; }
}
