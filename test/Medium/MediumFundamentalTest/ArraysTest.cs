using MediumFundamental;

namespace MediumFundamentalTest;

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

    #region 198. Uy qaroqchisi
    [Theory]
    [InlineData(4, new[] { 1, 2, 3, 1 })]
    [InlineData(12, new[] { 2, 7, 9, 3, 1 })]
    [InlineData(0, new int[] { })]
    [InlineData(9, new[] { 9 })]
    [InlineData(4, new[] { 2, 1, 1, 2 })]
    public void Robbery_MaxAmountWithoutAlertingPolice(int expected, int[] nums)
    {
        // Act
        var result = Solution.Rob(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1239. Maximum Length of a Concatenated String with Unique Characters
    [Theory]
    [InlineData(4, new[] { "un", "iq", "ue" })]
    [InlineData(6, new[] { "cha", "r", "act", "ers" })]
    [InlineData(26, new[] { "abcdefghijklmnopqrstuvwxyz" })]
    [InlineData(0, new string[] { })]
    [InlineData(9, new[] { "abc", "def", "ghi" })]
    public void MaxLength_ShouldReturnCorrectResult(int expected, string[] arr)
    {
        // Arrange & Act
        var result = Solution.MaxLength(arr);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
