using System;
using System.Collections.Generic;

public class HappyNumberFinder
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool result = IsHappy(number);
        Console.WriteLine(result);
    }

    private static bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();
        while (n != 1)
        {
            if (seen.Contains(n))
                return false;

            seen.Add(n);
            n = GetNext(n);
        }

        return true;
    }

    private static int GetNext(int n)
    {
        int totalSum = 0;
        while (n > 0)
        {
            int d = n % 10;
            n = n / 10;
            totalSum += d * d;
        }
        return totalSum;
    }
}