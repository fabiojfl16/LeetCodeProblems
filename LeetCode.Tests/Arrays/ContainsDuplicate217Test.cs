using LeetCodeProblems.Arrays;

namespace LeetCode.Tests.Arrays;

public class ContainsDuplicate217Test
{
    [Fact]
    public void ContainsDuplicateNumber1()
    {
        // Arrange
        int[] nums = new int[] { 1, 2, 3, 1 };

        var result = ContainsDuplicate217.ContainsDuplicate(nums);
        Assert.True(result);
    }

    [Fact]
    public void ContainsDuplicateReturnsFalse()
    {
        // Arrange
        int[] nums = new int[] { 1, 2, 3, 4 };

        var result = ContainsDuplicate217.ContainsDuplicate(nums);
        Assert.False(result);
    }
}