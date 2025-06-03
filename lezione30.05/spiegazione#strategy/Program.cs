// STRATEGY interfaccia o classe astratta che espone il metodo comune
// CONCRETESTRATEGYA, CONCRETESTRATEGYB, ecc..
// CONTEXT
// CLIENT


using System;
using System.Collections.Generic;

// 1. Strategy: definisce l'interfaccia comune per tutti gli algoritmi
public interface IStrategy
{
    // Ad esempio, elaborare una lista di numeri in modi diversi
    int DoOperation(int a, int b);
}

// 2. ConcreteStrategyAdd: implementa la somma
public class ConcreteStrategyAdd : IStrategy
{
    public int DoOperation(int a, int b)
    {
        return a + b;
    }
}

// 3. ConcreteStrategySubtract: implementa la sottrazione
public class ConcreteStrategySubtract : IStrategy
{
    public int DoOperation(int a, int b)
    {
        return a - b;
    }
}

// 4. ConcreteStrategyMultiply: implementa la moltiplicazione
public class ConcreteStrategyMultiply : IStrategy
{
    public int DoOperation(int a, int b)
    {
        return a * b;
    }
}

// 5. Context: utilizza una strategia per eseguire l'operazione
public class Context
{
    // Riferimento alla strategia corrente
    private IStrategy _strategy;

    // Permette di cambiare strategia a runtime
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    // Esegue l'algoritmo tramite la strategia corrente
    public void ExecuteStrategy(int a, int b)
    {
        if (_strategy == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");
            return;
        }
        int result = _strategy.DoOperation(a, b);
        Console.WriteLine($"Risultato dell'operazione: {result}");
    }
}

// 6. Client: configura il contesto e usa diverse strategie
class Program
{
    static void Main()
    {
        var context = new Context();

        // Usa la strategia di somma
        context.SetStrategy(new ConcreteStrategyAdd());
        Console.Write("Somma: ");
        context.ExecuteStrategy(10, 5);  // Output: 15

        // Cambia strategia in sottrazione
        context.SetStrategy(new ConcreteStrategySubtract());
        Console.Write("Sottrazione: ");
        context.ExecuteStrategy(10, 5);  // Output: 5

        // Cambia strategia in moltiplicazione
        context.SetStrategy(new ConcreteStrategyMultiply());
        Console.Write("Moltiplicazione: ");
        context.ExecuteStrategy(10, 5);  // Output: 50
    }
}

// Il CONTEXT non conosce i dettaglia dei calcoli: si affida all'interfaccia IStrategy

// Per aggiungere un nuovo algortirmo, basta creare una nuova classe ConcreteStrategyX che implementi IStrategy, senza toccare il Context

// La strategia può essere modificata anche a runtime, rendendo il comportamento dell'applicazione molto flessibile
