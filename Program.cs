Console.WriteLine("Pick an RNG Seed");
var seedString = Console.ReadLine();
if (String.IsNullOrEmpty(seedString))
    seedString = "0";
int seed = Int32.Parse(seedString);
var rand = new Random(seed);
var trueRand = new TrueHitRandom(seed);
var gausRand = new GaussianRandom(seed);
var gausRand2 = new GaussianRandom(seed, .7, .1);
var gausRand3 = new GaussianRandom(seed, .3, .1);
int[] intsRand = new int[100000];
int[] intsTrue = new int[100000];
int[] intsGaus = new int[100000];
int[] intsGaus2 = new int[100000];
int[] intsGaus3 = new int[100000];

for (int a = 0; a < 100000; a++){
    intsRand[a] = rand.Next(100);
    intsTrue[a] = trueRand.Next(100);
    intsGaus[a] = gausRand.Next(100);
    intsGaus2[a] = gausRand2.Next(100);
    intsGaus3[a] = gausRand3.Next(100);
}

if (!Directory.Exists("output"))
    Directory.CreateDirectory("output");

using (StreamWriter output = new StreamWriter("output/Random.txt")){
    foreach (int a in intsRand)
        output.WriteLine(a);
}
using (StreamWriter output = new StreamWriter("output/TrueHit.txt")){
    foreach (int a in intsTrue)
        output.WriteLine(a);
}
using (StreamWriter output = new StreamWriter("output/Gaus.txt")){
    foreach (int a in intsGaus)
        output.WriteLine(a);
}
using (StreamWriter output = new StreamWriter("output/Gaus2.txt")){
    foreach (int a in intsGaus2)
        output.WriteLine(a);
}
using (StreamWriter output = new StreamWriter("output/Gaus3.txt")){
    foreach (int a in intsGaus3)
        output.WriteLine(a);
}
