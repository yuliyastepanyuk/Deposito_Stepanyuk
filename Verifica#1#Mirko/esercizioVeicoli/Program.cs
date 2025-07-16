using System;

public class Veicolo // classe padre
{
    public string Marca;
    public string Modello;
    public int AnnoImmatricolazione;

    public Veicolo(string marca, string modello, int annoImmatricolazione) // il suo costruttore ovvero ciò che ne definisce la forma
    {
        Marca = marca;
        Modello = modello;
        AnnoImmatricolazione = annoImmatricolazione;
    }

    public virtual void StampaInfo()
    {
        Console.WriteLine($"Ecco le informazioni del veicolo: {Marca}\n {Modello}\n{AnnoImmatricolazione}\n ");
    }
}

public class AutoAziendale : Veicolo // classe figlia
{
    string Targa;
    bool UsoPrivato;

    public AutoAziendale(string marca, string modello, int annoImmatricolazione, string targa, bool usoPrivato) : base(marca, modello, annoImmatricolazione) // il suo costruttore
    {
        Targa = targa;
        UsoPrivato = usoPrivato;
    }

    public override void StampaInfo() // override del metodo per personalizzare il messaggio di ritnorno
    {
        base.StampaInfo();
        Console.WriteLine($"{Targa}\n {UsoPrivato}");
    }
}

public class FurgoneAziendale : Veicolo // classe dereivata
{
    int CapacitaCarico;

    public FurgoneAziendale(string marca, string modello, int annoImmatricolazione, int capacitaCarico) : base(marca, modello, annoImmatricolazione) // il suo costruttore
    {
        CapacitaCarico = capacitaCarico;
    }

    public override void StampaInfo() // override del metodo per personalizzare il messaggio di ritnorno
    {
        base.StampaInfo();
        Console.WriteLine($"{CapacitaCarico}");
    }
}

public class Programma
{
    public static void Main()
    {
        List<Veicolo> veicoli = new List<Veicolo>
        {
            new Veicolo("Fiat", "Panda", 2010),
            new AutoAziendale("Volkswagen", "Golf", 2018, "AB123CD", true),
            new FurgoneAziendale("Ford", "Transit", 2015, 1200)
        };

        foreach (Veicolo v in veicoli)
        {
            v.StampaInfo();
        }
    }
}