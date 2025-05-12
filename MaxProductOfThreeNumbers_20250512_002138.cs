using System;
using System.Linq;

public class MaxProductOfThreeNumbers
{
    public static void Main(string[] args)
    {
        int[] input = { -10, -10, 1, 3, 2 };
        Console.WriteLine("Maximum product of three numbers is " + MaxProduct(input));
    }
    
    public static int MaxProduct(int[] nums) 
    {
        Array.Sort(nums);
        int n = nums.Length;
        return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 1] * nums[n - 2] * nums[n - 3]);
    }
}