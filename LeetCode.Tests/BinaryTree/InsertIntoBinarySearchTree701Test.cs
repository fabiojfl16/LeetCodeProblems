using LeetCode.BinaryTree;

namespace LeetCode.Tests.BinaryTree;

public class InsertIntoBinarySearchTree701Test
{
    [Fact]
    public void ShouldInsertValueInTheRightSideOfBinarySearchTree()
    {
        // Arrange
        int val = 5;

        var tree = new TreeNode(4,
            new TreeNode(2,
                new TreeNode(1), new TreeNode(3)),
            new TreeNode(7));

        // Act
        var insert = new InsertIntoBinarySearchTree701();
        var result = insert.InsertIntoBST(tree, val);

        // Assert
        Assert.Equal(val, result.right!.left!.val);
    }

    [Fact]
    public void ShouldInsertValueInTheLeftSideOfBinarySearchTree()
    {
        // Arrange
        int val = 2;

        var tree = new TreeNode(5,
            new TreeNode(4,
                null, new TreeNode(3)),
            new TreeNode(7));

        // Act
        var insert = new InsertIntoBinarySearchTree701();
        var result = insert.InsertIntoBST(tree, val);

        // Assert
        Assert.Equal(val, result.left!.left!.val);
    }
}