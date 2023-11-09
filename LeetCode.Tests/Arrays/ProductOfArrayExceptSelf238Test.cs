using LeetCode.Arrays;

namespace LeetCode.Tests.Arrays;

public class ProductOfArrayExceptSelf238Test
{
    [Fact]
    public void ShouldReturnTheProductOfArrayNumbers()
    {
        // Arrange
        int[] nums = new int[] { 1, 2, 3, 4 };
        int[] expected = new int[] { 24, 12, 8, 6 };

        // Act
        var product = new ProductOfArrayExceptSelf238();
        var actual = product.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldReturnTheProductOfArrayWithNegativeNumbers()
    {
        // Arrange
        int[] nums = new int[] { -1, 1, 0, -3, 3 };
        int[] expected = new int[] { 0, 0, 9, 0, 0 };

        // Act
        var product = new ProductOfArrayExceptSelf238();
        var actual = product.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, actual);
    }
}
