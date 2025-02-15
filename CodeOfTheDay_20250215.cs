using System;

class Program
{
    static void Main()
    {
        // We will calculate the Fibonacci series up to the 15th number in the series
        int length = 15;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"{i + 1}: {Fibonacci(i)}");
        }
    }

    // Function to calculate Fibonacci series
    // each number is the sum of the two preceding ones, starting from 0 and 1
    static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;

        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }
}


This program calculates the Fibonacci series up to the 15th number. The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones, starting from 0 and 1. It has many applications in mathematics and science.