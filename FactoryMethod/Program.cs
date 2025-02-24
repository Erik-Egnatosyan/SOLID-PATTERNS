using FactoryMethod.Factories;

namespace FactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Fitness Club CRM <<<\n");

        Console.WriteLine("> Enter the membership type you would like to create: ");

        Console.WriteLine("> G - GYM");
        Console.WriteLine("> P - GYM and Pool");
        Console.WriteLine("> T - Personal Training");

        var membershipType = Console.ReadLine();

        var factory = GetFactory(membershipType);

        factory?.GetMemberShip();

        var membership = factory.GetMemberShip();

        Console.WriteLine("\n> Membership you've just created: \n");

        Console.WriteLine(
            $"Name:\t\t{membership.Name}\n" +
            $"Description:\t{membership.Description}\n" +
            $"Price:\t\t{membership.GetPrice()}");
    }

    private static MembershipFactory? GetFactory(string membershipType)
    {
        return membershipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Basic Membership"),
            "p" => new GymPlusPoolMembershipFactory(250, "Good price membership"),
            "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"),
            _ => null
        };
    }
}