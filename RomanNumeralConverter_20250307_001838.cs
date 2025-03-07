using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to be converted to Roman Numeral:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertToRoman(num));
    }

    static string ConvertToRoman(int num)
    {
        Dictionary<int, string> numerals = new Dictionary<int, string>()
        {
            { 1, "I" },    { 4, "IV" },   { 5, "V" },    { 9, "IX" },
            { 10, "X" },   { 40, "XL" },  { 50, "L" },   { 90, "XC" },
            { 100, "C" },  { 400, "CD" }, { 500, "D" },  { 900, "CM" },
            { 1000, "M" }
        };

        string roman = string.Empty;
        foreach (var item in numerals)
        {
            while (num >= item.Key)
            {
                roman = item.Value + roman;
                num -= item.Key;
            }
        }

        return roman;
    }
}