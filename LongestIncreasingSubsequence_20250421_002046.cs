using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] nums = {10, 9, 2, 5, 3, 7, 101, 18};
        Console.WriteLine(LengthOfLIS(nums));
    }

    public static int LengthOfLIS(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        List<int> dp = new List<int>();

        foreach (int num in nums)
        {
            if (dp.Count == 0 || dp[dp.Count - 1] < num)
            {
                dp.Add(num);
            }
            else
            {
                int i = 0;
                int j = dp.Count;
                while (i < j)
                {
                    int mid = i + (j - i) / 2;
                    if (dp[mid] < num)
                    {
                        i = mid + 1;
                    }
                    else
                    {
                        j = mid;
                    }
                }

                dp[i] = num;
            }
        }

        return dp.Count;
    }
}