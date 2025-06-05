using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(IsStrobogrammatic(number));
    }

    public static bool IsStrobogrammatic(string num)
    {
        Dictionary<char, char> map = new Dictionary<char, char>
        {
            {'0', '0'}, {'1', '1'}, {'6', '9'}, {'8', '8'}, {'9', '6'}
        };

        int i = 0, j = num.Length - 1;

        while (i <= j)
        {
            if (!map.ContainsKey(num[i]) || map[num[i]] != num[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}