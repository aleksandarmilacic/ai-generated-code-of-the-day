using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        GeneratePascalTriangle(10);
    }

    public static void GeneratePascalTriangle(int numRows)
    {
        List<List<int>> triangle = new List<List<int>>();
        
        if (numRows == 0)
        {
            return;
        }

        triangle.Add(new List<int> { 1 });

        for (int i = 1; i < numRows; i++)
        {
            List<int> row = new List<int> { 1 };
            List<int> prevRow = triangle[i - 1];

            for (int j = 1; j < i; j++)
            {
                row.Add(prevRow[j - 1] + prevRow[j]);
            }

            row.Add(1);
            triangle.Add(row);
        }

        foreach (var row in triangle)
        {
            foreach (var num in row)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}