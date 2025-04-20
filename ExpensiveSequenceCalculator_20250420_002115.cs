using System;
using System.Collections.Generic;

public class Program
{
    private static Dictionary<int, long> Cache = new Dictionary<int, long>() { { 0, 0 }, { 1, 1 }, { 2, 2 } };

    public static void Main()
    {
        for (int i = 0; i <= 15; i++)
        {
            Console.WriteLine($"{i}: {Expseq(i)}");
        }
    }

    public static long Expseq(int n)
    {
        if (Cache.ContainsKey(n))
        {
            return Cache[n];
        }

        long value = Expseq(n - Expseq(n - 1)) + Expseq(n - Expseq(n - 2));
        Cache[n] = value;

        return value;
    }
}