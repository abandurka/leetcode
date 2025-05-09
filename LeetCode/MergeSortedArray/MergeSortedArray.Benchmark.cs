﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LeetCode;

public partial class MergeSortedArray
{
    [SimpleJob(RuntimeMoniker.Net90)]
    [MemoryDiagnoser]
    [MarkdownExporter]
    public class Benchmark
    {
        [Params(10_000)] public int N;

        private int[] num;
        private int[] mum;

        [GlobalSetup]
        public void Setup()
        {
            var r = new Random();
            num = new int[N];
            mum = new int[N];
            for (int i = 0; i < N; i++)
            {
                num[i] = r.Next(N);
                mum[i] = r.Next(N);
            }

            Array.Sort(num);
            Array.Sort(num);
        }

        [Benchmark]
        public void MergeWithList()
        {
            var r = MergeSortedArray.MergeWithList(num, mum);
            foreach (var i in r)
            {
                //
            }
        }

        [Benchmark]
        public void MergeWithYield()
        {
            var r = MergeSortedArray.MergeWithYield(num, mum);
            foreach (var i in r)
            {
                //
            }
        }

        [Benchmark]
        public void MergeWithYieldToList()
        {
            var r = MergeSortedArray.MergeWithYield(num, mum).ToList();
            foreach (var i in r)
            {
                //
            }
        }

        [Benchmark]
        public void MergeWithArray()
        {
            var r = MergeSortedArray.MergeWithArray(num, mum);
            foreach (var i in r)
            {
                //
            }
        }
    }
}