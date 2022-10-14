using BenchmarkDotNet.Attributes;

namespace dotnet_algorithms
{
    public class SortBenchmark
    {
        [Benchmark]
        public void Bubble()
        {
            var values = new int[] { 4, 2, 8, 7, 1, 5, 3, 6 };
            BubbleSort.Sort(values);
        }

        [Benchmark]
        public void Quick()
        {
            var values = new int[] { 4, 2, 8, 7, 1, 5, 3, 6 };
            QuickSort.Sort(values);
        }
    }
}
