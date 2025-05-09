# Summary

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  .NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


| Method               | Job      | Runtime  | N     |      Mean |     Error |    StdDev |    Median |    Gen0 |    Gen1 |    Gen2 | Allocated |
|----------------------|----------|----------|-------|----------:|----------:|----------:|----------:|--------:|--------:|--------:|----------:|
| MergeWithList        | .NET 9.0 | .NET 9.0 | 10000 |  77.54 us |  0.767 us |  0.599 us |  77.47 us | 41.6260 | 41.6260 | 41.6260 |  262550 B |
| MergeWithYield       | .NET 9.0 | .NET 9.0 | 10000 |  62.88 us |  4.929 us | 14.534 us |  57.25 us |       - |       - |       - |      72 B |
| MergeWithYieldToList | .NET 9.0 | .NET 9.0 | 10000 | 151.82 us | 11.307 us | 33.338 us | 135.06 us | 41.5039 | 41.5039 | 41.5039 |  262582 B |
| MergeWithArray       | .NET 9.0 | .NET 9.0 | 10000 |  63.99 us |  3.195 us |  9.371 us |  66.15 us |  6.3477 |  1.5564 |       - |   80056 B |
