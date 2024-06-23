using EasyIntermediate;

namespace EasyIntermediateTest;

public class TreesTest
{
    // Arrange
    private readonly Trees Solution = new();

    #region 1022. Sum of Root To Leaf Binary Numbers
    [Theory]
    [InlineData(new[] { 1, 0, 1, 0, 1, 0, 1 }, 22)]
    [InlineData(new[] { 0 }, 0)]
    public void SumRootToLeaf_ShouldReturnCorrectSum(int[] treeValues, int expectedSum)
    {
        // Arrange
        TreeNode root = Trees.BuildBinaryTree(treeValues);

        // Act
        var result = Solution.SumRootToLeaf(root);

        // Assert
        Assert.Equal(expectedSum, result);
    }
    #endregion

    #region 2236. Root Equals Sum of Children
    [Theory]
    [InlineData(10, 4, 6, true)]
    [InlineData(5, 3, 1, false)]
    public void TestIsRootSumEqualToChildren(int rootVal, int leftVal, int rightVal, bool expected)
    {
        // Arrange
        TreeNode root = new(rootVal,
                            new TreeNode(leftVal),
                            new TreeNode(rightVal));

        // Act
        bool result = Solution.CheckTree(root);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}