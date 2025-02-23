namespace Strategy2.Strategies;

public class PayPal : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("We got money from your PayPal account!");
    }
}