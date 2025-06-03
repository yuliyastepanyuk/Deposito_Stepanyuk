using System;

public interface IPiatto
{
    string Descrizione();
    string Prepara();
}

public class ConcretePizza : IPiatto
{
    public string Descrizione()
    {
        return "Questa è una pizza";
    }

    public string Prepara()
    {
        return "Stendo l'impasto";
    }
}

public class ConcreteHamburger : IPiatto
{
    public string Descrizione()
    {
        return "Questo è un hamburger";
    }

    public string Prepara()
    {
        return "Assemblo l'hamburger";
    }
}

public class ConcreteInsalata : IPiatto
{
    public string Descrizione()
    {
        return "Questa è un'insalata";
    }

    public string Prepara()
    {
        return "Lavo e taglio le verdure";
    }
}

public abstract class IngredienteExtra : IPiatto
{
    protected IPiatto PiattoBase;

    protected IngredienteExtra(IPiatto piattoBase)
    {
        PiattoBase = piattoBase;
    }

    public virtual string Descrizione()
    {
        return "Piatto con aggiunta di";
    }

    public virtual string Prepara()
    {
        return PiattoBase.Prepara() + " + aggiungo un ingrediente extra";
    }

    // Per l’ingrediente extra (classe IngredienteExtra), il metodo Prepara dovrebbe chiamare il metodo Prepara del piatto base e aggiungere una descrizione dell’aggiunta dell’ingrediente. 
}

public class ConcreteDecoratorConFormaggio : IngredienteExtra
{
    public ConcreteDecoratorConFormaggio(IPiatto piattoBase) : base(piattoBase)
    { }

    public override string Descrizione()
    {
        return base.Descrizione() + " Formaggio";
    }
}

public class ConcreteDecoratorConBacon : IngredienteExtra
{
    public ConcreteDecoratorConBacon(IPiatto piattoBase) : base(piattoBase)
    { }

    public override string Descrizione()
    {
        return base.Descrizione() + " Bacon";
    }
}

public class ConcreteDecoratorConSalsa : IngredienteExtra
{
    public ConcreteDecoratorConSalsa(IPiatto piattoBase) : base(piattoBase)
    { }

    public override string Descrizione()
    {
        return base.Descrizione() + " Salsa";
    }
}

public static class FactoryPiatto
{
    public static IPiatto Crea(string tipo)
    {

        Console.WriteLine("Scegli la base del tuo piatto tra: 'pizza', 'hamburger' o 'insalata'");
        tipo = Console.ReadLine();
        switch (tipo.ToLower())
        {
            case "pizza":
                Console.WriteLine("Hai scelto pizza");
                return new ConcretePizza();
            case "vaniglia":
                Console.WriteLine("Hai scelto hamburger");
                return new ConcreteHamburger();
            case "frutta":
                Console.WriteLine("Hai scelto insalata");
                return new ConcreteInsalata();
            default:
                Console.WriteLine("Non hai inserito una scelta valida. Riprova!");
                return null;
        }
    }
}

public interface IPreparazioneStrategia
{
    string Prepara(string descrizione);
}

public class ConcreteStrategyFritto : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return descrizione + " e poi friggo il piatto.";
    }
}

public class ConcreteStrategyAlForno : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return descrizione + " e poi cuocio il piatto al forno.";
    }
}

public class ConcreteStrategyAllaGriglia : IPreparazioneStrategia
{
    public string Prepara(string descrizione)
    {
        return descrizione + " e poi griglio il piatto.";
    }
}

public class Chef
{
    private IPreparazioneStrategia _strategia;

    public void ImpostaPiatto(IPreparazioneStrategia strategia)
    {
        _strategia = strategia;
    }

    public string PreparaPiatto(string descrizione)
    {
        if (_strategia == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");

        }
        descrizione = _strategia.Prepara(piatto.Prepara());
    }
}


