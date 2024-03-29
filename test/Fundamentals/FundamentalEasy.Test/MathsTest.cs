﻿using Fundamental;

namespace FundamentalEasy.Test;

public class MathsTest
{
    // Arrange
    private readonly Maths Solution = new();

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

    #region 70. Climbing Stairs
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    [InlineData(6, 13)]
    [InlineData(43, 701408733)]
    [InlineData(45, 1836311903)]
    public void ClimbStairs_ShouldReturnCorrectResult(int n, int expected)
    {
        // Act
        int result = Solution.ClimbStairs(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 168. Excel Sheet Column Title
    [Theory]
    [InlineData(1, "A")]
    [InlineData(28, "AB")]
    [InlineData(701, "ZY")]
    public void ConvertToTitle_ShouldReturnCorrectResult(int columnNumber, string expected)
    {
        // Act
        var result = Solution.ConvertToTitle(columnNumber);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 190. Reverse Bits
    [Theory]
    [InlineData(0b00000010100101000001111010011100U, 964176192U)]
    [InlineData(0b11111111111111111111111111111101U, 3221225471U)]
    public void ReverseBits_ShouldReturnCorrectResult(uint n, uint expected)
    {
        // Act
        uint result = Solution.ReverseBits(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
