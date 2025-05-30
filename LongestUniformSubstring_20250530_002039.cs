using System;

public class LongestUniformSubstring
{
    public static void Main()
    {
        string input = "aaabbbaaaacccccddddd";
        Console.WriteLine(LongestUniformSub(input));
    }

    private static Tuple<char, int> LongestUniformSub(string input)
    {
        char lastChar = input[0];
        int longestLength = 0;
        int currentLength = 1;
        char longestChar = lastChar;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == lastChar)
            {
                currentLength++;
            }
            else
            {
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    longestChar = lastChar;
                }

                lastChar = input[i];
                currentLength = 1;
            }
        }

        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestChar = lastChar;
        }

        return new Tuple<char, int>(longestChar, longestLength);
    }
}