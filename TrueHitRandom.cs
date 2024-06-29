using System;

public class TrueHitRandom : Random {
    public TrueHitRandom() : base(){}

    public TrueHitRandom(int Seed) : base(Seed){}

    protected override double Sample(){
        return (base.Sample()+ base.Sample()) /2;
    }
    public override int Next(){
        return (int) (Sample() * int.MaxValue);
    }
    public override int Next(int maxValue){
        return (int) (Sample() * maxValue);
    }
    public override double NextDouble() => Sample();
}