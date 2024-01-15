namespace FundamentalEasy.Test;

public class StringsTest
{
    // Arrange
    private readonly Strings Solution = new();

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

    #region 14. Longest Common Prefix
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    [InlineData(new[] { "apple", "apricot", "apology" }, "ap")]
    [InlineData(new[] { "hello", "hell", "helicopter" }, "hel")]
    [InlineData(new[] { "test" }, "test")]
    [InlineData(new[] { "a" }, "a")] // Failed
    [InlineData(new[] { "ab", "a" }, "a")] // Failed
    public void LongestCommonPrefix_ShouldReturnCorrectResult(string[] strs, string expected)
    {
        // Act
        var result = Solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 28. Find the Index of the First Occurrence in a String Tests
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("hello", "ll", 2)]
    [InlineData("abc", "", 0)]
    [InlineData("abc", "d", -1)]
    [InlineData("mississippi", "issip", 4)]
    public void StrStr_ShouldReturnCorrectIndex(string haystack, string needle, int expectedIndex)
    {
        // Act
        int resultIndex = Solution.StrStr(haystack, needle);

        // Assert
        Assert.Equal(expectedIndex, resultIndex);
    }

    [Theory]
    [InlineData("anything", "", 0)]
    [InlineData("apple", "le", 3)]
    [InlineData("hello", "z", -1)]
    [InlineData("abc", "abc", 0)]
    [InlineData("abc", "d", -1)]
    [InlineData("mississippi", "issip", 4)]
    public void StrStr2_ShouldReturnCorrectIndex(string haystack, string needle, int expectedIndex)
    {
        // Act
        int resultIndex = Solution.StrStr2(haystack, needle);

        // Assert
        Assert.Equal(expectedIndex, resultIndex);
    }
    #endregion

    #region 709. To Lower Case Tests
    [Theory]
    [InlineData("Hello", "hello")]
    [InlineData("here", "here")]
    [InlineData("LOVELY", "lovely")]
    [InlineData("12345", "12345")]
    [InlineData("", "")]
    [InlineData("aBCdEf", "abcdef")]
    [InlineData("PrintableASCII", "printableascii")]
    public void ToLowerCase_ShouldReturnCorrectResult(string s, string expected)
    {
        // Act
        string result = Solution.ToLowerCase(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 58. Length of Last Word
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    [InlineData("a", 1)]
    public void LengthOfLastWord_ShouldReturnCorrectLength(string s, int expectedLength)
    {
        // Act
        int resultLength = Solution.LengthOfLastWord(s);

        // Assert
        Assert.Equal(expectedLength, resultLength);
    }
    #endregion

    #region 1768. Merge Strings Alternately
    [Theory]
    [InlineData("abc", "", "abc")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("ab", "pqrsdsds", "apbqrsdsds")]
    [InlineData("abcd", "pq", "apbqcd")]
    [InlineData("abcdddd", "pq", "apbqcdddd")]
    public void MergeAlternately_ShouldReturnCorrectResult(string word1, string word2, string expected)
    {
        // Act
        string result = Solution.MergeAlternately(word1, word2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
