using System;

class Citizen : IPessimist, IOptimist
{
    public double Predicted { get; }

    public Citizen(double predictedValue)
    {
        Predicted = predictedValue;
    }
    double IOptimist.GetForecast() => Predicted * 2;
    
    double IPessimist.GetForecast() => Predicted * 0.6;

    public double GetForecast() => Predicted * 1.1;

    internal static Citizen Parse(string input)
    {
        if (!int.TryParse(input, out var val) || val <= 0)
            throw new ArgumentException("Incorrect citizen");
        return new Citizen(double.Parse(input));
    }
}