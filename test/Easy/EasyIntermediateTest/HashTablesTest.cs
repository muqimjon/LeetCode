using EasyIntermediate;

namespace EasyIntermediateTest;

public class HashTablesTest
{
    // Arrange
    private readonly HashTables Solution = new();

    #region 1189. Maximum Number of Balloons
    [Theory]
    [InlineData("nlaebolko", 1)]
    [InlineData("loonbalxballpoon", 2)]
    [InlineData("leetcode", 0)]
    public void MaxNumberOfBalloons_ShouldReturnCorrectResult(string text, int expected)
    {
        // Act
        var result = Solution.MaxNumberOfBalloons(text);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 202. Happy Number
    [Theory]
    [InlineData(19, true)]
    [InlineData(2, false)]
    public void IsHappy_WithValidInput_ReturnsExpected(int n, bool expected)
    {
        // Act
        bool result = Solution.IsHappy(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2068. Check Whether Two Strings are Almost Equivalent
    [Theory]
    [InlineData("aaaa", "bccb", false)]
    [InlineData("abcdeef", "abaaacc", true)]
    [InlineData("cccddabba", "babababab", true)]
    public void TestCheckAlmostEquivalent(string word1, string word2, bool expected)
    {
        // Act
        bool result = Solution.CheckAlmostEquivalent(word1, word2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 383. Ransom Note
    [Theory]
    [InlineData("aa", "aab", true)]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    public void CanConstruct_ValidInput_ReturnsExpectedResult(string ransomNote, string magazine, bool expectedResult)
    {
        // Act
        bool result = Solution.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.Equal(expectedResult, result);
    }
    #endregion

    #region 771. Jewels and Stones
    [Theory]
    [InlineData("aA", "aAAbbbb", 3)]
    [InlineData("z", "ZZ", 0)]
    [InlineData("abc", "abcabcabc", 9)]
    [InlineData("XYZ", "XYZXYZ", 6)]
    public void NumJewelsInStones_TestCases(string jewels, string stones, int expected)
    {
        // Act
        int result = Solution.NumJewelsInStones(jewels, stones);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1876. Substrings of Size Three with Distinct Characters
    [Theory]
    [InlineData("xyzzaz", 1)]
    [InlineData("aababcabc", 4)]
    [InlineData("abababab", 0)]
    [InlineData("x", 0)] // FAIL
    public void TestCountGoodSubstrings(string s, int expected)
    {
        // Act
        int result = Solution.CountGoodSubstrings(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 409. Longest Palindrome
    [Theory]
    [InlineData("abccccdd", 7)]
    [InlineData("a", 1)]
    [InlineData("abcde", 1)]
    [InlineData("aab", 3)]
    [InlineData("aabbc", 5)]
    public void TestLongestPalindrome(string input, int expectedLength)
    {
        // Act
        int actualLength = Solution.LongestPalindrome(input);

        // Assert
        Assert.Equal(expectedLength, actualLength);
    }
    #endregion

    #region 1624. Largest Substring Between Two Equal Characters
    [Theory]
    [InlineData("aa", 0)]
    [InlineData("abca", 2)]
    [InlineData("cbzxy", -1)]
    public void TestLargestSubstring(string s, int expected)
    {
        // Act
        var result = Solution.MaxLengthBetweenEqualCharacters(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 884. Uncommon Words from Two Sentences
    [Theory]
    [InlineData("this apple is sweet", "this apple is sour", new string[] { "sweet", "sour" })]
    [InlineData("apple apple", "banana", new string[] { "banana" })]
    [InlineData("coding is fun", "coding is awesome", new string[] { "fun", "awesome" })]
    public void TestUncommonFromSentences(string s1, string s2, string[] expected)
    {
        // Act
        string[] result = Solution.UncommonFromSentences(s1, s2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 389. Find the Difference
    [Theory]
    [InlineData("abcd", "abcde", 'e')]
    [InlineData("", "y", 'y')]
    [InlineData("a", "aa", 'a')]
    [InlineData("ae", "aea", 'a')]
    public void FindTheDifferenceTests(string s, string t, char expected)
    {
        // Act
        char result = Solution.FindTheDifference(s, t);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 859. Buddy Strings
    [Theory]
    [InlineData("ab", "ba", true)]
    [InlineData("ab", "ab", false)]
    [InlineData("aa", "aa", true)]
    [InlineData("aaaaaaabc", "aaaaaaacb", true)]
    [InlineData("abcd", "badc", false)]
    public void TestBuddyStrings(string s, string goal, bool expected)
    {
        // Act
        bool result = Solution.BuddyStrings(s, goal);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 3083. Existence of a Substring in a String and Its Reverse
    [Theory]
    [InlineData("leetcode", true)]
    [InlineData("abcba", true)]
    [InlineData("abcd", false)]
    public void TestExistenceOfSubstring(string s, bool expected)
    {
        // Act
        bool result = Solution.IsSubstringPresent(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1832. Check if the Sentence Is Pangram
    [Theory]
    [InlineData("thequickbrownfoxjumpsoverthelazydog", true)]
    [InlineData("leetcode", false)]
    public void TestCheckIfPangram(string sentence, bool expected)
    {
        // Act
        bool result = Solution.CheckIfPangram(sentence);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2287. Rearrange Characters to Make Target String
    [Theory]
    [InlineData("ilovecodingonleetcode", "code", 2)]
    [InlineData("abcba", "abc", 1)]
    [InlineData("abbaccaddaeea", "aaaaa", 1)]
    public void TestRearrangeCharacters(string s, string target, int expected)
    {
        // Act
        int result = Solution.RearrangeCharacters(s, target);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2716 Minimize String Length
    [Theory]
    [InlineData("aaabc", 3)]
    [InlineData("cbbd", 3)]
    [InlineData("baadccab", 4)]
    public void TestMinimizeStringLength(string s, int expected)
    {
        // Act
        var result = Solution.MinimizedStringLength(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 3146 Permutation Difference between Two Strings
    [Theory]
    [InlineData("abc", "bac", 2)]
    [InlineData("abcde", "edbac", 12)]
    public void TestPermutationDifference(string s, string t, int expected)
    {
        // Act
        var result = Solution.FindPermutationDifference(s, t);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1941 Check if All Characters Have Equal Number of Occurrences
    [Theory]
    [InlineData("abacbc", true)]
    [InlineData("aaabb", false)]
    public void TestAllCharactersEqualOccurrences(string s, bool expected)
    {
        // Act
        var result = Solution.AreOccurrencesEqual(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1496 Path Crossing
    [Theory]
    [InlineData(false, "NES")]
    [InlineData(true, "NESWW")]
    public void TestPathCrossing(bool expected, string path)
    {
        // Act
        var result = Solution.IsPathCrossing(path);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 290 Word Pattern
    [Theory]
    [InlineData(true, "abba", "dog cat cat dog")]
    [InlineData(false, "abba", "dog cat cat fish")]
    [InlineData(false, "aaaa", "dog cat cat dog")]
    public void TestWordPattern(bool expected, string pattern, string s)
    {
        // Act
        var result = Solution.WordPattern(pattern, s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
