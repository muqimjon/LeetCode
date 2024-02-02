using EasyFundamental;

namespace EasyFundamentalTest;

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

    #region 125. Valid Palindrome
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    public void IsPalindrome_ShouldReturnCorrectResult(string input, bool expected)
    {
        // Act
        bool result = Solution.IsPalindrome(input);

        Console.WriteLine(result);
        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1470. Shuffle the Array
    [Theory]
    [InlineData(new[] { 2, 3, 5, 4, 1, 7 }, new[] { 2, 5, 1, 3, 4, 7 }, 3)]
    [InlineData(new[] { 1, 4, 2, 3, 3, 2, 4, 1 }, new[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4)]
    [InlineData(new[] { 1, 2, 1, 2 }, new[] { 1, 1, 2, 2 }, 2)]
    public void ShuffleArray_ShouldReturnCorrectResult(int[] expected, int[] nums, int n)
    {
        // Arrange & Act
        var result = Solution.Shuffle(nums, n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion  
}
