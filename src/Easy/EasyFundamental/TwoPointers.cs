namespace EasyFundamental;

public class TwoPointers
{
    #region 2000 Reverse Prefix of Word
    /// <summary>
    /// Reverses the segment of a word that starts at index 0 and ends at the index of the first occurrence of a specified character (inclusive).
    /// </summary>
    /// <param name="word">The input word.</param>
    /// <param name="ch">The character used to determine the segment to reverse.</param>
    /// <returns>The word with the specified segment reversed.</returns>
    /// <link>https://leetcode.com/problems/reverse-prefix-of-word/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public string ReversePrefix(string word, char ch)
    {
        int index = word.IndexOf(ch);
        if (index == -1) return word;
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray, 0, index + 1);
        return new string(charArray);
    }
    #endregion

    #region 344 Reverse String
    /// <summary>
    /// Reverses a string in place.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// returns>A string with the characters in reverse order.
    /// <link>https://leetcode.com/problems/reverse-string/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public void ReverseString(char[] s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
            (s[l], s[r]) = (s[r--], s[l++]);
    }
    #endregion

    #region 541 Reverse String II
    /// <summary>
    /// Reverses a string in place.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <param name="k">The number of characters to reverse.</param>
    /// <returns>A string with the characters in reverse order.</returns>
    /// <link>https://leetcode.com/problems/reverse-string-ii/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public string ReverseStr(string s, int k)
    {
        var c = s.ToCharArray();

        for (int i = 0; i < s.Length; i += 2 * k)
            Array.Reverse(c, i, Math.Min(k, s.Length - i));

        return new string(c);
    }
    #endregion

    #region 345 Reverse Vowels of a String
    /// <summary>
    /// Reverses only the vowels in a string.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The string with reversed vowels.</returns>
    /// <link>https://leetcode.com/problems/reverse-vowels-of-a-string/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public string ReverseVowels(string s)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] chars = s.ToCharArray();
        int left = 0, right = chars.Length - 1;

        while (left < right)
            if (Array.IndexOf(vowels, chars[left]) == -1)
                left++;
            else if (Array.IndexOf(vowels, chars[right]) == -1)
                right--;
            else
                (chars[right], chars[left]) = (chars[left++], chars[right--]);

        return new string(chars);
    }
    #endregion

    #region 925 Long Pressed Name
    /// <summary>
    /// Checks if the typed string can be obtained from the name string by possibly long pressing some characters.
    /// </summary>
    /// <param name="name">The actual name string.</param>
    /// <param name="typed">The string typed on the keyboard.</param>
    /// <returns>Returns true if the typed string is a long-pressed version of the name string; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/long-pressed-name/</link>
    /// <time>O(n + m)</time>
    /// <space>O(1)</space>
    public bool IsLongPressedName(string name, string typed)
    {
        int i = 0;

        foreach (char c in typed)
            if (i < name.Length && name[i] == c)
                i++;
            else if (i == 0 || name[i - 1] != c)
                return false;

        return i == name.Length;
    }
    #endregion

    #region 1332 Remove Palindromic Subsequences
    /// <summary>
    /// Removes the palindromic subsequences to make the string empty in minimum steps.
    /// </summary>
    /// <param name="s">Input string consisting of 'a' and 'b'.</param>
    /// <returns>The minimum number of steps to make the string empty.</returns>
    /// <remarks>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    /// </remarks>
    public int RemovePalindromeSub(string s)
        => s.Equals(string.Concat(s.Reverse())) ? 1 : 2;
    #endregion

    #region 392 Is Subsequence
    /// <summary>
    /// Determines if string 's' is a subsequence of string 't'.
    /// </summary>
    /// <param name="s">The string to check if it is a subsequence.</param>
    /// <param name="t">The string in which to check for the subsequence.</param>
    /// <returns>True if 's' is a subsequence of 't', otherwise false.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public bool IsSubsequence(string s, string t)
    {
        int i = 0;

        foreach (var c in t)
            if (i < s.Length && s[i] == c)
                i++;

        return i.Equals(s.Length);
    }
    #endregion

    #region 1455 Check If a Word Occurs As a Prefix of Any Word in a Sentence
    /// <summary>
    /// Checks if a searchWord is a prefix of any word in a sentence and returns the index (1-indexed).
    /// </summary>
    /// <param name="sentence">The sentence consisting of words separated by spaces.</param>
    /// <param name="searchWord">The word to search for as a prefix.</param>
    /// <returns>The 1-based index of the first word where searchWord is a prefix, or -1 if not found.</returns>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int IsPrefixOfWord(string sentence, string searchWord)
        => sentence.Split()
            .Select((word, index) => word.StartsWith(searchWord) ? index + 1 : -1)
            .FirstOrDefault(i => i != -1, -1);
    #endregion
}
