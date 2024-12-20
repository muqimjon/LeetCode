﻿using System.Text;

namespace EasyFundamental;

public class Maths
{
    #region 9 Palindrome Number
    /// <summary>
    /// 9 Palindrome Number
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

    #region 70 Climbing Stairs
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

    #region 171 Excel Sheet Column Title
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

    #region 190 Reverse Bits
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

    #region 1185 Day of the Week
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

    #region 1360 Number of Days Between Two Dates
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

    #region 2520 Count the Digits That Divide a Number
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

    #region 507 Perfect Number
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

    #region 412 Fizz Buzz
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

    #region 492 Construct the Rectangle
    /// <summary>
    /// Returns the smallest possible rectangle that can be formed with the given area.
    /// </summary>
    /// <param name="area">The area of the rectangle.</param>
    /// <returns>The smallest possible rectangle that can be formed with the given area.</returns>
    /// <link>https://leetcode.com/problems/construct-the-rectangle/</link>
    /// <time>Time Complexity: O(sqrt(n))</time>
    /// <space>Space Complexity: O(1)</space>
    public int[] ConstructRectangle(int area)
    {
        for (int width = (int)Math.Sqrt(area); width > 0; width--)
            if (area % width == 0)
                return [area / width, width];

        return [0, 0];
    }
    #endregion

