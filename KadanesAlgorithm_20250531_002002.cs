using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
        Console.Write("Maximum contiguous sum is " + MaxSubArraySum(arr));
    }

    static int MaxSubArraySum(int[] arr)
    {
        int size = arr.Length;
        int maxSoFar = int.MinValue, maxEndingHere = 0;

        for (int i = 0; i < size; i++)
        {
            maxEndingHere = maxEndingHere + arr[i];
            if (maxSoFar < maxEndingHere) maxSoFar = maxEndingHere;
            if (maxEndingHere < 0) maxEndingHere = 0;
        }
        return maxSoFar;
    }
}