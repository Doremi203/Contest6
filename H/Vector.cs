using System;

internal struct Vector
{
    public int X { get; }
    public int Y { get; }

    private Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Length => Math.Sqrt(X * X + Y * Y);

    public static Vector Parse(string input)
    {
        var vecData = input.Split();
        if (vecData.Length != 2 || !int.TryParse(vecData[0], out var x) || !int.TryParse(vecData[1], out var y))
            throw new ArgumentException("Incorrect vector");
        return new Vector(x, y);
    }

    public int CompareTo(Vector other)
    {
        if (Length > other.Length)
        {
            return 1;
        }

        if (Length < other.Length)
        {
            return -1;
        }

        return 0;
    }
    
    
}