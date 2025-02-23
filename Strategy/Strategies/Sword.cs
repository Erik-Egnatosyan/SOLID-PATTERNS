namespace SOLID_and_Patterns.Strategies;

public class Sword : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("Attack with sword!");
    }
}