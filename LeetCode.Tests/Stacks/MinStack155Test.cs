using LeetCode.Stacks;

namespace LeetCode.Tests.Stacks;

public class MinStack155Test
{
    [Fact]
    public void ShouldPushAndPopFromStack()
    {
        // Arrange
        var stack = new MinStack155();

        // Act, Assert
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);
        
        int min = stack.GetMin();
        Assert.Equal(-3, min);

        stack.Pop();

        int top = stack.Top();
        Assert.Equal(-0, top);

        min = stack.GetMin();
        Assert.Equal(-2, min);
    }

    [Fact]
    public void ShouldPushAndPopFromStackAndGetMinValue()
    {
        // Arrange
        var stack = new MinStack155();

        // Act, Assert
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-1);

        int min = stack.GetMin();
        Assert.Equal(-2, min);

        int top = stack.Top();
        Assert.Equal(-1, top);

        stack.Pop();

        min = stack.GetMin();
        Assert.Equal(-2, min);
    }
}