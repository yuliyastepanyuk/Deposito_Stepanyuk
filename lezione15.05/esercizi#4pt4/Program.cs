using System;


class Program
{
    static void Main(string[] args)
    {
        int bonus1 = 2;
        int bonus2 = 3;
        int bonus3 = 5;

        Console.WriteLine("Inserisci il punteggio 1: ");
        int punteggio1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il punteggio 2: ");
        int punteggio2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il punteggio 3: ");
        int punteggio3 = int.Parse(Console.ReadLine());
        AggoirnaPunteggio(ref punteggio1, ref punteggio2, ref punteggio3, bonus1, bonus2, bonus3, out int punteggioFinale, out double punteggioMedio);
        Console.WriteLine($"PunteggioFinale è {punteggioFinale} e il punteggio medio è {punteggioMedio}");


        Console.WriteLine("Insersisci il nome dello studente: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Inserisci il voto 1: ");
        int voto1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il voto 2: ");
        int voto2 = int.Parse(Console.ReadLine());
        ElaboraStudente(nome, ref voto1, ref voto2, out double votomedio, out bool promosso);
        Console.WriteLine($"Studente {nome} è {(promosso ? "promosso" : "non promosso")} con un voto medio di {votomedio}");
    }

    private static void AggoirnaPunteggio(ref int punteggio1, ref int punteggio2, ref int punteggio3, int bonus1, int bonus2, int bonus3, out int punteggioFinale, out double punteggioMedio)
    {
        punteggio1 += bonus1;
        punteggio2 += bonus2;
        punteggio3 += bonus3;

        punteggioFinale = punteggio1 + punteggio2 + punteggio3;
        punteggioMedio = punteggioFinale / 3;

    }

    private static void ElaboraStudente(string nome, ref int voto1, ref int voto2, out double votomedio, out bool promosso)
    {
        votomedio = (voto1 + voto2) / 2;
        promosso = votomedio >= 6.0;
    }
}
