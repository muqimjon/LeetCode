using EasyFundamental;

namespace EasyFundamentalTest;

public class TwoPointersTest
{
    // Arrange
    TwoPointers Solution = new();

    #region 2000. Reverse Prefix of Word
    [Theory]
    [InlineData("abcdefd", 'd', "dcbaefd")]
    [InlineData("xyxzxe", 'z', "zxyxxe")]
    [InlineData("abcd", 'z', "abcd")]
    public void TestReversePrefix(string word, char ch, string expected)
    {
        // Act
        string result = Solution.ReversePrefix(word, ch);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
