using System;

internal class Programmer
{
    private readonly int _id;
    //private readonly int linesOfCode;

    protected int Id => _id;

    public int WrittenCode => GetAlmostRandomNumber();
    
    private int GetAlmostRandomNumber() => (int) Math.Abs(Math.Sin(GetIdDigitsSum() % 11 + 1) * 12345);

    public Programmer(int id)
    {
        _id = id;
    }

    private int GetIdDigitsSum()
    {
        var sum = 0;
        var idCopy = Id;
        while (idCopy != 0)
        {
            sum += idCopy % 10;
            idCopy /= 10;
        }

        return sum;
    }
    
    public override string ToString()
    {
        return $"Id: {Id}\nLines of code: {WrittenCode}";
    }
}