using System.Text;

namespace EasyFundamental;

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

    #region 171. Excel Sheet Column Title
    /// <summary>
    /// Converts an Excel column number to its corresponding title.
    /// </summary>
    /// <param name="columnNumber">The column number to convert.</param>
    /// <returns>The Excel column title.</returns>
    /// <time>Time complexity: O(log(n))</time>
    /// <space>Space complexity: O(log(n))</space>
    public string ConvertToTitle(int columnNumber)
    {
        StringBuilder result = new();

        // Iterate over the column number, adjusting to a 0-based index, and convert each remainder to a character ('A' + remainder)
        for (; columnNumber > 0; columnNumber /= 26)
            result.Insert(0, (char)('A' + --columnNumber % 26));

        return result.ToString();
    }
    #endregion

    #region 190. Reverse Bits
    /// <summary>
    /// Reverses the bits of a 32-bit unsigned integer.
    /// </summary>
    /// <param name="n">The input unsigned integer.</param>
    /// <returns>The result after reversing the bits.</returns>
    /// <time>Time complexity: O(1)</time>
    /// <space>Space complexity: O(1)</space>
    public uint ReverseBits(uint n)
    {
        uint result = 0;

        // Iterate through each bit of the input
        for (int bits = 32; bits-- > 0; n >>= 1)
            result = (result << 1) | (n & 1);

        return result;
    }
    #endregion

    #region 1185. Day of the Week
    /// <summary>
    /// Returns the day of the week corresponding to the given date.
    /// </summary>
    /// <param name="day">The day of the month (1-31).</param>
    /// <param name="month">The month (1-12).</param>
    /// <param name="year">The year (1971-2100).</param>
    /// <returns>The name of the day of the week.</returns>
    /// <link>https://leetcode.com/problems/day-of-the-week/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public string DayOfTheWeek(int day, int month, int year)
        => Enum.GetName(new DateTime(year, month, day).DayOfWeek)!;
    #endregion
}