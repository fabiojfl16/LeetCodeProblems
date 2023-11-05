using LeetCode.Arrays;

namespace LeetCode.Tests.Arrays;

public class SortArray912Test
{
    [Fact]
    public void ShouldSortArray()
    {
        // Arrange
        int[] nums = new int[] { 5, 2, 3, 1 };
        int[] expected = new int[] { 1, 2, 3, 5 };

        SortArray912.SortArray(nums);
        Assert.Equal(expected, nums);
    }

    [Fact]
    public void ShouldSortArrayWithDuplicatedValues()
    {
        // Arrange
        int[] nums = new int[] { 5, 1, 1, 2, 0, 0 };
        int[] expected = new int[] { 0, 0, 1, 1, 2, 5 };

        SortArray912.SortArray(nums);
        Assert.Equal(expected, nums);
    }
}