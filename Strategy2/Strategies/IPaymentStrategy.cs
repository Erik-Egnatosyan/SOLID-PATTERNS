namespace Strategy2.Strategies;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}