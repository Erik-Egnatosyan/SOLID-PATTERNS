namespace SOLID_and_Patterns.Strategies;

public class Ult : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("One shot the enemy!");
    }
}