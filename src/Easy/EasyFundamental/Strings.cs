using System.Text;
using System.Text.RegularExpressions;

namespace EasyFundamental;

public class Strings
{
    #region 13. Roman to Integer
    /// <summary>
    /// 13. Roman to Integer
    /// </summary>
    /// <param name="s">Roman numeral string</param>
    /// <returns>Integer representation of the Roman numeral</returns>
    /// <time>Runtime: O(n) - Linear time complexity, where n is the length of the input string</time>
    /// <space>Memory: O(1) - Constant space complexity, as the dictionary size is fixed</space>
    public int RomanToInt(string s)
    {
        // Dictionary to store Roman numeral characters and their corresponding values
        Dictionary<char, int> numbers = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

        // Variable to store the result
        int result = 0;

        // Iterate through each character in the input string
        for (int i = 0; i < s.Length; i++)
        {
            // Check if the current numeral is smaller than the next numeral
            if (i < s.Length - 1 && numbers[s[i]] < numbers[s[i + 1]])
                // Subtract the current numeral value from the result
                result -= numbers[s[i]];
            else
                // Add the current numeral value to the result
                result += numbers[s[i]];
        }

        // Return the final result as the integer representation of the Roman numeral
        return result;
    }
    #endregion

    #region 14. Longest Common Prefix
    /// <summary>
    /// 14. Longest Common Prefix
    /// </summary>
    /// <param name="words">Array of strings</param>
    /// <returns>Longest common prefix as a string</returns>
    /// <time>Runtime: O(n * m) - Linear time complexity with respect to both n and m</time>
    /// <space>Memory: O(1) - Constant space complexity</space>
    public string LongestCommonPrefix(string[] words)
    {
        if (words.Length == 0)
            return "";

        // Determine the common length based on the minimum length of words
        int commonLength = words.Min(w => w.Length);

        // Iterate through each character position up to the common length
        for (int i = 0; i < commonLength; i++)
        {
            // Get the current character to compare
            char currentChar = words[0][i];

            // Check if the character at the current position is the same for all words
            if (words.Any(w => w[i] != currentChar))
                return words[0][0..i];
        }

        // Return the longest common prefix
        return words[0][0..commonLength];
    }
    #endregion

    #region 28. Find the Index of the First Occurrence in a String
    /// <summary>
    /// 28. Find the Index of the First Occurrence in a String
    /// </summary>
    /// <param name="haystack">The input string</param>
    /// <param name="needle">The substring to search for</param>
    /// <returns>The index of the first occurrence of the needle in haystack, or -1 if not found</returns>

    /// Solution 1
    /// <time>Runtime: O(n²) - Quadratic time complexity due to nested loops</time>
    /// <space>Memory: O(1) - Constant space complexity as only a few variables are used</space>
    public int StrStr(string haystack, string needle)
    {
        // Check if the needle is empty
        if (string.IsNullOrEmpty(needle))
            return 0;

        // Get the lengths of the input string and the needle
        var hayLength = haystack.Length;
        var needleLength = needle.Length;

        // Iterate through the input string
        for (int i = 0; i <= hayLength - needleLength; i++)
        {
            int j;

            // Compare characters in the needle with the substring in the haystack
            for (j = 0; j < needleLength; j++)
            {
                if (haystack[i + j] != needle[j])
                    break;
            }

            // If the entire needle is found, return the index
            if (j == needleLength)
                return i;
        }

        // Needle not found in haystack
        return -1;
    }

    /// Solution 2
    /// <time>Runtime: O(n²) - Quadratic time complexity</time>
    /// <space>Memory: O(1) - Constant space complexity</space>
    public int StrStr2(string haystack, string needle)
    {
        if (haystack.Contains(needle)) // haystack = "anything", needle = "" => true
        {
            if (string.IsNullOrEmpty(needle))
                return 0;

            var ch = haystack.Length;
            var cn = needle.Length;
            var c = needle.First();

            for (int i = haystack.IndexOf(c); i < ch;)
                if (haystack.Substring(i, cn).Equals(needle))
                    return i;
                else
                    i = haystack.IndexOf(c, i + 1);
        }
        return -1;
    }
    #endregion

    #region 709. To Lower Case
    /// <summary>
    /// 709. To Lower Case
    /// Given a string s, return the string after replacing every uppercase letter with the same lowercase letter.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The string after converting every uppercase letter to lowercase.</returns>
    /// <time>Runtime: O(n) - Linear time complexity</time>
    /// <space>Memory: O(n) - Linear space complexity</space>
    public string ToLowerCase(string s)
        => new(s.Select(c 
            => char.IsUpper(c) ? (char)(c + 32) : c)
            .ToArray());
    #endregion

    #region 58. Length of Last Word
    /// <summary>
    /// 58. Length of Last Word
    /// Returns the length of the last word in the given string, where a word is a substring of non-space characters.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The length of the last word in the string.</returns>
    /// <time>Runtime: O(n) - Linear time complexity</time>
    /// <space>Memory: O(n) - Linear space complexity</space>
    public int LengthOfLastWord(string s)
        => s.Split().Last(p => p.Length > 0).Length;
    #endregion

