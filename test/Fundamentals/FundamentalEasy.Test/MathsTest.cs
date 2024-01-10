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
}
