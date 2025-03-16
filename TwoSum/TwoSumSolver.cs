namespace TwoSum;

public class TwoSumSolver
{
    public static (int? a, int? b) Solve(int[] nums, int target)
    {
        var ht = new Dictionary<int, int>();
        for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {
            var curr = nums[currentIndex];
            var diff = target - curr;
            if (ht.TryGetValue(diff, out var secondIndex))
            {
                return (currentIndex, secondIndex);
            }

            ht[diff] = currentIndex;
        }

        return (null, null);
    }
}