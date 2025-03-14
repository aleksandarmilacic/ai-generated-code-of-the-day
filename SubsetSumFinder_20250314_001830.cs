using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] set = new int[] { 3, 1, 5, 9, 12 };
        int sum = 9;

        bool result = IsSubsetSum(set, set.Length, sum);

        Console.WriteLine(result);
    }

    private static bool IsSubsetSum(int[] set, int n, int sum)
    {
        if (sum == 0)
            return true;
        if (n == 0 && sum != 0)
            return false;

        if (set[n - 1] > sum)
            return IsSubsetSum(set, n - 1, sum);

        return IsSubsetSum(set, n - 1, sum)
               || IsSubsetSum(set, n - 1, sum - set[n - 1]);
    }
}