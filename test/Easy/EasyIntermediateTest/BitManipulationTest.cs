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

    #region 2220. Minimum Bit Flips to Convert Number
    [Theory]
    [InlineData(10, 7, 3)]
    [InlineData(3, 4, 3)]
    public void TestMinimumBitFlipsToConvertNumber(int start, int goal, int expected)
    {
        // Act
        int result = Solution.MinBitFlips(start, goal);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 3226 Number of Bit Changes to Make Two Integers Equal
    [Theory]
    [InlineData(13, 4, 2)]
    [InlineData(21, 21, 0)]
    [InlineData(14, 13, -1)]
    public void TestNumberOfBitChanges(int n, int k, int expected)
    {
        // Act
        var result = Solution.MinChanges(n, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
