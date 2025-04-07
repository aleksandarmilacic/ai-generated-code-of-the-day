using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms:");
        int n = Convert.ToInt32(Console.ReadLine());

        string currentTerm = "1";
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(currentTerm);
            currentTerm = NextTerm(currentTerm);
        }
    }

    static string NextTerm(string currentTerm)
    {
        List<string> result = new List<string>();

        int i = 0;
        while (i < currentTerm.Length)
        {
            int count = 1;
            while (i + 1 < currentTerm.Length && currentTerm[i] == currentTerm[i + 1])
            {
                i++;
                count++;
            }

            result.Add(count.ToString());
            result.Add(currentTerm[i].ToString());

            i++;
        }

        return string.Join("", result);
    }
}