namespace LeetCode;

public partial class TopKFrequentElements
{
    public static int[] TopKFrequentOneLine(int[] nums, int k)
    {
        return nums.GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .Select(x => x.Key)
            .Take(k)
            .ToArray();
    }
    
    public static int[] TopDictWithPriorityQ(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (dict.TryGetValue(num, out var value))
            {
                dict[num] = value + 1;
            }
            else
            {
                dict[num] = 1;
            }
        }

        PriorityQueue<int, int> pq = new();
        foreach(var key in dict.Keys) {
            pq.Enqueue(key, dict[key]);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        var res = new int[k];
        var j = k;

        while (pq.Count > 0)
            res[--j] = pq.Dequeue();

        return res;
    }
    
    public static int[] TopDictWithPreinitizlizedLoccetions(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>(nums.Length);
        foreach (var num in nums)
        {
            if (dict.TryGetValue(num, out var value))
            {
                dict[num] = value + 1;
            }
            else
            {
                dict[num] = 1;
            }
        }

        PriorityQueue<int, int> pq = new(k+1);
        foreach(var key in dict.Keys) {
            pq.Enqueue(key, dict[key]);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        var res = new int[k];
        var j = k;

        while (pq.Count > 0)
            res[--j] = pq.Dequeue();

        return res;
    }
    
    public static int[] ArraySortWithPQ(int[] nums, int k)
    {
        if (nums.Length == 0) return new int[k];
        
        Array.Sort(nums);
        
        PriorityQueue<int, int> pq = new();
        var currNum = nums[0];
        var currSum = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (currNum == nums[i])
            {
                currSum++;
                if (i != nums.Length - 1)
                {
                    continue;
                }
            }
            
            pq.Enqueue(currNum, currSum);
            currNum = nums[i];
            currSum = 1;
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        
        var res = new int[k];
        var j = Math.Min(k, nums.Length);

        while (j > 0)
            res[--j] = pq.Dequeue();

        return res;
    }
    
    public static int[] ArraySortWithPQ_v2(int[] nums, int k)
    {
        Array.Sort(nums);
        
        PriorityQueue<int, int> pq = new();
        var currNum = nums[0];
        var currSum = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (currNum == nums[i])
            {
                currSum++;
                if (i != nums.Length - 1)
                {
                    continue;
                }
            }
            
            if (pq.Count > k)
            {
                pq.DequeueEnqueue(currNum, currSum);
            }
            else
            {
                pq.Enqueue(currNum, currSum);
            }
            
            currNum = nums[i];
            currSum = 1;
        }
        
        var res = new int[k];
        var j = k;

        while (j > 0)
            res[--j] = pq.Dequeue();

        return res;
    }
    
    public static int[] WithTree(int[] nums, int k)
    {
        var root = new TreeNode(nums[0]);

        foreach (var num in nums)
        {
            var node = root.Put(num);
        }

        return [];
    }

    public class TreeNode
    {
        public TreeNode(int value)
        {
            Value = value;
        }
        
        public TreeNode? L;
        public TreeNode? R;
        public int Count = 1;
        public int Value;

        public TreeNode? LessCountNode;
        public TreeNode? GreaterCountNode;
        
        public TreeNode Put(int num)
        {
            if (num == Value)
            {
                Count++;
                return this;
            }

            if (num < Value)
            {
                return L == null 
                    ? L = new TreeNode(num) 
                    : L.Put(num);
            }

            return R == null 
                ? R = new TreeNode(num) 
                : R.Put(num);
        }
    }
}
