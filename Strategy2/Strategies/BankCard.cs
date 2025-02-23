namespace Strategy2.Strategies;

public class BankCard : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("We got money from your Bank card!");
    }
}