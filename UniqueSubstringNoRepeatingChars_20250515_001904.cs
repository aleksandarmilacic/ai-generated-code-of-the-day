using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string s = "abcabcbb";
        int result = LengthOfLongestSubstring(s);
        Console.WriteLine(result);
    }

    public static int LengthOfLongestSubstring(string s) 
    {
        int n = s.Length;
        HashSet<char> set = new HashSet<char>();
        int ans = 0, i = 0, j = 0;
        while (i < n && j < n) 
        {
            if (!set.Contains(s[j]))
            {
                set.Add(s[j++]);
                ans = Math.Max(ans, j - i);
            }
            else 
            {
                set.Remove(s[i++]);
            }
        }
        return ans;
    }
}