namespace Easy;

public class Maths
{
    #region 9. Palindrome Number
    /// <summary>
    /// 9. Palindrome Number
    /// </summary>
    /// <param name="x">Integer to check for palindrome</param>
    /// <returns>True if the integer is a palindrome, otherwise false</returns>
    /// <time>Runtime: O(log10(x)) - Time complexity logarithmic with respect to the input size</time>
    /// <space>Memory: O(1) - Constant space complexity, as only a few variables are used</space>
    public bool IsPalindrome(int x)
    {
        // Variable to store the reversed integer
        int reversed = 0;

        // Variable to store the original integer
        int original = x;

        // Reverse the digits of the integer
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        // Check if the reversed integer is equal to the original integer
        return reversed == original;
    }
    #endregion

    #region 70. Climbing Stairs
    /// <summary>
    /// Calculates the number of distinct ways to climb a staircase with n steps using dynamic programming.
    /// </summary>
    /// <param name="n">The number of steps in the staircase.</param>
    /// <returns>The number of distinct ways to climb to the top.</returns>
    /// <time>Runtime: O(n) - Linear time complexity</time>
    /// <space>Memory: O(n) - Linear space complexity</space>
    public int ClimbStairs(int n)
        => Fibonacci(n + 1);

    private Dictionary<int, int> memo = new Dictionary<int, int>();

    private int Fibonacci(int n)
    {
        if (memo.ContainsKey(n))
            return memo[n];

        int result = (n <= 1) ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
        memo[n] = result;
        return result;
    }
    #endregion
}
