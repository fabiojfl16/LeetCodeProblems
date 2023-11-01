using LeetCodeProblems.Arrays;

namespace LeetCode.Tests.Arrays;

public class TwoSum1Test
{
    [Fact]
    public void TwoSumReturns9()
    {
        // Arrange
        int target = 9;
        int[] nums = new int[] { 2, 7, 11, 15 };
        int[] expected = new int[] { 0, 1 };

        var result = TwoSum1.TwoSum(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSumReturns6()
    {
        // Arrange
        int target = 6;
        int[] nums = new int[] { 3, 2, 4 };
        int[] expected = new int[] { 1, 2 };

        var result = TwoSum1.TwoSum(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSumReturns6NotNestedItems()
    {
        // Arrange
        int target = 6;
        int[] nums = new int[] { 3, 2, 3 };
        int[] expected = new int[] { 0, 2 };

        var result = TwoSum1.TwoSum(nums, target);
        Assert.Equal(expected, result);
    }
}