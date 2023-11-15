using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinarySearchTree;

public class DeleteNodeInBinarySearchTree401Test
{
    [Fact]
    public void ShouldDeleteValueInTheLeftSideOfBinarySearchTree()
    {
        // Arrange
        int val = 3;
        int expectedValue = 2;

        var tree = 
            new TreeNode(5,
                new TreeNode(3,
                    new TreeNode(2), new TreeNode(4)),
                new TreeNode(6, 
                    null, new TreeNode(7))
            );

        // Act
        var delete = new DeleteNodeInBinarySearchTree401();
        var result = delete.DeleteNode(tree, val);

        // Assert
        Assert.Equal(expectedValue, result!.left!.val);
    }

    [Fact]
    public void ShouldDeleteValueInTheRightSideOfBinarySearchTree()
    {
        // Arrange
        int val = 3;
        int expectedValue = 2;

        var tree =
            new TreeNode(5,
                new TreeNode(3,
                    new TreeNode(2), new TreeNode(4)),
                new TreeNode(6,
                    null, new TreeNode(7))
            );

        // Act
        var delete = new DeleteNodeInBinarySearchTree401();
        var result = delete.DeleteNode(tree, val);

        // Assert
        Assert.Equal(expectedValue, result!.left!.val);
    }

    [Fact]
    public void ShouldDeleteTheRootValueOfBinarySearchTree()
    {
        // Arrange
        int val = 5;
        int expectedValue = 6;

        var tree =
            new TreeNode(5,
                new TreeNode(3,
                    new TreeNode(2), new TreeNode(4)),
                new TreeNode(6,
                    null, new TreeNode(7))
            );

        // Act
        var delete = new DeleteNodeInBinarySearchTree401();
        var result = delete.DeleteNode(tree, val);

        // Assert
        Assert.Equal(expectedValue, result!.val);
    }
}