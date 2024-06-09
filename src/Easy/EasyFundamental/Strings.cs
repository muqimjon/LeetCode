using System.Text;

namespace EasyFundamental;

public class Strings
{
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

    #region 709. To Lower Case
    /// <summary>
    /// 709. To Lower Case
    /// Given a string s, return the string after replacing every uppercase letter with the same lowercase letter.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The string after converting every uppercase letter to lowercase.</returns>
    /// <time>Runtime: O(n) - Linear time complexity</time>
    /// <space>Memory: O(n) - Linear space complexity</space>
    public string ToLowerCase(string s)
        => new(s.Select(c 
            => char.IsUpper(c) ? (char)(c + 32) : c)
            .ToArray());
    #endregion

    #region 58. Length of Last Word
    /// <summary>
    /// 58. Length of Last Word
    /// Returns the length of the last word in the given string, where a word is a substring of non-space characters.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The length of the last word in the string.</returns>
    /// <time>Runtime: O(n) - Linear time complexity</time>
    /// <space>Memory: O(n) - Linear space complexity</space>
    public int LengthOfLastWord(string s)
        => s.Split().Last(p => p.Length > 0).Length;
    #endregion

    #region 1768. Merge Strings Alternately
    /// <summary>
    /// Merges strings by alternating letters, starting with word1, and appends extra letters from the longer string.
    /// </summary>
    /// <param name="word1">The first input string.</param>
    /// <param name="word2">The second input string.</param>
    /// <returns>The merged string.</returns>
    /// <time>Runtime: O(N,M)</time>
    /// <space>Memory: O(N + M)</space>
    public string MergeAlternately(string word1, string word2)
    {
        var word = new StringBuilder();
        var length = Math.Min(word1.Length, word2.Length);
        for (int i = 0; i < length; ++i)
        {
            word.Append(word1[i]);
            word.Append(word2[i]);
        }

        word.Append(word1.Length > length ?
            word1.Substring(length) :
            word2.Substring(length)
        ).ToString();

        return word.ToString();
    }
    #endregion

    #region 125. Validating Polindrome
    /// <summary>
    /// Determines if a given string is a palindrome after removing non-alphanumeric characters and converting to lowercase.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>True if the string is a palindrome, false otherwise.</returns>
    /// <time>Runtime: O(n)</time>
    /// <space>Memory: O(n)</space>
    public bool IsPalindrome(string s)
    {
        s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return s == new string(s.Reverse().ToArray());
    }

    #endregion

    #region 1941. Check if All Characters Have Equal Number of Occurrences
    /// <summary>
    /// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
    /// Return the array in the form [x1,y1,x2,y2,...,xn,yn].
    /// </summary>
    /// <param name="nums">The input array consisting of 2n elements.</param>
    /// <param name="n">The number of pairs.</param>
    /// <returns>The array in the form [x1,y1,x2,y2,...,xn,yn].</returns>
    /// <link>https://leetcode.com/problems/shuffle-the-array/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[2 * n];
        for (int i = 0, j = 0; i < n; i++, j += 2)
            (result[j], result[j + 1]) = (nums[i], nums[i + n]);

