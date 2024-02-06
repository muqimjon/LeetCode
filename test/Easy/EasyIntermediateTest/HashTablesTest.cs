using EasyIntermediate;

namespace EasyIntermediateTest;

public class HashTablesTest
{
    // Arrange
    private readonly HashTables Solution = new();

    #region 1189. Maximum Number of Balloons
    [Theory]
    [InlineData("nlaebolko", 1)]
    [InlineData("loonbalxballpoon", 2)]
    [InlineData("leetcode", 0)]
    public void MaxNumberOfBalloons_ShouldReturnCorrectResult(string text, int expected)
    {
        // Act
        var result = Solution.MaxNumberOfBalloons(text);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

}
