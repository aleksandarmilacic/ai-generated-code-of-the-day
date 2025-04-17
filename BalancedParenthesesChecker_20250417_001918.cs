using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(IsBalanced("[()]{[()()]}"));
        Console.WriteLine(IsBalanced("[)(]{[()()]}"));
    }

    public static bool IsMatchingPair(char character1, char character2)
    {
        if (character1 == '(' && character2 == ')') return true;
        else if (character1 == '{' && character2 == '}') return true;
        else if (character1 == '[' && character2 == ']') return true;
        else return false;
    }

    public static bool IsBalanced(string exp)
    {
        Stack<char> st = new Stack<char>();

        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[') st.Push(exp[i]);
            if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
            {
                if (st.Count == 0) return false;
                else if (!IsMatchingPair(st.Pop(), exp[i])) return false;
            }
        }
        if (st.Count == 0) return true;
        else return false;
    }
}