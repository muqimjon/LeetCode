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

    #region 650. 2 Keys Keyboard
    /// <summary>
    /// Returns the minimum number of operations needed to get exactly n 'A's on the screen using copy and paste operations.
    /// </summary>
    /// <param name="n">The target number of 'A's.</param>
    /// <returns>The minimum number of operations required.</returns>
    /// <link>https://leetcode.com/problems/2-keys-keyboard/</link>
    /// <time>O(√n)</time>
    /// <space>O(1)</space>
    public int MinSteps(int n)
    {
        int steps = 0;

        for (int i = 2; i <= n; i++)
            while (n % i == 0)
            {
                steps += i;
                n /= i;
            }

        return steps;
    }
    #endregion
}