        return result;
    }

    #endregion

    #region 2379. Minimum Recolors to Get K Consecutive Black Blocks
    /// <summary>
    /// Finds the minimum number of recolors needed to obtain K consecutive black blocks.
    /// </summary>
    /// <param name="blocks">The input string representing the color of blocks.</param>
    /// <param name="k">The desired number of consecutive black blocks.</param>
    /// <returns>The minimum number of recolors needed.</returns>
    /// <link>https://leetcode.com/problems/minimum-recolors-to-get-k-consecutive-black-blocks/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MinimumRecolors(string blocks, int k)
    {
        int n = blocks.Length;
        int windowStart = 0;
        int minRecolors = int.MaxValue;
        int numBlack = 0;

        for (int windowEnd = 0; windowEnd < n; windowEnd++)
        {
            numBlack += blocks[windowEnd] == 'B' ? 1 : 0;

            if (windowEnd - windowStart + 1 == k)
            {
                minRecolors = Math.Min(minRecolors, k - numBlack);

                if (blocks[windowStart] == 'B')
                    numBlack--;

                windowStart++;
            }
        }

        return minRecolors != int.MaxValue ? minRecolors : 0;
    }
    #endregion

    #region 1446. Consecutive Characters
    /// <summary>
    /// Finds the maximum power of consecutive characters in the given string.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The maximum power of consecutive characters.</returns>
    /// <link>https://leetcode.com/problems/consecutive-characters/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MaxPower(string s)
    {
        int maxPower = 1;
        int currentPower = 1;

        for (int i = 1; i < s.Length; i++)
            if (s[i] == s[i - 1])
                maxPower = Math.Max(maxPower, ++currentPower);
            else
                currentPower = 1;

        return maxPower;
    }
    #endregion

    #region 520. Detect Capital
    /// <summary>
    /// Determines if the usage of capitals in a word is correct.
    /// </summary>
    /// <param name="word">The word to check.</param>
    /// <returns>True if the usage of capitals is correct, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/detect-capital/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool DetectCapitalUse(string word)
    {
        bool allUpper = char.IsUpper(word[0]);
        bool lower = true;

        foreach (char c in word[1..])
            if (char.IsUpper(c)) lower = false;
            else allUpper = false;

        return lower || allUpper;
    }
    #endregion

    #region 1108. Defanging an IP Address
    /// <summary>
    /// Returns the defanged version of the given IP address.
    /// </summary>
    /// <param name="address">The IP address to defang.</param>
    /// <returns>The defanged version of the given IP address.</returns>
    /// <link>https://leetcode.com/problems/defanging-an-ip-address/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public string DefangIPaddr(string address)
        => address.Replace(".", "[.]");
    #endregion

    #region 796. Rotate String
    /// <summary>
    /// Checks if s can become goal after some number of shifts.
    /// </summary>
    /// <param name="s">The original string.</param>
    /// <param name="goal">The target string to achieve.</param>
    /// <returns>True if s can become goal after some number of shifts, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/rotate-string/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public bool RotateString(string s, string goal)
        => s.Length == goal.Length && (s + s).Contains(goal);
    #endregion

    #region 2124. Check if All A's Appears Before All B's
    /// <summary>
    /// Checks if all A's appear before all B's
    /// </summary>
    /// <param name="s">The input string</param>
    /// <returns>True if all A's appear before all B's</returns>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public bool CheckString(string s)
    {
        bool foundB = false;
        foreach (char c in s)
            if (c == 'b')
                foundB = true;
            else if (c == 'a' && foundB)
                return false;

        return true;
    }
    #endregion

    #region 1507. Reformat Date
    /// <summary>
    /// Reformats the given date in the format "MM/DD/YYYY".
    /// </summary>
    /// <param name="date">The date in the format "MM/DD/YYYY".</param>
    /// <returns>The reformatted date in the format "YYYY-MM-DD".</returns>
    /// <link>https://leetcode.com/problems/reformat-date/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public string ReformatDate(string date)
    {
        string[] parts = date.Split();
        string month = parts[1] switch
        {
            "Jan" => "01",
            "Feb" => "02",
            "Mar" => "03",
            "Apr" => "04",
            "May" => "05",
            "Jun" => "06",
            "Jul" => "07",
            "Aug" => "08",
            "Sep" => "09",
            "Oct" => "10",
            "Nov" => "11",
            _ => "12"
        };

        return $"{parts[2]}-{month}-{int.Parse(parts[0][..^2]):D2}";
    }
    #endregion

    #region 1614. Maximum Nesting Depth of the Parentheses
    /// <summary>
    /// Returns the maximum nesting depth of the parentheses in the given string.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The maximum nesting depth of the parentheses.</returns>
    /// <link>https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MaxDepth(string s)
    {
        int max = 0, current = 0;
        foreach (char c in s)
            if (c == '(') max = Math.Max(max, ++current);
            else if (c == ')') current--;

        return max;
    }
    #endregion

    #region 1221. Split a String in Balanced Strings
    public int BalancedStringSplit(string s)
    {
        int count = 0, balance = 0;

        foreach (char c in s)
        {
            if (c == 'L') balance++;
            else balance--;

            if (balance == 0) count++;
        }

        return count;
    }
    #endregion

    #region 3019. Number of Changing Keys
    /// <summary>
    /// Counts the number of key changes in a given string.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The number of key changes.</returns>
    /// <link>https://leetcode.com/problems/number-of-changing-keys/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int CountKeyChanges(string s)
        => s.Zip(s.Skip(1), (a, b) => char.ToLower(a) != char.ToLower(b)).Count(change => change);
    #endregion

    #region 2315. Count Asterisks
    /// <summary>
    /// Counts the number of asterisks in a string, excluding those between pairs of vertical bars '|'.
    /// </summary>
    /// <param name="s">The input string containing asterisks and vertical bars.</param>
    /// <returns>The number of asterisks not between '|' pairs.</returns>
    /// <link>https://leetcode.com/problems/count-asterisks/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public int CountAsterisks(string s)
        => s.Split('|')
                .Where((_, ind) => ind % 2 != 1)
                .Sum(sub => sub.Count(c => c == '*'));
    #endregion

    #region 482. License Key Formatting
    /// <summary>
    /// Reformats a license key string by grouping characters and adding dashes.
    /// </summary>
    /// <param name="s">The original license key string.</param>
    /// <param name="k">The desired group size.</param>
    /// <returns>The reformatted license key string.</returns>
    /// <link>https://leetcode.com/problems/license-key-formatting/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(n)</space>
    public string LicenseKeyFormatting(string s, int k)
    {
        var ls = s.Replace("-", "").ToUpper().ToList();

        for (int i = ls.Count - k; i > 0; i -= k)
            ls.Insert(i, '-');

        return string.Join("", ls);
    }
    #endregion

    #region 1967. Number of Strings That Appear as Substrings in Word
    /// <summary>
    /// Calculates the number of strings in an array that appear as substrings in a given word.
    /// </summary>
    /// <param name="patterns">An array of strings to search for.</param>
    /// <param name="word">The word in which to search for substrings.</param>
    /// <returns>The number of strings from patterns that are substrings of word.</returns>
    /// <link>https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/</link>
    /// <time>O(n*m)</time>
    /// <space>O(1)</space>
    public int NumOfStrings(string[] patterns, string word)
        => patterns.Count(word.Contains);
    #endregion

    #region 1422. Maximum Score After Splitting a String
    /// <summary>
    /// Calculates maximum score by splitting string.
    /// </summary>
    /// <param name="s">The input string of zeros and ones.</param>
    /// <returns>The maximum score after splitting the string.</returns>
    /// <link>https://leetcode.com/problems/maximum-score-after-splitting-a-string/</link>
    /// <time>Time Complexity: O(n)</time>
    /// <space>Space Complexity: O(1)</space>
    public int MaxScore(string s)
        => Enumerable.Range(1, s.Length - 1)
            .Max(i => s.Take(i).Count(c => c == '0') + s.Skip(i).Count(c => c == '1'));
    #endregion

    #region 3114. Latest Time You Can Obtain After Replacing Characters
    /// <summary>
    /// Finds the latest possible 12-hour format time by replacing "?" characters in the input string.
    /// </summary>
    /// <param name="s">The input string representing a 12-hour format time with "?" characters.</param>
    /// <returns>The latest possible 12-hour format time as a string.</returns>
    /// <link>https://leetcode.com/problems/latest-time-you-can-obtain-after-replacing-characters/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public string FindLatestTime(string s)
    {
        char[] time = s.ToCharArray();

        time[0] = time[0] is '?' ? "1?0".Contains(time[1]) ? '1' : '0' : time[0];
        time[1] = time[1] is '?' ? time[0] == '1' ? '1' : '9' : time[1];
        time[3] = time[3] is '?' ? '5' : time[3];
        time[4] = time[4] is '?' ? '9' : time[4];

        return new string(time);
    }
    #endregion

    #region 2278. Percentage of Letter in String
    /// <summary>
    /// Calculates the percentage of characters in a string that equal the given letter, rounded down to the nearest whole percent.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <param name="letter">The character to count.</param>
    /// <returns>The percentage of the character in the string.</returns>
    /// <link>https://leetcode.com/problems/percentage-of-letter-in-string/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int PercentageLetter(string s, char letter)
        => 100 * s.Count(c => c == letter) / s.Length;
    #endregion

    #region 1880. Check if Word Equals Summation of Two Words
    /// <summary>
    /// Checks if the sum of the numerical values of two words equals the numerical value of a target word.
    /// </summary>
    /// <param name="firstWord">The first word.</param>
    /// <param name="secondWord">The second word.</param>
    /// <param name="targetWord">The target word.</param>
    /// <returns>True if the sum equals the target, false otherwise.</returns>
    /// <link>https://leetcode.com/problems/check-if-word-equals-summation-of-two-words/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        => ToNum(firstWord) + ToNum(secondWord) == ToNum(targetWord);

    private int ToNum(string word)
        => int.Parse(string.Concat(word.Select(c => c - 97)));
    #endregion

    #region 1974. Minimum Time to Type Word Using Special Typewriter
    /// <summary>
    /// Calculates the minimum number of seconds required to type out a given word using a special typewriter.
    /// </summary>
    /// <param name="word">The word to be typed.</param>
    /// <returns>The minimum number of seconds to type out the characters in the word.</returns>
    /// <link>https://leetcode.com/problems/minimum-time-to-type-word-using-special-typewriter/</link>
    /// <time>O(n)</time> // where n is the length of the input word
    /// <space>O(1)</space> // constant space is used
    public int MinTimeToType(string word)
        => word.Length + word.Select((c, i) 
            => Math.Min(Math.Abs(c - (i == 0 ? 'a' : word[i - 1])), 26 - Math.Abs(c - (i == 0 ? 'a' : word[i - 1])))).Sum();
    #endregion

    #region 1374. Generate a String With Characters That Have Odd Counts
    /// <summary>
    /// Generates a string of length n with characters having odd counts.
    /// </summary>
    /// <param name="n">The length of the string to generate.</param>
    /// <returns>A string with n characters, each occurring an odd number of times.</returns>
    /// <link>https://leetcode.com/problems/generate-a-string-with-characters-that-have-odd-counts/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public string GenerateTheString(int n)
        => n % 2 == 0 ? new string('a', n - 1) + 'b' : new string('a', n);
    #endregion

    #region 1844. Replace All Digits with Characters
    /// <summary>
    /// Replaces digits in a string with characters shifted from preceding characters.
    /// </summary>
    /// <param name="s">Input string with letters at even indices and digits at odd indices.</param>
    /// <returns>String after replacing all digits with shifted characters.</returns>
    /// <link>https://leetcode.com/problems/replace-all-digits-with-characters/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public string ReplaceDigits(string s)
        => new(s.Select((c, i) => i % 2 == 0 ? c : (char)(s[i - 1] + (c - '0'))).ToArray());
    #endregion

    #region 1668. Maximum Repeating Substring
    /// <summary>
    /// Finds the maximum k-repeating value of a word in a given sequence.
    /// </summary>
    /// <param name="sequence">The sequence string to search within.</param>
    /// <param name="word">The word to find the maximum k-repeating value for.</param>
    /// <returns>The highest value k where word concatenated k times is a substring of sequence.</returns>
    /// <link>https://leetcode.com/problems/maximum-repeating-substring/</link>
    /// <time>O(n^2)</time>
    /// <space>O(1)</space>
    public int MaxRepeating(string sequence, string word)
        => Enumerable.Range(1, sequence.Length / word.Length + 1).Reverse().FirstOrDefault(k => sequence.Contains(string.Concat(Enumerable.Repeat(word, k))));
    #endregion
}