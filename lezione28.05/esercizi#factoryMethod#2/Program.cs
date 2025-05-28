using System;

public interface IShape
{
    void Draw();
}

public class ConcreteCircle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Cerchio disegnato.");
    }
}

public class ConcreteSquare : IShape
{
    public void Draw()
    {
        Console.WriteLine("Quadrato disegnato");
    }
}

public abstract class ShapeCreator
{
    public abstract IShape FactoryMethod();

    public void CreateShape(string type)
    {
        IShape shape = FactoryMethod();
        shape.Draw();
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

public class Programma
{
    public static void Main()
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
