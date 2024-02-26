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
}
