using LeetCodeProblems.Arrays;

namespace LeetCode.Tests.Arrays;

public class RemoveElement27Test
{
    [Fact]
    public void ShouldRemoveElementAndReturn3()
    {
        // Arrange
        int[] nums = new int[] { 3, 2, 2, 3 };
        int val = 3;

        int[] expectedNumbers = new int[] { 2, 2 };
        int expectedNumber = 2;

        var removeElement = new RemoveElement27();

        // Act
        int actualNumber = removeElement.RemoveElement(nums, val);

        // Assert
        Assert.Equal(expectedNumber, actualNumber);

        for (int i = 0; i < expectedNumbers.Length; i++)
        {
            Assert.Equal(expectedNumbers[i], nums[i]);
        }
    }

    [Fact]
    public void ShouldRemoveElementAndReturn2()
    {
        // Arrange
        int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;

        int[] expectedNumbers = new int[] { 0, 1, 3, 0, 4 };
        int expectedNumber = 5;

        var removeElement = new RemoveElement27();

        // Act
        int actualNumber = removeElement.RemoveElement(nums, val);

        // Assert
        Assert.Equal(expectedNumber, actualNumber);

        for (int i = 0; i < expectedNumbers.Length; i++)
        {
            Assert.Equal(expectedNumbers[i], nums[i]);
        }
    }
}