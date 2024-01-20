using Medium;

namespace MediumTest;

public class ArraysTest
{
    // Arrange
    private readonly Arrays Solution = new();

    #region 931. Minimum Falling Path Sum
    [Theory]
    [InlineData(13, new[] { 2, 1, 3 }, new[] { 6, 5, 4 }, new[] { 7, 8, 9 })]
    [InlineData(-59, new[] { -19, 57 }, new[] { -40, -5 })]
    public void MinFallingPathSum_ShouldReturnCorrectResult(int expected, params int[][] matrix)
    {
        // Act
        var result = Solution.MinFallingPathSum(matrix);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 3. Longest Substring Without Repeating Characters
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData(" ", 1)]
    [InlineData("aab", 2)]
    [InlineData("dvdf", 3)]
    public void LengthOfLongestSubstring_ShouldReturnCorrectResult(string s, int expected)
    {
        // Act
        var result = Solution.LengthOfLongestSubstring(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
