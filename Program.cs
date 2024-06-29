internal class Program
{
    private static void Main(string[] args)
    {
        var rand = new Random(177);
        var trueRand = new TrueHitRandom(177);
        var gausRand = new GaussianRandom(177);
        var gausRand2 = new GaussianRandom(177, .7, .1);
        var gausRand3 = new GaussianRandom(.3, .1);
        int[] intsRand = new int[100000];
        int[] intsTrue = new int[100000];
        int[] intsGaus = new int[100000];
        int[] intsGaus2 = new int[100000];
        int[] intsGaus3 = new int[100000];

        for(int a = 0; a < 100000; a++){
            intsRand[a] = rand.Next(100);
            intsTrue[a] = trueRand.Next(100);
            intsGaus[a] = gausRand.Next(100);
            intsGaus2[a] = gausRand2.Next(100);
            intsGaus3[a] = gausRand3.Next(100);
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
        using(StreamWriter output = new StreamWriter("output/Gaus2.txt")){
            for(int a = 0; a < 100000; a++)
                output.WriteLine(intsGaus2[a]);
        }
        using(StreamWriter output = new StreamWriter("output/Gaus3.txt")){
            for(int a = 0; a < 100000; a++)
                output.WriteLine(intsGaus3[a]);
        }
    }
}