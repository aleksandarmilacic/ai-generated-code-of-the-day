using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] nums = new int[] { 1, 1, 1 };
        int k = 2;
        Console.WriteLine(SubarraySum(nums, k));
    }
  
    public static int SubarraySum(int[] nums, int k)
    {
        int count = 0, sum = 0;
        Dictionary<int, int> sumMap = new Dictionary<int, int>();
        sumMap.Add(0, 1);

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sumMap.ContainsKey(sum - k))
                count += sumMap[sum - k];
            if (!sumMap.ContainsKey(sum))
                sumMap.Add(sum, 0);
            sumMap[sum]++;
        }

        return count;
    }
}