namespace Easy;

public class Lists
{
    #region 9. Palindrome Number
    /// <summary>
    /// 9. Palindrome Number
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    /// <time>25 ms</time>
    /// <space>31.18 MB</space>
    public bool IsPalindrome(int x)
    {
        int reversed = 0;
        int original = x;
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return reversed == original;
    }
    #endregion

    #region 13. Roman to Integer
    /// <summary>
    /// 13. Roman to Integer
    /// </summary>
    /// <param name="s"></param>
    /// <returns>Integer</returns>
    /// <time>61 ms</time>
    /// <space>48.73 MB</space>
    public int RomanToInt(string s)
    {
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

        int result = 0;
        for (int i = 0; i < s.Length; i++)
            if (i < s.Length - 1 && numbers[s[i]] < numbers[s[i + 1]])
                result -= numbers[s[i]];
            else
                result += numbers[s[i]];

        return result;
    }
    #endregion

    #region 14. Longest Common Prefix
    /// <summary>
    /// 14. Longest Common Prefix 1
    /// </summary>
    /// <param name="words"></param>
    /// <returns>string</returns>
    /// <time>77 ms</time>
    /// <space>41.50 MB</space>
    public string LongestCommonPrefix(string[] words)
    {
        if (words.Length == 0)
            return "";

        int commonLength = words.Min(w => w.Length);
        for (int i = 0; i < commonLength; i++)
        {
            char currentChar = words[0][i];

            if (words.Any(w => w[i] != currentChar))
                return words[0][0..i];
        }

        return words[0][0..commonLength];
    }
    #endregion
}
