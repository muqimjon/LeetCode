using EasyFundamental;

namespace EasyFundamentalTest;

public class MathsTest
{
    // Arrange
    private readonly Maths Solution = new();

    #region 9. Palindrome Number
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

    #region 70. Climbing Stairs
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

    #region 168. Excel Sheet Column Title
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

    #region 190. Reverse Bits
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

    #region 1185. Day of the Week
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

    #region 1360. Number of Days Between Two Dates
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

    #region 2520. Count the Digits That Divide a Number
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

    #region 507. Perfect Number
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

    #region 412. Fizz Buzz
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

    #region 492. Construct the Rectangle
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

    #region 1154. Day of the Year
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

    #region 504. Base 7
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

    #region 1323. Maximum 69 Number
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

    #region 1523. Count Odd Numbers in an Interval Range
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

    #region 1716. Calculate Money in Leetcode Bank
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
}
