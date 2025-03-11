using System;

class Solution {
    static void Main() {
        int[] nums = {4,5,6,7,0,1,2};
        int target = 0;
        Console.WriteLine(Search(nums, target));
    }

    public static int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            int mid = (right + left) / 2;
            if (nums[mid] == target)
                return mid;
            if (nums[mid] >= nums[left]) {
                if (target >= nums[left] && target < nums[mid])
                    right = mid - 1;
                else 
                    left = mid + 1;
            }
            else {
                if (target <= nums[right] && target > nums[mid]) 
                    left = mid + 1;
                else 
                    right = mid - 1;
            }
        }

        return -1;
    }
}