using System;
using System.Text;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(SmartTextWrap("The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog.", 40));
    }

    public static string SmartTextWrap(string str, int lineLength)
    {
        if (str == null) { return null; }
        if (str.Length <= lineLength) { return str; }

        var words = str.Split(' ');
        var sb = new StringBuilder();

        sb.Append(words[0]);
        var chars = words[0].Length;

        for (int i = 1; i < words.Length; i++)
        {
            if (chars + 1 + words[i].Length > lineLength)
            {
                sb.Append("\n" + words[i]);
                chars = words[i].Length;
            }
            else
            {
                sb.Append(" " + words[i]);
                chars += 1 + words[i].Length;
            }
        }

        return sb.ToString();
    }
}