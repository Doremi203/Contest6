public class Mario : IHero,IPlumber
{
    public void KillMonster(ref int numberOfMonsters)
    {
        numberOfMonsters -= 1;
    }

    public void FixPipe(ref int numberOfCrashes)
    {
        numberOfCrashes -= 1;
    }
}