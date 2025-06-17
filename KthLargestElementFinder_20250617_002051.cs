using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = {3,2,1,5,6,4};
        int k = 2;
        Console.WriteLine(FindKthLargest(nums, k));
    }

    public static int FindKthLargest(int[] nums, int k)
    {
        return nums.OrderByDescending(n => n).ElementAt(k-1);
    }
}