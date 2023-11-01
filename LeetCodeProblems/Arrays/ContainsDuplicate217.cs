namespace LeetCodeProblems.Arrays;

public class ContainsDuplicate217
{
    public static bool ContainsDuplicate2(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int item = nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (item == nums[j])
                    return true;
            }
        }

        return false;
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        var hashSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (hashSet.Contains(nums[i]))
                return true;

            hashSet.Add(nums[i]);
        }

        return false;
    }
}