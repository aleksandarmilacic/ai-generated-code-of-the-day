using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = new int[] { 1, 2, 4, 6, 3, 7, 8 };
        Console.WriteLine(FindMissingNumber(input));
    }

    static int FindMissingNumber(int[] input)
    {
        int n = input.Length;
        int total = (n + 1) * (n + 2) / 2;
        int sum = input.Sum();
        return total - sum;
    }
}