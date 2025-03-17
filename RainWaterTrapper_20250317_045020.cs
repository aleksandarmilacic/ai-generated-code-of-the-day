using System;

class Program
{
    static void Main(string[] args)
    {
        int[] heights = new int[] { 2, 0, 2 };
        Console.WriteLine(Trap(heights));
    }

    static int Trap(int[] height)
    {
        if (height == null || height.Length == 0)
            return 0;
        int ans = 0;
        int size = height.Length;
        int[] leftMax = new int[size];
        int[] rightMax = new int[size];
        leftMax[0] = height[0];
        for (int i = 1; i < size; i++) 
        {
            leftMax[i] = Math.Max(height[i], leftMax[i - 1]);
        }
        rightMax[size - 1] = height[size - 1];
        for (int i = size - 2; i >= 0; i--) 
        {
            rightMax[i] = Math.Max(height[i], rightMax[i + 1]);
        }
        for (int i = 1; i < size - 1; i++) 
        {
            ans += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }
        return ans;
    }
}