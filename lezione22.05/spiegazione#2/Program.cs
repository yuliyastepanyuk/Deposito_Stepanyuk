// GET SET
//
class Programma
{
    private int _eta;
    public int _Eta
    {
        get
        {
            return _eta;
        }
        set
        {
            if (value >= 0)
                _eta = value;
        }
    }

    public string Nome { get; set; }
    // sono già settabili e gettabili così

    // ogni singola funzionalità sia in un file a parte

    public string Nome2 { get; private set; }
}    