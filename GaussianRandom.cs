using System;

public class GaussianRandom : Random
{

    protected override double Sample()
    {
        var x = base.Sample();
        var y = base.Sample();

        double rand_normal = .5 + .167*Math.Sqrt(-2.0 * Math.Log(x)) * Math.Sin(2.0 * Math.PI * y);

        return rand_normal;        
    }
    public override int Next()
    {
        return (int) (Sample() * int.MaxValue);
    }
    public override int Next(int maxValue)
    {
        return (int) (Sample() * maxValue);
    }
}