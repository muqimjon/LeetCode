namespace MediumFundamental;

public class Maths
{
    #region 50. Pow(x, n)
    /// <summary>
    /// Calculates x raised to the power of n
    /// </summary>
    /// <param name="x">The base</param>
    /// <param name="n">The exponent</param>
    /// <returns>x raised to the power of n</returns>
    /// <link>https://leetcode.com/problems/powx-n/</link>
    /// <time>Time Complexity: O(log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public double MyPow(double x, int n)
        => Math.Pow(x, n);
    #endregion
}
