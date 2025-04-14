using System;

class Program
{
    static void Main()
    {
        string original = "mirror";
        
        string mirroredString = Mirror(original);
        
        Console.WriteLine(mirroredString);
    }

    static string Mirror(string input)
    {
        int length = input.Length;
        char[] result = new char[length * 2];

        for (int i = 0; i < length; ++i)
        {
            result[i] = input[i]; 
            result[2 * length - i - 1] = input[i];
        }

        return new string(result);
    }
}