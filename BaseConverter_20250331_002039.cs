using System;
using System.Collections.Generic;
using System.Linq;

public class BaseConverter
{
    private const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public string ConvertBase(string number, int b1, int b2)
    {
        return FromBase10(ToBase10(number, b1), b2);
    }

    private int ToBase10(string number, int b1)
    {
        return number.ToUpper().Reverse().Select((c, i) => chars.IndexOf(c) * (int)Math.Pow(b1, i)).Sum();
    }

    private string FromBase10(int number, int b2)
    {
        var result = "";
        while (number > 0)
        {
            result = chars[number % b2] + result;
            number /= b2;
        }
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        var baseConverter = new BaseConverter();
        Console.WriteLine(baseConverter.ConvertBase("101", 2, 16)); // Outputs 5
    }
}