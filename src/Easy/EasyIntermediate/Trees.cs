namespace EasyIntermediate;

public class Trees
{
    #region 1022. Sum of Root To Leaf Binary Numbers
    /// <summary>
    /// Represents a binary tree where nodes have values 0 or 1, and each root-to-leaf path forms a binary number.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>The sum of binary numbers represented by root-to-leaf paths.</returns>
    /// <link>https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/</link>
    /// <time>Time complexity: O(N)</time>
    /// <space>Space complexity: O(log(N))</space>
    public int SumRootToLeaf(TreeNode root)
        => SumLeaf(root, 0);

    private static int SumLeaf(TreeNode? node, int currentSum)
    {
        if (node == null)
            return 0;

        currentSum = (currentSum << 1) | node.val;

        if (node.left == null && node.right == null)
            return currentSum;

        return SumLeaf(node.left, currentSum) + SumLeaf(node.right, currentSum);
    }
    #endregion

    #region 2236. Root Equals Sum of Children
    /// <summary>
    /// Determines if the value of the root node is equal to the sum of the values of its two children.
    /// </summary>
    /// <param name="root">The root of the binary tree.</param>
    /// <returns>True if the root's value equals the sum of its children's values, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/root-equals-sum-of-children/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public bool CheckTree(TreeNode root)
        => root.val == root.left.val + root.right.val;
    #endregion

    #region Build TreeNode >>
    public static TreeNode BuildBinaryTree(int[] values)
    {
        if (values.Length == 0) return null!;

        Queue<TreeNode> nodes = new();
        TreeNode root = new(values[0]);
        nodes.Enqueue(root);

        for (int i = 1; i < values.Length; i += 2)
        {
            TreeNode current = nodes.Dequeue();
            current.left = new TreeNode(values[i]);
            nodes.Enqueue(current.left);

            if (i + 1 < values.Length && values[i + 1] != null)
            {
                current.right = new TreeNode(values[i + 1]);
                nodes.Enqueue(current.right);
            }
        }

        return root;
    }
    #endregion
}

#region TreeNode Model >>
public class TreeNode(int val = 0, TreeNode left = null!, TreeNode right = null!)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}
#endregion