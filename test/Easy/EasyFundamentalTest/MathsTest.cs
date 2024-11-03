using EasyFundamental;

namespace EasyFundamentalTest;

public class MathsTest
{
    // Arrange
    private readonly Maths Solution = new();

    #region 9 Palindrome Number
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(12321, true)]
    [InlineData(12345, false)]
    public void IsPalindrome_ShouldReturnCorrectResult(int x, bool expected)
    {
        // Act
        var result = Solution.IsPalindrome(x);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 70 Climbing Stairs
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    [InlineData(6, 13)]
    [InlineData(43, 701408733)]
    [InlineData(45, 1836311903)]
    public void ClimbStairs_ShouldReturnCorrectResult(int n, int expected)
    {
        // Act
        int result = Solution.ClimbStairs(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 168 Excel Sheet Column Title
    [Theory]
    [InlineData(1, "A")]
    [InlineData(28, "AB")]
    [InlineData(701, "ZY")]
    public void ConvertToTitle_ShouldReturnCorrectResult(int columnNumber, string expected)
    {
        // Act
        var result = Solution.ConvertToTitle(columnNumber);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 190 Reverse Bits
    [Theory]
    [InlineData(0b00000010100101000001111010011100U, 964176192U)]
    [InlineData(0b11111111111111111111111111111101U, 3221225471U)]
    public void ReverseBits_ShouldReturnCorrectResult(uint n, uint expected)
    {
        // Act
        uint result = Solution.ReverseBits(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1185 Day of the Week
    [Theory]
    [InlineData(31, 8, 2019, "Saturday")]
    [InlineData(18, 7, 1999, "Sunday")]
    [InlineData(15, 8, 1993, "Sunday")]
    public void DayOfTheWeek_ReturnsCorrectDay(int day, int month, int year, string expected)
    {
        // Act
        var actual = Solution.DayOfTheWeek(day, month, year);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 1360 Number of Days Between Two Dates
    [Theory]
    [InlineData("2019-06-29", "2019-06-30", 1)]
    [InlineData("2020-01-15", "2019-12-31", 15)]
    public void DaysBetweenDates_InlineData_ReturnsCorrectResult(string date1, string date2, int expected)
    {
        // Act
        int result = Solution.DaysBetweenDates(date1, date2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2520 Count the Digits That Divide a Number
    [Theory]
    [InlineData(7, 1)]
    [InlineData(121, 2)]
    [InlineData(1248, 4)]
    public void CountDigits_Test(int num, int expected)
    {
        // Act
        int result = Solution.CountDigits(num);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 507 Perfect Number
    [Theory]
    [InlineData(28, true)]
    [InlineData(7, false)]
    [InlineData(6, true)]
    [InlineData(496, true)]
    [InlineData(8128, true)]
    [InlineData(8127, false)]
    public void CheckPerfectNumber_Test(int num, bool expected)
    {
        // Act
        bool result = Solution.CheckPerfectNumber(num);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 412 Fizz Buzz
    [Theory]
    [InlineData(1, new string[] { "1" })]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuzz_ShouldReturnExpectedOutput(int n, string[] expected)
    {
        // Act
        IList<string> result = Solution.FizzBuzz(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 492 Construct the Rectangle
    [Theory]
    [InlineData(4, new int[] { 2, 2 })]
    [InlineData(37, new int[] { 37, 1 })]
    [InlineData(122122, new int[] { 427, 286 })]
    public void ConstructRectangle_ValidInput_ReturnsExpected(int area, int[] expected)
    {
        // Act
        int[] actual = Solution.ConstructRectangle(area);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 1154 Day of the Year
    [Theory]
    [InlineData("2019-01-09", 9)]
    [InlineData("2019-02-10", 41)]
    [InlineData("2022-12-31", 365)]
    [InlineData("2020-02-29", 60)]
    public void TestDayOfYear(string date, int expected)
    {
        // Act
        int result = Solution.DayOfYear(date);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 504 Base 7
    [Theory]
    [InlineData(100, "202")]
    [InlineData(-7, "-10")]
    [InlineData(0, "0")]
    public void ConvertToBase7_ShouldReturnCorrectBase7Representation(int num, string expected)
    {
        // Act
        string base7String = Solution.ConvertToBase7(num);

        // Assert
        Assert.Equal(expected, base7String);
    }
    #endregion

    #region 1323 Maximum 69 Number
    [Theory]
    [InlineData(9669, 9969)] // Changing the second digit from 6 to 9
    [InlineData(9996, 9999)] // Changing the last digit from 6 to 9
    [InlineData(9999, 9999)] // No change needed
    [InlineData(6666, 9666)] // Changing the first digit from 6 to 9
    [InlineData(6699, 9699)] // Changing the second digit from 6 to 9
    public void TestMaximum69Number(int num, int expected)
    {
        // Act
        int result = Solution.Maximum69Number(num);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1523 Count Odd Numbers in an Interval Range
    [Theory]
    [InlineData(3, 7, 3)]
    [InlineData(2, 8, 3)]
    [InlineData(1, 10, 5)]
    [InlineData(0, 6, 3)]
    public void CountOdds_Returns_CorrectCount(int low, int high, int expected)
    {
        // Act
        int actual = Solution.CountOdds(low, high);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 1716 Calculate Money in Leetcode Bank
    [Theory]
    [InlineData(4, 10)]
    [InlineData(10, 37)]
    [InlineData(20, 96)]
    public void TestCalculateMoneyInLeetCodeBank(int n, int expected)
    {
        // Act
        int result = Solution.TotalMoney(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2769 Find the Maximum Achievable Number
    [Theory]
    [InlineData(4, 1, 6)]
    [InlineData(3, 2, 7)]
    public void TestMaximumAchievableNumber(int num, int t, int expected)
    {
        // Act
        int result = Solution.TheMaximumAchievableX(num, t);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1688 Count of Matches in Tournament
    [Theory]
    [InlineData(7, 6)]
    [InlineData(14, 13)]
    public void TestCountMatches(int n, int expected)
    {
        // Act
        int result = Solution.NumberOfMatches(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2427 Number of Common Factors
    [Theory]
    [InlineData(12, 6, 4)]
    [InlineData(25, 30, 2)]
    [InlineData(17, 23, 1)]
    public void TestCommonFactors(int a, int b, int expected)
    {
        // Act
        int result = Solution.CommonFactors(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2600 K Items With the Maximum Sum
    [Theory]
    [InlineData(3, 2, 0, 2, 2)]
    [InlineData(3, 2, 0, 4, 3)]
    [InlineData(6, 6, 6, 13, 5)] //FAILED
    public void TestMaxSumWithKItems(int numOnes, int numZeros, int numNegOnes, int k, int expected)
    {
        // Act
        int result = Solution.KItemsWithMaximumSum(numOnes, numZeros, numNegOnes, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2894 Divisible and Non-divisible Sums Difference
    [Theory]
    [InlineData(10, 3, 19)]
    [InlineData(5, 6, 15)]
    [InlineData(5, 1, -15)]
    public void TestDivisibleAndNonDivisibleSumsDifference(int n, int m, int expected)
    {
        // Act
        int result = Solution.DifferenceOfSums(n, m);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 273 Number of Steps to Reduce a Number to Zero
    [Theory]
    [InlineData(14, 6)]
    [InlineData(8, 4)]
    [InlineData(123, 12)]
    public void TestReduceNumberToZero(int num, int expected)
    {
        // Act
        int result = Solution.NumberOfSteps(num);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region Count Integers With Even Digit Sum
    [Theory]
    [InlineData(4, 2)]
    [InlineData(30, 14)]
    public void TestCountIntegersWithEvenDigitSum(int num, int expected)
    {
        // Act
        int result = Solution.CountEven(num);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 728 Self Dividing Numbers
    [Theory]
    [InlineData(1, 22, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 })]
    [InlineData(47, 85, new int[] { 48, 55, 66, 77 })]
    public void TestSelfDividingNumbers(int left, int right, int[] expected)
    {
        // Act
        IList<int> result = Solution.SelfDividingNumbers(left, right);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 509 Fibonacci Number
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    public void TestFib(int n, int expected)
    {
        // Act
        int result = Solution.Fib(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2582 Pass the Pillow
    [Theory]
    [InlineData(4, 5, 2)]
    [InlineData(3, 2, 3)]
    public void TestPassThePillow(int n, int time, int expected)
    {
        // Act
        int result = Solution.PassThePillow(n, time);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2469 Convert the Temperature
    [Theory]
    [InlineData(36.50, 309.65000, 97.70000)]
    [InlineData(122.11, 395.26000, 251.79800)]
    public void TestConvertTemperature(double celsius, double expectedKelvin, double expectedFahrenheit)
    {
        // Act
        double[] result = Solution.ConvertTemperature(celsius);

        // Assert
        Assert.Equal(expectedKelvin, result[0], 5);
        Assert.Equal(expectedFahrenheit, result[1], 5);
    }
    #endregion

    #region 2160 Minimum Sum of Four Digit Number After Splitting Digits
    [Theory]
    [InlineData(2932, 52)]
    [InlineData(4009, 13)]
    public void TestMinimumSum(int num, int expected)
    {
        // Act
        int result = Solution.MinimumSum(num);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 342 Power of Four
    [Theory]
    [InlineData(16, true)]
    [InlineData(5, false)]
    [InlineData(1, true)]
    public void TestIsPowerOfFour(int n, bool expected)
    {
        // Act
        bool result = Solution.IsPowerOfFour(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1281 Subtract the Product and Sum of Digits of an Integer
    [Theory]
    [InlineData(234, 15)]
    [InlineData(4421, 21)]
    public void TestSubtractProductAndSum(int n, int expected)
    {
        // Act
        int result = Solution.SubtractProductAndSum(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2481 Minimum Cuts to Divide a Circle
    [Theory]
    [InlineData(4, 2)]
    [InlineData(3, 3)]
    public void TestMinimumCutsToDivideCircle(int n, int expected)
    {
        // Act
        int result = Solution.NumberOfCuts(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1137 N-th Tribonacci Number
    [Theory]
    [InlineData(4, 4)]
    [InlineData(25, 1389537)]
    public void TestNthTribonacciNumber(int n, int expected)
    {
        // Act
        int result = Solution.Tribonacci(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 292 Nim Game
    [Theory]
    [InlineData(4, false)]
    [InlineData(1, true)]
    [InlineData(2, true)]
    public void TestNimGame(int n, bool expected)
    {
        // Act
        bool result = Solution.CanWinNim(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 263 Ugly Number
    [Theory]
    [InlineData(6, true)]
    [InlineData(1, true)]
    [InlineData(14, false)]
    public void TestIsUgly(int n, bool expected)
    {
        // Act
        bool result = Solution.IsUgly(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2651 Calculate Delayed Arrival Time
    [Theory]
    [InlineData(15, 5, 20)]
    [InlineData(13, 11, 0)]
    public void TestCalculateDelayedArrivalTime(int arrivalTime, int delayedTime, int expected)
    {
        // Act
        int result = Solution.FindDelayedArrivalTime(arrivalTime, delayedTime);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2864 Maximum Odd Binary Number
    [Theory]
    [InlineData("010", "001")]
    [InlineData("0101", "1001")]
    public void TestMaximumOddBinaryNumber(string s, string expected)
    {
        // Act
        string result = Solution.MaximumOddBinaryNumber(s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1837 Sum of Digits in Base K Tests
    [Theory]
    [InlineData(34, 6, 9)]
    [InlineData(10, 10, 1)]
    public void TestSumBase(int n, int k, int expected)
    {
        // Act
        int result = Solution.SumBase(n, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2413 Smallest Even Multiple
    [Theory]
    [InlineData(5, 10)]
    [InlineData(6, 6)]
    public void TestSmallestEvenMultiple(int n, int expected)
    {
        // Act
        var result = Solution.SmallestEvenMultiple(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1025 Divisor Game
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    public void TestDivisorGame(int n, bool expected)
    {
        // Act
        var result = Solution.DivisorGame(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 326 Power of Three
    [Theory]
    [InlineData(27, true)]
    [InlineData(0, false)]
    [InlineData(-1, false)]
    public void TestIsPowerOfThree(int n, bool expected)
    {
        // Act
        var result = Solution.IsPowerOfThree(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2544 Alternating Digit Sum
    [Theory]
    [InlineData(521, 4)]
    [InlineData(111, 1)]
    [InlineData(886996, 0)]
    public void TestAlternatingDigitSum(int n, int expected)
    {
        // Act
        var result = Solution.AlternateDigitSum(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2652 Sum Multiples
    [Theory]
    [InlineData(21, 7)]
    [InlineData(40, 10)]
    [InlineData(30, 9)]
    public void TestSumMultiples(int expected, int n)
    {
        // Act
        var result = Solution.SumOfMultiples(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 441 Arranging Coins
    [Theory]
    [InlineData(2, 5)]
    [InlineData(3, 8)]
    public void TestArrangingCoins(int expected, int n)
    {
        // Act
        int result = Solution.ArrangeCoins(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2485 Find the Pivot Integer
    [Theory]
    [InlineData(6, 8)]
    [InlineData(1, 1)]
    [InlineData(-1, 4)]
    public void TestFindPivotInteger(int expected, int n)
    {
        // Act
        int result = Solution.PivotInteger(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2525 Categorize Box According to Criteria
    [Theory]
    [InlineData("Heavy", 1000, 35, 700, 300)]
    [InlineData("Neither", 200, 50, 800, 50)]
    public void TestCategorizeBox(string expected, int length, int width, int height, int mass)
    {
        // Act
        string result = Solution.CategorizeBox(length, width, height, mass);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 258 Add Digits
    [Theory]
    [InlineData(2, 38)]
    [InlineData(0, 0)]
    public void TestAddDigits(int expected, int num)
    {
        // Act
        var result = Solution.AddDigits(num);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1486 XOR Operation in an Array
    [Theory]
    [InlineData(8, 5, 0)]
    [InlineData(8, 4, 3)]
    public void TestXorOperationInArray(int expected, int n, int start)
    {
        // Act
        var result = Solution.XorOperation(n, start);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}
