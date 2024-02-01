using EasyIntermediate;

namespace EasyIntermediateTest;

public class BinarySearchTest
{
    // Arrange
    private readonly BinarySearch Solution = new();

    #region 278. First Bad Version
    [Theory]
    [InlineData(5, 4, 4)] // Explanation in the prompt
    [InlineData(1, 1, 1)] // Only one version, and it's bad
    [InlineData(10, 6, 6)] // Bad version is in the middle
    [InlineData(7, 7, 7)] // Bad version is the last one
    [InlineData(8, 3, 3)] // Bad version is early in the sequence
    public void FirstBadVersion_ShouldReturnCorrectResult(int n, int bad, int expected)
    {
        // Arrange
        Solution.SetBadVersion(bad);

        // Act
        int result = Solution.FirstBadVersion(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