    #region 1154 Day of the Year
    /// <summary>
    /// Returns the day of the year corresponding to the given date.
    /// </summary>
    /// <param name="date">The date in the format "YYYY-MM-DD".</param>
    /// <returns>The day of the year.</returns>
    /// <link>https://leetcode.com/problems/day-of-the-year/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public int DayOfYear(string date)
    {
        string[] parts = date.Split('-');
        int year = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        int day = int.Parse(parts[2]);
        int[] daysOfMonth = [day, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            daysOfMonth[2] = 29;

        return daysOfMonth[..month].Sum();
    }
    #endregion

    #region 504 Base 7
    /// <summary>
    /// Converts an integer to its base 7 representation.
    /// </summary>
    /// <param name="num">The integer to convert.</param>
    /// <returns>The base 7 representation of the integer.</returns>
    /// <link>https://leetcode.com/problems/base-7/</link>
    /// <time>Time Complexity: O(log(n))</time>
    /// <space>Space Complexity: O(log(n))</space>
    public string ConvertToBase7(int num)
    {
        if (num == 0) return "0";

        StringBuilder result = new();
        int absNum = Math.Abs(num);

        while (absNum > 0)
        {
            result.Insert(0, absNum % 7);
            absNum /= 7;
        }

        return (num < 0 ? "-" : "") + result;
    }
    #endregion

    #region 1323 Maximum 69 Number
    /// <summary>
    /// Returns the maximum number after replacing all 6's with 9's.
    /// </summary>
    /// <param name="num">The number to replace 6's with 9's.</param>
    /// <returns>The maximum number after replacing all 6's with 9's.</returns>
    /// <link>https://leetcode.com/problems/maximum-69-number/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int Maximum69Number(int num)
    {
        char[] digits = num.ToString().ToCharArray();

        for (int i = 0; i < digits.Length; i++)
            if (digits[i] == '6')
            {
                digits[i] = '9';
                break;
            }

        return int.Parse(new string(digits));
    }
    #endregion

    #region 1523 Count Odd Numbers in an Interval Range
    /// <summary>
    /// Counts the number of odd integers in the inclusive interval range [low, high].
    /// </summary>
    /// <param name="low">The lower bound of the interval.</param>
    /// <param name="high">The upper bound of the interval.</param>
    /// <returns>The count of odd integers in the interval range.</returns>
    /// <link>https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/description/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public int CountOdds(int low, int high)
        => (high + 1) / 2 - low / 2;
    #endregion

    #region 1716 Calculate Money in Leetcode Bank
    /// <summary>
    /// Calculates the total amount of money Hercy will have in the Leetcode bank at the end of the nth day.
    /// </summary>
    /// <param name="day">The nth day.</param>
    /// <returns>The total amount of money at the end of the nth day.</returns>
    /// <link>https://leetcode.com/problems/calculate-money-in-leetcode-bank/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public int TotalMoney(int day)
    {
        int countWeeks = day / 7;
        int money = countWeeks * 28, i = 0;

        for (; i < countWeeks; ++i)
            money += i * 7;

        int residue = day % 7;

        return money + residue * (residue + 1) / 2 + i * residue;
    }
    #endregion

    #region 2769 Find the Maximum Achievable Number
    /// <summary>
    /// Returns the maximum achievable number based on the given input values.
    /// </summary>
    /// <param name="num">The target number to achieve.</param>
    /// <param name="t">The maximum number of times the operation can be applied.</param>
    /// <returns>The maximum achievable number.</returns>
    /// <link>https://leetcode.com/problems/find-the-maximum-achievable-number/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public int TheMaximumAchievableX(int num, int t)
        => 2 * t + num;
    #endregion

    #region 1688 Count of Matches in Tournament
    /// <summary>
    /// Calculates the number of matches played in a tournament.
    /// </summary>
    /// <param name="n">The number of teams in the tournament.</param>
    /// <returns>The number of matches played until a winner is decided.</returns>
    /// <link>https://leetcode.com/problems/count-of-matches-in-tournament/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public int NumberOfMatches(int n)
        => --n;
    #endregion

    #region 2427 Number of Common Factors
    /// <summary>
    /// Counts the number of common factors between two integers.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <returns>The number of common factors.</returns>
    /// <link>https://leetcode.com/problems/number-of-common-factors/</link>
    /// <time>Time Complexity: O(min(a, b))</time>
    /// <space>Space Complexity: O(1)</space>
    public int CommonFactors(int a, int b)
        => Enumerable.Range(1, Math.Min(a, b)).Count(i => a % i == 0 && b % i == 0);
    #endregion

    #region 2600 K Items With the Maximum Sum
    /// <summary>
    /// Calculates max sum of picked items from a bag.
    /// </summary>
    /// <param name="Ones">Number of items with 1 written on them.</param>
    /// <param name="Zeros">Number of items with 0 written on them.</param>
    /// <param name="NegOnes">Number of items with -1 written on them.</param>
    /// <param name="k">Number of items to pick from the bag.</param>
    /// <returns>The maximum possible sum of numbers written on the picked items.</returns>
    /// <link>https://leetcode.com/problems/k-items-with-the-maximum-sum/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public int KItemsWithMaximumSum(int Ones, int Zeros, int NegOnes, int k)
        => Ones > k ? k : (Ones + Zeros) > k ? Ones : Ones - Math.Min(NegOnes, k - Ones - Zeros);
    #endregion

    #region 2894 Divisible and Non-divisible Sums Difference
    /// <summary>
    /// Calculates the difference between the sum of non-divisible and divisible integers in a range.
    /// </summary>
    /// <param name="n">The upper limit of the range.</param>
    /// <param name="m">The divisor for checking divisibility.</param>
    /// <returns>The difference between the sum of non-divisible and divisible integers.</returns>
    /// <link>https://leetcode.com/problems/divisible-and-non-divisible-sums-difference/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int DifferenceOfSums(int n, int m)
        => Enumerable.Range(1, n).Sum(i => i % m != 0 ? i : -i);
    #endregion

    #region 273 Number of Steps to Reduce a Number to Zero
    /// <summary>
    /// Calculates the number of steps to reduce a number to zero.
    /// </summary>
    /// <param name="num">The number to be reduced.</param>
    /// <returns>The number of steps required to reduce the number to zero.</returns>
    /// <link>https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/</link>
    /// <time>O(log n)</time>
    /// <space>O(1)</space>
    public int NumberOfSteps(int num)
            => num == 0 ? 0 : 1 + NumberOfSteps(num % 2 == 0 ? num / 2 : num - 1);
    #endregion

    #region 2180 Count Integers With Even Digit Sum
    /// <summary>
    /// Calculates the number of positive integers less than or equal to num whose digit sums are even.
    /// </summary>
    /// <param name="num">The positive integer upper limit.</param>
    /// <returns>The number of positive integers with even digit sums less than or equal to num.</returns>
    /// <link>Link: Not specified</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int CountEven(int num) =>
        Enumerable.Range(1, num).Count(n => n.ToString().Sum(c => c - '0') % 2 == 0);
    #endregion

    #region 728 Self Dividing Numbers
    /// <summary>
    /// Finds self-dividing numbers in a range.
    /// </summary>
    /// <param name="left">The lower bound of the range.</param>
    /// <param name="right">The upper bound of the range.</param>
    /// <returns>A list of self-dividing numbers.</returns>
    /// <link>https://leetcode.com/problems/self-dividing-numbers/</link>
    /// <time>O(n * d)</time>
    /// <space>O(1)</space>
    public IList<int> SelfDividingNumbers(int left, int right)
        => Enumerable.Range(left, right - left + 1)
                     .Where(num => num.ToString().All(c => c != '0' && num % (c - '0') == 0))
                     .ToList();
    #endregion

    #region 509 Fibonacci Number
    /// <summary>
    /// Calculates the nth Fibonacci number.
    /// </summary>
    /// <param name="n">The position in the Fibonacci sequence.</param>
    /// <returns>The nth Fibonacci number.</returns>
    /// <time>O(2^n)</time>
    /// <space>O(n)</space>
    public int Fib(int n)
        => n <= 1 ? n : Fib(n - 1) + Fib(n - 2);
    #endregion

    #region 2582 Pass the Pillow
    /// <summary>
    /// Finds the index of the person holding the pillow after a given time.
    /// </summary>
    /// <param name="n">The number of people in the line.</param>
    /// <param name="time">The time in seconds.</param>
    /// <returns>The index of the person holding the pillow.</returns>
    /// <link>https://leetcode.com/problems/pass-the-pillow/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public int PassThePillow(int n, int time)
        => n - Math.Abs(n - 1 - time % (2 * (n - 1)));
    #endregion

    #region 2469 Convert the Temperature
    /// <summary>
    /// Converts Celsius temperature to Kelvin and Fahrenheit.
    /// </summary>
    /// <param name="celsius">Temperature in Celsius.</param>
    /// <returns>Array with temperatures in Kelvin and Fahrenheit.</returns>
    /// <link>https://leetcode.com/problems/convert-the-temperature/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public double[] ConvertTemperature(double celsius)
        => new[] { celsius + 273.15, celsius * 1.8 + 32 };
    #endregion

    #region 2160 Minimum Sum of Four Digit Number After Splitting Digits
    /// <summary>
    /// Minimum sum after split.
    /// </summary>
    /// <param name="num">A four-digit integer.</param>
    /// <returns>Minimum sum of splits.</returns>
    /// <link>https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/</link>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public int MinimumSum(int num)
    {
        var digits = num.ToString().Select(c => c - '0').Order().ToArray();
        return digits[0] * 10 + digits[2] + digits[1] * 10 + digits[3];
    }
    #endregion

    #region 342 Power of Four
    /// <summary>
    /// Checks if an integer is a power of four.
    /// </summary>
    /// <param name="n">Integer to check.</param>
    /// <returns>True if it's a power of four, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/power-of-four/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public bool IsPowerOfFour(int n)
        => n > 0 && (n & (n - 1)) == 0 && (n - 1) % 3 == 0;
    #endregion

    #region 1281 Subtract the Product and Sum of Digits of an Integer
    /// <summary>
    /// Returns the difference between the product and sum of the digits of an integer.
    /// </summary>
    /// <param name="n">The input integer.</param>
    /// <returns>The difference between the product and sum of its digits.</returns>
    /// <link>https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int SubtractProductAndSum(int n)
        => n.ToString().Aggregate(1, (p, c)
            => p * (c - 48)) - n.ToString().Sum(c => c - 48);
    #endregion

    #region 2481 Minimum Cuts to Divide a Circle
    /// <summary>
    /// Returns the minimum number of cuts needed to divide a circle into n equal slices.
    /// </summary>
    /// <param name="n">The number of equal slices.</param>
    /// <returns>The minimum number of cuts needed.</returns>
    /// <link>https://leetcode.com/problems/minimum-cuts-to-divide-a-circle/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public int NumberOfCuts(int n)
        => n < 2 ? 0 : (n % 2 == 0 ? n / 2 : n);
    #endregion

    #region 1137 N-th Tribonacci Number
    /// <summary>
    /// Computes the n-th Tribonacci number.
    /// </summary>
    /// <param name="n">The index of the Tribonacci number to compute.</param>
    /// <returns>The n-th Tribonacci number.</returns>
    /// <link>https://leetcode.com/problems/n-th-tribonacci-number/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int Tribonacci(int n)
    {
        int[] t = { 0, 1, 1 };
        for (int i = 3; i <= n; i++)
            t[i % 3] = t[0] + t[1] + t[2];
        return t[n % 3];
    }
    #endregion

    #region 292 Nim Game
    /// <summary>
    /// Determines if you can win the Nim Game given a number of stones.
    /// </summary>
    /// <param name="n">The number of stones in the heap.</param>
    /// <returns>True if you can win the game assuming optimal play, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/nim-game/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public bool CanWinNim(int n)
        => n % 4 != 0;
    #endregion

    #region 263 Ugly Number
    /// <summary>
    /// Returns true if n is an ugly number.
    /// </summary>
    /// <param name="n">The input integer.</param>
    /// <returns>Boolean indicating if n is an ugly number.</returns>
    /// <link>https://leetcode.com/problems/ugly-number/</link>
    /// <time>O(n log n)</time>
    /// <space>O(1)</space>
    public bool IsUgly(int n)
    {
        if (n <= 0)
            return false;

        foreach (int prime in new int[] { 2, 3, 5 })
            while (n % prime == 0)
                n /= prime;

        return n == 1;
    }
    #endregion

    #region 2651 Calculate Delayed Arrival Time
    /// <summary>
    /// Returns the time when the train will arrive at the station after the delay.
    /// </summary>
    /// <param name="arrivalTime">The initial arrival time in hours (0-23).</param>
    /// <param name="delayedTime">The delay time in hours.</param>
    /// <returns>The adjusted arrival time in hours (0-23).</returns>
    /// <link>https://leetcode.com/problems/calculate-delayed-arrival-time/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        => (arrivalTime + delayedTime) % 24;
    #endregion

    #region 2864 Maximum Odd Binary Number
    /// <summary>
    /// Rearranges the binary string to form the maximum odd binary number.
    /// </summary>
    /// <param name="s">The input binary string.</param>
    /// <returns>The maximum odd binary number as a string.</returns>
    /// <link>https://leetcode.com/problems/maximum-odd-binary-number/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public string MaximumOddBinaryNumber(string s)
        => new string('1', s.Count(c => c == '1') - 1) + new string('0', s.Count(c => c == '0')) + '1';
    #endregion

    #region 1837 Sum of Digits in Base K
    /// <summary>
    /// Converts the number n from base 10 to base k and returns the sum of its digits.
    /// </summary>
    /// <param name="n">The number in base 10.</param>
    /// <param name="k">The base to convert the number to.</param>
    /// <returns>The sum of the digits of n in base k.</returns>
    /// <link>https://leetcode.com/problems/sum-of-digits-in-base-k/</link>
    /// <time>O(n log (n))</time>
    /// <space>O(n log (n))</space>
    public int SumBase(int n, int k)
        => n == 0 ? 0 : n % k + SumBase(n / k, k);
    #endregion

    #region 2413 Smallest Even Multiple
    /// <summary>
    /// Returns the smallest positive integer that is a multiple of both 2 and n.
    /// </summary>
    /// <param name="n">The given positive integer.</param>
    /// <returns>The smallest even multiple of n.</returns>
    /// <link>https://leetcode.com/problems/smallest-even-multiple/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public int SmallestEvenMultiple(int n)
        => n % 2 is 0 ? n : n * 2;
    #endregion

    #region 1025 Divisor Game
    /// <summary>
    /// Returns true if Alice wins(n is even), otherwise false.
    /// </summary>
    /// <param name="n">The starting number on the chalkboard.</param>
    /// <returns>True if Alice wins, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/divisor-game/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public bool DivisorGame(int n)
        => n % 2 == 0;
    #endregion

    #region 326 Power of Three
    /// <summary>
    /// Determines if a given integer is a power of three.
    /// </summary>
    /// <param name="n">The integer to check.</param>
    /// <returns>True if the number is a power of three, otherwise false.</returns>
    /// <remarks>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    /// </remarks>
    public bool IsPowerOfThree(int n)
        => n > 0 && (1162261467 % n).Equals(0);
    #endregion

    #region 2544 Alternating Digit Sum
    /// <summary>
    /// Calculates the alternating digit sum of a given positive integer.
    /// </summary>
    /// <param name="n">The input integer.</param>
    /// <returns>The alternating sum of the digits of n.</returns>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public int AlternateDigitSum(int n)
        => $"{n}".Select((c, i) => (i % 2 == 0 ? 1 : -1) * (c - 48)).Sum();
    #endregion

    #region 2652 Sum Multiples
    /// <summary>
    /// Finds the sum of all integers in the range [1, n] that are divisible by 3, 5, or 7.
    /// </summary>
    /// <param name="n">A positive integer.</param>
    /// <returns>The sum of all integers divisible by 3, 5, or 7 in the range [1, n].</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int SumOfMultiples(int n)
        => Enumerable.Range(1, n)
            .Where(x => x % 3 == 0 || x % 5 == 0 || x % 7 == 0)
            .Sum();
    #endregion

    #region 441 Arranging Coins
    /// <summary>
    /// Determines the number of complete rows of the staircase that can be built with n coins.
    /// </summary>
    /// <param name="n">The total number of coins.</param>
    /// <returns>The number of complete rows.</returns>
    /// <time>O(sqrt(n))</time>
    /// <space>O(1)</space>
    public int ArrangeCoins(int n)
    {
        int k = 0;

        while (n > k++)
            n -= k;

        return k - 1;
    }
    #endregion

    #region 2485 Find the Pivot Integer
    /// <summary>
    /// Finds the pivot integer x such that the sum of all integers from 1 to x
    /// equals the sum of all integers from x to n.
    /// </summary>
    /// <param name="n">A positive integer n.</param>
    /// <returns>The pivot integer x if it exists, otherwise -1.</returns>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public int PivotInteger(int n)
    {
        int sum = n * (n + 1) / 2;
        int x = (int)Math.Sqrt(sum);
        return x * x == sum ? x : -1;
    }
    #endregion

    #region 2525 Categorize Box According to Criteria
    /// <summary>
    /// Categorizes the box based on its dimensions and mass.
    /// </summary>
    /// <param name="length">The length of the box.</param>
    /// <param name="width">The width of the box.</param>
    /// <param name="height">The height of the box.</param>
    /// <param name="mass">The mass of the box.</param>
    /// <returns>A string representing the category of the box.</returns>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public string CategorizeBox(int length, int width, int height, int mass)
    {
        bool bulky = length >= 10000 || width >= 10000 || height >= 10000 || (long)length * width * height >= 1_000_000_000;
        bool heavy = mass >= 100;

        if (bulky && heavy) return "Both";
        if (bulky) return "Bulky";
        if (heavy) return "Heavy";
        return "Neither";
    }
    #endregion

    #region 258 Add Digits
    /// <summary>
    /// Repeatedly adds all digits of an integer until a single-digit result is obtained.
    /// </summary>
    /// <param name="num">The integer to process.</param>
    /// <returns>The resulting single-digit integer.</returns>
    /// <time>O(1)</time> 
    /// <space>O(1)</space>
    public int AddDigits(int num)
        => 1 + (num - 1) % 9;
    #endregion

    #region 1486 XOR Operation in an Array
    /// <summary>
    /// Calculates the bitwise XOR of all elements in an array where nums[i] = start + 2 * i.
    /// </summary>
    /// <param name="n">The length of the array.</param>
    /// <param name="start">The starting integer for calculating array elements.</param>
    /// <returns>The bitwise XOR of all elements in the array.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int XorOperation(int n, int start)
    {
        int result = 0;
        for (int i = 0; i < n; i++)
            result ^= start + 2 * i;
        return result;
    }
    #endregion
}