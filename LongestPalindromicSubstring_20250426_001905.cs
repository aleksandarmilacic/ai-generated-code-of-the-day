using System;

public class Program
{
    private static string LongestPalindromicSubstring(string s)
    {
        int n = s.Length;
        bool[,] dp = new bool[n, n];
        int maxLength = 1;
        int start = 0;

        for (int i = 0; i < n; i++)
        {
            dp[i, i] = true;
        }

        for (int len = 2; len <= n; len++)
        {
            for (int i = 0; i < n - len + 1; ++i)
            {
                int end = i + len - 1;
                if (len == 2)
                {
                    if (s[i] == s[end])
                    {
                        dp[i, end] = true;
                        if (maxLength < len)
                        {
                            maxLength = len;
                            start = i;
                        }
                    }
                }
                else if (s[i] == s[end] && dp[i + 1, end - 1] == true)
                {
                    dp[i, end] = true;
                    if (maxLength < len)
                    {
                        maxLength = len;
                        start = i;
                    }
                }
            }
        }

        return s.Substring(start, maxLength);
    }

    public static void Main()
    {
        string s = "babad";

        Console.WriteLine(LongestPalindromicSubstring(s));
    }
}