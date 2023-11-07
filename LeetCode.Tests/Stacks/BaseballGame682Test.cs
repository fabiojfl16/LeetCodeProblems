using LeetCode.Stacks;

namespace LeetCode.Tests.Stacks;

public class BaseballGame682Test
{
    [Fact]
    public void ShouldComputeResultsAndReturn30()
    {
        // Arrange
        string[] ops = new string[] { "5", "2", "C", "D", "+" };
        int expected = 30;

        // Act
        var game = new BaseballGame682();
        int actual = game.CalPoints(ops);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldComputeResultsAndReturn27()
    {
        // Arrange
        string[] ops = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
        int expected = 27;

        // Act
        var game = new BaseballGame682();
        int actual = game.CalPoints(ops);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldComputeResultsAndReturn0()
    {
        // Arrange
        string[] ops = new string[] { "1", "C" };
        int expected = 0;

        // Act
        var game = new BaseballGame682();
        int actual = game.CalPoints(ops);

        // Assert
        Assert.Equal(expected, actual);
    }
}