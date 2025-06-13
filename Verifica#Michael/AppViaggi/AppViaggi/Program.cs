using System;

class Program
{
    static void Main(string[] args)
    {
        bool continua = true;
        Console.WriteLine("Benvenuto nella nosta app viaggi!");
        do
        {
            Menu.MostraMenuPrincipale();
            string scelta = Console.ReadLine();
            if (scelta == "1")
            {
                Utente.Registrazione();
            }
            else if (scelta == "2")
            {
                Utente utenteLoggato = Utente.Login();

                if (utenteLoggato != null)
                {
                    if (utenteLoggato.RuoloId == 1)
                    {
                        bool continuaUtente = true;
                        while (continuaUtente)
                        {
                            Menu.MostraMenuUtente();
                            string sceltaUtente = Console.ReadLine();

                            if (sceltaUtente == "0")
                            {
                                Console.WriteLine("Alla Prossima!");
                                continuaUtente = false;
                            }
                        }
                        continua = false; 
                    }
                    else if (utenteLoggato.RuoloId == 2)
                    {
                        bool continuaAdmin = true;
                        while (continuaAdmin)
                        {
                            Menu.MostraMenuAdmin();
                            string sceltaAdmin = Console.ReadLine();

                            switch(sceltaAdmin)
                            {
                              /*  case "1":
                                    Utente.AggiungiUtente();
                                    break;
                                case "2":
                                    Utente.EliminaUtente();
                                    break;
                                case "3":
                                    Destinazione.AggiungiDestinazione();
                                    break;
                                case "4":
                                    Destinazione.EliminaDestinazione();
                                    break;
                                case "5":
                                    Destinazione.ModificaDestinazione();
                                    break;
                                case "6":
                                    Attrazione.AggiungiAttrazione();
                                    break;
                                case "7":
                                    Attrazione.EliminaAttrazione();
                                    break;
                                case "8":
                                    Attrazione.ModificaAttrazione();
                                    break;
                                case "0":
                                    Console.WriteLine("Alla Prossima!");
                                    continuaAdmin = false;
                                    break;
                                default:
                                    Console.WriteLine("Scelta non valida. Riprova.");
                                    break;*/
                            } 

                            if (sceltaAdmin == "0")
                            {
                                Console.WriteLine("Alla Prossima!");
                                continuaAdmin = false;
                            }
                        }
                        continua = false; 
                    }
                }
            }
            else if (scelta == "3")
            {
                Console.WriteLine("Alla Prossima!");
                continua = false;
                return;
            }
            else
            {
                Console.WriteLine("Scelta non valida. Riprova.");
                return;
            }
        } while (continua);
    }
} 
