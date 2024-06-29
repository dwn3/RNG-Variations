using System;

public class GaussianRandom : Random {
    public GaussianRandom(){}
    public GaussianRandom(int Seed) : base(Seed){}
    protected override double Sample(){
        var x = base.Sample();
        var y = base.Sample();

        double rand_normal = .5 + .16667*Math.Sqrt(-2.0 * Math.Log(x)) * Math.Sin(2.0 * Math.PI * y);
        if(rand_normal <=0)
            return 0;
        if(rand_normal >= 0.99999999999999978)
            return 0.99999999999999978; //the max value the default Sample can ever return 
        return rand_normal;        
    }
    public override int Next(){
        return (int) (Sample() * int.MaxValue);
    }
    public override int Next(int maxValue){
        return (int) (Sample() * maxValue);
    }
    public override double NextDouble() => Sample();
}