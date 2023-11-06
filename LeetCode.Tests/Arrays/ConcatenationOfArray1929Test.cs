using LeetCodeProblems.Arrays;

namespace LeetCode.Tests.Arrays;

public class ConcatenationOfArray1929Test
{
    [Fact]
    public void ShouldConcatenateArrays()
    {
        // Arrange
        int[] nums = { 1, 2, 1 };
        int[] expected = { 1, 2, 1, 1, 2, 1 };

        // Act
        var contact = new ConcatenationOfArray1929();
        int[] actual = contact.GetConcatenation(nums);

        // Assert
        Assert.Equal(expected, actual);
    }
}