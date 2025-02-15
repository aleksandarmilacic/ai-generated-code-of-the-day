using System;

// This is a simple algorithm to generate the Fibonacci sequence up to a certain number.
// The Fibonacci sequence is a series of numbers in which each number is the sum of the two preceding ones, usually starting with 0 and 1.
// This sequence appears in many different areas of mathematics and science, and it's also a common programming interview question.

class Program
{
    static void Main()
    {
        // Let's generate the Fibonacci sequence up to a certain number.
        Console.Write("Enter the length of Fibonacci Series: ");
        int length = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    // This method calculates the Fibonacci number at a certain position in the sequence.
    static int Fibonacci(int n)
    {
        // The Fibonacci number at position 0 or 1 is always the same.
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            // The Fibonacci number at any other position is the sum of the two preceding numbers in the sequence.
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}