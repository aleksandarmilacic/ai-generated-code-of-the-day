using System;
using System.Linq;

public class SequenceFinder
{
    public static void Main(string[] args)
    {
        int[] numbers = new[] { 1, 2, 3, 7, 5, 4, 3, 2, 1, 0, 4, 5, 6, 7, 2, 9, 8 };

        var sequence = FindLongestArithmeticSequence(numbers);

        foreach (var number in sequence)
        {
            Console.WriteLine(number);
        }
    }

    public static int[] FindLongestArithmeticSequence(int[] numbers)
    {
        int longestLength = 0;
        int longestEndIndex = -1;

        for (int i = 0; i < numbers.Length - 2; i++)
        {
            int diff = numbers[i + 1] - numbers[i];
            int length = 2;

            for (int j = i + 2; j < numbers.Length; j++)
            {
                if (numbers[j] - numbers[j - 1] == diff)
                {
                    length++;
                }
                else
                {
                    break;
                }
            }

            if (length > longestLength)
            {
                longestLength = length;
                longestEndIndex = i + length - 1;
            }
        }

        if (longestEndIndex == -1)
        {
            return new int[0];
        }

        return numbers.Skip(longestEndIndex - longestLength + 1).Take(longestLength).ToArray();
    }
}