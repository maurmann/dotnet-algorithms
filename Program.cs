using dotnet_algorithms;
using System.Diagnostics;

var values = new int[] { 34,342,3,0,15,8,9,0 };

Console.WriteLine($"Unsorted...: {string.Join(',', values)}");

var stopWatch = new Stopwatch();
stopWatch.Start();
new BubbleSort().Sort(values);
stopWatch.Stop();

Console.WriteLine($"Sorted.....: {string.Join(',', values)}");
Console.WriteLine($"Elapsed ms.: {stopWatch.ElapsedMilliseconds}");
Console.ReadKey();
