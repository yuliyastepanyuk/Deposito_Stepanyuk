using System;

public interface IPaymentGateway
{
    void ProcessPayment(string messaggio);
}

public class PayPalGateway : IPaymentGateway
{
    public void ProcessPayment(string messaggio)
    {
        Console.WriteLine($"Pagamento tramite Paypal: {messaggio}");
    }
}

public class StripeGateway : IPaymentGateway
{
    public void ProcessPayment(string messaggio)
    {
        Console.WriteLine($"Pagamento tramite Stripe: {messaggio}");
    }
}

public class PaymentService
{
    private readonly IPaymentGateway _paymentGateway;

    public PaymentService(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public void MakePayment(string messaggio)
    {
        _paymentGateway.ProcessPayment(messaggio);
    }
}