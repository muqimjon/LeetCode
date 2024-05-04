namespace EasyFundamental;

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

    #region 1275. Find Winner on a Tic Tac Toe Game
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

    #region 2917. Find the K-or of an Array
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

    #region 1491. Average Salary Excluding the Minimum and Maximum Salary
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

    #region 169. Majority Element
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

    #region 2108. Find First Palindromic String in the Array
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

    #region 118. Pascal's Triangle
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
                row.Add(j == 0 || j == i ? 1 : triangle[i-1][j-1] + triangle[i-1][j]);
            triangle.Add(row);
        }

        return triangle;
    }
    #endregion

    #region 706. Binary Search
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

    #region 1646. Get Maximum in Generated Array
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

    #region 2535. Difference Between Element Sum and Digit Sum of an Array
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

    #region 2788. Split Strings by Separator
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

    #region 231. Power of Two
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

    #region 268. Missing Number
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

    #region 1502. Can Make Arithmetic Progression From Sequence
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

    #region 2248. Intersection of Multiple Arrays
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

    #region 977. Squares of a Sorted Array
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

    #region 1929. Concatenation of Array
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

    #region 744. Find Smallest Letter Greater Than Target
    /// <summary>
    /// Finds the smallest letter greater than the target letter in the given array of letters.
    /// </summary>
    /// <param name="letters"> The array of letters.</param>
    /// <param name="target"> The target letter. </param>
    /// <returns> The smallest letter greater than the target letter in the given array of letters. </returns>
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

    #region 3000. Minimum Area Rectangle
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

    #region 3024. Type of Triangle
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

    #region 1816. Truncate Sentence
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

    #region 1636. Sort Array by Increasing Frequency
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

    #region 1480. Running Sum of 1d Array
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

    #region 1662. Check If Two String Arrays are Equivalent
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

    #region 1460. Make Two Arrays Equal
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

    #region 1437. Check If All 1's Are at Least Length K Places Away
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

    #region 1920. Build Array from Permutation
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

    #region 1464. Maximum Product of Two Elements in an Array
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

    #region 2678. Number of Senior Citizens
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

    #region 1337. The K Weakest Rows in a Matrix
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

    #region 205. Isomorphic Strings
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

    #region 2255. Count Prefixes of a Given String
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

    #region 1550. Three Consecutive Odds
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
}