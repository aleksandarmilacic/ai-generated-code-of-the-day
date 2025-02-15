csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Read the number from the console
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the Fibonacci function
        Console.WriteLine($"The Fibonacci of {number} is {Fibonacci(number)}");

        // Call the Factorial function
        Console.WriteLine($"The Factorial of {number} is {Factorial(number)}");
    }

    // Recursive function to calculate Fibonacci number
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Recursive function to calculate Factorial
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}

This program will calculate the Fibonacci number and the Factorial of a given number. The Fibonacci number is the sum of the two preceding ones, and Factorial of a number is the product of an integer and all the integers below it.