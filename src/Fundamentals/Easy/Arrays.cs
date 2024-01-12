namespace Easy;

public class Arrays
{
    #region 1.TwoSum
    /// <summary>
    /// 1. Two Sum
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
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
    /// <returns></returns>
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
    /// <returns></returns>0
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
    /// <time>Runtime: O(m + n)</time>
    /// <space>Memory: O(1)</space>
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int k = m + n - 1;
        m--;
        n--;

        while (m >= 0 && n >= 0)
            nums1[k--] = (nums1[m] >= nums2[n]) ? nums1[m--] : nums2[n--];

        while (n >= 0)
            nums1[k--] = nums2[n--];
    }
    #endregion
}