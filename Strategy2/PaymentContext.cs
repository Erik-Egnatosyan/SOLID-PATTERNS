using Strategy2.Strategies;

namespace Strategy2;

public class PaymentContext
{
    private readonly decimal _money = 100;
    private IPaymentStrategy _payment;

    public PaymentContext(decimal money)
    {
        _money = money;
    }

    public void SetPaymentType(IPaymentStrategy payment)
    {
        _payment = payment;
    }

    public void ProcessPayment()
    {
        Console.WriteLine("Выберите способ оплаты:");
        Console.WriteLine("1. PayPal");
        Console.WriteLine("2. Bank Card");
        Console.WriteLine("3. Visa");
        var choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                SetPaymentType(new PayPal());
                break;
            case 2:
                SetPaymentType(new BankCard());
                break;
            case 3:
                SetPaymentType(new Visa());
                break;
            default:
                Console.WriteLine("Неверный выбор");
                return;
        }

        Console.WriteLine("Введите сумму для снятия:");
        var input = Convert.ToInt32(Console.ReadLine());
        if (input > _money)
        {
            Console.WriteLine("Недостаточно средств");
            return;
        }

        _payment?.ProcessPayment(input);
        Console.WriteLine($"Остаток: {_money - input}$");
    }
}