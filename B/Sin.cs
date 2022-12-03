using System;

internal sealed class Sin  : Function
{
    protected override double GetY(double x)
    {
        if (!IsDefined(x))
            throw new ArgumentException("Function is not defined in point");
        return 1 / Math.Sin(x);
    }

    protected override bool IsDefined(double x) => Math.Sin(x) != 0;
}