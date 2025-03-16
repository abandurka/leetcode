namespace TwoSum;

public class MergeSortedArray
{
    public static IEnumerable<int> MergeWithList(int[] num, int[] mum)
    {
        var currN = 0;
        var currM = 0;

        var r = new List<int>();
        for (int i = 0; i < num.Length + mum.Length; i++)
        {
            if (currN >= num.Length)
            {
                r.Add(mum[currM++]);
                continue;
            }

            if (currM >= mum.Length)
            {
                r.Add(num[currN++]);
                continue;
            }

            r.Add(num[currN] > mum[currM] 
                ? mum[currM++] 
                : num[currN++]
            );
        }

        return r;
    }
    
    public static IEnumerable<int> MergeWithYield(int[] num, int[] mum)
    {
        var currN = 0;
        var currM = 0;

        for (int i = 0; i < num.Length + mum.Length; i++)
        {
            if (currN >= num.Length)
            {
                yield return mum[currM++];
                continue;
            }

            if (currM >= mum.Length)
            {
                yield return num[currN++];
                continue;
            }

            yield return num[currN] > mum[currM]
                ? mum[currM++]
                : num[currN++];
        }
    }
}