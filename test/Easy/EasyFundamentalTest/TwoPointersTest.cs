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

    #region 541. Reverse String II
    [Theory]
    [InlineData("abcdefg", 2, "bacdfeg")]
    [InlineData("abcd", 2, "bacd")]
    [InlineData("abcdefgh", 3, "cbadefhg")]
    [InlineData("abcde", 3, "cbade")]
    public void TestReverseStr(string s, int k, string expected)
    {
        // Act
        string result = Solution.ReverseStr(s, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 345. Reverse Vowels of a String
    [Theory]
    [InlineData("hello", "holle")]
    [InlineData("leetcode", "leotcede")]
    public void TestReverseVowels(string input, string expected)
    {
        // Act
        string result = Solution.ReverseVowels(input);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 925 Long Pressed Name
    [Theory]
    [InlineData("alex", "aaleex", true)]
    [InlineData("saeed", "ssaaedd", false)]
    public void TestLongPressedName(string name, string typed, bool expected)
    {
        // Act
        var result = Solution.IsLongPressedName(name, typed);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1332 Remove Palindromic Subsequences
    [Theory]
    [InlineData("ababa", 1)]
    [InlineData("abb", 2)]
    [InlineData("baabb", 2)]
    public void TestRemovePalindromeSub(string s, int expected)
    {
        // Act
        var result = Solution.RemovePalindromeSub(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
