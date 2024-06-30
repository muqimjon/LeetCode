namespace MediumFundamental;

public class Arrays
{
    #region 931. Minimum Falling Path Sum
    /// <summary>
    /// Calculates the minimum falling path sum in the given matrix.
    /// </summary>
    /// <param name="matrix">The input matrix.</param>
    /// <returns>The minimum falling path sum.</returns>
    /// <time>Runtime: O(m * n)</time>
    /// <space>Memory: O(1)</space>
    public int MinFallingPathSum(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int row = 1; row < rows; row++)
            for (int col = 0; col < cols; col++)
                matrix[row][col] += Math.Min(matrix[row - 1][col], Math.Min(matrix[row - 1][Math.Max(0, col - 1)], matrix[row - 1][Math.Min(cols - 1, col + 1)]));

        return matrix[rows - 1].Min();
    }

    // detailed code
    //public int MinFallingPathSum(int[][] matrix)
    //{
    //    // Get the number of rows and columns in the matrix.
    //    int rows = matrix.Length;
    //    int cols = matrix[0].Length;

    //    // Iterate through the matrix starting from the second row.
    //    for (int r = 1; r < rows; r++)
    //    {
    //        for (int length = 0; length < cols; length++)
    //        {
    //            // Calculate the values from the upper row (left, middle, right).
    //            int left = (length > 0) ? matrix[r - 1][length - 1] : int.MaxValue;
    //            int middle = matrix[r - 1][length];
    //            int right = (length < cols - 1) ? matrix[r - 1][length + 1] : int.MaxValue;

    //            // Update the current element with the minimum sum.
    //            matrix[r][length] += Math.Min(left, Math.Min(middle, right));
    //        }
    //    }

    //    // Return the minimum sum from the last row.
    //    return matrix[rows - 1].Min();
    //}
    #endregion

    #region 3. Longest Substring Without Repeating Characters
    /// <summary>
    /// Finds the length of the longest substring without repeating characters.
    /// </summary>
    /// <param name="s">Input string.</param>
    /// <returns>Length of the longest substring without repeating characters.</returns>
    /// <time>Runtime: O(n^2)</time>
    /// <space>Memory: O(k)</space>
    public int LengthOfLongestSubstring(string s)
    {
        int longestLength = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            HashSet<char> set = [];
            for (int j = i; j < s.Length; ++j)
            {
                if (set.Contains(s[j])) break;
                set.Add(s[j]);

                if (j - i + 1 > longestLength)
                    longestLength = j - i + 1;
            }
        }
        return longestLength;
    }
    #endregion

    #region 198. House Robber
    /// <summary>
    /// Calculates the maximum amount of money that can be robbed from houses.
    /// </summary>
    /// <param name="nums">An array representing the amount of money in each house.</param>
    /// <returns>The maximum amount of money that can be robbed.</returns>
    /// <time>Runtime: O(n)</time>
    /// <space>Memory: O(1)</space>
    public int Rob(int[] nums)
    {
        int prevMax = 0, currMax = 0;

        foreach (var num in nums)
        {
            int temp = currMax;
            currMax = Math.Max(prevMax + num, currMax);
            prevMax = temp;
        }

        return currMax;
    }
    #endregion

    #region 1239. Maximum Length of a Concatenated String with Unique Characters
    /// <summary>
    /// Calculates the max length of a unique-character concatenated string.
    /// </summary>
    /// <param name="arr">List of strings to form the concatenated string.</param>
    /// <returns>Max length of the concatenated string.</returns>
    /// <time>Runtime: O(2^n * m)</time>
    /// <space>Memory: O(n * m)</space>
    public int MaxLength(IList<string> arr)
        => Backtrack(arr, 0, "");

    private int Backtrack(IList<string> arr, int index, string current)
    {
        if (new HashSet<char>(current).Count != current.Length)
            return 0;

        int maxLength = current.Length;
        for (int i = index; i < arr.Count; i++)
            maxLength = Math.Max(maxLength, Backtrack(arr, i + 1, current + arr[i]));

        return maxLength;
    }
    #endregion

    #region 189. Rotate Array
    /// <summary>
    /// Rotates the array to the right by k steps.
    /// </summary>
    /// <param name="nums">The input array.</param>
    /// <param name="k">The number of steps to rotate the array.</param>
    /// <link>https://leetcode.com/problems/rotate-array/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;
        int[] temp = new int[n];

        for (int i = 0; i < n; i++)
            temp[(i + k) % n] = nums[i];

        for (int i = 0; i < n; i++)
            nums[i] = temp[i];
    }
    #endregion
}
