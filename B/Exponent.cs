using System;

internal sealed class Exponent : Function
{
    protected override double GetY(double x)
    {
        if (!IsDefined(x))
            throw new ArgumentException("Function is not defined in point"); 
        return Math.Exp(1 / x);
    }

    protected override bool IsDefined(double x) => x != 0;
}