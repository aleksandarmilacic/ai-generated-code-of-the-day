using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        var durations = new[] {30, 20, 150, 100, 40};
        Console.WriteLine(PairsOfSongsWithDuration(durations));
    }

    static int PairsOfSongsWithDuration(int[] durations)
    {
        var remainders = new int[60];
        int count = 0;

        for (int i = 0; i < durations.Length; i++)
        {
            if (durations[i] % 60 == 0)
            {
                count += remainders[0];
            }
            else
            {
                count += remainders[60 - durations[i] % 60];
            }

            remainders[durations[i] % 60]++;
        }

        return count;
    }
}