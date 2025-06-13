using System;
using MySql.Data.MySqlClient;

public class Utente
{// Classe che rappresenta un utente del sistema
    public int UtenteId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? Telefono { get; set; }
    public int RuoloId { get; set; }
    public Ruolo Ruolo { get; set; }


    // Costruttore vuoto 
    public Utente() { }

    // Costruttore con parametri principali
    public Utente(string username, string email, string password) // Inizializza un nuovo utente con username, email e password
    {
        Username = username;
        Email = email;
        Password = password;
    }

    public static Utente Registrazione()
    {
        Console.WriteLine("Inserisci un username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Inserisci un'email valida: ");
        string email = Console.ReadLine();
        Console.WriteLine("Inserisci una password: ");
        string password = Console.ReadLine();

        string query = "INSERT INTO utente (username, email, password) VALUES (@Username, @Email, @Password)";
        using (MySqlCommand cmd = new MySqlCommand(query, DbConnection.Istanza.Connessione)) // Crea un comando SQL per inserire un nuovo utente usando l'istanza della connessione al database
        {
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
        }

        return new Utente(username, email, password);
        Console.WriteLine("Registrazione completata con successo!");
    }
    
    public static Utente Login()
    {
        Console.WriteLine("Inserisci le tue credenziali per accedere:");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        string query = "SELECT * FROM utente WHERE username = @Username AND password = @Password";
        using (MySqlCommand cmd = new MySqlCommand(query, DbConnection.Istanza.Connessione))
        {
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("Accesso effettuato con successo!");

                    return new Utente
                    {
                        UtenteId = int.Parse(reader["utente_id"].ToString()),
                        Username = reader["username"].ToString(),
                        Email = reader["email"].ToString(),
                        Password = reader["password"].ToString(),
                        RuoloId = int.Parse(reader["ruolo_id"].ToString()),
                    };
                }
                else
                {
                    Console.WriteLine("Credenziali non valide. Riprova.");
                     return null;
                }
            }
        }
    }
}