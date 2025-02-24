using System;
using System.Collections.Generic;

public class StringPermutationsFinder
{
    private void Swap(ref char a, ref char b)
    {
        if (a == b) return;

        var temp = a;
        a = b;
        b = temp;
    }

    public void FindPermutations(string str, int start, int end)
    {
        if (start == end)
        {
            Console.WriteLine(str);
        }
        else
        {
            for (var i = start; i <= end; i++)
            {
                Swap(ref str[start], ref str[i]);
                FindPermutations(str, start + 1, end);
                Swap(ref str[start], ref str[i]); // backtrack
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        var str = "ABC";
        var perm = new StringPermutationsFinder();
        perm.FindPermutations(str, 0, str.Length - 1);
    }
}