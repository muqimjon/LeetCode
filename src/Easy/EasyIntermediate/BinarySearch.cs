namespace EasyIntermediate;

public class BinarySearch
{
    #region 278. First Bad Version
    /// <summary>
    /// Finds the first bad version given a range of versions, using binary search.
    /// </summary>
    /// <param name="n">The total number of versions.</param>
    /// <returns>The first bad version.</returns>
    /// <link>https://leetcode.com/problems/first-bad-version/</link>
    /// <time>Runtime: O(log n)</time>
    /// <space>Memory: O(1)</space>
    public int FirstBadVersion(int n)
    {
        int left = 1, right = n;
        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (IsBadVersion(mid)) right = mid;
            else left = mid + 1;
        }

        return left;
    }

    public static int badVersion;
    public void SetBadVersion(int bad)
    {
        badVersion = bad;
    }

    public static bool IsBadVersion(int version)
        => version >= badVersion;
    #endregion
}
