using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] arr = { -1, -3, -10, 0, 60 };
        Console.WriteLine(FindMaxProduct(arr));
    }

    static int FindMaxProduct(int[] arr)
    {
        int n = arr.Length;
        int max_end_here = 1;
        int min_end_here = 1;
        int max_so_far = 1;
        int flag = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                max_end_here = max_end_here * arr[i];
                min_end_here = Math.Min(min_end_here * arr[i], 1);
                flag = 1;
            }
            else if (arr[i] == 0)
            {
                max_end_here = 1;
                min_end_here = 1;
            }
            else
            {
                int temp = max_end_here;
                max_end_here = Math.Max(min_end_here * arr[i], 1);
                min_end_here = temp * arr[i];
            }

            if (max_so_far < max_end_here)
                max_so_far = max_end_here;
        }

        if (flag == 0 && max_so_far == 1)
            return 0;

        return max_so_far;
    }
}