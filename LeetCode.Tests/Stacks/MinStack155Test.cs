using LeetCode.Stacks;

namespace LeetCode.Tests.Stacks;

public class MinStack155Test
{
    [Fact]
    public void ShouldPushAndPopFromStack()
    {
        // Arrange
        var stack = new MinStack155();

        // Act
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);
        stack.GetMin(); // return -3
        stack.Pop();
        int top = stack.Top();    // return 0
        int min = stack.GetMin(); // return -2

        // Assert
        Assert.Equal(-0, top);
        Assert.Equal(-2, min);
    }
}