﻿using SOLID_and_Patterns.Strategies;

namespace SOLID_and_Patterns;

public class Hero
{
    private readonly string _name;
    private IWeapon _weapon;

    public Hero(string name)
    {
        _name = name;
    }

    public void SetWeapon(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void Attack()
    {
        Console.WriteLine(">>>");
        if (_weapon is null)
        {
            Console.WriteLine($"{_name} cant attack with hand");
            return;
        }

        Console.WriteLine($"{_name} stands menacingly ");

        Console.Write($"{_name} ");

        _weapon.Shoot();

        Console.WriteLine($"{_name} ceases to stand menacingly ");
    }
}