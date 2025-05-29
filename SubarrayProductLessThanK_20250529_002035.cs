using System;

class Program
{
    static long countSubarrays(int[] arr, int n, int k)
    {
        long count = 0;
        int left = 0;
        int right = 1;
        double prod = arr[0];

        while (right <= n)
        {
            if (prod < k)
            {
                count += right - left;
                if (right < n)
                {
                    prod *= arr[right];
                }
                right++;
            }
            else
            {
                prod /= arr[left];
                left++;
            }
        }
        return count;
    }

    static void Main()
    {
        int[] arr = { 1, 11, 2, 3, 4 };
        int n = arr.Length;
        int k = 10;

        Console.WriteLine(countSubarrays(arr, n, k));
    }
}