namespace LeetCode;

public class Program
{
    static void Main(string[] args)
    {
        BenchmarkDotNet.Running.BenchmarkRunner.Run<TopKFrequentElements.Benchmark>();
    }
    
}