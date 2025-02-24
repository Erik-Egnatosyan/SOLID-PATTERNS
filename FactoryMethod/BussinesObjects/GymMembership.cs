namespace FactoryMethod.BussinesObjects;

public class GymMembership : IMemberShip
{
    private readonly decimal _price;

    public GymMembership(decimal price)
    {
        Name = "Gym membership";
        _price = price;
    }

    public string Name { get; }

    public string Description { get; set; }

    public decimal GetPrice()
    {
        return _price;
    }
}