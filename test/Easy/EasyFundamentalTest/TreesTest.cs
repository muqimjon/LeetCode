using EasyFundamental;

namespace EasyFundamentalTest;

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
}