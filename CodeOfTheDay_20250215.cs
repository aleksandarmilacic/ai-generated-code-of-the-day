using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Let's create a list of integers for our algorithm to work with
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Call our algorithm function
        List<int> oddNumbers = GetOddNumbers(numbers);

        // Print the result
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }

        Console.ReadKey();
    }

    /// <summary>
    /// Algorithm that filters out the odd numbers from a list of integers.
    /// </summary>
    /// <param name="numbers">List of integers</param>
    /// <returns>List of odd numbers</returns>
    static List<int> GetOddNumbers(List<int> numbers)
    {
        List<int> result = new List<int>();

        foreach(int number in numbers)
        {
            // Use modulo operator to check if a number is odd. 
            // If it is, add it to the result list.
            if (number % 2 != 0)
            {
                result.Add(number);
            }
        }

        return result;
    }
}