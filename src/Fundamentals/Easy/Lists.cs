namespace Easy;

public class Lists
{
    #region 9. Palindrome Number
    /// <summary>
    /// 9. Palindrome Number
    /// </summary>
    /// <param name="x">Integer to check for palindrome</param>
    /// <returns>True if the integer is a palindrome, otherwise false</returns>
    /// <time>Runtime: O(log10(x)) - Time complexity logarithmic with respect to the input size</time>
    /// <space>Memory: O(1) - Constant space complexity, as only a few variables are used</space>
    public bool IsPalindrome(int x)
    {
        // Variable to store the reversed integer
        int reversed = 0;

        // Variable to store the original integer
        int original = x;

        // Reverse the digits of the integer
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        // Check if the reversed integer is equal to the original integer
        return reversed == original;
    }
    #endregion

    #region 13. Roman to Integer
    /// <summary>
    /// 13. Roman to Integer
    /// </summary>
    /// <param name="s">Roman numeral string</param>
    /// <returns>Integer representation of the Roman numeral</returns>
    /// <time>Runtime: O(n) - Linear time complexity, where n is the length of the input string</time>
    /// <space>Memory: O(1) - Constant space complexity, as the dictionary size is fixed</space>
    public int RomanToInt(string s)
    {
        // Dictionary to store Roman numeral characters and their corresponding values
        Dictionary<char, int> numbers = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

        // Variable to store the result
        int result = 0;

        // Iterate through each character in the input string
        for (int i = 0; i < s.Length; i++)
        {
            // Check if the current numeral is smaller than the next numeral
            if (i < s.Length - 1 && numbers[s[i]] < numbers[s[i + 1]])
                // Subtract the current numeral value from the result
                result -= numbers[s[i]];
            else
                // Add the current numeral value to the result
                result += numbers[s[i]];
        }

        // Return the final result as the integer representation of the Roman numeral
        return result;
    }
    #endregion

    #region 14. Longest Common Prefix
    /// <summary>
    /// 14. Longest Common Prefix
    /// </summary>
    /// <param name="words">Array of strings</param>
    /// <returns>Longest common prefix as a string</returns>
    /// <time>Runtime: O(n * m) - Linear time complexity with respect to both n and m</time>
    /// <space>Memory: O(1) - Constant space complexity</space>
    public string LongestCommonPrefix(string[] words)
    {
        if (words.Length == 0)
            return "";

        // Determine the common length based on the minimum length of words
        int commonLength = words.Min(w => w.Length);

        // Iterate through each character position up to the common length
        for (int i = 0; i < commonLength; i++)
        {
            // Get the current character to compare
            char currentChar = words[0][i];

            // Check if the character at the current position is the same for all words
            if (words.Any(w => w[i] != currentChar))
                return words[0][0..i];
        }

        // Return the longest common prefix
        return words[0][0..commonLength];
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

    #region 28. Find the Index of the First Occurrence in a String
    /// <summary>
    /// 28. Find the Index of the First Occurrence in a String
    /// </summary>
    /// <param name="haystack">The input string</param>
    /// <param name="needle">The substring to search for</param>
    /// <returns>The index of the first occurrence of the needle in haystack, or -1 if not found</returns>

    /// Solution 1
    /// <time>Runtime: O(n²) - Quadratic time complexity due to nested loops</time>
    /// <space>Memory: O(1) - Constant space complexity as only a few variables are used</space>
    public int StrStr(string haystack, string needle)
    {
        // Check if the needle is empty
        if (string.IsNullOrEmpty(needle))
            return 0;

        // Get the lengths of the input string and the needle
        var hayLength = haystack.Length;
        var needleLength = needle.Length;

        // Iterate through the input string
        for (int i = 0; i <= hayLength - needleLength; i++)
        {
            int j;

            // Compare characters in the needle with the substring in the haystack
            for (j = 0; j < needleLength; j++)
            {
                if (haystack[i + j] != needle[j])
                    break;
            }

            // If the entire needle is found, return the index
            if (j == needleLength)
                return i;
        }

        // Needle not found in haystack
        return -1;
    }

    /// Solution 2
    /// <time>Runtime: O(n²) - Quadratic time complexity</time>
    /// <space>Memory: O(1) - Constant space complexity</space>
    public int StrStr2(string haystack, string needle)
    {
        if (haystack.Contains(needle)) // haystack = "anything", needle = "" => true
        {
            if (string.IsNullOrEmpty(needle))
                return 0;

            var ch = haystack.Length;
            var cn = needle.Length;
            var c = needle.First();

            for (int i = haystack.IndexOf(c); i < ch;)
                if (haystack.Substring(i, cn).Equals(needle))
                    return i;
                else
                    i = haystack.IndexOf(c, i + 1);
        }
        return -1;
    }
    #endregion  
}
