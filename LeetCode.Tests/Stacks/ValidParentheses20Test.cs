using LeetCode.Stacks;

namespace LeetCode.Tests.Stacks;

public class ValidParentheses20Test
{
    [Fact]
    public void ShouldValidateParenthesis()
    {
        // Arrange
        string input = "()";

        // Act
        var valid = new ValidParentheses20();
        bool isValid = valid.IsValid(input);

        // Assert
        Assert.True(isValid);
    }

    [Fact]
    public void ShouldValidateMultipleItems()
    {
        // Arrange
        string input = "()[]{}";

        // Act
        var valid = new ValidParentheses20();
        bool isValid = valid.IsValid(input);

        // Assert
        Assert.True(isValid);
    }

    [Fact]
    public void ShouldNotValidateItems()
    {
        // Arrange
        string input = "(]";

        // Act
        var valid = new ValidParentheses20();
        bool isValid = valid.IsValid(input);

        // Assert
        Assert.False(isValid);
    }

    [Fact]
    public void ShouldValidateNestedItems()
    {
        // Arrange
        string input = "([{}])";

        // Act
        var valid = new ValidParentheses20();
        bool isValid = valid.IsValid(input);

        // Assert
        Assert.True(isValid);
    }
}