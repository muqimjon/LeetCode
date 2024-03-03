namespace EasyFundamental;

public class TwoPointers
{
    #region 2000. Reverse Prefix of Word
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
}
