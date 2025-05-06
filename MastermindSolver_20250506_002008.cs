using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static List<string> AllCombinations()
    {
        var colors = new char[] { 'R', 'G', 'B', 'Y', 'O', 'P' };
        var combinations = new List<string>();
        for (var i = 0; i < colors.Length; i++)
            for (var j = 0; j < colors.Length; j++)
                for (var k = 0; k < colors.Length; k++)
                    for (var l = 0; l < colors.Length; l++)
                        combinations.Add("" + colors[i] + colors[j] + colors[k] + colors[l]);
        return combinations;
    }

    static (int,int) Score(string guess, string solution)
    {
        int blacks = 0, whites = 0;
        var freq = new int[128];
        for (int i = 0; i < 4; i++)
        {
            if (guess[i] == solution[i]) blacks++;
            else
            {
                if (freq[solution[i]]++ < 0) whites++;
                if (freq[guess[i]]-- > 0) whites++;
            }
        }
        return (blacks, whites);
    }

    public static void Main()
    {
        var solution = "RGBY";
        var combinations = AllCombinations();
        while (combinations.Count > 1)
        {
            string guess = combinations[0];
            var score = Score(guess, solution);
            combinations = combinations.Where(c => Score(guess, c) == score).ToList();
        }
        Console.WriteLine("Solution: " + combinations[0]);
    }
}