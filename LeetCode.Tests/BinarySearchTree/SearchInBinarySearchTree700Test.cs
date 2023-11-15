using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinaryTree;

public class SearchInBinarySearchTree700Test
{
    [Fact]
    public void ShouldFindValueInTheBinarySearchTree()
    {
        // Arrange
        var bst = new SearchInBinarySearchTree700();
        int expected = 2;
        int left = 1;
        int right = 3;

        var tree = new TreeNode(4, 
            new TreeNode(2, new TreeNode(1), new TreeNode(3)), 
            new TreeNode(7, null));

        // Act
        var result = bst.Search(tree, expected);

        // Assert
        Assert.Equal(expected, result.val);
        Assert.Equal(left, result.left!.val);
        Assert.Equal(right, result.right!.val);
    }

    [Fact]
    public void ShouldNotFindValueInTheBinarySearchTree()
    {
        // Arrange
        var bst = new SearchInBinarySearchTree700();
        int expected = 5;

        var tree = new TreeNode(4,
            new TreeNode(2, new TreeNode(1), new TreeNode(3)),
            new TreeNode(7, null));

        // Act
        var result = bst.Search(tree, expected);

        // Assert
        Assert.Null(result);
    }
}