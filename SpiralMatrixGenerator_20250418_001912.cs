using System;
using System.Collections.Generic;

public class SpiralMatrix
{
    public static List<List<int>> GenerateSpiralMatrix(int size)
    {
        List<List<int>> matrix = new List<List<int>>();
        for (int i = 0; i < size; i++)
            matrix.Add(new List<int>(new int[size]));

        int num = 1;
        for (int layer = 0; layer < (size + 1) / 2; layer++)
        {
            for (int ptr = layer; ptr < size - layer; ptr++)
                matrix[layer][ptr] = num++;
            for (int ptr = layer + 1; ptr < size - layer; ptr++)
                matrix[ptr][size - layer - 1] = num++;
            for (int ptr = layer + 1; ptr < size - layer; ptr++)
                matrix[size - layer - 1][size - ptr - 1] = num++;
            for (int ptr = layer + 1; ptr < size - layer - 1; ptr++)
                matrix[size - ptr - 1][layer] = num++;
        }

        return matrix;
    }

    static void Main(string[] args)
    {
        int size = 5;
        var result = GenerateSpiralMatrix(size);
        foreach (var row in result)
        {
            foreach (var num in row)
            {
                Console.Write($"{num}\t");
            }
            Console.WriteLine();
        }
    }
}