namespace LeetCode.Tests;

public class TopKFrequentElementsTests
{
    
    public record TestDataRecord(int[] Nums, int K, int[] ExpectedResult);
    
    public static class TestCases
    {
        public static IEnumerable<Func<TestDataRecord>> ListOf()
        {
            yield return () => new TestDataRecord([1, 1, 2, 0,3,3,3,3,0], 1, [3]);
            // yield return () => new TestDataRecord([ ], 1, [ ]);
        }
    }
    
    [Test]
    [MethodDataSource(typeof(TestCases), nameof(TestCases.ListOf))]

    public async Task Tests_TopKFrequentOneLine(TestDataRecord test)
    {
        var result = TopKFrequentElements.TopKFrequentOneLine(test.Nums, test.K);

        await Assert.That(result).IsEquivalentTo(test.ExpectedResult);
    }

    
    [Test]
    [MethodDataSource(typeof(TestCases), nameof(TestCases.ListOf))]
    public async Task Tests_TopDictWithPriorityQ(TestDataRecord test)
    {
        var result = TopKFrequentElements.TopDictWithPriorityQ(test.Nums, test.K);

        await Assert.That(result).IsEquivalentTo(test.ExpectedResult);
    }
    
    
    [Test]
    [MethodDataSource(typeof(TestCases), nameof(TestCases.ListOf))]
    public async Task Tests_TopDictWithPreinitizlizedLoccetions(TestDataRecord test)
    {
        var result = TopKFrequentElements.TopDictWithPreinitizlizedLoccetions(test.Nums, test.K);

        await Assert.That(result).IsEquivalentTo(test.ExpectedResult);
    }
    
    [Test]
    [MethodDataSource(typeof(TestCases), nameof(TestCases.ListOf))]
    public async Task Tests_ArraySortWithPQ(TestDataRecord test)
    {
        var result = TopKFrequentElements.ArraySortWithPQ(test.Nums, test.K);

        await Assert.That(result).IsEquivalentTo(test.ExpectedResult);
    }
    
    [Test]
    [MethodDataSource(typeof(TestCases), nameof(TestCases.ListOf))]
    public async Task Tests_ArraySortWithPQ_v2(TestDataRecord test)
    {
        var result = TopKFrequentElements.ArraySortWithPQ_v2(test.Nums, test.K);

        await Assert.That(result).IsEquivalentTo(test.ExpectedResult);
    }
    
    [Test, Skip("WithTree solution isn't finished")]
    [MethodDataSource(typeof(TestCases), nameof(TestCases.ListOf))]
    public async Task Tests_WithTree(TestDataRecord test)
    {
        var result = TopKFrequentElements.WithTree(test.Nums, test.K);

        await Assert.That(result).IsEquivalentTo(test.ExpectedResult);
    }
}