    #region 1768. Merge Strings Alternately
    /// <summary>
    /// Merges strings by alternating letters, starting with word1, and appends extra letters from the longer string.
    /// </summary>
    /// <param name="word1">The first input string.</param>
    /// <param name="word2">The second input string.</param>
    /// <returns>The merged string.</returns>
    /// <time>Runtime: O(N,M)</time>
    /// <space>Memory: O(N + M)</space>
    public string MergeAlternately(string word1, string word2)
    {
        var word = new StringBuilder();
        var length = Math.Min(word1.Length, word2.Length);
        for (int i = 0; i < length; ++i)
        {
            word.Append(word1[i]);
            word.Append(word2[i]);
        }

        word.Append(word1.Length > length ?
            word1.Substring(length) :
            word2.Substring(length)
        ).ToString();

        return word.ToString();
    }
    #endregion

    #region 125. Validating Polindrome
    /// <summary>
    /// Determines if a given string is a palindrome after removing non-alphanumeric characters and converting to lowercase.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>True if the string is a palindrome, false otherwise.</returns>
    /// <time>Runtime: O(n)</time>
    /// <space>Memory: O(n)</space>
    public bool IsPalindrome(string s)
    {
        s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return s == new string(s.Reverse().ToArray());
    }

    #endregion

    #region 1941. Check if All Characters Have Equal Number of Occurrences
    /// <summary>
    /// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
    /// Return the array in the form [x1,y1,x2,y2,...,xn,yn].
    /// </summary>
    /// <param name="nums">The input array consisting of 2n elements.</param>
    /// <param name="n">The number of pairs.</param>
    /// <returns>The array in the form [x1,y1,x2,y2,...,xn,yn].</returns>
    /// <link>https://leetcode.com/problems/shuffle-the-array/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[2 * n];
        for (int i = 0, j = 0; i < n; i++, j += 2)
            (result[j], result[j + 1]) = (nums[i], nums[i + n]);

        return result;
    }

    #endregion

    #region 2379. Minimum Recolors to Get K Consecutive Black Blocks
    /// <summary>
    /// Finds the minimum number of recolors needed to obtain K consecutive black blocks.
    /// </summary>
    /// <param name="blocks">The input string representing the color of blocks.</param>
    /// <param name="k">The desired number of consecutive black blocks.</param>
    /// <returns>The minimum number of recolors needed.</returns>
    /// <link>https://leetcode.com/problems/minimum-recolors-to-get-k-consecutive-black-blocks/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MinimumRecolors(string blocks, int k)
    {
        int n = blocks.Length;
        int windowStart = 0;
        int minRecolors = int.MaxValue;
        int numBlack = 0;

        for (int windowEnd = 0; windowEnd < n; windowEnd++)
        {
            numBlack += blocks[windowEnd] == 'B' ? 1 : 0;

            if (windowEnd - windowStart + 1 == k)
            {
                minRecolors = Math.Min(minRecolors, k - numBlack);

                if (blocks[windowStart] == 'B')
                    numBlack--;

                windowStart++;
            }
        }

        return minRecolors != int.MaxValue ? minRecolors : 0;
    }
    #endregion

    #region 1446. Consecutive Characters
    /// <summary>
    /// Finds the maximum power of consecutive characters in the given string.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The maximum power of consecutive characters.</returns>
    /// <link>https://leetcode.com/problems/consecutive-characters/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MaxPower(string s)
    {
        int maxPower = 1;
        int currentPower = 1;

        for (int i = 1; i < s.Length; i++)
            if (s[i] == s[i - 1])
                maxPower = Math.Max(maxPower, ++currentPower);
            else
                currentPower = 1;

        return maxPower;
    }
    #endregion

    #region 520. Detect Capital
    /// <summary>
    /// Determines if the usage of capitals in a word is correct.
    /// </summary>
    /// <param name="word">The word to check.</param>
    /// <returns>True if the usage of capitals is correct, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/detect-capital/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool DetectCapitalUse(string word)
    {
        bool allUpper = char.IsUpper(word[0]);
        bool lower = true;

        foreach (char c in word[1..])
            if (char.IsUpper(c)) lower = false;
            else allUpper = false;

        return lower || allUpper;
    }
    #endregion

    #region 1108. Defanging an IP Address
    /// <summary>
    /// Returns the defanged version of the given IP address.
    /// </summary>
    /// <param name="address">The IP address to defang.</param>
    /// <returns>The defanged version of the given IP address.</returns>
    /// <link>https://leetcode.com/problems/defanging-an-ip-address/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public string DefangIPaddr(string address)
        => address.Replace(".", "[.]");
    #endregion

    #region 796. Rotate String
    /// <summary>
    /// Checks if s can become goal after some number of shifts.
    /// </summary>
    /// <param name="s">The original string.</param>
    /// <param name="goal">The target string to achieve.</param>
    /// <returns>True if s can become goal after some number of shifts, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/rotate-string/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public bool RotateString(string s, string goal)
        => s.Length == goal.Length && (s + s).Contains(goal);
    #endregion
}
