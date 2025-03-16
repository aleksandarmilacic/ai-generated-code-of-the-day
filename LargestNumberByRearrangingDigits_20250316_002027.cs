using System;
using System.Linq;

public class LargestNumberByRearrangingDigits
{
    public static void Main()
    {
        int[] arr = {4, 6, 2, 7, 3, 8, 5};
        Console.WriteLine(GetLargest(arr));
    }

    public static string GetLargest(int[] arr)
    {
        return string.Join("", arr.OrderByDescending(x => x));
    }
}