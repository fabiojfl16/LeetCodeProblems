namespace LeetCodeProblems.Arrays;

public class TwoSum1
{
    // Big O (n2)
    public int[] TwoSum2(int[] nums, int target)
    {
        List<int> result = new();

        for (int i = 0; i < nums.Length; i++)
        {
            result = new();

            for (int j = i + 1; j < nums.Length; j++)
            {
                int value = nums[i] + nums[j];

                if (value == target)
                {
                    result.Add(i);
                    result.Add(j);
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }

    // Big O (n)
    public int[] TwoSum(int[] nums, int target)
    {
        var valueIndexMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (valueIndexMap.ContainsKey(diff))
                return new int[] { valueIndexMap[diff], i };
            else
                valueIndexMap.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }
}