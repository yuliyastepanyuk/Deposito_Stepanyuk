// FACTORY METHOD definisce un'interfccia per la creazione di un oggetto, lasciando che siano le sottoclassi a decidere quale classe concreta istanziare
// si usa quando non si conosce in anticipo il tipo esatto di oggetto da creare
// quando si vuole delegare
// per evitare dipendenze dirette tra client(qualsiasi cosa usi quel oggetto) e classi concrete

// VANTAGGI : riduce l'accoppiamento, facilita l'estensione, incapsula la logica di creazione in un unico punto

// PRODUCT
// CONCRETEPRODUCT
// CREATOR
// CONCRETECREATOR
// CLIENT

// abbiamo un padre dei fligli, introduciamo all'interno un'astrazione e andiamo a creare il metodo concreto che va a creare questi figli, li ritrona, riporta un prodotto finito, il creator product = ritorno del factorymethod

// 1. Product: definisce l'interfaccia del prodotto
public interface IProduct
{
    void Operation();
}

// 2. ConcreteProductA: implementa IProduct
public class ConcreteProductA : IProduct
{
    public void Operation()
    {
        Console.WriteLine("Esecuzione di ConcreteProductA.Operation()");
    }
}

// 3. ConcreteProductB: un altro prodotto concreto
public class ConcreteProductB : IProduct
{
    public void Operation()
    {
        Console.WriteLine("Esecuzione di ConcreteProductB.Operation()");
    }
}

// 4. Creator: dichiara il Factory Method
public abstract class Creator
{
    // Factory Method: restituisce un IProduct
    public abstract IProduct FactoryMethod();

    // Un metodo del creator che utilizza il prodotto
    public void AnOperation()
    {
        // Creazione del prodotto tramite FactoryMethod
        IProduct product = FactoryMethod(); // quale prodotto tornerà, in base al metodo reale, 
        product.Operation();
    }
}

// 5. ConcreteCreatorA: implementa FactoryMethod per ConcreteProductA
public class ConcreteCreatorA : Creator // stessa factorymethod
{
    public override IProduct FactoryMethod() // metodo logico
    {
        return new ConcreteProductA();
    }
}

// 6. ConcreteCreatorB: implementa FactoryMethod per ConcreteProductB
public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod() // metodo logico
    {
        return new ConcreteProductB();
    }
}

// Esempio di utilizzo (Client)
class Program
{
    static void Main()
    {
        Creator creatorA = new ConcreteCreatorA();
        creatorA.AnOperation();  // Usa ConcreteProductA
        
        Creator creatorB = new ConcreteCreatorB();
        creatorB.AnOperation();  // Usa ConcreteProductB
    }
}
