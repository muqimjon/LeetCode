using MediumFundamental;

namespace MediumFundamentalTest;

public class TwoPointersTest
{
    // Arrange
    private readonly TwoPointers Solution = new();

    #region 151 Reverse Words in a String
    [Theory]
    [InlineData("blue is sky the", "the sky is blue")]
    [InlineData("world hello", "  hello world  ")]
    [InlineData("example good a", "a good   example")]
    public void TestReverseWords(string expected, string input)
    {
        // Act
        var result = Solution.ReverseWords(input);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}