using System;

public interface IShape // interfaccia 
{
    void Draw();
}

public class ConcreteCircle : IShape // classe concreta che implementa l'interfaccia
{
    public void Draw() // implemento il metodo dell'interfaccia
    {
        Console.WriteLine("Cerchio disegnato.");
    }
}

public class ConcreteSquare : IShape // classe concreta che implementa l'interfaccia
{
    public void Draw() // implemento il metodo dell'interfaccia
    {
        Console.WriteLine("Quadrato disegnato");
    }
}

public abstract class ShapeCreator // classe astratta di tipo ShapeCreator
{
    public abstract IShape FactoryMethod(); // metodo astratto che resituisce un oggetto di tipo interfaccia

    public void CreateShape(string type) // metodo reale che usa oggetto interfaccia per richiamare il factorymethod
    {
        IShape shape = FactoryMethod();
        shape.Draw(); // richiama su shape il metodo Draw
    }
}

public class ConcreteCreatorCircle : ShapeCreator 
{
    public override IShape FactoryMethod()
    {
        return new ConcreteCircle();
    }
}

public class ConcreteCreatorSquare : ShapeCreator
{
    public override IShape FactoryMethod()
    {
        return new ConcreteSquare();
    }
}

public class Menu // classe menu
{
    public void ShowMenu()
    {
        Console.WriteLine("Scegli quale forma disegnare: 'circle' o 'square' ");
        string scelta = Console.ReadLine().ToLower();
        if (scelta == "circle")
        {
            ShapeCreator shape = new ConcreteCreatorCircle();
            shape.CreateShape("circle");
        }
        else if (scelta == "square")
        {
            ShapeCreator shape = new ConcreteCreatorSquare();
            shape.CreateShape("square");
        }
        else
        {
            Console.WriteLine("Scelta non valida!Riprova.");
        }
    }
}

public class Programma
{
    public static void Main()
    {
        Menu menu = new Menu();
        menu.ShowMenu();
    }
}
