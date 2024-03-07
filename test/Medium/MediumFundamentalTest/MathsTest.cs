using MediumFundamental;

namespace MediumFundamentalTest;

public class MathsTest
{
    // Arrange
    private readonly Maths Solution = new();

    #region 50. Pow(x, n)
    [Theory]
    [InlineData(2.00000, 10, 1024.00000)]
    [InlineData(2.10000, 3, 9.26100)]
    [InlineData(2.00000, -2, 0.25000)]
    public void Test_Pow(double x, int n, double expected)
    {
        // Act
        double result = Solution.MyPow(x, n);

        // Assert
        Assert.Equal(expected, result, 5); // using 5 digits precision for comparison
    }
    #endregion
}
