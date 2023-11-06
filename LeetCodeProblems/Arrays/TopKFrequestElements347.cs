namespace LeetCode.Arrays;

public class TopKFrequestElements347
{
    public int[] TopKFrequent(int[] nums, int numberOfElements)
    {
        var numbersMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!numbersMap.ContainsKey(nums[i]))
            {
                numbersMap.Add(nums[i], 0);
            }

            numbersMap[nums[i]]++;
        }

        return numbersMap
                .OrderByDescending(number => number.Value)
                .Select(pair => pair.Key)
                .Take(numberOfElements)
                .ToArray();
    }
}