using System;
using MySql.Data.MySqlClient;

public sealed class DbConnection
{
    private static DbConnection _istanza = null;
    private static readonly string _connectionString =
        "server=localhost;user=root;database=app_viaggi;port=3306;password=spike";

    private MySqlConnection _conn;

    // Costruttore privato
    private DbConnection()
    {
        _conn = new MySqlConnection(_connectionString);
        _conn.Open();
    }

    // Accesso all'istanza Singleton 
    public static DbConnection Istanza
    {
        get
        {
            if (_istanza == null)
                _istanza = new DbConnection();

            return _istanza;
        }
    }

    // Proprietà per accedere alla connessione
    public MySqlConnection Connessione => _conn;

    // Metodo per chiudere la connessione
    public void ChiudiConnessione()
    {
        if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
        {
            _conn.Close();
        }
    }
}