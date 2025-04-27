using System;
using System.Linq;

public class LargestContinuousSum
{
    public static void Main(string[] args)
    {
        var arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
        Console.WriteLine(FindLargestSum(arr));
    }

    static int FindLargestSum(int[] arr)
    {
        int currentMax = arr[0];
        int maxSoFar = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            currentMax = Math.Max(arr[i], currentMax + arr[i]);
            maxSoFar = Math.Max(maxSoFar, currentMax);
        }

        return maxSoFar;
    }
}