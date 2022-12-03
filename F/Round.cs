using System;
using System.Collections.Generic;

public class Round
{
    private int _amountOfMonsters;
    private int _amountOfCrashes;

    public Round(int amountOfMonsters, int amountOfCrashes)
    {
        _amountOfMonsters = amountOfMonsters;
        _amountOfCrashes = amountOfCrashes;
    }

    public void Play(IList<IHelper> helpers)
    {
        foreach (var helper in helpers)
        {
            switch (helper)
            {
                case Mario mario:
                    mario.FixPipe(ref _amountOfCrashes);
                    mario.KillMonster(ref _amountOfMonsters);
                    break;
                case Plumber plumber:
                    plumber.FixPipe(ref _amountOfCrashes);
                    break;
                case Hero hero:
                    hero.KillMonster(ref _amountOfMonsters);
                    break;
            }
        }

        if (_amountOfCrashes > 0 & _amountOfMonsters <= 0)
        {
            Console.WriteLine("Helpers lost this round!");
            helpers.Add(new Plumber());
        }
        if (_amountOfCrashes <= 0 & _amountOfMonsters > 0)
        {
            Console.WriteLine("Helpers lost this round!");
            helpers.Add(new Hero());
        }
        if (_amountOfCrashes > 0 & _amountOfMonsters > 0)
        {
            Console.WriteLine("Helpers lost this round!");
            helpers.Add(new Mario());
        }
        if (_amountOfCrashes <= 0 & _amountOfMonsters <= 0)
        {
            Console.WriteLine("Helpers won this round!");
        }
    }
}