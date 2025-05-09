namespace LeetCode.Tests;

public class TwoSumSolverTests
{
    public record TestDataRecord(int[] Nums, int Target, (int? l, int? r) ExpectedResult);
    
    public static class TestCases
    {
        public static IEnumerable<Func<TestDataRecord>> ListOf()
        {
            yield return () => new TestDataRecord([1, 1 ,2,0], 3, (2,1));
            yield return () => new TestDataRecord([2, 7, 11, 15], 9, (0, 1));
            yield return () => new TestDataRecord([3, 2, 4], 6, (1, 2));
            yield return () => new TestDataRecord([], 10, (null, null));
        }
    }
    
    [Test]
    [MethodDataSource(typeof(TestCases), nameof(TestCases.ListOf))]
    public async Task TestsSolution(TestDataRecord testData)
    {
        var result = TwoSumSolver.Solve(testData.Nums, testData.Target);

        await Assert.That(result)
            .IsEqualTo((testData.ExpectedResult.l, testData.ExpectedResult.r))
            .Or.IsEqualTo((testData.ExpectedResult.r, testData.ExpectedResult.l));
    }
}