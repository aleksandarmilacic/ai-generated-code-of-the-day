using System;
using System.Collections.Generic;

public class TwoSumSolver
{
    public static void Main()
    {
        int[] numbers = {2, 7, 11, 15};
        int target = 9;
        var result = TwoSum(numbers, target);
        if (result.Length > 1)
        {
            Console.WriteLine(result[0] + " " + result[1]);
        }
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dic.ContainsKey(complement))
            {
                return new int[] { dic[complement], i };
            }
            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }
        throw new ArgumentException("No two sum solution");
    }
}