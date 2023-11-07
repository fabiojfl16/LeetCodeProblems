namespace LeetCode.Arrays;

public class SortArray912InsertionSort
{
    /// <summary>
    /// Insertion Sort Algorithm: O(n2)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortArray(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            int j = i;

            while (j > 0 && nums[j] < nums[j - 1])
            {
                int temp = nums[j];
                nums[j] = nums[j - 1];
                nums[j - 1] = temp;
                j--;
            }
        }

        return nums;
    }
}