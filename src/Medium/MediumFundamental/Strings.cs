namespace MediumFundamental;

public class Strings
{
    #region 22 Generate Parentheses
    /// <summary>
    /// Generates all combinations of well-formed parentheses for n pairs.
    /// </summary>
    /// <param name="n">The number of pairs of parentheses.</param>
    /// <returns>A list of all combinations of well-formed parentheses.</returns>
    /// <time>O(n^2)</time>
    /// <space>O(n)</space>
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> result = [];

        void Backtrack(string current, int open, int close)
        {
            if (current.Length == n * 2)
            {
                result.Add(current);
                return;
            }

            if (open < n) Backtrack(current + "(", open + 1, close);
            if (close < open) Backtrack(current + ")", open, close + 1);
        }

        Backtrack("", 0, 0);
        return result;
    }
    #endregion
}