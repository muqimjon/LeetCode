using MediumFundamental;

namespace MediumFundamentalTest;

public class StringsTest
{
    // Arrange
    private readonly Strings Solution = new();

    #region 22 Generate Parentheses
    [Theory]
    [InlineData(new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" }, 3)]
    [InlineData(new string[] { "()" }, 1)]
    public void TestGenerateParentheses(string[] expected, int n)
    {
        // Act
        var result = Solution.GenerateParenthesis(n);

        // Assert
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }
    #endregion
}