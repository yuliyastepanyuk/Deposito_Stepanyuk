using System;
using System.Net;

class Program 
{
    static int contatore = 10;

    const float PI = 3.14f;

    static readonly string Nome = "Franco";
    private static void Main(string[] args)
 {
   Console.WriteLine("Hello, World!");
   Console.WriteLine(contatore);

   TipiDiDato();

   // Conversione implicita
   int numero = 10;
   float numeroFloat = numero;
   Console.WriteLine($"numero conertito: {numeroFloat}");

   float numeroFloat2 = 3.14f;
   int numeroInt = (int)numeroFloat2;
   Console.WriteLine($"float to int: {numeroInt}");
   // tra tipi di dato simili

   Console.Write("Ciao, inserisci nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine($"Ciao, {nome}");

   
    Console.Write("Inserisci un numero intero: ");
    string n1 = Console.ReadLine();
    Console.Write("Inserisci secondo numero: ");
    string n2 = Console.ReadLine();

    int numero1 = int.Parse(n1);
    int numero2 = int.Parse(n2);

    Console.WriteLine($"Somma di {n1} e {n2} = {numero1 + numero2}");

 }
    private static void MyMethod (){}

     static void TipiDiDato()
    {
         int numero = 10; // numero intero
         float decimale = 3.14f; // numero a virgola mobile
         char lettera = 'A'; // carattere
         bool condizione = true; // booleano (0 false, 1 true)
         string saluto = "Ciao a tutti!"; // stringa di caratteri

         Console.WriteLine("Numero: " + numero);
         Console.WriteLine("Decimale: " + decimale);
         Console.WriteLine("Lettera: " + lettera);
         Console.WriteLine($"Saluto: {saluto}");;
         Console.WriteLine("Condizione: " + condizione);

    }
}

// dotnet run --ptoject Myproject per fare il run sul terminale