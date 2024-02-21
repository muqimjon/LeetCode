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

    #region 202. Happy Number
    [Theory]
    [InlineData(19, true)]
    [InlineData(2, false)]
    public void IsHappy_WithValidInput_ReturnsExpected(int n, bool expected)
    {
        // Act
        bool result = Solution.IsHappy(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2068. Check Whether Two Strings are Almost Equivalent
    [Theory]
    [InlineData("aaaa", "bccb", false)]
    [InlineData("abcdeef", "abaaacc", true)]
    [InlineData("cccddabba", "babababab", true)]
    public void TestCheckAlmostEquivalent(string word1, string word2, bool expected)
    {
        // Act
        bool result = Solution.CheckAlmostEquivalent(word1, word2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
