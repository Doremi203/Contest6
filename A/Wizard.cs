using System;
using System.Collections.Generic;
using System.Linq;

internal sealed class Wizard : LegendaryHuman
{
    private static readonly Dictionary<string, int> _ranks= new()
    {
        { "Neophyte", 1 },
        { "Adept", 2 },
        { "Charmer", 3 },
        { "Sorcerer", 4 },
        { "Master", 5 },
        { "Archmage", 6 }
    };
    private readonly string _rank;


    public string Rank
    {
        get => _rank;
        private init
        {
            if (!_ranks.ContainsKey(value))
                throw new ArgumentException("Invalid wizard rank.");
            _rank = value;
        }
    }

    private int MagePower => Power * (int)Math.Pow(_ranks[Rank], 1.5) + HealthPoints / 10;

    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints, power)
    {
        Rank = rank;
    }

    public override void Attack(LegendaryHuman enemy)
    {
        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            switch (enemy)
            {
                case Wizard wizard:
                    Console.WriteLine($"{_rank} {GetType()} {Name} with HP {HealthPoints} attacked {wizard.Rank} {wizard.GetType()} {wizard.Name} with HP {wizard.HealthPoints}.");
                    wizard.HealthPoints -= MagePower;
                    break;
                case Knight knight:
                    Console.WriteLine($"{_rank} {GetType()} {Name} with HP {HealthPoints} attacked {knight.GetType()} {knight.Name} with HP {knight.HealthPoints}.");
                    knight.HealthPoints -= MagePower;
                    break;
            }
            if (enemy.HealthPoints <=0)
            {
                switch (enemy)
                {
                    case Wizard wizard:
                        Console.WriteLine($"{wizard.Rank} {wizard.GetType()} {wizard.Name} with HP {wizard.HealthPoints} is dead.");
                        break;
                    case Knight knight:
                        Console.WriteLine($"{knight.GetType()} {knight.Name} with HP {knight.HealthPoints} is dead.");
                        break;
                }
            }
        }
    }
}