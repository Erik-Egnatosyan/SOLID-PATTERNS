namespace FactoryMethod.BussinesObjects;

public class PersonalTrainingMembership : IMemberShip
{
    private readonly decimal _price;

    public PersonalTrainingMembership(decimal price)
    {
        Name = "Personal training membership";
        _price = price;
    }

    public string Name { get; }

    public string Description { get; set; }

    public decimal GetPrice()
    {
        return _price;
    }
}