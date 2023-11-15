namespace LeetCode.BinaryTree;

public class DeleteNodeInBinarySearchTree401
{
    public TreeNode? DeleteNode(TreeNode? root, int val)
    {
        if (root == null)
            return null;

        if(val > root.val)
            root.right = DeleteNode(root.right, val);
        else if(val < root.val)
            root.left = DeleteNode(root.left, val);
        else
        {
            if (root.left == null)
                return root.right;
            else if (root.right == null)
                return root.left;
            else
            {
                TreeNode minNode = GetMinValueNode(root.right);
                root.val = minNode.val;
                root.right = DeleteNode(root.right, minNode.val);
            }
        }

        return root;
    }

    private TreeNode GetMinValueNode(TreeNode root)
    {
        var current = root;

        while (current.left != null)
            current = current.left;

        return current;
    }
}