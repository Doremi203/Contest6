using System;

internal sealed class Parabola  : Function
{
    protected override double GetY(double x) => x * x + x + 7;

    protected override bool IsDefined(double x)
    {
        return true;
    }
}