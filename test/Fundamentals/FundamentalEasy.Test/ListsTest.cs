namespace FundamentalEasy.Test;

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
}
