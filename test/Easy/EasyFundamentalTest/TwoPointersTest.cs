using EasyFundamental;

namespace EasyFundamentalTest;

public class TwoPointersTest
{
    // Arrange
    readonly TwoPointers Solution = new();

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

    #region 344. Reverse String
    [Theory]
    [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    [InlineData(new char[] { 'A', 'B', 'C', 'D' }, new char[] { 'D', 'C', 'B', 'A' })]
    [InlineData(new char[] { '1', '2', '3', '4', '5' }, new char[] { '5', '4', '3', '2', '1' })]
    public void ReverseString_ShouldReverseStringInPlace(char[] input, char[] expected)
    {
        // Arrange
        Solution.ReverseString(input);

        // Assert
        Assert.Equal(expected, input);
    }
    #endregion
}
