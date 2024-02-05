﻿namespace EasyFundamental;

public class Arrays
{
    #region 1.TwoSum
    /// <summary>
    /// 1. Two Sum
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <link>https://leetcode.com/problems/two-sum/</link>
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndexMap = [];
        for (int i = 0; i < nums.Length; ++i)
        {
            int complement = target - nums[i];
            if (numIndexMap.TryGetValue(complement, out int value))
                return [value, i];
            numIndexMap[nums[i]] = i;
        }
        return [];
    }
    #endregion

    #region 26.RemoveDuplicates
    /// <summary>
    /// 26. Remove Duplicates from Sorted Array
    /// </summary>
    /// <param name="nums"></param>
    /// <link>https://leetcode.com/problems/remove-duplicates-from-sorted-array/</link>
    public int RemoveDuplicates(int[] nums)
    {
        int uniqueCount = 1;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] != nums[i - 1])
                nums[uniqueCount++] = nums[i];

        return uniqueCount;
    }
    #endregion

    #region 27. Remove Element
    /// <summary>
    /// 27. Remove Element
    /// </summary>
    /// <param name="nums">Integer array</param>
    /// <param name="val">Value to remove</param>
    /// <returns>Number of elements in nums which are not equal to val</returns>
    /// <link>https://leetcode.com/problems/remove-element/</link>
    /// <time>Runtime: O(n) - Linear time complexity</time>
    /// <space>Memory: O(1) - Constant space complexity</space>
    public int RemoveElement(int[] nums, int val)
    {
        // Create a filtered list without the specified value
        var filteredList = nums.Where(i => i != val).ToList();

        // Initialize a counter for the elements without the specified value
        var counter = 0;

        // Iterate through the filtered list and update the original array
        for (; counter < filteredList.Count; ++counter)
        {
            nums[counter] = filteredList[counter];
        }

        // Return the number of elements without the specified value
        return counter;
    }
    #endregion

    #region 349. Intersection of Two Arrays
    /// <summary>
    /// 349. Intersection of Two Arrays
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="nums2"></param>
    /// <link>https://leetcode.com/problems/intersection-of-two-arrays/</link>
    /// <time>Runtime: O(n + m)</time>
    /// <space>Memory: O(min(n, m))</space>
    public int[] Intersection(int[] nums1, int[] nums2)
        => nums1.Join(nums2, num => num, num => num, (num1, num2) => num1)
                .Distinct()
                .ToArray();
    #endregion

    #region 88. Merge Sorted Array
    /// <summary>
    /// Merges two sorted arrays in non-decreasing order.
    /// </summary>
    /// <param name="nums1">First sorted array (length = m + n).</param>
    /// <param name="m">Number of elements in nums1.</param>
    /// <param name="nums2">Second sorted array (length = n).</param>
    /// <param name="n">Number of elements in nums2.</param>
    /// <link>https://leetcode.com/problems/merge-sorted-array/</link>
    /// <time>Runtime: O(m + n)</time>
    /// <space>Memory: O(1)</space>
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int k = m -- + n -- - 1;

        while (m >= 0 && n >= 0)
            nums1[k--] = (nums1[m] >= nums2[n]) ? nums1[m--] : nums2[n--];

        while (n >= 0)
            nums1[k--] = nums2[n--];
    }
    #endregion

    #region 1207. Unique Number of Occurrences
    /// <summary>
    /// Checks if the number of occurrences of each value in the array is unique.
    /// </summary>
    /// <param name="arr">Input array of integers.</param>
    /// <returns>True if occurrences are unique, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/unique-number-of-occurrences/</link>
    /// <time>Runtime: O(n)</time>
    /// <space>Memory: O(n)</space>
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (frequencyMap.TryGetValue(num, out int value))
                frequencyMap[num]++;
            else
                frequencyMap[num] = 1;
        }

        HashSet<int> occurrencesSet = new HashSet<int>();
        foreach (var frequency in frequencyMap.Values)
        {
            if (!occurrencesSet.Add(frequency))
                return false;
        }

        return true;
    }
    #endregion

    #region 1672. Richest Customer Wealth
    /// <summary>
    /// Calculates the wealth of the richest customer based on the given grid of bank accounts.
    /// </summary>
    /// <param name="accounts">m x n grid representing customer wealth in each bank.</param>
    /// <returns>Wealth of the richest customer.</returns>
    /// <link>https://leetcode.com/problems/richest-customer-wealth/</link>
    /// <time>Runtime: O(m * n)</time>
    /// <space>Memory: O(1)</space>
    public int MaximumWealth(int[][] accounts)
        => accounts.Select(e => e.Sum()).Max();
    #endregion

    #region 645. Set Mismatch
    /// <summary>
    /// Finds the duplicate and missing numbers in the given array after an error.
    /// </summary>
    /// <param name="nums">Input array.</param>
    /// <returns>Array containing the duplicate and missing numbers.</returns>
    /// <link>https://leetcode.com/problems/set-mismatch/</link>
    /// <time>Runtime: O(n)</time>
    /// <space>Memory: O(1)</space>
    public int[] FindErrorNums(int[] nums)
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
                nums[index] = -nums[index];
            else
                result[0] = Math.Abs(nums[i]);
        }

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] > 0)
            {
                result[1] = i + 1;
                break;
            }

        return result;
    }
    #endregion

    #region 2133. Check if Every Row and Column Consist of the Same Element
    /// <summary>
    /// Checks if the given matrix is valid, where every row and column contains all integers from 1 to n.
    /// </summary>
    /// <param name="matrix">The matrix to check.</param>
    /// <returns>True if the matrix is valid, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/</link>
    /// <time>Time Complexity: O(n^2)</time>
    /// <space>Space Complexity: O(n)</space>
    public bool CheckValid(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; ++i)
        {
            if (matrix.Length != new HashSet<int>(matrix[i]).Count)
                return false;

            HashSet<int> col = [];
            for (int j = 0; j < matrix.Length; ++j)
                if (!col.Add(matrix[j][i]))
                    return false;
        }
        return true;
    }
    #endregion

    #region 35. Search Insert Position
    /// <summary>
    /// Given a sorted array of distinct integers and a target value, return the index if the target is found.
    /// </summary>
    /// <param name="nums">The sorted array of distinct integers.</param>
    /// <param name="target">The target value to search for.</param>
    /// <returns>The index if the target is found; otherwise, the index where it would be inserted.</returns>
    /// <link>https://leetcode.com/problems/search-insert-position/</link>
    /// <time>Time Complexity: O(log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] < target) left = mid + 1;
            else right = mid - 1;
        }

        return left;
    }
    #endregion

    #region 455. Assign Cookies
    /// <summary>
    /// Maximize content children with cookies and greed factors.
    /// </summary>
    /// <param name="g">The array of children's greed factors.</param>
    /// <param name="s">The array of cookie sizes.</param>
    /// <returns>The maximum number of content children.</returns>
    /// <link>https://leetcode.com/problems/assign-cookies/</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int contentChildren = 0;

        for (int i = 0, j = 0; i < g.Length && j < s.Length; i++)
        {
            while (j < s.Length && s[j] < g[i])
                j++;

            if (j < s.Length)
            {
                contentChildren++;
                j++;
            }
        }

        return contentChildren;
    }
    #endregion

    #region 1979. Find Greatest Common Divisor of Array
    /// <summary>
    /// Find the greatest common divisor of the smallest and largest numbers in the array.
    /// </summary>
    /// <param name="nums">The integer array.</param>
    /// <returns>The greatest common divisor.</returns>
    /// <link>https://leetcode.com/problems/find-greatest-common-divisor-of-array/</link>
    /// <time>Time Complexity: O(log(minimum, maximum))</time>
    /// <space>Space Complexity: O(1)</space>
    public int FindGCD(int[] nums) => CalculateGCD(nums.Min(), nums.Max());

    private int CalculateGCD(int a, int b) => b == 0 ? Math.Abs(a) : CalculateGCD(b, a % b);
    #endregion

    #region 2855. Minimum Right Shifts to Sort the Array
    /// <summary>
    /// Returns the minimum number of right shifts required to sort the array, or -1 if it's not possible.
    /// </summary>
    /// <param name="nums">The list of distinct positive integers.</param>
    /// <returns>The minimum number of right shifts or -1 if not possible.</returns>
    /// <link>https://leetcode.com/problems/minimum-right-shifts-to-sort-the-array/</link>
    /// <time>Time Complexity: O(n^2)</time>
    /// <space>Space Complexity: O(n)</space>
    public int MinimumRightShifts(IList<int> nums)
    {
        var sortedNums = nums.OrderBy(x => x).ToList();

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums.SequenceEqual(sortedNums))
                return i;

            int last = nums[nums.Count - 1];

            for (int j = nums.Count - 1; j > 0; j--)
                nums[j] = nums[j - 1];

            nums[0] = last;
        }
        return -1;
    }
    #endregion
}