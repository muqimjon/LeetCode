﻿namespace FundamentalEasy.Test;

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


}
