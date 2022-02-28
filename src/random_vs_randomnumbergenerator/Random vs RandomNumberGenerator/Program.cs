
using System.Diagnostics;
using System.Security.Cryptography;

const int NUMBER_OF_ITERATIONS = 100_000_000;

var sw = new Stopwatch();

var random = new Random();

Console.WriteLine("Running Random()");

sw.Start();
for (int num = 0; num < NUMBER_OF_ITERATIONS; num++)
{
    random.Next(0, int.MaxValue);
}
sw.Stop();
var speed_random = sw.Elapsed;

Console.WriteLine("Completed Random()");

sw.Reset();

Console.WriteLine("Running RandomNumberGenerator()");

sw.Start();

for (int num = 0; num < NUMBER_OF_ITERATIONS; num++)
{
    RandomNumberGenerator.GetInt32(int.MaxValue);
}
sw.Stop();

Console.WriteLine("Completed RandomNumberGenerator()");

var speed_rng = sw.Elapsed;

Console.WriteLine("Completed All");
Console.Write($"Random Speed : ");
Print(speed_random);
Console.WriteLine();

Console.Write($"Random Speed : ");
Print(speed_rng);
Console.WriteLine();

Console.ReadLine();

void Print(TimeSpan ts)
{
    //Console.Write(@"{0} Seconds and {1} Milliseconds", ts.Seconds, ts.Milliseconds);
    Console.Write(@"Total Milliseconds : {0}", ts.TotalMilliseconds);
}