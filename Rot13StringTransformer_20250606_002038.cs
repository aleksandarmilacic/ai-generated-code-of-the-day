using System;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to transform using ROT13:");
        string input = Console.ReadLine();
        
        string result = Rot13Transform(input);
        Console.WriteLine($"Transformed string: {result}");
    }

    static string Rot13Transform(string value)
    {
        var result = new StringBuilder();

        foreach (char ch in value)
        {
            if (!char.IsLetter(ch))
            {
                result.Append(ch);
                continue;
            }

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            char transformed = (char)((ch - offset + 13) % 26 + offset);
            result.Append(transformed);
        }

        return result.ToString();
    }
}