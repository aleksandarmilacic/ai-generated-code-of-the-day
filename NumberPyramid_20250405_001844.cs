using System;

public class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the pyramid: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            PrintNumberPyramid(n);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    public static void PrintNumberPyramid(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            PrintSpaces(n - i);
            PrintIncreasingNumbers(i);
            PrintDecreasingNumbers(i);
            Console.WriteLine();
        }
    }

    private static void PrintSpaces(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(" ");
        }
    }

    private static void PrintIncreasingNumbers(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
        }
    }

    private static void PrintDecreasingNumbers(int n)
    {
        for (int i = n - 1; i >= 1; i--)
        {
            Console.Write(i);
        }
    }
}