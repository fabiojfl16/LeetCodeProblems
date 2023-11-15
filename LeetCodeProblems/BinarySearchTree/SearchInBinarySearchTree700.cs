namespace LeetCode.BinaryTree;

public class SearchInBinarySearchTree700
{
    public TreeNode Search(TreeNode? root, int val)
    {
        if (root == null || root.val == val)
            return root;

        if (root.val > val)
            return Search(root.left, val);
        else
            return Search(root.right, val);
    }
}