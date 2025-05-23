using System;

public class Programma
{
    private decimal saldo;

    public decimal OttieniSaldo()
    {
        return saldo;
    }

    public void Deposita(decimal importo)
    {
        if (importo > 0)
            saldo += importo;
    }
}

// get set solo alla propritetà
// invece metodi di accesso sono richiamabili, esempio se ho il set private tramite il metodo di accesso posso richiamarlo
