using System;
using System.Collections.Generic;

public class PerfectNumberGenerator
{
    public static void Main()
    {
        int numberOfPerfectNumbersToGenerate = 4;
        GeneratePerfectNumbers(numberOfPerfectNumbersToGenerate);
    }

    public static void GeneratePerfectNumbers(int count)
    {
        List<long> perfectNumbers = new List<long>() { 6, 28 };
        int perNumCount = 2;
        long num = 30;
        
        while (perNumCount < count)
        {
            long sum = 1;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    if(i * i != num)
                        sum = sum + i + num / i;
                    else
                        sum = sum + i;
                }
            }
            if (sum == num)
            {
                perfectNumbers.Add(num);
                perNumCount++;
            }
            num += 2;
        }

        foreach(long number in perfectNumbers)
        {
            Console.Write(number + " ");
        }
    }
}