using System;

class Program
{
    static void Main(string[] args)
    {
        //PrimoEsercizio();
        //SecondoEsercizio();
        //TerzoEsercizio();
        //QuartoEsercizio();
        //QuintoEsercizio();
        //SestoEsercizio();
        //EsercizioExtra();
        SettimoEsercizio();
        OttavoEsercizio();
    }

    static void PrimoEsercizio()
    {
        Console.WriteLine("Inserisci un numero intero");
        int numero = int.Parse(Console.ReadLine());

        if (numero%2 == 0)
        {
            Console.WriteLine("Il numero è pari");

        } 
        else
        {
            Console.WriteLine("Il numero è dispari");
        }
    }

    static void SecondoEsercizio()
    {
        const int password = 1234;
        Console.WriteLine("Inserisci la password per accedere: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero == password)
        {
            Console.WriteLine("Accesso consentito");

        } 
        else
        {
            Console.WriteLine("Accesso negato");
        }
    }

    static void TerzoEsercizio() 
    {
        Console.WriteLine("Inserisci un numero qualsiasi: ");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero");
        double numero2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci l'operatore da utilizzare: ");
        string operatore = Console.ReadLine();

        if (operatore == "+")
        {
            Console.WriteLine($"La somma è: {numero1 + numero2}");
        }
        else if (operatore == "-")
        {
            Console.WriteLine($"La differenza è {numero1 - numero2}");

        }
        else
        {
            Console.WriteLine("Operatore non valido");
        }
     }

     static void QuartoEsercizio()
     {
        Console.WriteLine("Inserisci un voto da 1 a 10: ");
        int voto = int.Parse(Console.ReadLine());

        if (voto >=1 && voto <=4)
        {
            Console.WriteLine("Insufficiente");

        }
        else if (voto == 5 || voto == 6)
        {
            Console.WriteLine("Sufficiente");
        }
        else if (voto == 7 || voto == 8)
        {
            Console.WriteLine("Buono");
        }
        else if (voto == 9 || voto == 10)
        {
            Console.WriteLine("Ottimo");
        }
        else
        {
            Console.WriteLine("Il tuo voto non è valido");
        }
     }

     static void QuintoEsercizio()
     {
        const double sottopeso = 18.5;
        const double normopeso = 25;
        const double sovvrapeso = 30;

        double peso;
        double altezza;
        
        Console.WriteLine("Inserisci la tua altezza in metri: ");
        altezza = double.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il tuo peso in kg: ");
        peso = double.Parse(Console.ReadLine());

        double bmi = peso/(altezza*altezza);

        if(bmi < sottopeso && bmi>0)
        {
            Console.WriteLine("Sei sottopeso");
        }
        else if (bmi >= sottopeso && bmi <= normopeso)
        {
            Console.WriteLine("Sei normopeso");
        }
        else if (bmi >= normopeso && bmi <= sovvrapeso)
        {
            Console.WriteLine("Sei sovvrapeso");
        }
        else if (bmi >= sovvrapeso)
        {
            Console.WriteLine("Sei obeso");
        }
        else
        {
            Console.WriteLine("Dati non validi");
        }

     }

     static void SestoEsercizio()
     {
        double celsius;
        double kelvin;
        double far;
        double rankine;

        const double celtokal = 273.15;
        const double celtofar1 = 1.8;
        const int celtofar2 = 32;
        const double celtoran = 491.67;
       

        Console.WriteLine("Inserisci la temperatura in Celsius: ");
        celsius = double.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci l'unità in cui convertire la temperatura tra 'F','K' e 'R'");
        string a = Console.ReadLine();

        if (a == "K")
        {
            kelvin = celsius + celtokal;
            Console.WriteLine($"La temperatura in Kelvin è {kelvin} K");
        }
        else if (a == "F")
        {
            far = celsius*celtofar1+celtofar2;
            Console.WriteLine($"La temperatura in Fahrenheit è {far} F");
        }
        else if ( a == "R")
        {
            rankine = celsius*celtofar1+celtoran;
            Console.WriteLine($"La temperatura in Rankine è {rankine} R");
        }

     }

     static void EsercizioExtra()
     {
        double temperatura;
        double celsius;
        double kelvin;
        double far;
        double rankine;

        const double celtokal = 273.15;
        const double celtofar1 = 1.8;
        const int celtofar2 = 32;
        const double celtoran = 491.67;
        const double fartoran = 459.67;


        Console.WriteLine("Inserisci la temperatura nel valore che preferisici: ");
        temperatura = double.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci l'unità di misura di partenza tra 'C','F','K' o 'R'");
        string a = Console.ReadLine();

        Console.WriteLine("Inserisci l'unità di misura in cui voi convertire la temperatura tra 'C','F','K' o 'R'");
        string b = Console.ReadLine();

        if (a == "C" )
        {
            if (b == "K")
            {
                kelvin = temperatura + celtokal;
                Console.WriteLine($"La temperatura in Kelvin è {kelvin} K");
            }
            else if (b == "F")
            {
                far = temperatura*celtofar1+celtofar2;
                Console.WriteLine($"La temperatura in Fahrenheit è {far} F");
            }
            else if ( b == "R")
            {
                rankine = temperatura*celtofar1+celtoran;
                Console.WriteLine($"La temperatura in Rankine è {rankine} R");
            }

        }

        if (a == "F")
        {
            if(b == "C")
            {
                celsius = (temperatura - celtofar2)*celtofar1;
                Console.WriteLine($"La temperarura in Celsius è {celsius} C");
            }
            else if(b == "K")
            {
                kelvin = ((temperatura - celtofar2)/celtofar1) + celtokal;
                Console.WriteLine($"La temperarura in Kelvin è {kelvin} K");
            }
            else if (b == "R")
            {
                rankine = temperatura+fartoran;
                Console.WriteLine($"La temperarura in Kelvin è {rankine} R");
            }
        }
    }

    static void SettimoEsercizio()
    {
        Console.WriteLine("Inserisci un numero e ti dirò che giorno è: ");
        int giorno = int.Parse(Console.ReadLine());

        switch(giorno)
        {
            case 1:
                Console.WriteLine("Oggi è lunedì !");
                break;
            case 2:
                Console.WriteLine("Oggi è martedì !");
                break;
            case 3:
                Console.WriteLine("Oggi è mercoledì !");
                break;
            case 4:
                Console.WriteLine("Oggi è giovedì !");
                break;
            case 5:
                Console.WriteLine("Oggi è venerdi !");
                break;
            case 6:
                Console.WriteLine("Oggi è sabato !");
                break; 
            case 7:
                Console.WriteLine("Oggi è domenica !");
                break;
            default:
                Console.WriteLine("Non ci sono altri giorni della settimana !");
                break;
        }
    }

    static void OttavoEsercizio()
    {
        double latoQ;
        double altezzaT;
        double baseT;
        double raggioC;

        const double PI = 3.14;

        Console.WriteLine("Di quale figura vuoi calcolare l'area tra triangolo, quadrato e cerchio ('q','t'e'c')");
        string? figura = Console.ReadLine();

        switch(figura)
        {
            case "q":
                Console.WriteLine("Inserisci la lunghezza del lato del quadrato: ");
                latoQ = double.Parse(Console.ReadLine());
                Console.WriteLine($"L'area del quadrato è {latoQ*latoQ}");
                break;
            case "t":
                Console.WriteLine("Inserisci la base del triangolo: ");
                baseT = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci l'altezza del triangolo: ");
                altezzaT = double.Parse(Console.ReadLine());
                Console.WriteLine($"L'area del triangolo è {(baseT*altezzaT)/2}");
                break;
            case "c":
                Console.WriteLine("Inserisci il raggio del cerchio: ");
                raggioC = double.Parse(Console.ReadLine());
                Console.WriteLine($"L'area del cerchio è {PI*raggioC*raggioC}");
                break;
            default:
                Console.WriteLine("Non conosco questa figura");
                break;    
        }
    }
}

