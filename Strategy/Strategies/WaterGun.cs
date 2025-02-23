namespace SOLID_and_Patterns.Strategies;

public class WaterGun : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("Attack with water gun!");
    }
}