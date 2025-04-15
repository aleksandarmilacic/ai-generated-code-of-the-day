using System;

public class Solution 

{
    public string DecodeString(string s) 
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }

        var currentNumber = 0;
        var currentString = string.Empty;
        var numberStack = new System.Collections.Generic.Stack<int>();
        var stringStack = new System.Collections.Generic.Stack<string>();

        foreach (var character in s)
        {
            if (char.IsDigit(character))
            {
                currentNumber = currentNumber * 10 + (character - '0');
            }
            else if (character == '[')
            {
                numberStack.Push(currentNumber);
                stringStack.Push(currentString);

                currentNumber = 0;
                currentString = string.Empty;
            }
            else if (character == ']')
            {
                var repeatTimes = numberStack.Pop();
                var previousString = stringStack.Pop();

                currentString = previousString + RepeatString(currentString, repeatTimes);
            }
            else
            {
                currentString += character;
            }
        }

        return currentString;
    }

    private string RepeatString(string s, int times) 
    {
        var result = string.Empty;
        for (var i = 0; i < times; i++) 
        {
            result += s;
        }
        return result;
    }
}

public static class Program
{
    public static async Task Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.DecodeString("3[a]2[bc]")); // Expected: "aaabcbc"
        Console.WriteLine(solution.DecodeString("3[a2[c]]")); // Expected: "accaccacc"
        Console.WriteLine(solution.DecodeString("2[abc]3[cd]ef")); // Expected: "abcabccdcdcdef"
    }
}