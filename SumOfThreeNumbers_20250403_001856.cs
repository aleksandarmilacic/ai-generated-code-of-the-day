using System;
using System.Linq;

class Program
{
    static bool FindNumbersWithSum(int[] arr, int targetSum)
    {
        int n = arr.Length;
        Array.Sort(arr);

        for (int i = 0; i < n - 2; i++)
        {
            int j = i + 1;
            int k = n - 1;

            while (j < k)
            {
                int sum = arr[i] + arr[j] + arr[k];

                if (sum == targetSum)
                {
                    return true;
                }

                if (sum < targetSum)
                {
                    j++;
                }
                else
                {
                    k--;
                }
            }
        }

        return false;
    }

    static void Main()
    {
        int[] arr = new int[] { 1, 4, 3, 6, 9, 7};
        int sum = 16;

        bool result = FindNumbersWithSum(arr, sum);

        Console.WriteLine(result);
    }
}