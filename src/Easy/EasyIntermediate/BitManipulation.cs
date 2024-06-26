namespace EasyIntermediate;

public class BitManipulation
{
    #region 461. Hamming Distance
    /// <summary>
    /// Calculates the Hamming distance between two integers
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>Hamming distance</returns>
    /// <link>https://leetcode.com/problems/hamming-distance/</link>
    /// <time>Time complexity: O(1)</time>
    /// <space>Space complexity: O(1)</space>
    public int HammingDistance(int x, int y) =>
        Convert.ToString(x ^ y, 2).Count(c => c == '1');
    #endregion

    #region 2220. Minimum Bit Flips to Convert Number
    /// <summary>
    /// Returns the minimum number of bit flips required to convert the number start to goal.
    /// </summary>
    /// <param name="start">The starting number.</param>
    /// <param name="goal">The target number.</param>
    /// <returns>The minimum number of bit flips needed.</returns>
    /// <link>https://leetcode.com/problems/minimum-bit-flips-to-convert-number/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MinBitFlips(int start, int goal)
        => (start ^ goal).ToString("b").Count(c => c == '1');
    #endregion
}
