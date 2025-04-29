using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> set = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    static void Main()
    {
        int[] nums = new int[] {100, 4, 200, 1, 3, 2};
        Console.WriteLine(LongestConsecutive(nums));
    }
}