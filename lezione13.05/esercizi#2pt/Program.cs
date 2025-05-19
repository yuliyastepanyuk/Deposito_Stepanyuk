using System;

class Program
{
    static void Main(string[] args)
    {
        //PrimoEsercizio();
        //SecondoEsercizio();
        //TerzoEsercizio();
        QuartoEsercizio();
        QuintoEsercizio();
        SestoEsercizio();
    }

    static void PrimoEsercizio()
    {
        int numero;
        int somma = 0;

        while (true)
        {
            Console.WriteLine("Inserisci un numero intero positivo: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                somma += numero;
            }
            else
            {
                Console.WriteLine($"La somma è {somma}");
                break;
            }
        }
    }

    static void SecondoEsercizio()
    {
        const int NumeroSegreto = 50;
        bool indovino = true;
        while (indovino)
        {
            Console.WriteLine("Indovina il numero!");
            int numero = int.Parse(Console.ReadLine());

            if (numero > NumeroSegreto)
            {
                Console.WriteLine("Hai sbagliato, il numero segreto è più piccolo di quello che hai scritto.");
            }
            else if (numero < NumeroSegreto)
            {
                Console.WriteLine("Hai sbagliato, il numero segreto è più grande di quello che hai scritto.");
            }
            else if (numero == NumeroSegreto)
            {
                indovino = false;
                Console.WriteLine("Hai indovinato!");
            }
            else
            {
                Console.WriteLine("Dato non valido!");
            }
        }
    }

    static void TerzoEsercizio()
    {
        int scelta;
        double saldo = 0;
        double deposito;
        double prelievo;

        bool esci = true;

        while (esci)
        {
            Console.WriteLine("Scegli l'operazione da 1 a 4:\n 1.Visualizza saldo\n 2.Deposita denaro\n 3.Preleva denaro\n 4.Esci");
            scelta = int.Parse(Console.ReadLine());     // int.TryParse(Console.ReadLine(), out numero) else Console.WriteLine("Dato non valido")continue;
            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Il tuo saldo è {saldo}");
                    break;
                case 2:
                    Console.WriteLine("Quanto vuoi depositare?");
                    deposito = double.Parse(Console.ReadLine());
                    if (deposito > 0)
                    {
                        saldo += deposito;
                        Console.WriteLine($"Hai depositato {deposito}\n Il tuo saldo è ora {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("Valore non valido");
                    }
                    break;
                case 3:
                    Console.WriteLine("Quanto vuoi prelevare?");
                    prelievo = double.Parse(Console.ReadLine());
                    if (prelievo <= saldo)
                    {
                        saldo -= prelievo;
                        Console.WriteLine($"Hai prelevato {prelievo}\n Il tuo saldo ora è {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("Valore non valido");
                    }
                    break;
                case 4:
                    Console.WriteLine("Arrividerci");
                    esci = false;
                    break;
            }


        }
    }

    static void QuartoEsercizio()
    {
        const int password = 1234;
        int tentativi = 0;
        bool accessoConcesso = false;

        do
        {
            Console.WriteLine("Inserisci la password, hai fino a tre tentativi: ");
            int a = int.Parse(Console.ReadLine());

            if (inserita == password)
            {
                Console.WriteLine("Password corretta. Accesso consentito.");
                accessoConcesso = true;
            }
            else
            {
                Console.WriteLine("Password errata.");
                tentativi++;
            }
        }
        while (!accessoConcesso && tentativi < 3);
        if (!accessoConcesso)
        {
            Console.WriteLine("Hai esaurito i tentativi. Accesso negato.");
        }
    }

    static void QuintoEsercizio()
    {
        int numero;
        int somma = 0;

        do
        {
            Console.WriteLine("Inserisci un numero intero: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                somma += numero;
            }
            else
            {
                Console.WriteLine("Non hai inserito un numero. Riprova");
                numero = 1;

            }


        }
        while (numero != 0);
        Console.WriteLine($"La somma finale è {somma}");
    }

    static void SestoEsercizio()
    {
        string operatore;
        double num1;
        double num2;

        bool calcola = true;

        do
        {
            Console.WriteLine("Benvenuto, inserisci il primo numero: ");
            if (double.TryParse(Console.ReadLine(), out num1))
            {                                                                       //if(!PrimoValido)
                // Ciclo per chiedere il secondo numero finché non è valido         //{continue}
                bool secondoNumeroValido = false;
                do
                {
                    Console.WriteLine("Inserisci il secondo numero: ");
                    secondoNumeroValido = double.TryParse(Console.ReadLine(), out num2);
                    if (!secondoNumeroValido)
                    {
                        Console.WriteLine("Valore non valido. Riprova.");
                    }
                }
                while (!secondoNumeroValido);

                Console.WriteLine("Inserisci l'operatore tra '+', '-', '*' e '/'");
                operatore = Console.ReadLine();
                
                double risultato;
                switch (operatore)
                {
                    case "+"
                        risultato = num1+num2;
                        Console.WriteLine($"Il risultato dell'operazione è {risultato}")
                        break;
                    case "-"
                        risultato = num1-num2;
                        Console.WriteLine($"Il risultato dell'operazione è {risultato}")
                        break;
                    case "*"
                        risultato = num1*num2;
                        Console.WriteLine($"Il risultato dell'operazione è {risultato}")
                        break;
                    case "/";
                        risultato = num1/num2;
                        Console.WriteLine($"Il risultato dell'operazione è {risultato}")
                        break;
                    default:
                        Console.WriteLine("Operatore non valido.");
                        break;
                }
                Console.WriteLine("Vuoi eseguire un'altra operazione? (s/n): ");
                if (risposta != "s")
                {
                    calcola = false;
                    Console.WriteLine("Grazie per aver usato la calcolatrice.");
                }
            }
            else
            {
                Console.WriteLine("Il primo numero non è valido. Riprova.");
            }
        }
        while(calcola);
    }
}


