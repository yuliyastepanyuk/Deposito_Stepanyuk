    /*// 1.
    int numero1 = 3;
    int numero2 = 4;
    Console.WriteLine(numero1 + numero2);
    // 2.
    double prezzo1 = 29.99;
    double prezzoScontato = prezzo1- (prezzo1/100)*20;
    Console.WriteLine(prezzoScontato);
    // 3.
    float numero3 = -4;
    bool numeroPos = numero3 >0;
    Console.WriteLine(numeroPos);
    // 4.
    Console.WriteLine("Inserisci numero intero: ");
    int numInt = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci numero con la virgola: ");
    double numVir = double.Parse(Console.ReadLine());
    Console.WriteLine(numInt + numVir);
    // 5.
    Console.WriteLine("Inserisci la tua età: ");
    int eta = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci la tua altezza: ");
    float altezza = float.Parse(Console.ReadLine());
    int altezza1 = (int)altezza;

    Console.WriteLine(eta + altezza1); */

     //------------------------------

     // 1.

     const int etaMinima = 18;
     Console.WriteLine("Inserisci la tua età: ");
     int eta1 = int.Parse(Console.ReadLine());

      if (eta1 > etaMinima)
      {
        Console.WriteLine("Sei maggiorenne.");
      }

      if (eta1 < etaMinima)
      {
        Console.WriteLine("Sei minorenne.");
      }

    // 2.

    const int sconto = 10; // sconto del 10% const double = 10/100
    const int prezzoDaSuperare = 100;

    Console.WriteLine("Inserire il prezzo: ");
    double prezzo = double.Parse(Console.ReadLine());
    double prezzoFinale = prezzo; // valore di default: senza sconto

    if (prezzo > prezzoDaSuperare)
    {
        prezzoFinale = prezzo - (prezzo / 100 * sconto);
    }

    Console.WriteLine($"Il prezzo finale è: {prezzoFinale} = {prezzo} - ({prezzo} / 100 * {sconto})");


    // 3.

    Console.WriteLine("Inserisci 3 numeri interi: ");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());

    double media = (num1 + num2 + num3)/3;

    if(media >= 60)
    {
        Console.WriteLine("Hai superato la Prova!");
    }

    if(media < 60)
    {
        Console.WriteLine("Prova fallita");
    }

    Console.WriteLine(media);



    

