using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var rand = new Random(17);
        int[] ints = new int[100000];
        for(int a = 0; a < 100000; a++){
            ints[a] = (rand.Next(100) + rand.Next(100) )/2 +1;
        }

        using(StreamWriter output = new StreamWriter("rng17.txt")){
            for(int a = 0; a < 100000; a++)
                output.WriteLine(ints[a]);
        }
    }
}