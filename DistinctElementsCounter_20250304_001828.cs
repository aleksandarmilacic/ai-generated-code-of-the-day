using System;
using System.Collections.Generic;
using System.Linq;

public class DistinctElementsCounter
{
    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5, 5, 6 };
        Console.WriteLine(CountDistinctElements(numbers));
    }

    static int CountDistinctElements(List<int> numbers)
    {
        return numbers.Distinct().Count();
    }
}