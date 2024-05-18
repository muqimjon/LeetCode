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

    #region 1624. Largest Substring Between Two Equal Characters
    /// <summary>
    /// Calculates the maximum length of substring between two equal characters.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The maximum length between two equal characters.</returns>
    /// <link>https://leetcode.com/problems/largest-substring-between-two-equal-characters/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        int maxLength = -1;
        Dictionary<char, int> lastIndexMap = [];

        for (int i = 0; i < s.Length; i++)
            if (lastIndexMap.TryGetValue(s[i], out int value))
                maxLength = Math.Max(maxLength, i - value - 1);
            else
                lastIndexMap[s[i]] = i;

        return maxLength;
    }
    #endregion

    #region 884. Uncommon Words from Two Sentences
    /// <summary>
    /// Finds uncommon words between two sentences.
    /// </summary>
    /// <param name="s1">The first sentence.</param>
    /// <param name="s2">The second sentence.</param>
    /// <returns>An array of uncommon words.</returns>
    /// <link>https://leetcode.com/problems/uncommon-words-from-two-sentences/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var wordCounts = (s1 + " " + s2).Split(' ')
            .GroupBy(word => word)
            .ToDictionary(group => group.Key, group => group.Count());

        return wordCounts.Where(pair => pair.Value == 1)
            .Select(pair => pair.Key)
            .ToArray();
    }
    #endregion

    #region 389. Find the Difference
    /// <summary>
    /// Finds the extra character added to string t compared to string s.
    /// </summary>
    /// <param name="s">The original string.</param>
    /// <param name="t">The string with one additional character.</param>
    /// <returns>The character that was added to t.</returns>
    /// <link>https://leetcode.com/problems/find-the-difference/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public char FindTheDifference(string s, string t)
        => (char)(t.Sum(c => c) - s.Sum(c => c));
    #endregion
}