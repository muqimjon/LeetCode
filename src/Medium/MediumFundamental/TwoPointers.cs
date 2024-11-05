namespace MediumFundamental;

public class TwoPointers
{
    #region 151 Reverse Words in a String
    /// <summary>
    /// Reverses the order of words in a string with only a single space between them and no leading or trailing spaces.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>A new string with words in reverse order, separated by a single space.</returns>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public string ReverseWords(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
    #endregion
}