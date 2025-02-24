using FactoryMethod.BussinesObjects;

namespace FactoryMethod.Factories;

public class GymPlusPoolMembershipFactory : MembershipFactory
{
    private readonly string _description;
    private readonly decimal _price;

    public GymPlusPoolMembershipFactory(decimal price, string description)
    {
        _price = price;
        _description = description;
    }

    public override IMemberShip GetMemberShip()
    {
        GymMembership membership = new(_price)
        {
            Description = _description
        };
        return membership;
    }
}