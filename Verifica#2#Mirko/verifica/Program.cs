using System;


// INTERFACCIA BASE PER PIZZA
public interface IPizza
{
    string Descrizione(); // Metodo che ritorna la descrizione della pizza
}

// CLASSI CONCRETE PER OGNI TIPO DI PIZZA
public class ConcreteMargherita : IPizza
{
    public string Descrizione()
    {
        return "Questa è una Margherita";
    }
}

public class ConcreteDiavola : IPizza
{
    public string Descrizione()
    {
        return "Questa è una Diavola";
    }
}

public class ConcreteVegetariana : IPizza
{
    public string Descrizione()
    {
        return "Questa è una Vegetariana";
    }
}

// FACTORY PER CREARE PIZZE
public static class PizzaFactory
{
    public static IPizza CreaPizza()
    {
        Console.WriteLine("Scegli il gusto di pizza tra: 'margherita', 'diavola' o 'vegetariana'");
        string tipo = Console.ReadLine().ToLower();

        switch (tipo)
        {
            case "margherita":
                Console.WriteLine("Hai scelto Margherita");
                return new ConcreteMargherita();
            case "diavola":
                Console.WriteLine("Hai scelto Diavola");
                return new ConcreteDiavola();
            case "vegetariana":
                Console.WriteLine("Hai scelto Vegetariana");
                return new ConcreteVegetariana();
            default:
                Console.WriteLine("Scelta non valida.");
                return null;
        }
    }
}

// CLASSE BASE PER DECORATOR (INGREDIENTI EXTRA)
public abstract class IngredienteDecorator : IPizza
{
    protected IPizza PizzaBase;

    protected IngredienteDecorator(IPizza pizzaBase)
    {
        PizzaBase = pizzaBase;
    }

    public virtual string Descrizione()
    {
        return PizzaBase.Descrizione() + " con l'aggiunta di";
    }
}

// DECORATOR CONCRETII
public class DecoratorConOlive : IngredienteDecorator
{
    public DecoratorConOlive(IPizza pizzaBase) : base(pizzaBase) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " olive";
    }
}

public class DecoratorConMozzarellaExtra : IngredienteDecorator
{
    public DecoratorConMozzarellaExtra(IPizza pizzaBase) : base(pizzaBase) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " mozzarella extra";
    }
}

public class DecoratorConFunghi : IngredienteDecorator
{
    public DecoratorConFunghi(IPizza pizzaBase) : base(pizzaBase) { }

    public override string Descrizione()
    {
        return base.Descrizione() + " funghi";
    }
}

// STRATEGY: METODO DI COTTURA
public interface IMetodoCottura
{
    string Cuoci(string pizza);
}

public class FornoElettrico : IMetodoCottura
{
    public string Cuoci(string pizza)
    {
        return pizza + " cotta nel forno elettrico";
    }
}

public class FornoLegna : IMetodoCottura
{
    public string Cuoci(string pizza)
    {
        return pizza + " cotta nel forno a legna";
    }
}

public class FornoVentilato : IMetodoCottura
{
    public string Cuoci(string pizza)
    {
        return pizza + " cotta nel forno ventilato";
    }
}

// SINGLETON: GESTORE ORDINI
public sealed class GestoreOrdine
{
    private static GestoreOrdine _istanza; // Istanza unica
    private IPizza _pizza; // La pizza dell’ordine

    private GestoreOrdine() { }

    public static GestoreOrdine Istanza
    {
        get
        {
            if (_istanza == null)
            {
                _istanza = new GestoreOrdine();
            }
            return _istanza;
        }
    }

    public void ImpostaPizza(IPizza pizza)
    {
        _pizza = pizza;
    }

    public void StampaOrdine()
    {
        Console.WriteLine("Ordine attuale:");
        if (_pizza == null)
        {
            Console.WriteLine("Nessuna pizza nell'ordine.");
        }
        else
        {
            Console.WriteLine(_pizza.Descrizione());
        }
    }
}

// OBSERVER: SISTEMI DI NOTIFICA
public interface IOsservatore
{
    void Notifica(string messaggio);
}

public class SistemaLog : IOsservatore
{
    public void Notifica(string messaggio)
    {
        Console.WriteLine($"{messaggio}");
    }
}

public class SistemaMarketing : IOsservatore
{
    public void Notifica(string messaggio)
    {
        Console.WriteLine($"Promozione : {messaggio}");
    }
}

// PROGRAMMA PRINCIPALE
public class Program
{
    public static void Main()
    {
        IPizza pizzaScelta = null;
        bool continua = true;

        // FASE 1: Scelta della pizza base
        do
        {
            Console.WriteLine("Che pizza vuoi scegliere tra: 'margherita', 'diavola' e 'vegetariana'?");
            string scelta = Console.ReadLine().ToLower();

            switch (scelta)
            {
                case "margherita":
                    pizzaScelta = new ConcreteMargherita();
                    continua = false;
                    break;
                case "diavola":
                    pizzaScelta = new ConcreteDiavola();
                    continua = false;
                    break;
                case "vegetariana":
                    pizzaScelta = new ConcreteVegetariana();
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        } while (continua);

        // FASE 2: Aggiunta ingredienti extra
        bool aggiungi = true;
        while (aggiungi)
        {
            Console.WriteLine("\nVuoi aggiungere ingredienti extra?");
            Console.WriteLine("1. Olive");
            Console.WriteLine("2. Mozzarella extra");
            Console.WriteLine("3. Funghi");
            Console.WriteLine("4. Nessuna aggiunta (fine)");

            int extra;
            if (!int.TryParse(Console.ReadLine(), out extra))
            {
                Console.WriteLine("Scelta non valida.");
                continue;
            }

            switch (extra)
            {
                case 1:
                    pizzaScelta = new DecoratorConOlive(pizzaScelta);
                    break;
                case 2:
                    pizzaScelta = new DecoratorConMozzarellaExtra(pizzaScelta);
                    break;
                case 3:
                    pizzaScelta = new DecoratorConFunghi(pizzaScelta);
                    break;
                case 4:
                    Console.WriteLine("Hai finito di aggiungere ingredienti!");
                    aggiungi = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}


