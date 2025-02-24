namespace FactoryMethod.BussinesObjects;

public class GymPlusPoolMembership : IMemberShip
{
    private readonly decimal _price;

    public GymPlusPoolMembership(decimal price)
    {
        Name = "Gym + Pool membership";
        _price = price;
    }

    public string Name { get; }

    public string Description { get; set; }

    public decimal GetPrice()
    {
        return _price;
    }
}