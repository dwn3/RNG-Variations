public class GaussianRandom : Random {
    private double Mean;
    private double StandardDeviation;
    public GaussianRandom(){
        Mean = 0.5;
        StandardDeviation = .16667;
    }
    public GaussianRandom(int Seed) : base(Seed){
        Mean = 0.5;
        StandardDeviation = .16667;
    }
    public GaussianRandom(double Mean, double StandardDeviation){
        this.Mean = Mean;
        this.StandardDeviation = StandardDeviation;
    }
    public GaussianRandom(int Seed, double Mean, double StandardDeviation) : base(Seed){
        this.Mean = Mean;
        this.StandardDeviation = StandardDeviation;
    }
    protected override double Sample(){
        var x = base.Sample();
        var y = base.Sample();

        double RandomNormal = Mean + StandardDeviation*Math.Sqrt(-2.0 * Math.Log(x)) * Math.Sin(2.0 * Math.PI * y);
        if(RandomNormal <=0)
            return 0;
        if(RandomNormal >= 0.99999999999999978)
            return 0.99999999999999978; //the max value the default Sample can ever return 
        return RandomNormal;        
    }
    public override int Next(){
        return (int) (Sample() * int.MaxValue);
    }
    public override int Next(int maxValue){
        return (int) (Sample() * maxValue);
    }
    public override double NextDouble() => Sample();
}