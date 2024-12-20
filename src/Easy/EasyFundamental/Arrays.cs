﻿namespace EasyFundamental;

public class Arrays
{
    #region 1 TwoSum
    /// <summary>
    /// 1 Two Sum
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

    #region 26 RemoveDuplicates
    /// <summary>
    /// 26 Remove Duplicates from Sorted Array
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

    #region 27 Remove Element
    /// <summary>
    /// 27 Remove Element
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

    #region 349 Intersection of Two Arrays
    /// <summary>
    /// 349 Intersection of Two Arrays
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

    #region 88 Merge Sorted Array
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
        int k = m-- + n-- - 1;

        while (m >= 0 && n >= 0)
            nums1[k--] = (nums1[m] >= nums2[n]) ? nums1[m--] : nums2[n--];

        while (n >= 0)
            nums1[k--] = nums2[n--];
    }
    #endregion

    #region 1207 Unique Number of Occurrences
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

    #region 1672 Richest Customer Wealth
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

    #region 645 Set Mismatch
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

    #region 2133 Check if Every Row and Column Consist of the Same Element
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

    #region 35 Search Insert Position
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

    #region 455 Assign Cookies
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

    #region 1979 Find Greatest Common Divisor of Array
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

    #region 2855 Minimum Right Shifts to Sort the Array
    /// <summary>
    /// Returns the minimum number of r shifts required to sort the array, or -1 if it's not possible.
    /// </summary>
    /// <param name="nums">The list of distinct positive integers.</param>
    /// <returns>The minimum number of r shifts or -1 if not possible.</returns>
    /// <link>https://leetcode.com/problems/minimum-r-shifts-to-sort-the-array/</link>
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

    #region 1275 Find Winner on a Tic Tac Toe Game
    /// <summary>
    /// Determines the winner of a Tic Tac Toe game based on the moves made.
    /// </summary>
    /// <param name="moves">The moves made by players.</param>
    /// <returns>The winner of the game: "A", "B", or "Draw" if the game is still pending.</returns>
    /// <link>https://leetcode.com/problems/find-winner-on-a-tic-tac-toe-game/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public string Tictactoe(int[][] moves)
    {
        // Initialize arrays to track row, column, diagonal, and anti-diagonal sums
        int[] rows = new int[3], cols = new int[3];
        int diag = 0, antiDiag = 0;
        // Player 1 represents "X", Player -1 represents "O"
        int player = 1;

        // Iterate through each move
        foreach (var move in moves)
        {
            int row = move[0], col = move[1];
            // Update sums for the current row and column
            rows[row] += player;
            cols[col] += player;
            // Update sums for the main diagonal and anti-diagonal if applicable
            if (row == col) diag += player;
            if (row + col == 2) antiDiag += player;
            // Check if any player has won
            if (Math.Abs(rows[row]) == 3 || Math.Abs(cols[col]) == 3 || Math.Abs(diag) == 3 || Math.Abs(antiDiag) == 3)
                return player == 1 ? "A" : "B";
            // Switch player for the next move
            player *= -1;
        }

        // If all moves are made and no winner is found, check if the game is a draw or still pending
        return moves.Length == 9 ? "Draw" : "Pending";
    }
    #endregion

    #region 2917 Find the K-or of an Array
    /// <summary>
    /// Returns the K-or of an integer array.
    /// </summary>
    /// <param name="nums">The integer array.</param>
    /// <param name="k">The desired number of consecutive set bits in the K-or.</param>
    /// <returns>The K-or of the array.</returns>
    /// <link>https://leetcode.com/problems/find-the-k-or-of-an-array</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int FindKOr(int[] nums, int k)
    {
        int result = 0;

        for (int i = 31; i >= 0; i--)
        {
            int count = 0;
            foreach (int num in nums)
                count += (num >> i) & 1;

            if (count >= k)
                result |= 1 << i;
        }

        return result;
    }
    #endregion

    #region 1491 Average Salary Excluding the Minimum and Maximum Salary
    /// <summary>
    /// Calculates the average salary excluding the minimum and maximum salaries.
    /// </summary>
    /// <param name="salary">An array of unique integers representing the salaries of employees.</param>
    /// <returns>The average salary excluding the minimum and maximum salaries.</returns>
    /// <link>https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public double Average(int[] salary)
    {
        Array.Sort(salary);
        int sum = 0;
        for (int i = 1; i < salary.Length - 1; i++)
            sum += salary[i];

        return (double)sum / (salary.Length - 2);
    }
    #endregion

    #region 169 Majority Element
    /// <summary>
    /// Finds the majority element in an integer array.
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>The majority element.</returns>
    /// <link>https://leetcode.com/problems/majority-element/</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
    #endregion

    #region 2108 Find First Palindromic String in the Array
    /// <summary>
    /// Returns the first palindromic string in the array.
    /// </summary>
    /// <param name="words">An array of strings.</param>
    /// <returns>The first palindromic string in the array.</returns>
    /// <link>https://leetcode.com/problems/find-first-palindromic-string-in-the-array/</link>
    /// <time>Time Complexity: O(n∗m)</time>
    /// <space>Space Complexity: O(1)</space>
    public string FirstPalindrome(string[] words)
        => words.FirstOrDefault(word => IsPalindrome(word)) ?? "";

    private bool IsPalindrome(string word)
    {
        for (int l = 0, r = word.Length - 1; l < r; l++, r--)
            if (word[l] != word[r])
                return false;

        return true;
    }
    #endregion

    #region 118 Pascal's Triangle
    /// <summary>
    /// Generates Pascal's triangle up to a specified number of rows.
    /// </summary>
    /// <param name="numRows">The number of rows to generate.</param>
    /// <returns>The Pascal's triangle up to the specified number of rows.</returns>
    /// <link>https://leetcode.com/problems/pascals-triangle/</link>
    /// <time>Time Complexity: O(n^2)</time>
    /// <space>Space Complexity: O(n)</space>
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> triangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            IList<int> row = new List<int>();

            for (int j = 0; j <= i; j++)
                row.Add(j == 0 || j == i ? 1 : triangle[i - 1][j - 1] + triangle[i - 1][j]);
            triangle.Add(row);
        }

        return triangle;
    }
    #endregion

    #region 706 Binary Search
    /// <summary>
    /// Performs binary search on a sorted array to find the target element.
    /// </summary>
    /// <param name="nums">The sorted array of integers.</param>
    /// <param name="target">The target integer to search for.</param>
    /// <returns>The index of the target element if found; otherwise, returns -1.</returns>
    /// <link>https://leetcode.com/problems/binary-search/</link>
    /// <time>Time Complexity: O(log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
    #endregion

    #region 1646 Get Maximum in Generated Array
    /// <summary>
    /// Returns the maximum integer in the generated array based on specific rules.
    /// </summary>
    /// <param name="n">The number of elements in the array.</param>
    /// <returns>The maximum integer in the generated array.</returns>
    /// <link>https://leetcode.com/problems/get-maximum-in-generated-array/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int GetMaximumGenerated(int n)
    {
        if (n == 0) return 0;

        int[] nums = new int[n + 1];
        nums[1] = 1;
        int max = 1;

        for (int i = 2; i <= n; i++)
        {
            nums[i] = nums[i / 2] + i % 2 * nums[i / 2 + 1];
            max = Math.Max(max, nums[i]);
        }

        return max;
    }
    #endregion

    #region 2535 Difference Between Element Sum and Digit Sum of an Array
    /// <summary>
    /// Calculates the absolute difference between the sum of all elements in an array and the sum of their digits.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The absolute difference between the sum of the elements and the sum of their digits.</returns>
    /// <link>https://leetcode.com/problems/difference-between-sum-of-odd-and-even-numbers/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int DifferenceOfSum(int[] nums)
        => Math.Abs(nums.Sum() - nums.Sum(num => num.ToString().Select(c => c - '0').Sum()));
    #endregion

    #region 2788 Split Strings by Separator
    /// <summary>
    /// Splits a list of strings into individual words by a specified separator character, removing any empty entries.
    /// </summary>
    /// <param name="words">The list of strings to split.</param>
    /// <param name="separator">The separator character.</param>
    /// <returns>A list of individual words after splitting by the separator.</returns>
    /// <link>https://leetcode.com/problems/split-strings-by-separator/</link>
    /// <time>Time Complexity: 	O(n * m)</time>
    /// <space>Space Complexity: O(m)</space>
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        => words.SelectMany(word => word.Split(separator, StringSplitOptions.RemoveEmptyEntries)).ToList();
    #endregion

    #region 231 Power of Two
    /// <summary>
    /// Determines whether the given integer is a power of two.
    /// </summary>
    /// <param name="n">The integer to check.</param>
    /// <returns>True if the integer is a power of two; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/power-of-two/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool IsPowerOfTwo(int n)
        => n > 0 && (n & (n - 1)) == 0;
    #endregion

    #region 268 Missing Number
    /// <summary>
    /// Finds the missing number in a sequence of integers from 0 to n, where each integer appears exactly once, except for one missing number.
    /// </summary>
    /// <param name="nums">An array of integers representing the sequence.</param>
    /// <returns>The missing number in the sequence.</returns>
    /// <link>https://leetcode.com/problems/missing-number/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int MissingNumber(int[] nums)
        => Enumerable.Range(0, nums.Length + 1).Except(nums).First();
    #endregion

    #region 1502 Can Make Arithmetic Progression From Sequence
    /// <summary>
    /// Determines whether the given array can be rearranged to form an arithmetic progression.
    /// </summary>
    /// <param name="arr">The array of numbers.</param>
    /// <returns>True if the array can form an arithmetic progression; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);
        int commonDifference = arr[1] - arr[0];

        for (int i = 2; i < arr.Length; i++)
            if (arr[i] - arr[i - 1] != commonDifference)
                return false;

        return true;
    }
    #endregion

    #region 2248 Intersection of Multiple Arrays
    /// <summary>
    /// Finds the intersection of multiple arrays.
    /// </summary>
    /// <param name="nums">A 2D integer array where nums[i] is a non-empty array of distinct positive integers.</param>
    /// <returns>The list of integers that are present in each array of nums sorted in ascending order.</returns>
    /// <link>https://leetcode.com/problems/intersection-of-multiple-arrays/</link>
    /// <time>Time Complexity: O(n*m)</time>
    /// <space>Space Complexity: O(n)</space>
    public IList<int> Intersection(int[][] nums)
    {
        HashSet<int> intersection = new(nums[0]);

        for (int i = 1; i < nums.Length; i++)
            intersection.IntersectWith(new HashSet<int>(nums[i]));

        return intersection.OrderBy(x => x).ToList();
    }
    #endregion

    #region 977 Squares of a Sorted Array
    /// <summary>
    /// Calculates the squares of the numbers in the input array and returns them in sorted order.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>An array containing the squares of the input numbers sorted in ascending order.</returns>
    /// <link>https://leetcode.com/problems/squares-of-a-sorted-array/</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int[] SortedSquares(int[] nums)
    {
        //int s = -8;
        //int t = -2;
        //s *= t;
        //Console.WriteLine(s);

        // for (int i = 0; i < nums.Length; ++i)
        //    nums[i] *= nums[i] < 0 ? -nums[i] : nums[i];

        // Array.Sort(nums);
        // return nums;

        return [.. nums.Select(num => Math.Abs(num * num)).Order()];
    }
    #endregion

    #region 1929 Concatenation of Array
    /// <summary>
    /// Concatenates the given array with itself.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The concatenated array.</returns>
    /// <link>https://leetcode.com/problems/concatenation-of-array/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int[] GetConcatenation(int[] nums)
        => [.. nums, .. nums];
    #endregion

    #region 744 Find Smallest Letter Greater Than Target
    /// <summary>
    /// Finds the smallest letter greater than the target letter in the given array of letters.
    /// </summary>
    /// <param name="letters"> The array of letters.</param>
    /// <param name="target"> The target letter </param>
    /// <returns> The smallest letter greater than the target letter in the given array of letters </returns>
    /// <link>https://leetcode.com/problems/find-smallest-letter-greater-than-target/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public char NextGreatestLetter(char[] letters, char target)
    {
        foreach (char letter in letters)
            if (letter > target)
                return letter;

        return letters[0];
    }
    #endregion

    #region 3000 Minimum Area Rectangle
    /// <summary>
    /// Calculates the area of the rectangle with the longest diagonal.
    /// </summary>
    /// <param name="dimensions">The dimensions of the rectangles.</param>
    /// <returns>The area of the rectangle with the longest diagonal.</returns>
    /// <link>https://leetcode.com/problems/minimum-area-rectangle/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
        Dictionary<double, int> areas = new Dictionary<double, int>();

        foreach (var dimension in dimensions)
        {
            var diameter = Math.Sqrt(dimension.Select(n => n * n).Sum());
            var area = dimension[0] * dimension[1];
            if (areas.TryGetValue(diameter, out int value))
                areas[diameter] = value < area ? area : value;
            else
                areas[diameter] = area;
        }

        return areas[areas.Keys.Max()];
    }
    #endregion

    #region 3024 Type of Triangle
    /// <summary>
    /// Determines the type of triangle based on the given side lengths.
    /// </summary>
    /// <param name="nums">The array containing the side lengths of the triangle.</param>
    /// <returns>The type of triangle formed by the given side lengths.</returns>
    /// <link>Problem Link: https://leetcode.com/problems/type-of-triangle/</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public string TriangleType(int[] nums)
    {
        Array.Sort(nums);
        if (nums[0] + nums[1] <= nums[2]) return "none";
        if (nums[0] == nums[1] && nums[1] == nums[2]) return "equilateral";
        if (nums[0] == nums[1] || nums[1] == nums[2]) return "isosceles";
        return "scalene";
    }
    #endregion

    #region 1816 Truncate Sentence
    /// <summary>
    /// Truncates the given sentence to contain only the first k words.
    /// </summary>
    /// <param name="s">The input sentence.</param>
    /// <param name="k">The number of words to keep.</param>
    /// <returns>The truncated sentence.</returns>
    /// <link>https://leetcode.com/problems/truncate-sentence/</link>
    /// <time>Time Complexity: O(n + k)</time>
    /// <space>Space Complexity: O(n)</space>
    public string TruncateSentence(string s, int k)
        => string.Join(' ', s.Split(' ').Take(k));
    #endregion

    #region 1636 Sort Array by Increasing Frequency
    /// <summary>
    /// Sorts the array in ascending order based on the frequency of the numbers in the array.
    /// </summary>
    /// <param name="nums">The array to be sorted.</param>
    /// <returns>The sorted array.</returns>
    /// <link>https://leetcode.com/problems/sort-array-by-increasing-frequency/</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int[] FrequencySort(int[] nums)
    {
        var freqMap = new Dictionary<int, int>();

        foreach (var num in nums)
            freqMap[num] = freqMap.TryGetValue(num, out var val) ? val + 1 : 1;

        Array.Sort(nums, (a, b) =>
        {
            var freqComparison = freqMap[a] - freqMap[b];
            return freqComparison != 0 ? freqComparison : b - a;
        });

        return nums;
    }
    #endregion

    #region 1480 Running Sum of 1d Array
    /// <summary>
    /// Calculates the running sum of an array.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The running sum of the array.</returns>
    /// <link>https://leetcode.com/problems/running-sum-of-1d-array/</link>
    /// <time>Time Complexity: O(n²)</time>
    /// <space>Space Complexity: O(n)</space>
    public int[] RunningSum(int[] nums)
        => nums.Select((x, i) => nums.Take(i + 1).Sum()).ToArray();
    #endregion

    #region 1662 Check If Two String Arrays are Equivalent
    /// <summary>
    /// Checks if two string arrays are equivalent.
    /// </summary>
    /// <param name="word1">The first string array.</param>
    /// <param name="word2">The second string array.</param>
    /// <returns>True if the arrays are equivalent, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/</link>
    /// <time>Time Complexity: O(n + m)</time>
    /// <space>Space Complexity: O(n + m)</space>
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        => string.Concat(word1) == string.Concat(word2);
    #endregion

    #region 1460 Make Two Arrays Equal
    /// <summary>
    /// Determines if two arrays are equal by comparing their elements in the same order.
    /// </summary>
    /// <param name="target">The first array.</param>
    /// <param name="arr">The second array.</param>
    /// <returns>True if the arrays are equal; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/make-two-arrays-equal/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool CanBeEqual(int[] target, int[] arr)
        => target.OrderBy(x => x).SequenceEqual(arr.OrderBy(x => x));
    #endregion

    #region 1437 Check If All 1's Are at Least Length K Places Away
    /// <summary>
    /// Determines if all 1's are at least k places away from each other.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="k">The number of places.</param>
    /// <returns>True if all 1's are at least k places away from each other; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/check-if-all-1s-are-at-least-length-k-places-away/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool KLengthApart(int[] nums, int k)
    {
        for (int i = 0, count = k; i < nums.Length; i++)
            if (nums[i] == 1)
            {
                if (count < k) return false;
                count = 0;
            }
            else
                count++;

        return true;
    }
    #endregion

    #region 1920 Build Array from Permutation
    /// <summary>
    /// Builds an array from its permutation.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The array from its permutation.</returns>
    /// <link>https://leetcode.com/problems/build-array-from-permutation/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int[] BuildArray(int[] nums)
        => nums.Select(i => nums[i]).ToArray();
    #endregion

    #region 1464 Maximum Product of Two Elements in an Array
    /// <summary>
    /// Returns the maximum product of two integers in an array.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The maximum product of two integers in the array.</returns>
    /// <link>https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MaxProduct(int[] nums)
    {
        int max1 = int.MinValue, max2 = int.MinValue;

        foreach (int num in nums)
            if (num >= max1)
                (max2, max1) = (max1, num);
            else if (num > max2)
                max2 = num;

        return (max1 - 1) * (max2 - 1);
    }
    #endregion

    #region 2678 Number of Senior Citizens
    /// <summary>
    /// Returns the number of senior citizens in an array of strings.
    /// </summary>
    /// <param name="details">The array of strings.</param>
    /// <returns>The number of senior citizens in the array.</returns>
    /// <link>https://leetcode.com/problems/number-of-senior-citizens/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int CountSeniors(string[] details)
        => details.Count(d => int.Parse(d[11..13]) > 60);
    #endregion

    #region 1337 The K Weakest Rows in a Matrix
    /// <summary>
    /// Returns the indices of the k weakest rows in a matrix.
    /// </summary>
    /// <param name="mat">The matrix of integers.</param>
    /// <param name="k">The number of rows to return.</param>
    /// <returns>The indices of the k weakest rows in the matrix.</returns>
    /// <link>https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/</link>
    /// <time>Time Complexity:  O(m log(m) + k)</time>
    /// <space>Space Complexity: O(m)</space>
    public int[] KWeakestRows(int[][] mat, int k)
        => mat.Select((arr, index) => (arr, index))
            .OrderBy(x => x.arr.Sum())
            .Take(k)
            .Select(x => x.index)
            .ToArray();
    #endregion

    #region 205 Isomorphic Strings
    /// <summary>
    /// Determines if two strings are isomorphic.
    /// </summary>
    /// <param name="s">The first string.</param>
    /// <param name="t">The second string.</param>
    /// <returns>True if the strings are isomorphic; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/isomorphic-strings/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var mapS = new int[256];
        var mapT = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            if (mapS[s[i]] != mapT[t[i]]) return false;

            mapS[s[i]] = i + 1;
            mapT[t[i]] = i + 1;
        }

        return true;
    }
    #endregion

    #region 2255 Count Prefixes of a Given String
    /// <summary>
    /// Returns the number of prefixes of a given string in an array of strings.
    /// </summary>
    /// <param name="words">The array of strings.</param>
    /// <param name="s">The given string.</param>
    /// <returns>The number of prefixes of the given string in the array.</returns>
    /// <link>https://leetcode.com/problems/count-prefixes-of-a-given-string/</link>
    /// <time>Time Complexity: O(n * m)</time>
    /// <space>Space Complexity: O(1)</space>
    public int CountPrefixes(string[] words, string s)
        => words.Count(word => s.StartsWith(word));
    #endregion

    #region 1550 Three Consecutive Odds
    /// <summary>
    /// Determines if there are three consecutive odds in an array.
    /// </summary>
    /// <param name="arr">The array of integers.</param>
    /// <returns>True if there are three consecutive odds in the array; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/three-consecutive-odds/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        for (int i = 0; i < arr.Length - 2; i++)
            if (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0 && arr[i + 2] % 2 != 0)
                return true;

        return false;
    }
    #endregion

    #region 1436 Destination City
    /// <summary>
    /// Returns the destination city of a list of paths.
    /// </summary>
    /// <param name="paths">The list of paths.</param>
    /// <returns>The destination city of the list of paths.</returns>
    /// <link>https://leetcode.com/problems/destination-city/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> outgoingCities = [];
        HashSet<string> incomingCities = [];

        foreach (var path in paths)
        {
            outgoingCities.Add(path[0]);
            incomingCities.Add(path[1]);
        }

        foreach (var city in incomingCities)
            if (!outgoingCities.Contains(city))
                return city;

        return "";
    }
    #endregion

    #region 1710 Maximum Units on a Truck
    /// <summary>
    /// Finds max units on truck (sort by units, greedy selection).
    /// </summary>
    /// <param name="boxTypes">Box types (count, units per box).</param>
    /// <param name="truckSize">Truck capacity.</param>
    /// <returns></returns>
    /// <link>https://leetcode.com/problems/maximum-units-on-a-truck</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Array.Sort(boxTypes, (a, b) => b[1] - a[1]);

        int totalUnits = 0;
        for (int i = 0; i < boxTypes.Length && truckSize > 0; i++)
        {
            int boxCount = boxTypes[i][0];
            int unitsPerBox = boxTypes[i][1];

            int boxesToAdd = Math.Min(boxCount, truckSize);
            totalUnits += boxesToAdd * unitsPerBox;
            truckSize -= boxesToAdd;
        }

        return totalUnits;
    }
    #endregion

    #region 1893 Check if All the Integers in a Range Are Covered
    /// <summary>
    /// Checks if all the integers in a range are covered in an array of ranges.
    /// </summary>
    /// <param name="ranges">The array of ranges.</param>
    /// <param name="left">The left boundary of the range.</param>
    /// <param name="right">The right boundary of the range.</param>
    /// <returns>True if all the integers in the range are covered in the array; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/check-if-all-the-integers-in-a-range-are-covered/</link>
    /// <time>Time Complexity: O(n + m)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool IsCovered(int[][] ranges, int left, int right)
    {
        bool[] covered = new bool[51];

        foreach (var range in ranges)
            for (int i = range[0]; i <= range[1]; i++)
                covered[i] = true;

        return covered[left..(right + 1)].All(x => x);
    }
    #endregion

    #region 1351 Count Negative Numbers in a Sorted Matrix
    /// <summary>
    /// Counts the number of negative numbers in a sorted matrix.
    /// </summary>
    /// <param name="grid">The sorted matrix.</param>
    /// <returns>The count of negative numbers in the matrix.</returns>
    /// <link>https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/</link>
    /// <time>Time Complexity: O(n + m)</time>
    /// <space>Space Complexity: O(1)</space>
    public int CountNegatives(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length, count = 0;

        for (int row = 0, col = n - 1; row < m && col >= 0;)
            if (grid[row][col] < 0)
            {
                count += m - row;
                col--;
            }
            else
                row++;

        return count;
    }
    #endregion

    #region 2706 Buy Two Chocolates
    /// <summary>
    /// Calculates the leftover money after buying two chocolates with minimum prices.
    /// </summary>
    /// <param name="prices">The array of chocolate prices.</param>
    /// <param name="money">The initial amount of money.</param>
    /// <returns>The leftover money after buying two chocolates.</returns>
    /// <link>https://leetcode.com/problems/buy-two-chocolates/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int BuyChoco(int[] prices, int money)
    {
        int min1 = int.MaxValue, min2 = int.MaxValue;

        foreach (int price in prices)
            if (price < min1)
                (min2, min1) = (min1, price);
            else if (price < min2)
                min2 = price;

        int leftover = money - (min1 + min2);
        return leftover >= 0 ? leftover : money;
    }
    #endregion

    #region 2011 Final Value of Variable After Performing Operations
    /// <summary>
    /// Calculates final variable value after operations.
    /// </summary>
    /// <param name="operations">Array of increment and decrement operations.</param>
    /// <returns>Final variable value after all operations.</returns>
    /// <link>https://leetcode.com/problems/final-value-of-variable-after-performing-operations/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int FinalValueAfterOperations(string[] operations)
        => operations.Sum(op => op.Contains('+') ? 1 : -1);
    #endregion

    #region 2465 Number of Distinct Averages
    /// <summary>
    /// Counts the number of distinct averages calculated from the input array of integers.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The count of distinct averages.</returns>
    /// <link>https://leetcode.com/problems/number-of-distinct-averages/</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int DistinctAverages(int[] nums)
    {
        HashSet<double> averages = [];

        Array.Sort(nums);

        for (int left = 0, right = nums.Length - 1; left < right; left++, right--)
            averages.Add((nums[left] + nums[right]) / 2.0);

        return averages.Count;
    }
    #endregion

    #region 2974 Minimum Number Game
    /// <summary>
    /// Rearranges array for odd indexes to exceed preceding evens.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The rearranged array.</returns>
    /// <link>Link: Not specified</link>
    /// <time>Time Complexity: O(n log n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 1; i < nums.Length; i += 2)
            (nums[i], nums[i - 1]) = (nums[i - 1], nums[i]);

        return nums;
    }
    #endregion

    #region 2341 Maximum Number of Pairs in Array
    /// <summary>
    /// Counts pairs and leftover integers in an array.
    /// </summary>
    /// <param name="nums">Input array of integers.</param>
    /// <returns>Number of pairs formed and leftover integers.</returns>
    /// <link>Link: Not specified</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int[] NumberOfPairs(int[] nums)
    {
        Dictionary<int, int> counts = [];
        int pairs = 0;

        foreach (var num in nums)
        {
            if (counts.ContainsKey(num))
            {
                pairs++;
                counts.Remove(num);
            }
            else
                counts[num] = 1;
        }

        return [pairs, counts.Count];
    }
    #endregion

    #region 941 Valid Mountain Array
    /// <summary>
    /// Checks if the given array is a valid mountain array.
    /// </summary>
    /// <param name="arr">The input array of integers.</param>
    /// <returns>True if the array is a valid mountain array, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/valid-mountain-array/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool ValidMountainArray(int[] arr)
    {
        int n = arr.Length;
        int i = 0;

        while (i + 1 < n && arr[i] < arr[i + 1])
            i++;

        if (i == 0 || i == n - 1)
            return false;

        while (i + 1 < n && arr[i] > arr[i + 1])
            i++;

        return i + 1 == n;
    }
    #endregion

    #region 1408 String Matching in an Array
    /// <summary>
    /// Finds substrings in an array of words that are substrings of other words.
    /// </summary>
    /// <param name="words">The array of words to search through.</param>
    /// <returns>A list of strings that are substrings of other words.</returns>
    /// <link>https://leetcode.com/problems/string-matching-in-an-array/</link>
    /// <time>Time Complexity: O(n^2 * m)</time>
    /// <space>Space Complexity: O(m)</space>
    public IList<string> StringMatching(string[] words)
    {
        HashSet<string> set = [];
        foreach (var item in words)
            if (words.Count(w => w.Contains(item)) > 1)
                set.Add(item);

        return [.. set];
    }
    #endregion

    #region 2073 Time Needed to Buy Tickets
    /// <summary>
    /// Calculates the time needed for a person to buy tickets at a specific position in a line.
    /// </summary>
    /// <param name="tickets">An array representing the number of tickets each person wants to buy.</param>
    /// <param name="k">The position of the person in the line (0-indexed).</param>
    /// <returns>The time taken for the person at position k to finish buying tickets.</returns>
    /// <link>Link: Not specified</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int ans = 0;

        for (int i = 0; i < tickets.Length; i++)
            ans += Math.Min(tickets[i], i <= k ? tickets[k] : tickets[k] - 1);

        return ans;
    }
    #endregion

    #region 1512 Number of Good Pairs
    /// <summary>
    /// Calculates the number of good pairs in an array.
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>The number of good pairs in the array.</returns>
    /// <link>https://leetcode.com/problems/number-of-good-pairs/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int NumIdenticalPairs(int[] nums)
    {
        int goodPairs = 0;
        int[] freq = new int[101];

        foreach (int num in nums)
            goodPairs += freq[num]++;

        return goodPairs;
    }
    #endregion

    #region 2824 Count Pairs Whose Sum is Less than Target
    /// <summary>
    /// Counts pairs whose sum is less than the target in an array.
    /// </summary>
    /// <param name="nums">A list of integers.</param>
    /// <param name="target">The target sum.</param>
    /// <returns>The number of pairs whose sum is less than the target.</returns>
    /// <link>https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/</link>
    /// <time>O(n^2)</time>
    /// <space>O(1)</space>
    public int CountPairs(IList<int> nums, int target)
        => nums.SelectMany((x, i) => nums.Skip(i + 1).Select(y => x + y < target ? 1 : 0)).Sum();
    #endregion

    #region 2446 Determine if Two Events Have Conflict
    /// <summary>
    /// Determines if there is a conflict between two events based on their start and end times.
    /// </summary>
    /// <param name="event1">An array representing the start and end times of the first event in HH:MM format.</param>
    /// <param name="event2">An array representing the start and end times of the second event in HH:MM format.</param>
    /// <returns>True if there is a conflict, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/determine-if-two-events-have-conflict/</link>
    /// <time>Time Complexity: O(1)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool HaveConflict(string[] event1, string[] event2)
        => !(event1[1].CompareTo(event2[0]) < 0 || event2[1].CompareTo(event1[0]) < 0);
    #endregion

    #region 2605 Form Smallest Number From Two Digit Arrays
    /// <summary>
    /// Finds the smallest number that contains at least one digit from each array.
    /// </summary>
    /// <param name="nums1">Array of unique digits.</param>
    /// <param name="nums2">Array of unique digits.</param>
    /// <returns>The smallest number containing at least one digit from each array.</returns>
    /// <link>Link: Not specified</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MinNumber(int[] nums1, int[] nums2)
        => nums1.Intersect(nums2).DefaultIfEmpty(Math.Min(nums1.Min(), nums2.Min()) * 10 + Math.Max(nums1.Min(), nums2.Min())).Min();
    #endregion

    #region 2828 Check if a String Is an Acronym of Words
    /// <summary>
    /// Checks if a string is an acronym of words.
    /// </summary>
    /// <param name="words">Array of strings.</param>
    /// <param name="s">String to check.</param>
    /// <returns>True if s is an acronym of words, false otherwise.</returns>
    /// <link>Link: Not specified</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool IsAcronym(IList<string> words, string s)
        => string.Concat(words.Select(word => word[0])) == s;
    #endregion

    #region 2643 Row With Maximum Ones
    /// <summary>
    /// Finds the row with the maximum count of ones in a binary matrix.
    /// </summary>
    /// <param name="mat">Binary matrix.</param>
    /// <returns>An array containing the index of the row and the number of ones in it.</returns>
    /// <link>https://leetcode.com/problems/row-with-maximum-ones/</link>
    /// <time>Time Complexity: O(m*n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int[] RowAndMaximumOnes(int[][] mat)
        => mat.Select((row, i) => new[] { i, row.Sum() }).MaxBy(a => a[1])!;
    #endregion

    #region 2848 Points That Intersect With Cars
    /// <summary>
    /// Counts the number of integer points on the line covered by cars.
    /// </summary>
    /// <param name="nums">2D array representing the coordinates of cars.</param>
    /// <returns>The number of points covered by cars.</returns>
    /// <link>https://leetcode.com/problems/points-that-intersect-with-cars/</link>
    /// <time>Time Complexity: O(n*m)</time>
    /// <space>Space Complexity: O(n*m)</space>
    public int NumberOfPoints(IList<IList<int>> nums)
        => nums.SelectMany(car => Enumerable.Range(car[0], car[1] - car[0] + 1)).Distinct().Count();
    #endregion

    #region 628 Maximum Product of Three Numbers
    /// <summary>
    /// Finds the maximum product of three numbers in an integer array.
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>The maximum product of any three numbers.</returns>
    /// <link>https://leetcode.com/problems/maximum-product-of-three-numbers/</link>
    /// <time>O(n log n)</time>
    /// <space>O(1)</space>
    public int MaximumProduct(int[] nums)
    {
        Array.Sort(nums);
        return Math.Max(nums[^1] * nums[^2] * nums[^3], nums[0] * nums[1] * nums[^1]);
    }
    #endregion

    #region 2057 Smallest Index With Equal Value
    /// <summary>
    /// Finds the smallest index in an array where i mod 10 equals nums[i].
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>The smallest index i such that i mod 10 == nums[i], or -1 if no such index exists.</returns>
    /// <link>https://leetcode.com/problems/smallest-index-with-equal-value/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int SmallestEqual(int[] nums)
        => nums.Select((num, i) => new { num, i })
           .Where(x => x.i % 10 == x.num)
           .Select(x => x.i)
           .DefaultIfEmpty(-1)
           .First();
    #endregion

    #region 1089 Duplicate Zeros
    /// <summary>
    /// Duplicates each occurrence of zero in the array, shifting the remaining elements to the right in place.
    /// </summary>
    /// <param name="arr">A fixed-length integer array.</param>
    /// <link>https://leetcode.com/problems/duplicate-zeros/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public void DuplicateZeros(int[] arr)
    {
        int zeros = arr.Count(x => x == 0);
        int n = arr.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            if (i + zeros < n) arr[i + zeros] = arr[i];
            if (arr[i] == 0 && --zeros + i < n) arr[i + zeros] = 0;
        }
    }
    #endregion

    #region 2549 Count Distinct Numbers on Board
    /// <summary>
    /// Returns the number of distinct integers present on the board after a large number of days.
    /// </summary>
    /// <param name="n">The initial positive integer placed on the board.</param>
    /// <returns>The number of distinct integers present on the board.</returns>
    /// <link>https://leetcode.com/problems/count-distinct-numbers-on-board/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public int DistinctIntegers(int n) => n == 1 ? 1 : n - 1;
    #endregion

    #region 1365 How Many Numbers Are Smaller Than the Current Number
    /// <summary>
    /// Finds how many numbers in the array are smaller than the current number for each element in the array.
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>An array where each element is the count of numbers smaller than the corresponding element in the input array.</returns>
    /// <link>https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/</link>
    /// <time>O(n^2)</time>
    /// <space>O(n)</space>
    public int[] SmallerNumbersThanCurrent(int[] nums)
        => nums.Select(i => nums.Count(c => c < i)).ToArray();
    #endregion

    #region 1913 Maximum Product Difference Between Two Pairs
    /// <summary>
    /// Calculates the maximum product difference between two pairs of elements in an integer array.
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>The maximum product difference between any two pairs of elements.</returns>
    /// <link>https://leetcode.com/problems/maximum-product-difference-between-two-pairs/</link>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public int MaxProductDifference(int[] nums)
        => nums.OrderBy(n => n).ToArray() switch { var sorted => sorted[^1] * sorted[^2] - sorted[0] * sorted[1] };
    #endregion

    #region 961 N-Repeated Element in Size 2N Array
    /// <summary>
    /// Finds the element in an array that is repeated exactly n times.
    /// </summary>
    /// <param name="nums">An array of integers where one element is repeated n times.</param>
    /// <returns>The element that is repeated n times.</returns>
    /// <link>https://leetcode.com/problems/n-repeated-element-in-size-2n-array/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int RepeatedNTimes(int[] nums)
        => nums.GroupBy(x => x).First(g => g.Count() > 1).Key;
    #endregion

    #region 3005 Count Elements With Maximum Frequency
    /// <summary>
    /// Counts elements with the maximum frequency in an array.
    /// </summary>
    /// <param name="nums">The array of positive integers.</param>
    /// <returns>The total count of elements with maximum frequency.</returns>
    /// <link>https://leetcode.com/problems/count-elements-with-maximum-frequency/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int MaxFrequencyElements(int[] nums)
        => nums.GroupBy(x => x)
                .Select(g => g.Count())
                .Max() * nums.GroupBy(x => x)
                    .Count(g => g.Count() == nums.GroupBy(x => x)
                        .Select(g => g.Count())
                        .Max());
    #endregion

    #region 2806 Account Balance After Rounded Purchase
    /// <summary>
    /// Calculates the account balance after rounding the purchase amount to the nearest multiple of 10 and subtracting it from the initial balance of 100.
    /// </summary>
    /// <param name="purchaseAmount">The amount of the purchase.</param>
    /// <returns>The remaining account balance after the rounded purchase.</returns>
    /// <link>https://leetcode.com/problems/account-balance-after-rounded-purchase/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public int AccountBalanceAfterPurchase(int purchaseAmount)
        => 100 - ((purchaseAmount + 5) / 10) * 10;
    #endregion

    #region 905 Sort Array By Parity
    /// <summary>
    /// Sorts an array by moving all even integers to the beginning followed by all odd integers.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>A new array with all even integers at the beginning and odd integers at the end.</returns>
    /// <link>https://leetcode.com/problems/sort-array-by-parity/</link>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public int[] SortArrayByParity(int[] nums)
        => nums.OrderBy(x => x % 2).ToArray();
    #endregion

    #region 2778 Sum of Squares of Special Elements
    /// <summary>
    /// Returns the sum of the squares of all special elements in the given array.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The sum of the squares of all special elements.</returns>
    /// <link>https://leetcode.com/problems/sum-of-squares-of-special-elements/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int SumOfSquares(int[] nums)
        => Enumerable.Range(1, nums.Length).Where(i => nums.Length % i == 0).Sum(i => nums[i - 1] * nums[i - 1]);
    #endregion

    #region 2148 Count Elements With Strictly Smaller and Greater Elements
    /// <summary>
    /// Counts elements with both a strictly smaller and a strictly greater element.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The count of such elements.</returns>
    /// <link>https://leetcode.com/problems/count-elements-with-strictly-smaller-and-greater-elements/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int CountElements(int[] nums)
    {
        int min = nums.Min(), max = nums.Max();
        return nums.Count(num => num > min && num < max);
    }
    #endregion

    #region 1720 Decode XORed Array
    /// <summary>
    /// Decodes the XORed array to find the original array.
    /// </summary>
    /// <param name="encoded">The encoded array of integers.</param>
    /// <param name="first">The first element of the original array.</param>
    /// <returns>The original array.</returns>
    /// <link>https://leetcode.com/problems/decode-xored-array/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int[] Decode(int[] encoded, int first)
        => Enumerable.Range(0, encoded.Length + 1).Select(i => i == 0 ? first : first ^= encoded[i - 1]).ToArray();
    #endregion

    #region 2815 Max Pair Sum in an Array
    /// <summary>
    /// Returns the maximum sum of pairs of numbers in the array where the largest digit in each pair is the same.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The maximum sum of pairs with the same largest digit, or -1 if no such pair exists.</returns>
    /// <link>https://leetcode.com/problems/maximum-sum-of-pairs-with-equal-digit-sum/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int MaxSum(int[] nums)
        => nums.GroupBy(num => num.ToString().Max())
               .Select(g => g.Count() > 1 ? g.OrderByDescending(x => x).Take(2).Sum() : -1)
               .Max();
    #endregion

    #region 1304 Find N Unique Integers Sum up to Zero
    /// <summary>
    /// Returns an array containing n unique integers that sum up to zero.
    /// </summary>
    /// <param name="n">The number of unique integers.</param>
    /// <returns>An array of n unique integers that sum up to zero.</returns>
    /// <link>https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int[] SumZero(int n)
        => [.. Enumerable.Range(1, n - 1), -(n * (n - 1) / 2)];
    #endregion

    #region 1587 Count the Number of Vowel Strings in Range
    /// <summary>
    /// Returns the number of vowel strings in the specified range of words.
    /// </summary>
    /// <param name="words">An array of strings.</param>
    /// <param name="left">The left index of the range.</param>
    /// <param name="right">The right index of the range.</param>
    /// <returns>The count of vowel strings within the range [left, right].</returns>
    /// <link>https://leetcode.com/problems/count-the-number-of-vowel-strings-in-range/</link>
    /// <time>O(n)</time> where n is the number of words and m is the average length of words.
    /// <space>O(1)</space>
    public int CountVowelStringsInRange(string[] words, int left, int right)
        => words.Skip(left).Take(right - left + 1)
                .Count(word => "aeiou".Contains(word[0]) && "aeiou".Contains(word[^1]));
    #endregion

    #region 3069 Distribute Elements Into Two Arrays I
    /// <summary>
    /// Distributes elements of nums into two arrays arr1 and arr2 and returns the concatenated result.
    /// </summary>
    /// <param name="nums">The input array of distinct integers.</param>
    /// <returns>The concatenated result array.</returns>
    /// <link>https://leetcode.com/problems/distribute-elements-into-two-arrays-i/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int[] ResultArray(int[] nums)
    {
        List<int> arr1 = [nums[0]], arr2 = [nums[1]];

        for (int i = 2; i < nums.Length; i++)
            (arr1.Last() > arr2.Last() ? arr1 : arr2).Add(nums[i]);

        return [.. arr1, .. arr2];
    }
    #endregion

    #region 575 Distribute Candies
    /// <summary>
    /// Returns the maximum number of different types of candies Alice can eat if she only eats n / 2 of them.
    /// </summary>
    /// <param name="candyType">The array of candy types.</param>
    /// <returns>The maximum number of different types of candies Alice can eat.</returns>
    /// <link>https://leetcode.com/problems/distribute-candies/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int DistributeCandies(int[] candyType)
        => Math.Min(candyType.Length / 2, candyType.Distinct().Count());
    #endregion

    #region 2185 Counting Words With a Given Prefix
    /// <summary>
    /// Counts the number of strings in the array that contain the specified prefix.
    /// </summary>
    /// <param name="words">Array of strings to search through.</param>
    /// <param name="pref">Prefix string to search for.</param>
    /// <returns>The number of strings in words that contain pref as a prefix.</returns>
    /// <link>https://leetcode.com/problems/count-words-with-a-given-prefix/</link>
    /// <time>O(n)</time> where n is the number of words and m is the average length of words.
    /// <space>O(1)</space> additional space.
    public int PrefixCount(string[] words, string pref)
        => words.Count(word => word.StartsWith(pref));
    #endregion

    #region 1431 Kids With the Greatest Number of Candies
    /// <summary>
    /// Determines if each kid, after receiving extra candies, will have the greatest number of candies.
    /// </summary>
    /// <param name="candies">The array representing the number of candies each kid has.</param>
    /// <param name="extraCandies">The number of extra candies to be given to each kid.</param>
    /// <returns>A list of booleans indicating whether each kid will have the greatest number of candies.</returns>
    /// <link>https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/</link>
    /// <time>O(n)</time> for a single scan to find the max and another scan to determine the result.
    /// <space>O(n)</space> for the result list.
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        => candies.Select(c => c + extraCandies >= candies.Max()).ToList();
    #endregion

    #region 2239 Find Closest Number to Zero
    /// <summary>
    /// Finds the number in the array that is closest to zero If there are multiple answers, returns the largest number.
    /// </summary>
    /// <param name="nums">The integer array to search.</param>
    /// <returns>The number closest to zero in the array.</returns>
    /// <link>https://leetcode.com/problems/find-closest-number-to-zero/</link>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public int FindClosestNumber(int[] nums)
        => nums.OrderBy(n => (Math.Abs(n), -n)).First();
    #endregion

    #region 2357 Make Array Zero by Subtracting Equal Amounts
    /// <summary>
    /// Returns the minimum number of operations to make every element in the array equal to 0.
    /// </summary>
    /// <param name="nums">The input array of non-negative integers.</param>
    /// <returns>The minimum number of operations.</returns>
    /// <link>https://leetcode.com/problems/make-array-zero-by-subtracting-equal-amounts/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int MinimumOperations(int[] nums)
        => nums.Where(n => n > 0).Distinct().Count();
    #endregion

    #region 2923 Find Champion I
    /// <summary>
    /// Returns the team that will be the champion of the tournament.
    /// </summary>
    /// <param name="grid">A 2D boolean matrix representing the strength relationships between teams.</param>
    /// <returns>The team number that will be the champion.</returns>
    /// <link>https://leetcode.com/problems/find-champion-i/</link>
    /// <time>O(n^2)</time>
    /// <space>O(1)</space>
    public int FindChampion(int[][] grid)
        => Enumerable.Range(0, grid.Length).First(i => grid.All(row => row[i] == 0));
    #endregion

    #region 1475 Final Prices With a Special Discount in a Shop
    /// <summary>
    /// Returns final prices after applying special discounts.
    /// </summary>
    /// <param name="prices">An array where prices[i] is the price of the ith item.</param>
    /// <returns>An array where answer[i] is the final price after discounts for the ith item.</returns>
    /// <link>https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/</link>
    /// <time>O(n^2)</time>
    /// <space>O(n)</space>
    public int[] FinalPrices(int[] prices)
        => prices.Select((p, i) => p - prices.Skip(i + 1).FirstOrDefault(d => d <= p)).ToArray();
    #endregion

    #region 1051 Height Checker
    /// <summary>
    /// Returns the number of indices where heights[i] != expected[i].
    /// </summary>
    /// <param name="heights">An array representing the current order of students' heights.</param>
    /// <returns>The number of indices where the heights do not match the expected order.</returns>
    /// <link>https://leetcode.com/problems/height-checker/</link>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public int HeightChecker(int[] heights)
        => heights.OrderBy(h => h).Where((h, i) => h != heights[i]).Count();
    #endregion

    #region 561 Array Partition
    /// <summary>
    /// Returns the maximized sum of min(ai, bi) for all pairs.
    /// </summary>
    /// <param name="nums">Input array of 2n integers.</param>
    /// <returns>Maximized sum of min values for the optimal pairs.</returns>
    /// <link>https://leetcode.com/problems/array-partition/</link>
    /// <time>O(n log n)</time>
    /// <space>O(1)</space>
    public int ArrayPairSum(int[] nums)
        => nums.OrderBy(x => x).Where((_, i) => i % 2 == 0).Sum();
    #endregion

    #region 1385 Find the Distance Value Between Two Arrays
    /// <summary>
    /// Returns the distance value between two arrays.
    /// </summary>
    /// <param name="arr1">First input array.</param>
    /// <param name="arr2">Second input array.</param>
    /// <param name="d">The distance threshold.</param>
    /// <returns>The distance value.</returns>
    /// <link>https://leetcode.com/problems/find-the-distance-value-between-two-arrays/</link>
    /// <time>O(n * m)</time>
    /// <space>O(1)</space>
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        => arr1.Count(a => arr2.All(b => Math.Abs(a - b) > d));
    #endregion

    #region 3065 Minimum Operations to Exceed Threshold Value I
    /// <summary>
    /// Returns the minimum number of operations needed so that all elements are greater than or equal to k.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <param name="k">The threshold value.</param>
    /// <returns>The minimum number of operations.</returns>
    /// <link>https://leetcode.com/problems/minimum-operations-to-exceed-threshold-value-i/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MinOperations(int[] nums, int k)
        => nums.Count(x => x < k);
    #endregion

    #region 1748 Sum of Unique Elements
    /// <summary>
    /// Returns the sum of all unique elements in the array.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <returns>The sum of unique elements.</returns>
    /// <link>https://leetcode.com/problems/sum-of-unique-elements/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int SumOfUnique(int[] nums)
        => nums.GroupBy(n => n)
               .Where(g => g.Count() == 1)
               .Sum(g => g.Key);
    #endregion

    #region 1346 Check If N and Its Double Exist
    /// <summary>
    /// Checks if there exist two indices i and j such that arr[i] == 2 * arr[j].
    /// </summary>
    /// <param name="arr">The input integer array.</param>
    /// <returns>True if such indices exist, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/check-if-n-and-its-double-exist/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public bool CheckIfExist(int[] arr)
        => arr.ToHashSet().Any(x => x != 0 && arr.Contains(2 * x) || x == 0 && arr.Count(v => v == 0) > 1);
    #endregion

    #region 1732 Find the Highest Altitude
    /// <summary>
    /// Finds the highest altitude achieved given the altitude gains between points.
    /// </summary>
    /// <param name="gain">Array of altitude gains between points.</param>
    /// <returns>The highest altitude achieved.</returns>
    /// <link>https://leetcode.com/problems/find-the-highest-altitude/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int LargestAltitude(int[] gain)
        => gain.Aggregate(new { max = 0, current = 0 }, (acc, g)
            => new { max = Math.Max(acc.max, acc.current + g), current = acc.current + g }).max;
    #endregion

    #region 832 Flipping an Image
    /// <summary>
    /// Flips the image horizontally, then inverts it, and returns the resulting image.
    /// </summary>
    /// <param name="image">An n x n binary matrix where each element is 0 or 1.</param>
    /// <returns>The transformed image after flipping and inverting.</returns>
    /// <link>https://leetcode.com/problems/flipping-an-image/</link>
    /// <time>O(n^2)</time>
    /// <space>O(1)</space>
    public int[][] FlipAndInvertImage(int[][] image)
        => image.Select(row => row.Reverse().Select(b => b ^ 1).ToArray()).ToArray();
    #endregion

    #region 1684 Count the Number of Consistent Strings
    /// <summary>
    /// Returns the count of strings from 'words' that only contain characters from 'allowed'.
    /// </summary>
    /// <param name="allowed">Distinct allowed characters.</param>
    /// <param name="words">Array of words to check.</param>
    /// <returns>Number of consistent strings.</returns>
    /// <link>https://leetcode.com/problems/count-the-number-of-consistent-strings/</link>
    /// <time>O(n * m)</time>
    /// <space>O(a)</space>
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var allowedSet = allowed.ToHashSet();
        return words.Count(word => word.All(allowedSet.Contains));
    }
    #endregion

    #region 2798 Number of Employees Who Met the Target
    /// <summary>
    /// Counts the number of employees who worked at least `target` hours.
    /// </summary>
    /// <param name="hours">An array of integers representing the hours worked by each employee.</param>
    /// <param name="target">The minimum number of hours required to meet the target.</param>
    /// <returns>The number of employees who worked at least `target` hours.</returns>
    /// <link>https://leetcode.com/problems/number-of-employees-who-met-the-target/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        => hours.Count(h => h >= target);
    #endregion

    #region 2335 Minimum Amount of Time to Fill Cups
    /// <summary>
    /// Calculates the minimum seconds to fill all cold, warm, and hot water cups.
    /// </summary>
    /// <param name="amount">An array of three integers for cold, warm, and hot water cups needed.</param>
    /// <returns>The minimum number of seconds required to fill all the cups.</returns>
    /// <link>https://leetcode.com/problems/minimum-amount-of-time-to-fill-cups/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int FillCups(int[] amount)
        => Math.Max(amount.Max(), (amount.Sum() + 1) / 2);
    #endregion

    #region 2154 Keep Multiplying Found Values by Two
    /// <summary>
    /// Multiplies original by two if it is found in nums, and repeats until original is no longer in nums.
    /// </summary>
    /// <param name="nums">An array of integers where each value can be checked for the presence of original.</param>
    /// <param name="original">The initial value to be multiplied by two if found in the array.</param>
    /// <returns>The final value of original after the process.</returns>
    /// <link>https://leetcode.com/problems/keep-multiplying-found-values-by-two/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int FindFinalValue(int[] nums, int original)
    {
        while (nums.Contains(original))
            original *= 2;

        return original;
    }
    #endregion

    #region 1413 Minimum Value to Get Positive Step by Step Sum
    /// <summary>
    /// Computes the minimum start value to ensure the step-by-step sum of `nums` never falls below 1.
    /// </summary>
    /// <param name="nums">Array of integers representing the steps.</param>
    /// <returns>The minimum positive start value.</returns>
    /// <link>https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MinStartValue(int[] nums)
    {
        int minSum = 0, sum = 0;

        foreach (int num in nums)
            minSum = Math.Min(minSum, sum += num);

        return 1 - minSum;
    }
    #endregion

    #region 2956 Find Common Elements Between Two Arrays
    /// <summary>
    /// Finds the number of elements in nums1 that exist in nums2, and vice versa.
    /// </summary>
    /// <param name="nums1">First integer array.</param>
    /// <param name="nums2">Second integer array.</param>
    /// <returns>An array containing two integers: the number of common elements from nums1 to nums2, and from nums2 to nums1.</returns>
    /// <link>https://leetcode.com/problems/find-common-elements-between-two-arrays/</link>
    /// <time>O(n * m)</time>
    /// <space>O(1)</space>
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        => new int[] { nums1.Count(nums2.Contains), nums2.Count(nums1.Contains) };
    #endregion

    #region 1725 Number Of Rectangles That Can Form The Largest Square
    /// <summary>
    /// Counts the number of rectangles that can form the largest possible square.
    /// </summary>
    /// <param name="rectangles">An array of rectangles represented by their lengths and widths.</param>
    /// <returns>Returns the number of rectangles that can form a square with the largest possible side length.</returns>
    /// <link>https://leetcode.com/problems/number-of-rectangles-that-can-form-the-largest-square/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int CountGoodRectangles(int[][] rectangles)
    {
        int maxLen = rectangles.Max(r => Math.Min(r[0], r[1]));
        return rectangles.Count(r => Math.Min(r[0], r[1]) == maxLen);
    }
    #endregion

    #region 914 X of a Kind in a Deck of Cards
    /// <summary>
    /// Checks if the deck can be partitioned into groups of size > 1 with identical cards.
    /// </summary>
    /// <param name="deck">An array where deck[i] represents the number on the ith card.</param>
    /// <returns>Returns true if the deck can be partitioned as described; otherwise, false.</returns>
    /// <link>https://leetcode.com/problems/x-of-a-kind-in-a-deck-of-cards/</link>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public bool HasGroupsSizeX(int[] deck)
    {
        static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

        return deck.GroupBy(x => x)
                   .Select(g => g.Count())
                   .Aggregate(GCD) > 1;
    }
    #endregion

    #region 1629 Slowest Key
    /// <summary>
    /// Finds the key with the longest duration pressed.
    /// </summary>
    /// <param name="releaseTimes">The times at which each key was released.</param>
    /// <param name="keysPressed">The sequence of keys pressed.</param>
    /// <returns>The key with the longest duration pressed, or the largest key in case of a tie.</returns>
    /// <link>https://leetcode.com/problems/slowest-key/</link>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public char SlowestKey(int[] releaseTimes, string keysPressed)
        => keysPressed.Select((c, i)
            => new { Key = c, Duration = i == 0 ? releaseTimes[i] : releaseTimes[i] - releaseTimes[i - 1] })
            .OrderByDescending(x => x.Duration)
            .ThenByDescending(x => x.Key)
            .First().Key;
    #endregion

    #region 3079 Find the Sum of Encrypted Integers
    /// <summary>
    /// Calculates the sum of integers after encrypting each integer in the array.
    /// </summary>
    /// <param name="nums">An array of positive integers.</param>
    /// <returns>The sum of the encrypted integers.</returns>
    /// <link>https://leetcode.com/problems/find-the-sum-of-encrypted-integers/</link>
    /// <time>O(n * d)</time>
    /// <space>O(1)</space>
    public int SumOfEncryptedInt(int[] nums)
        => nums.Sum(n => int.Parse(new string(n.ToString().Max(), n.ToString().Length)));
    #endregion

    #region 1450 Number of Students Doing Homework at a Given Time
    /// <summary>
    /// Counts the number of students who are doing their homework at a specific query time.
    /// </summary>
    /// <param name="startTime">Array representing the start time of homework for each student.</param>
    /// <param name="endTime">Array representing the end time of homework for each student.</param>
    /// <param name="queryTime">The specific time to check for students doing their homework.</param>
    /// <returns>The number of students doing homework at the given query time.</returns>
    /// <link>https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/</link>
    /// <time>O(n)</time> <!-- where n is the length of startTime and endTime -->
    /// <space>O(1)</space>
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        => startTime.Where((t, i) => t <= queryTime && endTime[i] >= queryTime).Count();
    #endregion

    #region 1773 Count Items Matching a Rule
    /// <summary>
    /// Counts the number of items that match a given rule based on the ruleKey and ruleValue.
    /// </summary>
    /// <param name="items">List of items, where each item is a list containing [type, color, name].</param>
    /// <param name="ruleKey">The key of the rule to apply, which can be "type", "color", or "name".</param>
    /// <param name="ruleValue">The value of the rule to match against the items.</param>
    /// <returns>The number of items that match the given rule.</returns>
    /// <link>https://leetcode.com/problems/count-items-matching-a-rule/</link>
    /// <time>O(n)</time> <!-- where n is the number of items in the list -->
    /// <space>O(1)</space>
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        => items.Count(item
            => item[ruleKey switch
            {
                "type" => 0,
                "color" => 1,
                "name" => 2,
                _ => -1
            }] == ruleValue);
    #endregion

    #region 2733 Neither Minimum nor Maximum
    /// <summary>
    /// Finds and returns any number from the array that is neither the minimum nor the maximum value.
    /// </summary>
    /// <param name="nums">Array of distinct positive integers.</param>
    /// <returns>A number that is neither the minimum nor the maximum value, or -1 if there is no such number.</returns>
    /// <link>https://leetcode.com/problems/neither-minimum-nor-maximum/</link>
    /// <time>O(n log n)</time> <!-- Sorting takes O(n log n) time -->
    /// <space>O(1)</space>
    public int FindNonMinOrMax(int[] nums)
        => nums.Length > 2 ? nums.OrderBy(n => n).ElementAt(1) : -1;
    #endregion

    #region 747 Largest Number At Least Twice of Others
    /// <summary>
    /// Determines whether the largest element in the array is at least twice as much as every other number in the array.
    /// </summary>
    /// <param name="nums">Array of integers where the largest integer is unique.</param>
    /// <returns>The index of the largest element if it is at least twice as much as every other number, otherwise -1.</returns>
    /// <link>https://leetcode.com/problems/largest-number-at-least-twice-of-others/</link>
    /// <time>O(n)</time> <!-- Two passes over the array -->
    /// <space>O(1)</space>
    public int DominantIndex(int[] nums)
    {
        int max = nums.Max();
        int index = Array.IndexOf(nums, max);
        return nums.All(x => max >= 2 * x || x == max) ? index : -1;
    }
    #endregion

    #region 2460 Apply Operations to an Array
    /// <summary>
    /// Doubles matching elements, zeroes the next, then moves all zeros to the end
    /// </summary>
    /// <param name="nums">A 0-indexed array of non-negative integers.</param>
    /// <returns>The modified array with all zeros shifted to the end.</returns>
    /// <link>https://leetcode.com/problems/apply-operations-to-an-array/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int[] ApplyOperations(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
            if (nums[i] == nums[i + 1]) { nums[i] *= 2; nums[i + 1] = 0; }

        return nums.Where(x => x != 0).Concat(nums.Where(x => x == 0)).ToArray();
    }
    #endregion

    #region 1217 Minimum Cost to Move Chips to The Same Position
    /// <summary>
    /// Calculates the minimum cost to move all chips to the same position
    /// </summary>
    /// <param name="position">An array of integers representing the positions of the chips.</param>
    /// <returns>The minimum cost to move all chips to the same position.</returns>
    /// <link>https://leetcode.com/problems/minimum-cost-to-move-chips-to-the-same-position/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MinCostToMoveChips(int[] position)
        => Math.Min(position.Count(p => p % 2 == 0), position.Count(p => p % 2 != 0));
    #endregion

    #region 3158 Find the XOR of Numbers Which Appear Twice
    /// <summary>
    /// Returns the XOR of all numbers that appear exactly twice in the array.
    /// </summary>
    /// <param name="nums">An array where each number appears either once or twice.</param>
    /// <returns>The bitwise XOR of numbers that appear twice, or 0 if none.</returns>
    /// <link>https://leetcode.com/problems/find-the-xor-of-numbers-which-appear-twice/</link>
    /// <time>O(n)</time> 
    /// <space>O(n)</space> 
    public int DuplicateNumbersXOR(int[] nums)
        => nums.GroupBy(x => x)
               .Where(g => g.Count() == 2)
               .Select(g => g.Key)
               .Aggregate(0, (acc, x) => acc ^ x);
    #endregion

    #region 2089 Find Target Indices After Sorting Array
    /// <summary>
    /// Finds the indices of the target element after sorting the array in non-decreasing order.
    /// </summary>
    /// <param name="nums">An array of integers to be sorted.</param>
    /// <param name="target">The target integer to find after sorting.</param>
    /// <returns>A list of indices where the target appears in the sorted array.</returns>
    /// <link>https://leetcode.com/problems/find-target-indices-after-sorting-array/</link>
    /// <time>O(n log n)</time> <!-- Sorting the array dominates the time complexity -->
    /// <space>O(n)</space> <!-- Due to the sorting operation -->
    public IList<int> TargetIndices(int[] nums, int target)
        => nums.OrderBy(n => n)
               .Select((n, i) => (n, i))
               .Where(x => x.n == target)
               .Select(x => x.i)
               .ToList();
    #endregion

    #region 1018 Binary Prefix Divisible By 5
    /// <summary>
    /// Checks if each prefix of the binary number formed by the array is divisible by 5.
    /// </summary>
    /// <param name="nums">A binary array of 0s and 1s.</param>
    /// <returns>A list of booleans indicating whether each binary prefix is divisible by 5.</returns>
    /// <link>https://leetcode.com/problems/binary-prefix-divisible-by-5/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public IList<bool> PrefixesDivBy5(int[] nums)
    {
        int x = 0;
        return nums.Select(num => (x = (x * 2 + num) % 5) == 0).ToList();
    }
    #endregion

    #region 1389 Create Target Array in the Given Order
    /// <summary>
    /// Creates a target array by inserting elements from nums into the target array at positions specified by index.
    /// </summary>
    /// <param name="nums">An array of integers to be inserted into the target array.</param>
    /// <param name="index">An array specifying the index positions for each element in nums.</param>
    /// <returns>The target array after all insertions.</returns>
    /// <link>https://leetcode.com/problems/create-target-array-in-the-given-order/</link>
    /// <time>O(n^2)</time>
    /// <space>O(n)</space>
    public int[] CreateTargetArray(int[] nums, int[] index)
        => [.. index.Select((x, i) => (x, nums[i]))
            .Aggregate(new List<int>(), (t, pair)
            => { t.Insert(pair.x, pair.Item2); return t; })];
    #endregion

    #region 2644 Find the Maximum Divisibility Score
    /// <summary>
    /// Finds the divisor from the divisors array that has the highest divisibility score based on nums array.
    /// </summary>
    /// <param name="nums">Array of numbers to be checked for divisibility.</param>
    /// <param name="divisors">Array of divisors to compute the divisibility score.</param>
    /// <returns>The divisor with the maximum divisibility score.</returns>
    /// <link>https://leetcode.com/problems/find-the-maximum-divisibility-score/</link>
    /// <time>O(n * m)</time>
    /// <space>O(1)</space>
    public int MaxDivScore(int[] nums, int[] divisors)
    {
        return divisors.OrderByDescending(d => nums.Count(n => n % d == 0))
            .ThenBy(d => d)
            .First();
    }
    #endregion

    #region 217 Contains Duplicate
    /// <summary>
    /// Checks if there are any duplicate values in the array.
    /// </summary>
    /// <param name="nums">Array of integers.</param>
    /// <returns>True if any value appears at least twice, otherwise False.</returns>
    /// <link>https://leetcode.com/problems/contains-duplicate/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public bool ContainsDuplicate(int[] nums)
        => nums.Length != nums.Distinct().Count();
    #endregion

    #region 1827 Minimum Operations to Make the Array Increasing
    /// <summary>
    /// Calculates the minimum number of operations required to make the array strictly increasing.
    /// </summary>
    /// <param name="nums">Array of integers.</param>
    /// <returns>Minimum number of operations.</returns>
    /// <link>https://leetcode.com/problems/minimum-operations-to-make-the-array-increasing/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MinOperations(int[] nums)
    {
        int ops = 0;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] <= nums[i - 1])
            {
                ops += nums[i - 1] - nums[i] + 1;
                nums[i] = nums[i - 1] + 1;
            }

        return ops;
    }
    #endregion

    #region 1752 Check if Array Is Sorted and Rotated
    /// <summary>
    /// Checks if the array was originally sorted in non-decreasing order and then rotated.
    /// </summary>
    /// <param name="nums">Array of integers.</param>
    /// <returns>True if the array is sorted and rotated, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public bool Check(int[] nums)
        => nums.Where((n, i) => n < nums[(i + nums.Length - 1) % nums.Length]).Count() <= 1;
    #endregion

    #region 3074 Apple Redistribution into Boxes
    /// <summary>
    /// Calculates the minimum number of boxes required to redistribute the apples.
    /// </summary>
    /// <param name="apple">Array representing the number of apples in each pack.</param>
    /// <param name="capacity">Array representing the capacity of each box.</param>
    /// <returns>Minimum number of boxes required to redistribute all the apples.</returns>
    /// <remarks>
    /// <time>O(m log m)</time>
    /// <space>O(1)</space>
    /// </remarks>
    public int MinimumBoxes(int[] apple, int[] capacity)
    {
        int totalApples = apple.Sum();

        return capacity.OrderByDescending(c => c)
            .TakeWhile(c => (totalApples -= c) > 0)
            .Count() + 1;
    }
    #endregion

    #region 1848 Minimum Distance to the Target Element
    /// <summary>
    /// Finds the minimum distance from the start index to any index where the target value occurs in the array.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="target">The target value to find.</param>
    /// <param name="start">The start index.</param>
    /// <returns>The minimum absolute distance to the target.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int GetMinDistance(int[] nums, int target, int start)
        => nums.Select((num, index) => num == target ? Math.Abs(index - start) : int.MaxValue).Min();
    #endregion

    #region 1588 Sum of All Odd Length Subarrays
    /// <summary>
    /// Calculates the sum of all odd-length subarrays.
    /// </summary>
    /// <param name="arr">The input array of positive integers.</param>
    /// <returns>The sum of all odd-length subarrays.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int SumOddLengthSubarrays(int[] arr)
    {
        int sum = 0, n = arr.Length;

        for (int i = 0; i < n; i++)
            sum += ((i + 1) * (n - i) + 1) / 2 * arr[i];

        return sum;
    }
    #endregion

    #region 3162 Find the Number of Good Pairs I
    /// <summary>
    /// Counts the number of good pairs where nums1[i] is divisible by nums2[j] * k.
    /// </summary>
    /// <param name="nums1">The first array of integers.</param>
    /// <param name="nums2">The second array of integers.</param>
    /// <param name="k">The multiplier applied to nums2[j] in the divisibility check.</param>
    /// <returns>The total number of good pairs.</returns>
    /// <time>O(n * m)</time>
    /// <space>O(1)</space>
    public int NumberOfPairs(int[] nums1, int[] nums2, int k)
        => nums1.SelectMany(x => nums2, (x, y) => x % (y * k) == 0)
                .Count(valid => valid);
    #endregion

    #region 867 Transpose Matrix
    /// <summary>
    /// Transposes the given 2D integer array (matrix), flipping it over its main diagonal.
    /// </summary>
    /// <param name="matrix">The input matrix to transpose.</param>
    /// <returns>The transposed matrix.</returns>
    /// <time>O(m * n)</time>
    /// <space>O(m * n)</space>
    public int[][] Transpose(int[][] matrix)
        => Enumerable.Range(0, matrix[0].Length)
            .Select(i => matrix.Select(row => row[i]).ToArray())
            .ToArray();
    #endregion

    #region 2942 Find Words Containing Character
    /// <summary>
    /// Finds the indices of words that contain a specific character.
    /// </summary>
    /// <param name="words">An array of words.</param>
    /// <param name="x">The character to search for in the words.</param>
    /// <returns>A list of indices representing the words that contain the character x.</returns>
    /// <time>O(n * m)</time>
    /// <space>O(1)</space>
    public IList<int> FindWordsContaining(string[] words, char x)
        => words.Select((word, i) => word.Contains(x) ? i : -1).Where(i => i != -1).ToList();
    #endregion

    #region 1827 Minimum Operations to Make the Array Increasing
    /// <summary>
    /// Calculates the minimum number of operations needed to make the array strictly increasing.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>The minimum number of operations.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MinOperations2(int[] nums)
    {
        int prev = nums[0];
        return nums.Skip(1)
            .Select(n => (prev = Math.Max(prev + 1, n)) - n)
            .Sum();
    }
    #endregion

    #region 997 Find the Town Judge
    /// <summary>
    /// Identifies the town judge based on the trust relationships provided.
    /// </summary>
    /// <param name="n">The number of people in the town.</param>
    /// <param name="trust">An array representing trust relationships where trust[i] = [ai, bi].</param>
    /// <returns>The label of the town judge, or -1 if no judge exists.</returns>
    /// <time>O(n)</time> where n is the number of people and t is the number of trust relationships.
    /// <space>O(1)</space>
    public int FindJudge(int n, int[][] trust)
        => Enumerable.Range(1, n).FirstOrDefault(i
            => trust.Count(t => t[1] == i) == n - 1 && trust.All(t => t[0] != i), -1);
    #endregion

    #region 1299 Replace Elements with Greatest Element on Right Side
    /// <summary>
    /// Replaces each element in the array with the greatest element to its right, and replaces the last element with -1.
    /// </summary>
    /// <param name="arr">The input array of integers.</param>
    /// <returns>A new array where each element is replaced with the greatest element to its right.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int[] ReplaceElements(int[] arr)
        => arr.Select((_, i) => i == arr.Length - 1 ? -1 : arr[(i + 1)..].Max()).ToArray();
    #endregion

    #region 2363 Merge Similar Items
    /// <summary>
    /// Merges two item arrays by value, sums weights, and returns a sorted list of lists.
    /// </summary>
    /// <param name="items1">First array of items (value, weight).</param>
    /// <param name="items2">Second array of items (value, weight).</param>
    /// <returns>A merged list of items with summed weights, sorted by value.</returns>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        => [.. items1.Concat(items2)
            .GroupBy(item => item[0])
            .Select(group => new List<int> { group.Key, group.Sum(item => item[1]) })
            .OrderBy(item => item[0])];
    #endregion

    #region 896 Monotonic Array
    /// <summary>
    /// Checks if the given array is monotonic (either entirely non-increasing or non-decreasing).
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>True if the array is monotonic, false otherwise.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public bool IsMonotonic(int[] nums)
        => nums.Zip(nums.Skip(1), (a, b) => a <= b).All(x => x) ||
           nums.Zip(nums.Skip(1), (a, b) => a >= b).All(x => x);
    #endregion

    #region 350 Intersection of Two Arrays II
    /// <summary>
    /// Finds the intersection of two integer arrays, returning each element as many times as it appears in both arrays.
    /// </summary>
    /// <param name="nums1">First array of integers.</param>
    /// <param name="nums2">Second array of integers.</param>
    /// <returns>An array containing the intersection of the two arrays.</returns>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var counts = nums1.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        return nums2.Where(x => counts.ContainsKey(x) && counts[x]-- > 0).ToArray();
    }
    #endregion

    #region 3131 Find the Integer Added to Array I
    /// <summary>
    /// Finds the integer added to each element of nums1 to make it equal to nums2.
    /// </summary>
    /// <param name="nums1">First array of integers.</param>
    /// <param name="nums2">Second array of integers.</param>
    /// <returns>The integer x that was added to each element of nums1.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int AddedInteger(int[] nums1, int[] nums2)
        => nums2.Min() - nums1.Min();
    #endregion

    #region 1539 Kth Missing Positive Number
    /// <summary>
    /// Finds the kth positive integer that is missing from a sorted array of positive integers.
    /// </summary>
    /// <param name="arr">An array of positive integers sorted in strictly increasing order.</param>
    /// <param name="k">The k-th missing positive integer to find.</param>
    /// <returns>The k-th missing positive integer.</returns>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int FindKthPositive(int[] arr, int k)
        => Enumerable.Range(1, arr.Length + k)
            .Except(arr)
            .ElementAt(k - 1);
    #endregion

    #region 283 Move Zeroes
    /// <summary>
    /// Moves all 0's to the end of the array while maintaining the relative order of non-zero elements.
    /// This solution uses additional space for non-zero elements.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public void MoveZeroes(int[] nums)
    {
        var nonZeroes = nums.Where(x => x != 0).ToArray();
        Array.Clear(nums, 0, nums.Length);
        nonZeroes.CopyTo(nums, 0);
    }
    #endregion

    #region 836 Rectangle Overlap
    /// <summary>
    /// Determines if two rectangles overlap based on their corner coordinates.
    /// </summary>
    /// <param name="rec1">First rectangle coordinates: [x1, y1, x2, y2].</param>
    /// <param name="rec2">Second rectangle coordinates: [x1, y1, x2, y2].</param>
    /// <returns>True if rectangles overlap, otherwise false.</returns>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        => rec1[0] < rec2[2] &&
            rec1[2] > rec2[0] &&
            rec1[1] < rec2[3] &&
            rec1[3] > rec2[1];
    #endregion

    #region 2639 Find the Width of Columns of a Grid
    /// <summary>
    /// Finds the width of each column in the grid based on the maximum length of integers in that column.
    /// </summary>
    /// <param name="grid">m x n integer matrix.</param>
    /// <returns>Array where each element is the width of the respective column.</returns>
    /// <time>O(m * n)</time>
    /// <space>O(n)</space>
    public int[] FindColumnWidth(int[][] grid)
        => Enumerable.Range(0, grid[0].Length)
            .Select(j => grid.Max(row => row[j].ToString().Length))
            .ToArray();
    #endregion

    #region 3248 Snake in Matrix
    /// <summary>
    /// Finds the final position of the snake in the grid after following the commands.
    /// </summary>
    /// <param name="n">The size of the grid (n x n).</param>
    /// <param name="commands">The list of commands to move the snake.</param>
    /// <returns>The final position of the snake in the grid.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space> 
    public int FinalPositionOfSnake(int n, IList<string> commands)
    {
        int row = 0;
        int col = 0;

        foreach (string command in commands)
        {
            if (command == "UP" && row > 0)
                row--;
            else if (command == "DOWN" && row < n - 1)
                row++;
            else if (command == "LEFT" && col > 0)
                col--;
            else if (command == "RIGHT" && col < n - 1)
                col++;
        }

        return row * n + col;
    }
    #endregion

    #region 2496 Maximum Value of a String in an Array
    /// <summary>
    /// Returns the maximum value of any string in the array based on the given criteria.
    /// </summary>
    /// <param name="strs">An array of alphanumeric strings.</param>
    /// <returns>The maximum value of any string in the array.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MaximumValue(string[] strs)
        => strs.Max(s => int.TryParse(s, out int n) ? n : s.Length);
    #endregion

    #region 1822 Sign of the Product of an Array
    /// <summary>
    /// Returns the sign of the product of all values in the array.
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>1 if the product is positive, -1 if the product is negative, 0 if the product is 0.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int ArraySign(int[] nums)
        => nums.Contains(0) ? 0 : nums.Count(n => n < 0) % 2 == 0 ? 1 : -1;
    #endregion

    #region 3151 Special Array I
    /// <summary>
    /// Determines if an array is special, meaning every pair of adjacent elements has different parity
    /// </summary>
    /// <param name="nums">An array of integers.</param>
    /// <returns>True if the array is special, otherwise false.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public bool IsArraySpecial(int[] nums)
        => nums.Zip(nums.Skip(1), (a, b) => a % 2 != b % 2).All(x => x);
    #endregion

    #region 2395 Find Subarrays With Equal Sum
    /// <summary>
    /// Determines if there exist two subarrays of length 2 with equal sum in the array.
    /// </summary>
    /// <param name="nums">The input array of integers.</param>
    /// <returns>True if two subarrays with equal sum exist, otherwise false.</returns>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public bool FindSubarrays(int[] nums)
    {
        HashSet<int> sums = [];

        for (int i = 1; i < nums.Length; i++)
        {
            int sum = nums[i] + nums[i - 1];

            if (!sums.Add(sum))
                return true;
        }

        return false;
    }
    #endregion

    #region 1608 Special Array With X Elements Greater Than or Equal X
    /// <summary>
    /// Finds the special number x such that exactly x numbers are greater than or equal to x.
    /// </summary>
    /// <param name="nums">The array of non-negative integers.</param>
    /// <returns>The special number x or -1 if it doesn't exist.</returns>
    /// <time>O(n^2)</time>
    /// <space>O(1)</space>
    public int SpecialArray(int[] nums)
    {
        for (int x = 0; x <= nums.Length; ++x)
            if (x == nums.Count(num => num >= x))
                return x;

        return -1;
    }
    #endregion

    #region 1313 Decompress Run-Length Encoded List
    /// <summary>
    /// Decompresses the run-length encoded list into its original form.
    /// </summary>
    /// <param name="nums">The run-length encoded array of integers.</param>
    /// <returns>The decompressed list of integers.</returns>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public int[] DecompressRLElist(int[] nums)
    {
        List<int> result = [];

        for (int i = 0; i < nums.Length; i += 2)
            result.AddRange(Enumerable.Repeat(nums[i + 1], nums[i]));

        return [.. result];
    }
    #endregion

    #region 1295 Find Numbers with Even Number of Digits
    /// <summary>
    /// Returns the count of numbers with an even number of digits in the given array.
    /// </summary>
    /// <param name="nums">Array of integers.</param>
    /// <returns>The count of numbers containing an even number of digits.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int FindNumbers(int[] nums)
        => nums.Count(n => (n.ToString().Length & 1) == 0);
    #endregion

    #region 2016 Maximum Difference Between Increasing Elements
    /// <summary>
    /// Finds the maximum difference nums[j] - nums[i] where 0 <= i < j < n and nums[i] < nums[j].
    /// </summary>
    /// <param name="nums">An integer array.</param>
    /// <returns>The maximum difference satisfying the conditions, or -1 if none exists.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MaximumDifference(int[] nums)
    {
        int maxDiff = -1, min = nums[0];

        foreach (var num in nums[1..])
            if (num > min)
                maxDiff = Math.Max(maxDiff, num - min);
            else
                min = num;

        return maxDiff;
    }
    #endregion

    #region 1637 Widest Vertical Area Between Two Points Containing No Points
    /// <summary>
    /// Finds the maximum width of a vertical area between two points in a 2D plane such that no points are inside the area.
    /// </summary>
    /// <param name="points">An array of points represented as integer arrays.</param>
    /// <returns>The maximum width of the vertical area.</returns>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var x = points.Select(p => p[0]).OrderBy(x => x).ToArray();
        return x.Zip(x.Skip(1), (a, b) => b - a).DefaultIfEmpty(0).Max();
    }
    #endregion

    #region 136 Single Number
    /// <summary>
    /// Finds the single number in an array where every element appears twice except for one.
    /// </summary>
    /// <param name="nums">An integer array where each element appears twice except one.</param>
    /// <returns>The single element that appears only once.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int SingleNumber(int[] nums)
        => nums.Aggregate(0, (xor, i) => xor ^ i);
    #endregion

    #region 2114 Maximum Number of Words Found in Sentences
    /// <summary>
    /// Finds the maximum number of words in a single sentence from an array of sentences.
    /// </summary>
    /// <param name="sentences">An array of strings where each string represents a sentence.</param>
    /// <returns>The maximum word count found in any sentence.</returns>
    /// <time>O(n * m)</time>
    /// <space>O(1)</space>
    public int MostWordsFound(string[] sentences)
        => sentences.Max(s => s.Count(c => c == ' ') + 1);
    #endregion

    #region 80 Remove Duplicates from Sorted Array II
    /// <summary>
    /// Removes duplicates in-place from a sorted array so that each unique element appears at most twice.
    /// </summary>
    /// <param name="nums">A sorted array of integers.</param>
    /// <returns>The length k, where the first k elements of nums contain the result with at most two duplicates per unique element.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int RemoveDuplicates2(int[] nums)
    {
        int k = Math.Min(2, nums.Length);

        foreach (var num in nums.Skip(2))
            if (num != nums[k - 2])
                nums[k++] = num;

        return k;
    }
    #endregion

    #region 3300 Minimum Element After Replacement With Digit Sum
    /// <summary>
    /// Replaces each element in the input array with the sum of its digits and returns the minimum element after replacement.
    /// </summary>
    /// <param name="nums">The input integer array.</param>
    /// <returns>The minimum element in the array after all replacements with the sum of digits.</returns>
    /// <time>O(n * d)</time>
    /// <space>O(1)</space>
    public int MinElement(int[] nums)
    {
        int minElement = int.MaxValue;

        foreach (int num in nums)
        {
            int digitSum = num.ToString().Sum(c => c - '0');
            minElement = Math.Min(minElement, digitSum);
        }

        return minElement;
    }
    #endregion

    #region 860 Lemonade Change
    /// <summary>
    /// Determines if it's possible to provide the correct change for every customer in line at a lemonade stand.
    /// </summary>
    /// <param name="bills">An array where each element represents a bill ($5, $10, or $20) that a customer pays.</param>
    /// <returns>True if every customer can receive the correct change, otherwise false.</returns>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public bool LemonadeChange(int[] bills)
    {
        int fiveCount = 0, tenCount = 0;

        foreach (int bill in bills)
            switch (bill)
            {
                case 5:
                    fiveCount++;
                    break;
                case 10:
                    if (fiveCount == 0) return false;
                    fiveCount--;
                    tenCount++;
                    break;
                case 20:
                    if (tenCount > 0 && fiveCount > 0)
                    {
                        tenCount--;
                        fiveCount--;
                    }
                    else if (fiveCount >= 3) fiveCount -= 3;
                    else return false;
                    break;
            }

        return true;
    }
    #endregion

    #region 1863 Sum of All Subset XOR Totals
    /// <summary>
    /// Calculates the sum of XOR totals for all subsets of the given array.
    /// </summary>
    /// <param name="nums">An array of integers</param>
    /// <returns>The sum of XOR totals for every subset</returns>
    /// <time>O(2^n)</time>
    /// <space>O(n)</space>
    public int SubsetXORSum(int[] nums) => Calculate(nums, 0, 0);

    private int Calculate(int[] nums, int index, int currentXor) =>
        index == nums.Length ? currentXor : Calculate(nums, index + 1, currentXor) + Calculate(nums, index + 1, currentXor ^ nums[index]);
    #endregion

    #region 976 Largest Perimeter Triangle
    /// <summary>
    /// Finds the largest perimeter of a triangle that can be formed from three lengths in the array.
    /// </summary>
    /// <param name="nums">An array of integers representing the lengths</param>
    /// <returns>The largest perimeter of a valid triangle or 0 if none can be formed</returns>
    /// <time>O(n log n)</time>
    /// <space>O(1)</space>
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        for (int i = nums.Length - 3; i >= 0; i--)
            if (nums[i] + nums[i + 1] > nums[i + 2])
                return nums[i] + nums[i + 1] + nums[i + 2];
        return 0;
    }
    #endregion

    #region 506 Relative Ranks
    /// <summary>
    /// Assigns relative ranks to athletes based on their scores.
    /// </summary>
    /// <param name="score">An array of unique integers representing scores of athletes.</param>
    /// <returns>An array of strings where each string represents the rank of the corresponding athlete.</returns>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public string[] FindRelativeRanks(int[] score)
    {
        int n = score.Length;
        string[] result = new string[n];

        var ranked = score
            .Select((s, i) => new { Score = s, Index = i })
            .OrderByDescending(x => x.Score)
            .ToList();

        for (int i = 0; i < n; i++)
            result[ranked[i].Index] = i switch
            {
                0 => "Gold Medal",
                1 => "Silver Medal",
                2 => "Bronze Medal",
                _ => (i + 1).ToString()
            };

        return result;
    }
    #endregion
}

#region 705 Design HashSet
/// <summary>
/// Implements a HashSet without using any built-in hash table libraries.
/// </summary>
/// <link>https://leetcode.com/problems/design-hashset/</link>
/// <time>O(n)</time>
/// <space>O(n)</space>
public class MyHashSet
{
    private readonly List<int> elements;

    public MyHashSet()
    {
        elements = [];
    }

    public void Add(int key)
    {
        if (!elements.Contains(key))
            elements.Add(key);
    }

    public void Remove(int key)
    {
        elements.Remove(key);
    }

    public bool Contains(int key)
        => elements.Contains(key);
}
#endregion