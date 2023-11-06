using LeetCodeProblems.Arrays;

namespace LeetCode.Tests.Arrays;

public class RemoveDuplicates26Test
{
    [Fact]
    public void ShouldRemovedDuplicatedValuesAndReturn2UniqueElements()
    {
        // Arrange
        int[] nums = new int[] { 1, 1, 2 };
        int[] expectedList = new int[] { 1, 2 };
        int expectedNumberUniqueElements = 2;
        
        var removeDuplicates = new RemoveDuplicates26();

        // Act
        var numberUniqueElements = removeDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expectedNumberUniqueElements, numberUniqueElements);

        for (int i = 0; i < expectedList.Length; i++)
        {
            Assert.Equal(expectedList[i], nums[i]);
        }
    }

    [Fact]
    public void ShouldRemovedDuplicatedValuesAndReturn5UniqueElements()
    {
        // Arrange
        int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int[] expectedList = new int[] { 0, 1, 2, 3, 4 };
        int expectedNumberUniqueElements = 5;

        var removeDuplicates = new RemoveDuplicates26();

        // Act
        var numberUniqueElements = removeDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expectedNumberUniqueElements, numberUniqueElements);

        for (int i = 0; i < expectedList.Length; i++)
        {
            Assert.Equal(expectedList[i], nums[i]);
        }
    }

    [Fact]
    public void ShouldRemovedDuplicatedValuesAndReturn4UniqueElements()
    {
        // Arrange
        int[] nums = new int[] { 0, 1, 1, 2, 2, 3 };
        int[] expectedList = new int[] { 0, 1, 2, 3 };
        int expectedNumberUniqueElements = 4;

        var removeDuplicates = new RemoveDuplicates26();

        // Act
        var numberUniqueElements = removeDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expectedNumberUniqueElements, numberUniqueElements);

        for (int i = 0; i < expectedList.Length; i++)
        {
            Assert.Equal(expectedList[i], nums[i]);
        }
    }
}
