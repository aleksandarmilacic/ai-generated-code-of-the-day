using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(FirstMissingPositive(new int[]{3, 4, -1, 1}));
    }

    public static int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        for(int i = 0; i < n; i++){
            while(nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]){
                Swap(nums, i, nums[i] - 1);
            }
        }

        for(int i = 0; i < n; i++){
            if(nums[i] != i + 1){
                return i + 1;
            }
        }

        return n + 1;
    }

    private static void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}