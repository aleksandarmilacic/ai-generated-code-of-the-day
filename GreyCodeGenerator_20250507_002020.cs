using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int n = 3;
        List<int> result = GetGrayCode(n);
        foreach (var code in result)
        {
            Console.WriteLine(Convert.ToString(code, 2).PadLeft(n, '0'));
        }
    }

    public static List<int> GetGrayCode(int n)
    {
        if (n == 0)
        {
            return new List<int> { 0 };
        }

        var result = GetGrayCode(n - 1);
        int leadingBitOne = 1 << (n - 1);

        for (int i = result.Count - 1; i >= 0; i--)
        {
            result.Add(leadingBitOne | result[i]);
        }

        return result;
    }
}