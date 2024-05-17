﻿using EasyFundamental;

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

    #region 2379. Minimum Recolors to Get K Consecutive Black Blocks
    [Theory]
    [InlineData("WBBWWBBWBW", 7, 3)]
    [InlineData("WBWBBBW", 2, 0)]
    [InlineData("BBBBBBBB", 3, 0)]
    [InlineData("", 1, 0)]
    public void MinimumRecolors_ShouldReturnCorrectResult(string blocks, int k, int expected)
    {
        // Act
        var result = Solution.MinimumRecolors(blocks, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1446. Consecutive Characters
    [Theory]
    [InlineData("leetcode", 2)]
    [InlineData("abbcccddddeeeeedcba", 5)]
    [InlineData("a", 1)]
    [InlineData("ab", 1)]
    [InlineData("aa", 2)]
    [InlineData("abcde", 1)]
    [InlineData("aaaaaaa", 7)]
    [InlineData("abcdabcdabcdabcd", 1)]
    public void MaxPower_ShouldReturnExpected(string s, int expected)
    {
        // Act
        int result = Solution.MaxPower(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 520. Detect Capital
    [Theory]
    [InlineData("USA", true)]
    [InlineData("leetcode", true)]
    [InlineData("Google", true)]
    [InlineData("FlaG", false)]
    [InlineData("LeetCode", false)]
    [InlineData("APPLE", true)]
    public void DetectCapitalUse_WithVariousInputs_ReturnsExpectedResult(string word, bool expected)
    {
        // Act
        bool result = Solution.DetectCapitalUse(word);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1108. Defanging an IP Address
    [Theory]
    [InlineData("1.1.1.1", "1[.]1[.]1[.]1")]
    [InlineData("255.100.50.0", "255[.]100[.]50[.]0")]
    [InlineData("192.168.0.1", "192[.]168[.]0[.]1")]
    [InlineData("10.0.0.1", "10[.]0[.]0[.]1")]
    public void DefangIPaddr_ValidInput_ReturnsDefangedIP(string input, string expected)
    {
        // Act
        var result = Solution.DefangIPaddr(input);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 151. 796. Rotate String
    [Theory]
    [InlineData("abcde", "cdeab", true)]
    [InlineData("abcde", "abced", false)]
    [InlineData("", "", true)]
    [InlineData("a", "a", true)]
    [InlineData("ab", "ba", true)]
    [InlineData("ab", "ab", true)]
    [InlineData("abcde", "deabc", true)]
    [InlineData("abcde", "eabcd", true)]
    public void RotateString_TestCases(string s, string goal, bool expected)
    {
        // Act
        bool result = Solution.RotateString(s, goal);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2124. Check if All A's Appears Before All B's
    [Theory]
    [InlineData("aaabbb", true)]
    [InlineData("abab", false)]
    [InlineData("bbb", true)]
    public void TestCheckAllAsBeforeBs(string s, bool expected)
    {
        // Act
        bool result = Solution.CheckString(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1507. Reformat Date
    [Theory]
    [InlineData("20th Oct 2052", "2052-10-20")]
    [InlineData("6th Jun 1933", "1933-06-06")]
    [InlineData("26th May 1960", "1960-05-26")]
    public void TestReformatDate(string input, string expected)
    {
        // Act
        string result = Solution.ReformatDate(input);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1614. Maximum Nesting Depth of the Parentheses
    [Theory]
    [InlineData("(1+(2*3)+((8)/4))+1", 3)]
    [InlineData("(1)+((2))+(((3)))", 3)]
    [InlineData("", 0)]
    [InlineData("()", 1)]
    [InlineData("((()))", 3)]
    public void MaxDepth_ShouldReturnCorrectDepth(string s, int expected)
    {
        // Act
        int actual = Solution.MaxDepth(s);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 1221. Split a String in Balanced Strings
    [Theory]
    [InlineData("RLRRLLRLRL", 4)]
    [InlineData("LLLLRRRR", 1)]
    public void TestBalancedStringSplit(string input, int expected)
    {
        // Act
        var result = Solution.BalancedStringSplit(input);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 3019. Number of Changing Keys
    [Theory]
    [InlineData("aAbBcC", 2)]
    [InlineData("AaAaAaaA", 0)]
    public void CountKeyChanges_ValidInput_ReturnsExpectedCount(string input, int expected)
    {
        // Act
        int actual = Solution.CountKeyChanges(input);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 2315. Count Asterisks
    [Theory]
    [InlineData("l|*e*et|c**o|*de|", 2)]
    [InlineData("iamprogrammer", 0)]
    [InlineData("yo|uar|e**|b|e***au|tifu|l", 5)]
    public void TestCountAsterisks(string s, int expected)
    {
        // Act
        int result = Solution.CountAsterisks(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 482. License Key Formatting
    [Theory]
    [InlineData("5F3Z-2e-9-w", 4, "5F3Z-2E9W")]
    [InlineData("2-5g-3-J", 2, "2-5G-3J")]
    public void TestLicenseKeyFormatting(string s, int k, string expected)
    {
        // Act
        string result = Solution.LicenseKeyFormatting(s, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1967. Number of Strings That Appear as Substrings in Word
    [Theory]
    [InlineData(new string[] { "a", "abc", "bc", "d" }, "abc", 3)]
    [InlineData(new string[] { "a", "b", "c" }, "aaaaabbbbb", 2)]
    [InlineData(new string[] { "a", "a", "a" }, "ab", 3)]
    public void TestNumberOfSubstrings(string[] patterns, string word, int expected)
    {
        // Act
        int result = Solution.NumOfStrings(patterns, word);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1422. Maximum Score After Splitting a String
    [Theory]
    [InlineData("011101", 5)]
    [InlineData("00111", 5)]
    [InlineData("1111", 3)]
    public void TestMaxScore(string s, int expected)
    {
        // Act
        int result = Solution.MaxScore(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
