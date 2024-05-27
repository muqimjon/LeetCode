using EasyFundamental;

namespace EasyFundamentalTest;

public class ArraysTest
{
    // Arrange
    private readonly Arrays Solution = new();

    #region 1.TwoSum
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSum_ShouldReturnCorrectIndices(int[] nums, int target, int[] expected)
    {
        // Act
        var result = Solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 26.RemoveDuplicates
    [Theory]
    [InlineData(new[] { 1, 1, 2 }, 2, new[] { 1, 2 })]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new[] { 0, 1, 2, 3, 4 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, 1, new[] { 1 })]
    public void RemoveDuplicates_ShouldReturnCorrectResult(int[] nums, int expectedUniqueCount, int[] expectedArray)
    {
        // Act
        int resultUniqueCount = Solution.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expectedUniqueCount, resultUniqueCount);
        Assert.Equal(expectedArray, nums[0..resultUniqueCount]);
    }
    #endregion

    #region 27. Remove Element Tests
    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, 2, new[] { 2, 2 })]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new[] { 0, 1, 3, 0, 4 })]
    [InlineData(new[] { 5, 5, 5, 5, 5 }, 5, 0, new int[] { })]
    [InlineData(new int[] { }, 10, 0, new int[] { })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 6, 5, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, 1, 0, new int[] { })]
    public void RemoveElement_ShouldReturnCorrectResult(int[] nums, int val, int expectedLength, int[] expectedArray)
    {
        // Act
        int resultLength = Solution.RemoveElement(nums, val);

        // Assert
        Assert.Equal(expectedLength, resultLength);
        Assert.Equal(expectedArray, nums.Take(expectedLength));
    }
    #endregion

    #region 349. Intersection of Two Arrays
    [Theory]
    [InlineData(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2 })]
    [InlineData(new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9, 5 }, new[] { 9, 4 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new int[] { })]
    public void Intersection_ShouldReturnCorrectResult(int[] nums1, int[] nums2, int[] expected)
    {
        // Act
        var result = Solution.Intersection(nums1, nums2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 88. Merge Sorted Array
    [Theory]
    [InlineData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [InlineData(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]
    [InlineData(new[] { 4, 5, 6, 0, 0, 0 }, 3, new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3, 4, 5, 6 })]
    public void Merge_ShouldMergeArrays(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        // Act
        Solution.Merge(nums1, m, nums2, n);

        // Assert
        Assert.Equal(expected, nums1);
    }
    #endregion

    #region 1207. Unique Number of Occurrences
    [Theory]
    [InlineData(new[] { 1, 2, 2, 1, 1, 3 }, true)]
    [InlineData(new[] { 1, 2 }, false)]
    [InlineData(new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, true)]
    public void UniqueOccurrencesCheck_ShouldReturnCorrectResult(int[] arr, bool expected)
    {
        // Act
        var result = Solution.UniqueOccurrences(arr);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1672. Richest Customer Wealth
    [Theory]
    [InlineData(6, new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [InlineData(10, new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 })]
    [InlineData(17, new int[] { 2, 8, 7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 })]
    public void MaximumWealth_ShouldReturnCorrectResult(int expected, params int[][] accounts)
    {
        // Act
        var result = Solution.MaximumWealth(accounts);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 645. Set Mismatch
    [Theory]
    [InlineData(new[] { 2, 3 }, new[] { 1, 2, 2, 4 })]
    [InlineData(new[] { 1, 2 }, new[] { 1, 1 })]
    [InlineData(new[] { 2, 1 }, new[] { 2, 2 })]
    public void FindErrorNums_ShouldReturnCorrectResult(int[] expected, int[] nums)
    {
        // Act
        var result = Solution.FindErrorNums(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2133. Check if Every Row and Column Contains All Numbers
    [Theory]
    [InlineData(true, new[] { 1, 2, 3 }, new[] { 3, 1, 2 }, new[] { 2, 3, 1 })]
    [InlineData(false, new[] { 1, 1, 1 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    public void IsValidMatrix_ShouldReturnCorrectResult(bool expected, params int[][] matrix)
    {
        // Arrange & Act
        var result = Solution.CheckValid(matrix);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 35. Search Insert Position
    [Theory]
    [InlineData(2, new[] { 1, 3, 5, 6 }, 5)]
    [InlineData(1, new[] { 1, 3, 5, 6 }, 2)]
    [InlineData(4, new[] { 1, 3, 5, 6 }, 7)]
    [InlineData(0, new[] { 1, 3, 5, 6 }, 0)]
    public void SearchInsert_ShouldReturnCorrectPosition(int expected, int[] nums, int target)
    {
        // Arrange & Act
        var result = Solution.SearchInsert(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 455. Assign Cookies
    [Theory]
    [InlineData(1, new[] { 1, 2, 3 }, new[] { 1, 1 })]
    [InlineData(2, new[] { 1, 2 }, new[] { 1, 2, 3 })]
    [InlineData(3, new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [InlineData(0, new[] { 5, 10, 15 }, new[] { 1, 2, 3 })]
    [InlineData(2, new[] { 10, 9, 8, 7 }, new[] { 5, 6, 7, 8 })] // FAILED
    public void FindContentChildren_ShouldReturnCorrectNumber(int expected, int[] g, int[] s)
    {
        // Arrange & Act
        var result = Solution.FindContentChildren(g, s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1979. Find Greatest Common Divisor of Array
    [Theory]
    [InlineData(2, new[] { 2, 5, 6, 9, 10 })]
    [InlineData(1, new[] { 7, 5, 6, 8, 3 })]
    [InlineData(3, new[] { 3, 3 })]
    public void FindGCD_ShouldReturnCorrectNumber(int expected, int[] nums)
    {
        // Arrange & Act
        var result = Solution.FindGCD(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2855. Minimum Right Shifts to Sort the Array
    [Theory]
    [InlineData(2, new[] { 3, 4, 5, 1, 2 })]
    [InlineData(0, new[] { 1, 3, 5 })]
    [InlineData(-1, new[] { 2, 1, 4 })]
    public void MinRightShiftsToSort_ShouldReturnCorrectResult(int expected, int[] nums)
    {
        // Arrange & Act
        var result = Solution.MinimumRightShifts(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1275. Find Winner in Tic Tac Toe
    [Theory]
    [InlineData("A", new int[] { 0, 0 }, new int[] { 2, 0 }, new int[] { 1, 1 }, new int[] { 2, 1 }, new int[] { 2, 2 })]
    [InlineData("B", new int[] { 0, 0 }, new int[] { 1, 1 }, new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 0 }, new int[] { 2, 0 })]
    [InlineData("Draw", new int[] { 0, 0 }, new int[] { 1, 1 }, new int[] { 2, 0 }, new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 2, 1 }, new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 2, 2 })]
    public void TicTacToe_Test(string expected, params int[][] moves)
    {
        // Act
        var result = Solution.Tictactoe(moves);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2191. Find Kth Positive Number in the Sequence
    [Theory]
    [InlineData(new int[] { 7, 12, 9, 8, 9, 15 }, 4, 9)]
    [InlineData(new int[] { 2, 12, 1, 11, 4, 5 }, 6, 0)]
    [InlineData(new int[] { 10, 8, 5, 9, 11, 6, 8 }, 1, 15)]
    public void FindKOr_Test(int[] nums, int k, int expected)
    {
        // Act
        int result = Solution.FindKOr(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1491. Average Salary Excluding the Minimum and Maximum Salary
    [Theory]
    [InlineData(new int[] { 4000, 3000, 1000, 2000 }, 2500.0)]
    [InlineData(new int[] { 1000, 2000, 3000 }, 2000.0)]
    public void Average_ReturnsExpectedResult(int[] salary, double expected)
    {
        // Act
        double actual = Solution.Average(salary);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 169. Majority Element
    [Theory]
    [InlineData(new int[] { 3, 2, 3 }, 3)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void MajorityElement_WithValidInput_ReturnsCorrectResult(int[] nums, int expected)
    {
        // Act
        int result = Solution.MajorityElement(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2108. Find First Palindromic String in the Array
    [Theory]
    [InlineData(new string[] { "abc", "car", "ada", "racecar", "cool" }, "ada")]
    [InlineData(new string[] { "notapalindrome", "racecar" }, "racecar")]
    [InlineData(new string[] { "def", "ghi" }, "")]
    public void FirstPalindrome_ValidInput_ReturnsExpected(string[] words, string expected)
    {
        // Act
        string result = Solution.FirstPalindrome(words);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 118. Pascal's Triangle
    [Theory]
    [InlineData(1, new int[] { 1 })]
    [InlineData(2, new int[] { 1 }, new int[] { 1, 1 })]
    [InlineData(3, new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 })]
    [InlineData(5, new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 1, 3, 3, 1 }, new int[] { 1, 4, 6, 4, 1 })]
    public void Generate_Test(int numRows, params int[][] expected)
    {
        // Act
        IList<IList<int>> result = Solution.Generate(numRows);

        // Assert
        Assert.Equal(expected.Length, result.Count);
        for (int i = 0; i < expected.Length; i++)
            Assert.Equal(expected[i], result[i]);
    }
    #endregion

    #region 706. Binary Search
    [Theory]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    [InlineData(new[] { 1, 3, 5, 7, 9 }, 3, 1)]
    [InlineData(new[] { 1, 3, 5, 7, 9 }, 5, 2)]
    [InlineData(new[] { 1, 3, 5, 7, 9 }, 7, 3)]
    [InlineData(new[] { 1, 3, 5, 7, 9 }, 9, 4)]
    [InlineData(new[] { 2, 4, 6, 8, 10 }, 1, -1)]
    [InlineData(new[] { 2, 4, 6, 8, 10 }, 5, -1)]
    [InlineData(new[] { 2, 4, 6, 8, 10 }, 11, -1)]
    public void Search_WhenCalled_ReturnsExpectedIndex(int[] nums, int target, int expected)
    {
        // Act
        int result = Solution.Search(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1646. Get Maximum in Generated Array
    [Theory]
    [InlineData(7, 3)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(0, 0)]
    public void TestGetMaximumGenerated(int n, int expected)
    {
        // Act
        int result = Solution.GetMaximumGenerated(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2535. Difference Between Element Sum and Digit Sum of an Array
    [Theory]
    [InlineData(new int[] { 1, 15, 6, 3 }, 9)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 0)]
    [InlineData(new int[] { 9, 99, 999 }, 1053)]
    [InlineData(new int[] { 123, 456, 789 }, 1323)]
    [InlineData(new int[] { 10, 4, 4, 7, 7, 1, 5, 8, 3, 5 }, 9)] // FAIL
    public void DifferenceOfSum_Test(int[] nums, int expected)
    {
        // Act
        var result = Solution.DifferenceOfSum(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2788. Split Strings by Separator
    [Theory]
    [InlineData(new string[] { "one.two.three", "four.five", "six" }, '.', new string[] { "one", "two", "three", "four", "five", "six" })]
    [InlineData(new string[] { "$easy$", "$problem$" }, '$', new string[] { "easy", "problem" })]
    [InlineData(new string[] { "|||" }, '|', new string[] { })]
    public void ExampleTests(string[] words, char separator, string[] expected)
    {
        // Act
        var result = Solution.SplitWordsBySeparator(words, separator);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 231. Power of Two
    [Theory]
    [InlineData(1, true)]
    [InlineData(16, true)]
    [InlineData(3, false)]
    [InlineData(0, false)]
    [InlineData(-16, false)]
    public void IsPowerOfTwo_Test(int n, bool expected)
    {
        // Act
        bool result = Solution.IsPowerOfTwo(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 268. Missing Number
    [Theory]
    [InlineData(new int[] { 3, 0, 1 }, 2)]
    [InlineData(new int[] { 0, 1 }, 2)]
    [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    public void MissingNumber_ValidInput_ReturnsMissingNumber(int[] nums, int expected)
    {
        // Act
        int result = Solution.MissingNumber(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1502. Can Make Arithmetic Progression From Sequence
    [Theory]
    [InlineData(new int[] { 3, 5, 1 }, true)]
    [InlineData(new int[] { 1, 2, 4 }, false)]
    public void CanMakeArithmeticProgression_FromSequence_Test(int[] arr, bool expected)
    {
        // Act
        bool actual = Solution.CanMakeArithmeticProgression(arr);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 2248. Intersection of Multiple Arrays

    [Theory]
    [InlineData(new int[] { 3, 4 }, new int[] { 3, 1, 2, 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 5, 6 })]
    [InlineData(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 })]
    public void IntersectionOfMultipleArrays_ValidInput_ReturnsCommonElements(int[] expected, params int[][] nums)
    {
        // Act
        IList<int> result = Solution.Intersection(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 977. Squares of a Sorted Array
    [Theory]
    [InlineData(new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 })]
    [InlineData(new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 })]
    [InlineData(new[] { -5, -4, -3, -2, -1 }, new[] { 1, 4, 9, 16, 25 })]
    public void SortedSquares_ValidInput_ReturnsSortedSquares(int[] nums, int[] expected)
    {
        // Act
        var result = Solution.SortedSquares(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1929. Concatenation of Array
    [Theory]
    [InlineData(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 1, 2, 1 })]
    [InlineData(new[] { 1, 3, 2, 1 }, new[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
    [InlineData(new[] { 5, 10, 15 }, new[] { 5, 10, 15, 5, 10, 15 })]
    public void GetConcatenation_WithValidInput_ReturnsExpectedResult(int[] nums, int[] expected)
    {
        // Act
        var result = Solution.GetConcatenation(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 744. Find Smallest Letter Greater Than Target
    [Theory]
    [InlineData(new char[] { 'c', 'f', 'j' }, 'a', 'c')]
    [InlineData(new char[] { 'c', 'f', 'j' }, 'c', 'f')]
    [InlineData(new char[] { 'x', 'x', 'y', 'y' }, 'z', 'x')]
    public void NextGreatestLetter_WithTestData_ReturnsExpectedResult(char[] letters, char target, char expected)
    {
        // Act
        char result = Solution.NextGreatestLetter(letters, target);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 3000. Maximum Area of Longest Diogonal Rectangle
    [Theory]
    [InlineData(48, new int[] { 9, 3 }, new int[] { 8, 6 })]
    [InlineData(12, new int[] { 3, 4 }, new int[] { 4, 3 })]
    [InlineData(80, new int[] { 4, 10 }, new int[] { 4, 9 }, new int[] { 9, 3 }, new int[] { 10, 8 })]
    [InlineData(2028,
    new int[] { 4, 7 }, new int[] { 8, 9 }, new int[] { 5, 3 }, new int[] { 6, 10 }, new int[] { 2, 9 },
    new int[] { 3, 10 }, new int[] { 2, 2 }, new int[] { 5, 8 }, new int[] { 5, 10 }, new int[] { 5, 6 },
    new int[] { 8, 9 }, new int[] { 10, 7 }, new int[] { 8, 9 }, new int[] { 3, 7 }, new int[] { 2, 6 },
    new int[] { 5, 1 }, new int[] { 7, 4 }, new int[] { 1, 10 }, new int[] { 1, 7 }, new int[] { 6, 9 },
    new int[] { 3, 3 }, new int[] { 4, 6 }, new int[] { 8, 2 }, new int[] { 10, 6 }, new int[] { 7, 9 },
    new int[] { 9, 2 }, new int[] { 1, 2 }, new int[] { 3, 8 }, new int[] { 10, 2 }, new int[] { 4, 1 },
    new int[] { 9, 7 }, new int[] { 10, 3 }, new int[] { 6, 9 }, new int[] { 9, 8 }, new int[] { 7, 7 },
    new int[] { 5, 7 }, new int[] { 5, 4 }, new int[] { 6, 5 }, new int[] { 1, 8 }, new int[] { 2, 3 },
    new int[] { 7, 10 }, new int[] { 3, 9 }, new int[] { 5, 7 }, new int[] { 2, 4 }, new int[] { 5, 6 },
    new int[] { 9, 5 }, new int[] { 8, 8 }, new int[] { 8, 10 }, new int[] { 6, 8 }, new int[] { 5, 1 },
    new int[] { 10, 8 }, new int[] { 7, 4 }, new int[] { 2, 1 }, new int[] { 2, 7 }, new int[] { 10, 3 },
    new int[] { 2, 5 }, new int[] { 7, 6 }, new int[] { 10, 5 }, new int[] { 10, 9 }, new int[] { 5, 7 },
    new int[] { 10, 6 }, new int[] { 4, 3 }, new int[] { 10, 4 }, new int[] { 1, 5 }, new int[] { 8, 9 },
    new int[] { 3, 1 }, new int[] { 2, 5 }, new int[] { 9, 10 }, new int[] { 6, 6 }, new int[] { 5, 10 },
    new int[] { 10, 2 }, new int[] { 6, 10 }, new int[] { 1, 1 }, new int[] { 8, 6 }, new int[] { 1, 7 },
    new int[] { 6, 3 }, new int[] { 9, 3 }, new int[] { 1, 4 }, new int[] { 1, 1 }, new int[] { 10, 4 },
    new int[] { 7, 9 }, new int[] { 4, 5 }, new int[] { 2, 8 }, new int[] { 7, 9 }, new int[] { 7, 3 },
    new int[] { 4, 9 }, new int[] { 2, 8 }, new int[] { 4, 6 }, new int[] { 9, 1 }, new int[] { 8, 4 },
    new int[] { 2, 4 }, new int[] { 7, 8 }, new int[] { 3, 5 }, new int[] { 7, 6 }, new int[] { 8, 6 },
    new int[] { 4, 7 }, new int[] { 25, 60 }, new int[] { 39, 52 }, new int[] { 16, 63 }, new int[] { 33, 56 }
    )] // FAILED
    public void MaximalRectangleArea_Test(int expected, params int[][] dimensions)
    {
        // Act
        int result = Solution.AreaOfMaxDiagonal(dimensions);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 3024. Type of Triangle
    [Theory]
    [InlineData("equilateral", new int[] { 3, 3, 3 })]
    [InlineData("scalene", new int[] { 3, 4, 5 })]
    [InlineData("isosceles", new int[] { 5, 5, 3 })]
    [InlineData("none", new int[] { 1, 2, 3 })]
    public void TriangleType_Test(string expected, int[] nums)
    {
        // Act
        string result = Solution.TriangleType(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1816. Truncate Sentence
    [Theory]
    [InlineData("Hello how are you Contestant", 4, "Hello how are you")]
    [InlineData("What is the solution to this problem", 4, "What is the solution")]
    [InlineData("chopper is not a tanuki", 5, "chopper is not a tanuki")]
    public void TruncateSentence_Test(string s, int k, string expected)
    {
        // Act
        string result = Solution.TruncateSentence(s, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1636. Sort Array by Increasing Frequency
    [Theory]
    [InlineData(new[] { 1, 1, 2, 2, 2, 3 }, new[] { 3, 1, 1, 2, 2, 2 })]
    [InlineData(new[] { 2, 3, 1, 3, 2 }, new[] { 1, 3, 3, 2, 2 })]
    [InlineData(new[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }, new[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 })]
    public void FrequencySort_ValidInput_ReturnsSortedArray(int[] nums, int[] expected)
    {
        // Act
        var result = Solution.FrequencySort(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1480. Running Sum of 1d Array
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
    public void RunningSum_ValidInput_ReturnsExpectedResult(int[] nums, int[] expected)
    {
        // Act
        var result = Solution.RunningSum(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1662. Check If Two String Arrays are Equivalent
    [Theory]
    [InlineData(new string[] { "ab", "c" }, new string[] { "a", "bc" }, true)]
    [InlineData(new string[] { "a", "cb" }, new string[] { "ab", "c" }, false)]
    [InlineData(new string[] { "abc", "d", "defg" }, new string[] { "abcddefg" }, true)]
    public void ArrayStringsAreEqual_ShouldReturnExpectedResult(string[] word1, string[] word2, bool expected)
    {
        // Act
        bool result = Solution.ArrayStringsAreEqual(word1, word2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1460. Make Two Arrays Equal by Reversing Sub-arrays
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 1, 3 }, true)]
    [InlineData(new int[] { 7 }, new int[] { 7 }, true)]
    [InlineData(new int[] { 3, 7, 9 }, new int[] { 3, 7, 11 }, false)]
    [InlineData(new int[] { 1, 2, 2, 3 }, new int[] { 1, 1, 2, 3 }, false)] // FAILED
    public void CanBeEqual_Test(int[] target, int[] arr, bool expected)
    {
        // Act
        bool result = Solution.CanBeEqual(target, arr);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1437. Check If All 1's Are at Least Length K Places Away
    [Theory]
    [InlineData(new[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2, true)]
    [InlineData(new[] { 1, 0, 0, 1, 0, 1 }, 2, false)]
    [InlineData(new[] { 1, 0, 0, 0, 0, 1 }, 1, true)]
    [InlineData(new[] { 1, 0, 0, 0, 0, 1 }, 2, true)]
    [InlineData(new[] { 1, 0, 1, 0, 1, 0 }, 2, false)]
    public void TestKLengthApart(int[] nums, int k, bool expected)
    {
        // Act
        bool result = Solution.KLengthApart(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1920. Build Array from Permutation
    [Theory]
    [InlineData(new int[] { 0, 2, 1, 5, 3, 4 }, new int[] { 0, 1, 2, 4, 5, 3 })]
    [InlineData(new int[] { 5, 0, 1, 2, 3, 4 }, new int[] { 4, 5, 0, 1, 2, 3 })]
    public void TestBuildArrayFromPermutation(int[] nums, int[] expected)
    {
        // Act
        int[] result = Solution.BuildArray(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1464. Maximum Product of Two Elements in an Array
    [Theory]
    [InlineData(new int[] { 3, 4, 5, 2 }, 12)]
    [InlineData(new int[] { 1, 5, 4, 5 }, 16)]
    [InlineData(new int[] { 3, 7 }, 12)]
    public void MaxProduct_ShouldReturnCorrectResult(int[] nums, int expected)
    {
        // Act
        var result = Solution.MaxProduct(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2678. Number of Senior Citizens
    [Theory]
    [InlineData(new string[] { "7868190130M7522", "5303914400F9211", "9273338290F4010" }, 2)]
    [InlineData(new string[] { "1313579440F2036", "2921522980M5644" }, 0)]
    public void CountSeniorCitizens_ShouldReturnCorrectCount(string[] details, int expected)
    {
        // Act
        var result = Solution.CountSeniors(details);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1337. The K Weakest Rows in a Matrix
    [Theory]
    [InlineData(3, new int[] { 2, 0, 3 },
        new int[] { 1, 1, 0, 0, 0 },
        new int[] { 1, 1, 1, 1, 0 },
        new int[] { 1, 0, 0, 0, 0 },
        new int[] { 1, 1, 0, 0, 0 },
        new int[] { 1, 1, 1, 1, 1 })]
    [InlineData(2, new int[] { 0, 2 },
        new int[] { 1, 0, 0, 0 },
        new int[] { 1, 1, 1, 1 },
        new int[] { 1, 0, 0, 0 },
        new int[] { 1, 0, 0, 0 }
    )]
    public void KWeakestRows_WithValidInput_ReturnsExpectedResult(int k, int[] expected, params int[][] mat)
    {
        // Act
        var result = Solution.KWeakestRows(mat, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 205. Isomorphic Strings
    [Theory]
    [InlineData("egg", "add", true)]
    [InlineData("foo", "bar", false)]
    [InlineData("paper", "title", true)]
    [InlineData("ab", "aa", false)]
    public void IsIsomorphic_ReturnsExpectedResult(string s, string t, bool expected)
    {
        // Act
        bool actual = Solution.IsIsomorphic(s, t);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 2255. Count Prefixes of a Given String
    [Theory]
    [InlineData(new string[] { "a", "b", "c", "ab", "bc", "abc" }, "abc", 3)]
    [InlineData(new string[] { "a", "a" }, "aa", 2)]
    [InlineData(new string[] { "hello", "world", "hey" }, "hi", 0)]
    public void CountPrefixes_ShouldReturnCorrectCount(string[] words, string s, int expected)
    {
        // Act
        int actual = Solution.CountPrefixes(words, s);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 1550. Three Consecutive Odds

    [Theory]
    [InlineData(new int[] { 2, 6, 4, 1 }, false)]
    [InlineData(new int[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }, true)]
    [InlineData(new int[] { 1, 3, 5 }, true)] // Three consecutive odds at the end
    [InlineData(new int[] { 1, 2, 4 }, false)] // No consecutive odds
    [InlineData(new int[] { 1 }, false)] // Not enough elements
    public void HasThreeConsecutiveOdds_ShouldReturnExpected(int[] arr, bool expected)
    {
        // Arrange and Act
        bool result = Solution.ThreeConsecutiveOdds(arr);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1436. Destination City
    [Theory]
    [InlineData("Sao Paulo", new string[] { "London", "New York" }, new string[] { "New York", "Lima" }, new string[] { "Lima", "Sao Paulo" })]
    [InlineData("A", new string[] { "B", "C" }, new string[] { "D", "B" }, new string[] { "C", "A" })]
    [InlineData("Z", new string[] { "A", "Z" })]
    public void DestCity_ValidInput_ReturnsCorrectDestination(string expectedDestination, params string[][] paths)
    {
        // Arrange
        IList<IList<string>> pathList = [];
        foreach (var path in paths)
            pathList.Add(new List<string>(path));

        // Act
        string actualDestination = Solution.DestCity(pathList);

        // Assert
        Assert.Equal(expectedDestination, actualDestination);
    }
    #endregion

    #region 1710. Maximum Units on a Truck
    [Theory]
    [InlineData(4, 8, new[] { 1, 3 }, new[] { 2, 2 }, new[] { 3, 1 })]
    [InlineData(10, 91, new[] { 5, 10 }, new[] { 2, 5 }, new[] { 4, 7 }, new[] { 3, 9 })]
    public void MaximumUnits_ShouldReturnMaximumTotalUnits(int truckSize, int expected, params int[][] boxTypes)
    {
        // Act
        int actual = Solution.MaximumUnits(boxTypes, truckSize);

        // Assert
        Assert.Equal(expected, actual);
    }
    #endregion

    #region 1893. Check if All the Integers in a Range Are Covered
    [Theory]
    [InlineData(2, 5, true, new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 })]
    [InlineData(21, 21, false, new int[] { 1, 10 }, new int[] { 10, 20 })]
    [InlineData(11, 14, false, new int[] { 1, 10 }, new int[] { 15, 20 })]
    public void TestIsCovered(int left, int right, bool expectedResult, params int[][] ranges)
    {
        // Act
        bool result = Solution.IsCovered(ranges, left, right);

        // Assert
        Assert.Equal(expectedResult, result);
    }
    #endregion

    #region 1351. Count Negative Numbers in a Sorted Matrix
    [Theory]
    [InlineData(8, new int[] { 4, 3, 2, -1 }, new int[] { 3, 2, 1, -1 }, new int[] { 1, 1, -1, -2 }, new int[] { -1, -1, -2, -3 })]
    [InlineData(0, new int[] { 3, 2 }, new int[] { 1, 0 })]
    public void TestCountNegatives(int expected, params int[][] grid)
    {
        // Act
        int result = Solution.CountNegatives(grid);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2706. Buy Two Chocolates
    [Theory]
    [InlineData(new int[] { 1, 2, 2 }, 3, 0)]
    [InlineData(new int[] { 3, 2, 3 }, 3, 3)]
    public void TestBuyChoco(int[] prices, int money, int expected)
    {
        // Act
        int result = Solution.BuyChoco(prices, money);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2011. Final Value of Variable After Performing Operations
    [Theory]
    [InlineData(new string[] { "--X", "X++", "X++" }, 1)]
    [InlineData(new string[] { "++X", "++X", "X++" }, 3)]
    [InlineData(new string[] { "X++", "++X", "--X", "X--" }, 0)]
    public void FinalValueAfterOperations_ShouldReturnCorrectValue(string[] operations, int expected)
    {
        // Act
        int result = Solution.FinalValueAfterOperations(operations);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2465. Number of Distinct Averages
    [Theory]
    [InlineData(new int[] { 4, 1, 4, 0, 3, 5 }, 2)]
    [InlineData(new int[] { 1, 100 }, 1)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 1)]
    public void DistinctAverages_ValidInput_ReturnsCorrectCount(int[] nums, int expected)
    {
        // Act
        int result = Solution.DistinctAverages(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2974. Minimum Number Game
    [Theory]
    [InlineData(new int[] { 5, 4, 2, 3 }, new int[] { 3, 2, 5, 4 })]
    [InlineData(new int[] { 2, 5 }, new int[] { 5, 2 })]
    public void TestNumberGame(int[] nums, int[] expected)
    {
        // Act
        var result = Solution.NumberGame(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2341. Maximum Number of Pairs in Array
    [Theory]
    [InlineData(new int[] { 1, 3, 2, 1, 3, 2, 2 }, new int[] { 3, 1 })]
    [InlineData(new int[] { 1, 1 }, new int[] { 1, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0, 1 })]
    public void TestNumberOfPairs(int[] nums, int[] expected)
    {
        // Act
        var result = Solution.NumberOfPairs(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 941. Valid Mountain Array
    [Theory]
    [InlineData(new int[] { 2, 1 }, false)]
    [InlineData(new int[] { 3, 5, 5 }, false)]
    [InlineData(new int[] { 0, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, false)]
    public void TestIsValidMountainArray(int[] arr, bool expected)
    {
        // Act
        bool result = Solution.ValidMountainArray(arr);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1408. String Matching in an Array
    [Theory]
    [InlineData(new string[] { "mass", "as", "hero", "superhero" }, new string[] { "as", "hero" })]
    [InlineData(new string[] { "leetcode", "et", "code" }, new string[] { "et", "code" })]
    [InlineData(new string[] { "blue", "green", "bu" }, new string[] { })]
    public void TestStringMatching(string[] words, string[] expected)
    {
        // Act
        IList<string> result = Solution.StringMatching(words);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2073. Time Needed to Buy Tickets
    [Theory]
    [InlineData(new int[] { 2, 3, 2 }, 2, 6)]
    [InlineData(new int[] { 5, 1, 1, 1 }, 0, 8)]
    [InlineData(new int[] { 84, 49, 5, 24, 70, 77, 87, 8 }, 3, 154)] //FAILED
    public void TestTimeToBuyTickets(int[] tickets, int k, int expected)
    {
        // Act
        int result = Solution.TimeRequiredToBuy(tickets, k);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1512. Number of Good Pairs
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1, 1, 3 }, 4)]
    [InlineData(new int[] { 1, 1, 1, 1 }, 6)]
    [InlineData(new int[] { 1, 2, 3 }, 0)]
    public void TestNumIdenticalPairs(int[] nums, int expected)
    {
        // Act
        int result = Solution.NumIdenticalPairs(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2824. Count Pairs Whose Sum is Less than Target
    [Theory]
    [InlineData(new int[] { -1, 1, 2, 3, 1 }, 2, 3)]
    [InlineData(new int[] { -6, 2, 5, -2, -7, -1, 3 }, -2, 10)]
    public void TestCountPairs(int[] nums, int target, int expected)
    {
        // Act
        int result = Solution.CountPairs(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2446. Determine if Two Events Have Conflict
    [Theory]
    [InlineData(new string[] { "01:15", "02:00" }, new string[] { "02:00", "03:00" }, true)]
    [InlineData(new string[] { "01:00", "02:00" }, new string[] { "01:20", "03:00" }, true)]
    [InlineData(new string[] { "10:00", "11:00" }, new string[] { "14:00", "15:00" }, false)]
    public void TestDetermineIfTwoEventsHaveConflict(string[] event1, string[] event2, bool expected)
    {
        // Act
        bool result = Solution.HaveConflict(event1, event2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region Form Smallest Number From Two Digit Arrays
    [Theory]
    [InlineData(new int[] { 4, 1, 3 }, new int[] { 5, 7 }, 15)]
    [InlineData(new int[] { 3, 5, 2, 6 }, new int[] { 3, 1, 7 }, 3)]
    public void TestFormSmallestNumber(int[] nums1, int[] nums2, int expected)
    {
        // Act
        int result = Solution.MinNumber(nums1, nums2);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region Check if a String Is an Acronym of Words
    [Theory]
    [InlineData(new string[] { "alice", "bob", "charlie" }, "abc", true)]
    [InlineData(new string[] { "an", "apple" }, "a", false)]
    [InlineData(new string[] { "never", "gonna", "give", "up", "on", "you" }, "ngguoy", true)]
    public void TestIsAcronym(string[] words, string s, bool expected)
    {
        // Act
        bool result = Solution.IsAcronym(words, s);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region Row With Maximum Ones
    [Theory]
    [InlineData(new int[] { 0, 1 }, new int[] { 0, 1 }, new int[] { 1, 0 })]
    [InlineData(new int[] { 1, 2 }, new int[] { 0, 0, 0 }, new int[] { 0, 1, 1 })]
    [InlineData(new int[] { 1, 2 }, new int[] { 0, 0 }, new int[] { 1, 1 }, new int[] { 0, 0 })]
    [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 })] //FAILED
    public void TestMaxOnesRow(int[] expected, params int[][] mat)
    {
        // Act
        int[] result = Solution.RowAndMaximumOnes(mat);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region Points That Intersect With Cars
    [Theory]
    [InlineData(7,  new int[] { 3, 6 }, new int[] { 1, 5 }, new int[] { 4, 7 })]
    [InlineData(7, new int[] { 1, 3 }, new int[] { 5, 8 })]
    public void TestIntersectingPoints(int expected, params int[][] nums)
    {
        // Act
        int result = Solution.NumberOfPoints(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 628. Maximum Product of Three Numbers
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 6)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 24)]
    [InlineData(new int[] { -1, -2, -3 }, -6)]
    [InlineData(new int[] { -10, -10, 5, 2 }, 500)]
    public void MaximumProductTests(int[] nums, int expected)
    {
        // Act
        int result = Solution.MaximumProduct(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 2057. Smallest Index With Equal Value
    [Theory]
    [InlineData(new int[] { 0, 1, 2 }, 0)]
    [InlineData(new int[] { 4, 3, 2, 1 }, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, -1)]
    [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new int[] { 10, 1, 20, 3, 30, 5, 40, 7, 50, 9 }, 1)]
    public void SmallestEqualTests(int[] nums, int expected)
    {
        // Act
        int result = Solution.SmallestEqual(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1089. Duplicate Zeros
    [Theory]
    [InlineData(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0 })]
    [InlineData(new int[] { 8, 4, 5, 0, 0, 0, 0, 7 }, new int[] { 8, 4, 5, 0, 0, 0, 0, 0 })]
    public void DuplicateZerosTests(int[] arr, int[] expected)
    {
        // Act
        Solution.DuplicateZeros(arr);

        // Assert
        Assert.Equal(expected, arr);
    }
    #endregion

    #region 2549. Count Distinct Numbers on Board
    [Theory]
    [InlineData(5, 4)]
    [InlineData(3, 2)]
    [InlineData(1, 1)] //FAILED
    public void TestDistinctNumbers(int n, int expected)
    {
        // Act
        int result = Solution.DistinctIntegers(n);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion

    #region 1365. How Many Numbers Are Smaller Than the Current Number
    [Theory]
    [InlineData(new int[] { 8, 1, 2, 2, 3 }, new int[] { 4, 0, 1, 1, 3 })]
    [InlineData(new int[] { 6, 5, 4, 8 }, new int[] { 2, 1, 0, 3 })]
    [InlineData(new int[] { 7, 7, 7, 7 }, new int[] { 0, 0, 0, 0 })]
    public void TestSmallerNumbersThanCurrent(int[] nums, int[] expected)
    {
        // Act
        int[] result = Solution.SmallerNumbersThanCurrent(nums);

        // Assert
        Assert.Equal(expected, result);
    }
    #endregion
}