namespace FundamentalEasy.Test;

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
}