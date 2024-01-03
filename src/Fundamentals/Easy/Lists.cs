namespace Easy;

public class Lists
{
    #region 9. Palindrome Number
    /// <summary>
    /// 9. Palindrome Number
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    /// <time>25 ms</time>
    /// <space>31.18 MB</space>
    public bool IsPalindrome(int x)
    {
        int reversed = 0;
        int original = x;
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return reversed == original;
    }
    #endregion
}
