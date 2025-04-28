using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 13, 7, 5, 9, 20, 9, 5, 14 };
        int target = 14;

        var pairs = FindUniquePairs(arr, target);
        foreach (var pair in pairs)
        {
            Console.WriteLine($"{pair.Item1}, {pair.Item2}");
        }
    }

    static List<Tuple<int, int>> FindUniquePairs(int[] array, int target)
    {
        Array.Sort(array);

        int left = 0;
        int right = array.Length - 1;
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();

        while (left < right)
        {
            int sum = array[left] + array[right];

            if (sum == target)
            {
                result.Add(new Tuple<int, int>(array[left], array[right]));
                while (left < right && array[left] == array[left + 1]) left++;
                while (left < right && array[right] == array[right - 1]) right--;
                left++;
                right--;
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return result;
    }
}