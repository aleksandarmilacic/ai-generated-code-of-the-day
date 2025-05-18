using System;

public class NumberEncoder
{
    public void Main()
    {
        var input = "ABCD";
        var encoded = Encode(input);
        Console.WriteLine($"Encoded: {encoded}");

        var decoded = Decode(encoded);
        Console.WriteLine($"Decoded: {decoded}");
    }

    private string Encode(string input)
    {
        var result = "";
        foreach(var ch in input)
        {
            result += ((int)ch - 'A' + 1).ToString().PadLeft(2, '0');
        }
        return result;
    }

    private string Decode(string input)
    {
        var result = "";
        for (var i = 0; i < input.Length; i += 2)
        {
            var number = int.Parse(input.Substring(i, 2));
            result += (char)(number + 'A' - 1);
        }
        return result;
    }
}