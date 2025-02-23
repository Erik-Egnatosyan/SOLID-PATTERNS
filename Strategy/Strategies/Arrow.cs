namespace SOLID_and_Patterns.Strategies;

public class Arrow : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("Attack with arrow!");
    }
}