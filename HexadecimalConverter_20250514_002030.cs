using System;

class HexadecimalConverter
{
    string HexConversion(int number)
    {
        if (number < 0) 
        {
            throw new InvalidOperationException("Number cannot be negative.");
        }

        string hexNum = number.ToString("X");
        return hexNum;
    }

    static void Main() 
    {
        HexadecimalConverter converter = new HexadecimalConverter();
        Console.WriteLine(converter.HexConversion(254));    
    }
}