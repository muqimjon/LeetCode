namespace EasyIntermediate;

public class HashTables
{
    #region 1189. Maximum Number of Balloons
    /// <summary>
    /// Given a string text, the function calculates the maximum number of instances of the word "balloon" that can be formed.
    /// </summary>
    /// <param name="text">The input string.</param>
    /// <returns>The maximum number of instances of "balloon" that can be formed.</returns>
    /// <link>https://leetcode.com/problems/maximum-number-of-balloons/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MaxNumberOfBalloons(string text)
    {
        Dictionary<char, int> bl = new() { { 'b', 0 }, { 'a', 0 }, { 'l', 0 }, { 'o', 0 }, { 'n', 0 } };
        foreach (char c in text)
            if (bl.ContainsKey(c))
                bl[c]++;
        bl['l'] /= 2;
        bl['o'] /= 2;

        return bl.Values.Min();
    }
    #endregion

    #region 202. Happy Number
    /// <summary>
    /// Write an algorithm to determine if a number is "happy".
    /// </summary>
    /// <param name="n">The number to check.</param>
    /// <returns>True if the number is "happy", false otherwise.</returns>
    /// <link>https://leetcode.com/problems/happy-number/</link>
    /// <time>Time Complexity: O(log(n))</time>
    /// <space>Space Complexity: O(n)</space>
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new();
        while (n != 1 && seen.Add(n))
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            n = sum;
        }
        return n == 1;
    }
    #endregion

    #region 2068. Check Whether Two Strings are Almost Equivalent
    /// <summary>
    /// Checks whether two strings are almost equivalent.
    /// </summary>
    /// <param names=["word1", "word2"]>Strings</param>
    /// <returns>True if the strings are almost equivalent, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/check-whether-two-strings-are-almost-equivalent/</link>
    /// <time>Time Complexity: O(m+n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool CheckAlmostEquivalent(string word1, string word2)
    {
        Dictionary<char, int> ab = new();

        foreach (char a in word1)
            ab[a] = ab.TryGetValue(a, out int value) ? value + 1 : 1;

        foreach (var a in word2)
            ab[a] = ab.TryGetValue(a, out int value) ? value - 1 : -1;

        return ab.Values.All(e => e < 4 && e > -4);
    }
    #endregion

    #region 383. Ransom Note
    /// <summary>
    /// Determines whether the ransom note can be constructed using the letters from the magazine.
    /// </summary>
    /// <param name="ransomNote">The ransom note string.</param>
    /// <param name="magazine">The magazine string.</param>
    /// <returns>True if the ransom note can be constructed, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/ransom-note/</link>
    /// <time>Time Complexity: O(m + n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var count = new int[26];

        foreach (var c in magazine)
            count[c - 'a']++;

        foreach (var c in ransomNote)
            if (--count[c - 'a'] < 0)
                return false;

        return true;
    }
    #endregion

    #region 771. Jewels and Stones
    /// <summary>
    /// Given two strings jewels and stones, each character in stones is a type of stone.
    /// </summary>
    /// <param name="jewels">The types of stones that are in the bag.</param>
    /// <param name="stones">The stones that are in the bag.</param>
    /// <returns>The number of stones that are also jewels.</returns>
    /// <link>https://leetcode.com/problems/jewels-and-stones/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int NumJewelsInStones(string jewels, string stones)
        => stones.Count(jewels.Contains);
    #endregion

    #region 1876. Substrings of Size Three with Distinct Characters
    /// <summary>
    /// Returns the number of good substrings.
    /// </summary>
    /// <param name="s">The string to check.</param>
    /// <returns>The number of good substrings.</returns>
    /// <link>https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int CountGoodSubstrings(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length - 2; i++)
            if (s.Substring(i, 3).Distinct().Count() == 3)
                count++;

        return count;
    }
    #endregion

    #region 409. Longest Palindrome
    /// <summary>
    /// Returns the length of the longest palindromic substring in s.
    /// </summary>
    /// <param name="s">The string to check.</param>
    /// <returns>The length of the longest palindromic substring in s.</returns>
    /// <link>https://leetcode.com/problems/longest-palindrome/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int LongestPalindrome(string s)
    {
        int[] charCounts = new int[128];
        int length = 0, odd = 0;

        foreach (char c in s)
            charCounts[c]++;

        foreach (int count in charCounts)
        {
            length += count / 2 * 2;
            if (count % 2 == 1) odd = 1;
        }

        return odd + length;
    }
    #endregion
}