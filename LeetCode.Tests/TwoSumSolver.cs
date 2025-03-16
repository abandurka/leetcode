namespace LeetCode.Tests;

public class TwoSumSolver
{
    [Test]
    [Arguments(new[] { 1, 1 ,2,0}, 3, 1,1)]

    public async Task MyTest(int[] nums, int target, int l, int r)
    {
        var result = TwoSum.TwoSumSolver.Solve(nums, target);

        await Assert.That(result).IsEqualTo((l, r));
    }
}