using System;

class Program // struttura 1
{
    static void Main(string[] args) // struttura 2 ecc..
    {
        WhileEsempio();
    }
    static void WhileEsempio()
    {
        bool continua = true;
        // int contatore = 0;
        while(continua)
        {
            Console.WriteLine("Vuoi uscire dal ciclo?")
            var rsiposta = Console.ReadLine();

            if(risposta == "s")
            {
                continua = false;
                // break
            }
            else if(risposta == "n")
            {
            Console.WriteLine("ok si continua")
            }
        }
    }
}
