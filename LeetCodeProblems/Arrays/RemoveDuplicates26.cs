namespace LeetCodeProblems.Arrays;

public class RemoveDuplicates26
{
    public int RemoveDuplicates(int[] nums)
    {
        int left = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[left] = nums[i];
                left++;
            }
        }

        return left;
    }
}