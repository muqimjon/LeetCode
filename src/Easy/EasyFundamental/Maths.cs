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

    #region 1360. Number of Days Between Two Dates
    /// <summary>
    /// Calculates the number of days between two given dates.
    /// </summary>
    /// <param name="date1">The first date in the format "YYYY-MM-DD".</param>
    /// <param name="date2">The second date in the format "YYYY-MM-DD".</param>
    /// <returns>The number of days between the two dates.</returns>
    /// <link>https://leetcode.com/problems/number-of-days-between-two-dates/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public int DaysBetweenDates(string date1, string date2)
        => Math.Abs((DateTime.Parse(date1) - DateTime.Parse(date2)).Days);
    #endregion

    #region 2520. Count the Digits That Divide a Number
    /// <summary>
    /// Counts the number of digits in the given number that divide the number itself.
    /// </summary>
    /// <param name="num">The integer number.</param>
    /// <returns>The count of digits that divide the number.</returns>
    /// <link>https://leetcode.com/problems/count-the-digits-that-divide-a-number/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int CountDigits(int num)
            => num.ToString().Count(d => d % 48 > 0 && num % (d % 48) < 1);
    #endregion

    #region 507. Perfect Number
    /// <summary>
    /// Checks if the given number is a perfect number.
    /// </summary>
    /// <param name="num">The number to check.</param>
    /// <returns>True if the number is perfect, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/perfect-number/</link>
    /// <time>Time Complexity: O(sqrt(n))</time>
    /// <space>Space Complexity: O(1)</space>
    public bool CheckPerfectNumber(int num)
    {
        if (num < 6)
            return false;

        int sum = 1;

        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0)
                sum += i + (i != num / i ? num / i : 0);

        return sum == num;
    }
    #endregion

    #region 412. Fizz Buzz
    /// <summary>
    /// Returns a list of strings that represent the numbers from 1 to n.
    /// </summary>
    /// <param name="n">The number to generate.</param>
    /// <returns>A list of strings that represent the numbers from 1 to n.</returns>
    /// <link>https://leetcode.com/problems/fizz-buzz/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public IList<string> FizzBuzz(int n) =>
        Enumerable.Range(1, n)
            .Select(i => (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "") + (i % 3 != 0 && i % 5 != 0 ? i.ToString() : ""))
            .ToList();
    #endregion
}