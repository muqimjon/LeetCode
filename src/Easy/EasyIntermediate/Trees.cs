using System.Xml.Linq;

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

        currentSum = (currentSum << 1) | node.val ?? 0;

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

    #region 100. Same Tree
    /// <summary>
    /// Checks if two binary trees are structurally identical with the same node values.
    /// </summary>
    /// <param name="p">Root of the first tree.</param>
    /// <param name="q">Root of the second tree.</param>
    /// <returns>True if the trees are the same, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/same-tree/</link>
    /// <time>O(n)</time>
    /// <space>O(h)</space>
    public bool IsSameTree(TreeNode p, TreeNode q)
        => p == null && q == null ? true :
            p == null || q == null || p.val != q.val ? false :
            IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    #endregion

    #region 559. Maximum Depth of N-ary Tree
    /// <summary>
    /// Returns the maximum depth of the n-ary tree.
    /// </summary>
    /// <param name="root">The root node of the n-ary tree.</param>
    /// <returns>The maximum depth of the n-ary tree.</returns>
    /// <link>https://leetcode.com/problems/maximum-depth-of-n-ary-tree/</link>
    /// <time>O(n)</time>
    /// <space>O(h)</space>
    public int MaxDepth(Node root)
        => root == null ? 0 : 1 + root.children.Select(MaxDepth).DefaultIfEmpty(0).Max();
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

            if (i + 1 < values.Length)
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
public class TreeNode(int? val = 0, TreeNode left = null!, TreeNode right = null!)
{
    public int? val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}
#endregion

#region Node >>
public class Node
{
    public int val;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}
#endregion