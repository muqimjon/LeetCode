using EasyIntermediate;

namespace EasyIntermediateTest;

public class BitManipulationTest
{
    // Arrange
    private readonly BitManipulation Solution = new();

    #region 461. Hamming Distance
    [Theory]
    [InlineData(1, 4, 2)]  // Example 1
    [InlineData(3, 1, 1)]  // Example 2
    [InlineData(0, 0, 0)]  // Zero distance
    [InlineData(255, 255, 0)]  // Same number
    [InlineData(0, 15, 4)]  // All bits are different
    public void HammingDistance_ShouldReturnExpectedValue(int x, int y, int expected)
    {
        // Act
        int actual = Solution.HammingDistance(x, y);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion
}
