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

    #region 1704. Determine if String Halves Are Alike
    /// <summary>
    /// Determines if the two halves of the given string are alike by comparing the number of vowels in each half.
    /// </summary>
    /// <param name="s">The input string of even length.</param>
    /// <returns>True if both halves have the same number of vowels, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/determine-if-string-halves-are-alike/</link>
    /// <time>O(n)</time> where n is the length of the string.
    /// <space>O(1)</space>
    public bool HalvesAreAlike(string s)
        => s.Take(s.Length / 2).Count(c => "aeiouAEIOU".Contains(c))
        == s.Skip(s.Length / 2).Count(c => "aeiouAEIOU".Contains(c));
    #endregion

    #region 1047. Remove All Adjacent Duplicates In String
    /// <summary>
    /// Removes all adjacent duplicate characters from the string.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The final string after all adjacent duplicates have been removed.</returns>
    /// <link>https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public string RemoveDuplicates(string s)
    {
        Stack<char> stack = [];
        foreach (var c in s)
        {
            if (stack.Count > 0 && stack.Peek() == c)
                stack.Pop();
            else
                stack.Push(c);
        }
        return new string(stack.Reverse().ToArray());
    }
    #endregion

    #region 1784. Check if Binary String Has at Most One Segment of Ones
    /// <summary>
    /// Checks if a binary string contains at most one contiguous segment of ones.
    /// </summary>
    /// <param name="s">The binary string without leading zeros.</param>
    /// <returns>True if the string contains at most one contiguous segment of ones, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public bool CheckOnesSegment(string s)
        => !s.Contains("01");
    #endregion

    #region 2833. Furthest Point From Origin
    /// <summary>
    /// Returns the furthest distance from the origin after a series of moves.
    /// </summary>
    /// <param name="moves">A string representing movements 'L', 'R', or '_' on a number line.</param>
    /// <returns>The furthest distance from the origin reachable after the moves.</returns>
    /// <link>https://leetcode.com/problems/furthest-point-from-origin/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int FurthestDistanceFromOrigin(string moves)
        => Math.Abs(moves.Count(c => c == 'R') - moves.Count(c => c == 'L')) + moves.Count(c => c == '_');
    #endregion

    #region 2264. Largest 3-Same-Digit Number in String
    /// <summary>
    /// Finds the largest "good" integer of length 3 in the given string.
    /// </summary>
    /// <param name="num">String representing a large integer.</param>
    /// <returns>The largest "good" integer as a string, or an empty string if none exists.</returns>
    /// <link>https://leetcode.com/problems/largest-3-same-digit-number-in-string/</link>
    /// <time>O(n)</time> where n is the length of num.
    /// <space>O(1)</space> additional space.
    public string LargestGoodInteger(string num)
    {
        string maxGood = "";

        for (int i = 0; i < num.Length - 2; i++)
        {
            string substr = num.Substring(i, 3);

            if (substr[0] == substr[1] && substr[1] == substr[2])
                maxGood = substr.CompareTo(maxGood) > 0 ? substr : maxGood;
        }

        return maxGood;
    }
    #endregion

    #region Faulty Keyboard
    /// <summary>
    /// Simulates typing on a faulty keyboard where typing 'i' reverses the string.
    /// </summary>
    /// <param name="s">The string to be typed on the faulty keyboard.</param>
    /// <returns>The final string after simulating the faulty keyboard typing.</returns>
    /// <link>https://leetcode.com/problems/faulty-keyboard/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public string FinalString(string s)
    {
        var result = new List<char>();

        s.ToList().ForEach(c =>
        {
            if (c == 'i') result.Reverse();
            else result.Add(c);
        });

        return new string(result.ToArray());
    }
    #endregion

    #region Number of Segments in a String
    /// <summary>
    /// Returns the number of segments in the string.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The number of segments in the string.</returns>
    /// <link>https://leetcode.com/problems/number-of-segments-in-a-string/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int CountSegments(string s)
        => s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    #endregion

    #region 1078. Occurrences After Bigram
    /// <summary>
    /// Returns an array of all the words that follow the occurrences of "first second" in the given text.
    /// </summary>
    /// <param name="text">The input text.</param>
    /// <param name="first">The first word of the bigram.</param>
    /// <param name="second">The second word of the bigram.</param>
    /// <returns>An array of words that follow the occurrences of "first second".</returns>
    /// <link>https://leetcode.com/problems/occurrences-after-bigram/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public string[] FindOcurrences(string text, string first, string second)
    {
        var words = text.Split();
        return words.Skip(2)
                    .Where((w, i) => words[i] == first && words[i + 1] == second)
                    .ToArray();
    }
    #endregion

    #region 3110. Score of a String
    /// <summary>
    /// Calculates the score of a string based on the absolute differences between ASCII values of adjacent characters.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The score of the string.</returns>
    /// <link>https://leetcode.com/problems/score-of-a-string/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int ScoreOfString(string s)
        => s.Zip(s.Skip(1), (a, b) => Math.Abs(a - b)).Sum();
    #endregion

    #region 3168. Minimum Number of Chairs in a Waiting Room
    /// <summary>
    /// Finds the minimum number of chairs needed in a waiting room given the sequence of entries and exits.
    /// </summary>
    /// <param name="s">String representing the sequence of entries ('E') and exits ('L').</param>
    /// <returns>The minimum number of chairs needed.</returns>
    /// <link>https://leetcode.com/problems/minimum-number-of-chairs-in-a-waiting-room/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MinimumChairs(string s)
        => s.Aggregate((current: 0, max: 0), (acc, c)
            => c == 'E' ? (acc.current + 1, Math.Max(acc.max, acc.current + 1))
            : (acc.current - 1, acc.max)).max;
    #endregion

    #region 1957. Delete Characters to Make Fancy String
    /// <summary>
    /// Deletes the minimum number of characters to ensure no three consecutive characters are the same.
    /// </summary>
    /// <param name="s">Input string consisting only of lowercase English letters.</param>
    /// <returns>The modified string where no three consecutive characters are equal.</returns>
    /// <link>https://leetcode.com/problems/delete-characters-to-make-fancy-string/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public string MakeFancyString(string s)
        => new(s.Where((c, i) => i < 2 || !(s[i] == s[i - 1] && s[i] == s[i - 2])).ToArray());
    #endregion

    #region 459. Repeated Substring Pattern
    /// <summary>
    /// Checks if the string can be constructed by taking a substring and appending multiple copies of it.
    /// </summary>
    /// <param name="s">The input string to check.</param>
    /// <returns>True if the string can be constructed by repeating a substring, otherwise false.</returns>
    /// <link>https://leetcode.com/problems/repeated-substring-pattern/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public bool RepeatedSubstringPattern(string s)
        => (s + s).Substring(1, s.Length * 2 - 2).Contains(s);
    #endregion

    #region 1859. Sorting the Sentence
    /// <summary>
    /// Reconstructs the original sentence from a shuffled sentence with numbered words.
    /// </summary>
    /// <param name="s">Shuffled sentence with appended word positions.</param>
    /// <returns>Original sentence with correct word order.</returns>
    /// <link>https://leetcode.com/problems/sorting-the-sentence/</link>
    /// <time>O(n log n)</time>
    /// <space>O(n)</space>
    public string SortSentence(string s)
        => string.Join(" ", s.Split().OrderBy(w => w[^1]).Select(w => w[..^1]));
    #endregion

    #region 2138. Divide a String Into Groups of Size k
    /// <summary>
    /// Divides the string `s` into groups of size `k`, padding the last group with `fill` if necessary.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <param name="k">The size of each group.</param>
    /// <param name="fill">The character used to fill the last group if it's incomplete.</param>
    /// <returns>Array of strings representing the groups.</returns>
    /// <link>https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/</link>
    /// <time>O(n)</time>
    /// <space>O(n)</space>
    public string[] DivideString(string s, int k, char fill)
        => s.PadRight((s.Length + k - 1) / k * k, fill)
            .Chunk(k)
            .Select(chunk => new string(chunk))
            .ToArray();
    #endregion

    #region 1758. Minimum Changes To Make Alternating Binary String
    /// <summary>
    /// Calculates the minimum number of operations needed to make the binary string alternating.
    /// </summary>
    /// <param name="s">The input binary string.</param>
    /// <returns>The minimum number of changes required.</returns>
    /// <link>https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public int MinOperations(string s)
    {
        int changes = 0;

        for (int i = 0; i < s.Length; i++)
            changes += s[i] == (i % 2 == 0 ? '0' : '1') ? 0 : 1;

        return Math.Min(changes, s.Length - changes);
    }
    #endregion

    #region 1736. Latest Time by Replacing Hidden Digits
    /// <summary>
    /// Replaces hidden digits in the time string to get the latest possible valid time.
    /// </summary>
    /// <param name="time">The input time string with hidden digits represented by '?'.</param>
    /// <returns>The latest valid time in the format hh:mm.</returns>
    /// <link>https://leetcode.com/problems/latest-time-by-replacing-hidden-digits/</link>
    /// <time>O(1)</time>
    /// <space>O(1)</space>
    public string MaximumTime(string time)
    {
        char[] t = time.ToCharArray();
        t[0] = t[0] == '?' ? (t[1] == '?' || t[1] <= '3' ? '2' : '1') : t[0];
        t[1] = t[1] == '?' ? (t[0] == '2' ? '3' : '9') : t[1];
        t[3] = t[3] == '?' ? '5' : t[3];
        t[4] = t[4] == '?' ? '9' : t[4];
        return new string(t);
    }
    #endregion

    #region 2042. Check if Numbers Are Ascending in a Sentence
    /// <summary>
    /// Checks if all numbers in the given sentence are in strictly increasing order.
    /// </summary>
    /// <param name="s">The sentence string which contains numbers and words.</param>
    /// <returns>True if numbers are strictly increasing, otherwise False.</returns>
    /// <link>https://leetcode.com/problems/check-if-numbers-are-ascending-in-a-sentence/</link>
    /// <time>O(n)</time>
    /// <space>O(1)</space>
    public bool AreNumbersAscending(string s)
        => s.Split().Where(x => int.TryParse(x, out _))
            .Select(int.Parse)
            .Aggregate((a, b) => a < b ? b : int.MaxValue) != int.MaxValue;
    #endregion
}