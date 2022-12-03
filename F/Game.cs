using System;
using System.Collections.Generic;

public class Game
{

    public static IList<IHelper> helpers = new List<IHelper>();
    
    private readonly int numberOfRounds;

    public Game(int numberOfHeroes, int numberOfPlumbers, int numberOfMarios, int numberOfRounds)
    {
        for (int i = 0; i < numberOfHeroes; i++)
        {
            helpers.Add(new Hero());
        }
        
        for (int i = 0; i < numberOfPlumbers; i++)
        {
            helpers.Add(new Plumber());
        }
        
        for (int i = 0; i < numberOfMarios; i++)
        {
            helpers.Add(new Mario());
        }

        this.numberOfRounds = numberOfRounds;
    }

    public void Play()
    {
        for (int i = 0; i < numberOfRounds; i++)
        {
            int monsters, crashes;
            var input = Console.ReadLine().Split();
            while(input.Length != 2 ||
                !int.TryParse(input[0], out monsters) | !int.TryParse(input[1], out crashes))
            {
                Console.WriteLine("Incorrect data!");
                input = Console.ReadLine().Split();
            }
            var round = new Round(monsters, crashes);
                round.Play(helpers);
        }
    }
}