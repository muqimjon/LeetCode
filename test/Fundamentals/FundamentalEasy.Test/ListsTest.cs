﻿namespace FundamentalEasy.Test;

public class ListsTest
{
    // Arrange
    private readonly Lists Solution = new();

    #region 9. Palindrome Number
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(12321, true)]
    [InlineData(12345, false)]
    public void IsPalindrome_ShouldReturnCorrectResult(int x, bool expected)
    {
        // Act
        var result = Solution.IsPalindrome(x);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 13. Roman to Integer
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("IX", 9)]
    [InlineData("IV", 4)]
    [InlineData("XLII", 42)]
    [InlineData("CDXLIV", 444)]
    [InlineData("XCIX", 99)]
    public void RomanToInt_ShouldReturnCorrectResult(string s, int expected)
    {
        // Act
        var result = Solution.RomanToInt(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
