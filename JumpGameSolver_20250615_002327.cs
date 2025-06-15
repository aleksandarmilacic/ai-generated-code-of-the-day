using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {2, 3, 1, 1, 4};
        Console.WriteLine(CanJump(nums));
    }

    public static bool CanJump(int[] nums)
    {
        int lastPos = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= lastPos)
            {
                lastPos = i;
            }
        }
        return lastPos == 0;
    }
}