using System;

using System;
using System.Collections.Generic;

// INTERFACCIA DEI SUBSCRIBER
public interface INewsSubscriber
{
    void Update(string news);
}

// IL SUBJECT (SINGLETON)
public class NewsAgency
{
    private static NewsAgency _instance;
    private string _news;

    private readonly List<INewsSubscriber> _subscribers = new List<INewsSubscriber>();

    // Costruttore privato
    private NewsAgency() { }

    // Accesso al singleton
    public static NewsAgency Instance
    {
        get
        {
            if (_instance == null)
                _instance = new NewsAgency();
            return _instance;
        }
    }

    // Proprietà News
    public string News
    {
        get => _news;
        set
        {
            _news = value;
            NotifySubscribers();
        }
    }

    // Aggiunge un osservatore
    public void Subscribe(INewsSubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    // Rimuove un osservatore
    public void Unsubscribe(INewsSubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    // Notifica tutti gli osservatori
    private void NotifySubscribers()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(_news);
        }
    }
}

// SUBSCRIBER: MobileApp
public class MobileApp : INewsSubscriber
{
    public void Update(string news)
    {
        Console.WriteLine($"Notification on mobile: {news}");
    }
}

// SUBSCRIBER: EmailClient
public class EmailClient : INewsSubscriber
{
    public void Update(string news)
    {
        Console.WriteLine($"Email sent: {news}");
    }
}

// PROGRAMMA DI TEST
public class Program
{
    public static void Main()
    {
        var agency = NewsAgency.Instance;

        var mobile = new MobileApp();
        var email = new EmailClient();

        agency.Subscribe(mobile);
        agency.Subscribe(email);

        Console.WriteLine("Setting news to 'Breaking: Market hits all-time high!'");
        agency.News = "Breaking: Market hits all-time high!";

        Console.WriteLine("\nSetting news to 'Update: New programming course available'");
        agency.News = "Update: New programming course available";
    }
}

