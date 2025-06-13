using System;
public class Pagamento
{
    public int PagamentoId { get; set; }
    public decimal Importo { get; set; }
    public DateTime DataPagamento { get; set; } = DateTime.Now;
    public int PrenotazioneId { get; set; }
    public int MetodoPagamentoId { get; set; }

    public Prenotazione Prenotazione { get; set; }
    public MetodoPagamento MetodoPagamento { get; set; }

    public Pagamento() { }

    public Pagamento(decimal importo, int prenotazioneId, int metodoPagamentoId)
    {
        Importo = importo;
        PrenotazioneId = prenotazioneId;
        MetodoPagamentoId = metodoPagamentoId;
        DataPagamento = DateTime.Now;
    }
}