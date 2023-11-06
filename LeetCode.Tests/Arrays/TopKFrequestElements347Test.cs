using LeetCode.Arrays;

namespace LeetCode.Tests.Arrays;

public class TopKFrequestElements347Test
{
    [Fact]
    public void ShouldReturn1and2AsMostFrequentNumbers()
    {
        // Arrange
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int numberOfElements = 2;

        // Act
        var topK = new TopKFrequestElements347();
        int[] result = topK.TopKFrequent(nums, numberOfElements);

        // Assert
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
    }

    [Fact]
    public void ShouldReturn1AsMostFrequentNumber()
    {
        // Arrange
        int[] nums = { 1 };
        int numberOfElements = 1;

        // Act
        var topK = new TopKFrequestElements347();
        int[] result = topK.TopKFrequent(nums, numberOfElements);

        // Assert
        Assert.Equal(1, result[0]);
    }
}