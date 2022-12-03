using System;

internal abstract class Function
{
    protected abstract double GetY(double x);

    protected abstract bool IsDefined(double x);
    public static Function GetFunction(string functionName)
    {
        switch (functionName)
        {
            case "Exp":
                return new Exponent();
            case "Parabola":
                return new Parabola();
            case "Sin":
                return new Sin();
            default:
                throw new ArgumentException("Incorrect input");
        }
    }

    public static double SolveIntegral(Function func, double left, double right, double step)
    {
        if (right < left)
            throw new ArgumentException("Left border greater than right");
        double sum = 0;
        while (right - left - step > 0)
        {
            sum += (func.GetY(left) + func.GetY(left + step)) / 2  * step;
            left += step;
        } 
        sum += (func.GetY(left) + func.GetY(right)) / 2  * (right - left);
        return sum;
    }
}