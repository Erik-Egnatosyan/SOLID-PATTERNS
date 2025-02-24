using FactoryMethod.BussinesObjects;

namespace FactoryMethod.Factories;

public abstract class MembershipFactory
{
    public abstract IMemberShip GetMemberShip();
}