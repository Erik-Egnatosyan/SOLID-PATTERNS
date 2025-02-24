using FactoryMethod.BussinesObjects;

namespace FactoryMethod.Factories;

public class PersonalTrainingMembershipFactory : MembershipFactory
{
    private readonly string _description;
    private readonly decimal _price;

    public PersonalTrainingMembershipFactory(decimal price, string description)
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