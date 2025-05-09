namespace LeetCode;

public class TwoSumSolver
{
    public static (int? a, int? b) Solve(int[] nums, int target)
    {
        var ht = new Dictionary<int, int>();
        for (var currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {
            var curr = nums[currentIndex];
            var diff = target - curr;
            if (ht.TryGetValue(diff, out var secondIndex))
            {
                return (currentIndex, secondIndex);
            }

            ht[curr] = currentIndex;
        }

        return (null, null);
    }
}