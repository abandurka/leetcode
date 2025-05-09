using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LeetCode;

public partial class TopKFrequentElements
{
    [ShortRunJob(RuntimeMoniker.Net90)]
    [MemoryDiagnoser]
    [MarkdownExporter]
    public class Benchmark
    {
        [Params(10_000)] public int N;
        public int K = 10;

        private int[] input;

        [GlobalSetup]
        public void Setup()
        {
            var r = new Random();
            input = Enumerable.Range(0, N).Select(x => r.Next(100)).ToArray();
        }

        [Benchmark]
        public void OneLine()
        {
            var r = TopKFrequentOneLine(input, K);
        }
        
        [Benchmark]
        public void DictWithPriorityQ()
        {
            var r = TopDictWithPriorityQ(input, K);
        } 
        
        [Benchmark]
        public void TopDictAllocated()
        {
            var r = TopDictWithPreinitizlizedLoccetions(input, K);
        }
        
        [Benchmark]
        public void ArraySortWithPq()
        {
            var r = ArraySortWithPQ(input, K);
        }
        
        [Benchmark]
        public void ArraySortWithPq_v2()
        {
            var r = ArraySortWithPQ_v2(input, K);
        } 
        
        [Benchmark]
        public void ThreeSolution()
        {
            var r = WithTree(input, K);
        }
    }
}