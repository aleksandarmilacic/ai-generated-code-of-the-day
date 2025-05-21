using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsSubsequence("abc", "ahbgdc"));
        Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
    }

    static bool IsSubsequence(string s, string t)
    {
        int j = 0;
        for (int i = 0; i < t.Length && j < s.Length; i++)
        {
            if (s[j] == t[i])
            {
                j++;
            }
        }

        return j == s.Length;
    }
}