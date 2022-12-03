using System;

internal sealed class Knight : LegendaryHuman
{
    private readonly string[] _equipment;

    public Knight(string name, int healthPoints, int power, string[] equipment) : base(name, healthPoints, power)
    {
        Equipment = equipment;
        Power += 10 * Equipment.Length;
    }

    private string[] Equipment
    {
        get => _equipment;
        init
        {
            if (value.Length == 0)
                throw new ArgumentException("Not enough equipment.");
            _equipment = value;
        }
    }

    public override void Attack(LegendaryHuman enemy)
    {
        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            switch (enemy)
            {
                case Wizard wizard:
                    Console.WriteLine($"{GetType()} {Name} with HP {HealthPoints} attacked {wizard.Rank} {wizard.GetType()} {wizard.Name} with HP {wizard.HealthPoints}.");
                    wizard.HealthPoints -= Power;
                    if (wizard.HealthPoints <= 0)
                        Console.WriteLine($"{wizard.Rank} {wizard.GetType()} {wizard.Name} with HP {wizard.HealthPoints} is dead.");
                    break;
                case Knight knight:
                    Console.WriteLine($"{GetType()} {Name} with HP {HealthPoints} attacked {knight.GetType()} {knight.Name} with HP {knight.HealthPoints}.");
                    knight.HealthPoints -= Power;
                    if (knight.HealthPoints <= 0)
                        Console.WriteLine($"{knight.GetType()} {knight.Name} with HP {knight.HealthPoints} is dead.");
                    break;
            }
        }
    }
    
}