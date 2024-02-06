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
}
