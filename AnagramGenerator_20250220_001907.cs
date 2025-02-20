using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var str = "CAT";
        var anagrams = GenerateAnagrams(str).ToList();

        foreach (var anagram in anagrams)
        {
            Console.WriteLine(anagram);
        }
    }

    static IEnumerable<string> GenerateAnagrams(string str)
    {
        if (str.Length == 1) return new List<string> { str };

        var anagrams = new List<string>();

        for (var i = 0; i < str.Length; i++)
        {
            var left = str[i];
            var right = str.Substring(0, i) + str.Substring(i + 1);

            var rightAnagrams = GenerateAnagrams(right);

            foreach (var rightAnagram in rightAnagrams)
            {
                anagrams.Add(left + rightAnagram);
            }
        }

        return anagrams;
    }
}