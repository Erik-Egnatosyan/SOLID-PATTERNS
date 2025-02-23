namespace Strategy2.Strategies;

public class Visa : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("We get money from your visa!");
    }
}