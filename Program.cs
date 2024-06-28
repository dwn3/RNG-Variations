using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var rand = new Random();
        var trueRand = new TrueHitRandom();
        var gausRand = new GaussianRandom();
        int[] intsRand = new int[100000];
        int[] intsTrue = new int[100000];
        int[] intsGaus = new int[100000];

        for(int a = 0; a < 100000; a++){
            intsRand[a] = rand.Next(100);
            intsTrue[a] = trueRand.Next(100);
            intsGaus[a] = gausRand.Next(100);
        }

        if(!Directory.Exists("output"))
            Directory.CreateDirectory("output");
            

        using(StreamWriter output = new StreamWriter("output/Random.txt")){
            for(int a = 0; a < 100000; a++)
                output.WriteLine(intsRand[a]);
        }
        using(StreamWriter output = new StreamWriter("output/TrueHit.txt")){
            for(int a = 0; a < 100000; a++)
                output.WriteLine(intsTrue[a]);
        }
        using(StreamWriter output = new StreamWriter("output/Gaus.txt")){
            for(int a = 0; a < 100000; a++)
                output.WriteLine(intsGaus[a]);
        }
    }
}