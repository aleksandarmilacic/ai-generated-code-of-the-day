using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(LongestCommonSubstring("HelloWorld", "WorldHello"));
    }

    static string LongestCommonSubstring(string str1, string str2)
    {
        string result = string.Empty;
        int[,] lcs = new int[str1.Length, str2.Length];
        int length = 0, end = 0;

        for (var i = 0; i < str1.Length; i++)
        {
            for (var j = 0; j < str2.Length; j++)
            {
                if (str1[i] != str2[j]) continue;
                
                lcs[i, j] = (i == 0 || j == 0) ? 1 : lcs[i - 1, j - 1] + 1;
                
                if (lcs[i, j] <= length) continue;
                
                length = lcs[i, j];
                end = i;
            }
        }

        result = str1.Substring(end - length + 1, length);
        return result;
    }
}