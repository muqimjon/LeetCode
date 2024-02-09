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
}
