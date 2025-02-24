using Strategy2.Strategies;

namespace Strategy2;

internal class Program
{
    private static void Main(string[] args)
    {
        PaymentContext payment = new(100);
        payment.ProcessPayment();
        payment.SetPaymentType(new PayPal());
    }
}