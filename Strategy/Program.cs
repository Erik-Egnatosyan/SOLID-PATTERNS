using SOLID_and_Patterns.Strategies;

namespace SOLID_and_Patterns;

internal class Program
{
    private static void Main(string[] args)
    {
        Hero hero = new("Garen");
        hero.SetWeapon(new Ult());
        hero.Attack();
    }
}