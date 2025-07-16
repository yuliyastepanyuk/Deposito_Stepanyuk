// setter inhection, la dipendenza viene iniettata tramite una proprietà pubblica, questo approccio è utile quando la dipendenza non è nesessaria per il corretto funzionamento dell'intera classe
// non garantisce che la dipendenza sia impostata prima dell'uso, quindi è importante assicurarsi che venga impostata correttamente prima di utilizzare la classe

using System.ComponentModel;

public interface IDatabaseService
{
    void Connect();
}

public class SqlDatabaseService : IDatabaseService
{
    public void Connect()
    {
        Console.WriteLine("Connessione al database SQL stabilita.");
    }
}

public class ReportGenerator
{
    public IDatabaseService DatabaseService { get; set; }

    public void GenerateReport()
    {
        if (DatabaseService == null)
        {
            Console.WriteLine("DatabaseService non impostato.");
            return;
        }

        DatabaseService.Connect();
        Console.WriteLine("Generazione report in corso...");
    }
}

public class Program
{
    public static void Main()
    {
        var generator = new ReportGenerator();
        generator.DatabaseService = new SqlDatabaseService();
        generator.GenerateReport();
    }
}
