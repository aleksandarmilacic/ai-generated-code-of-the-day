using System;
using System.Collections.Generic;

public class Program
{
    private static int vertexCount;
    private static List<int>[] graph;
    private static int[] colors;

    public static void Main()
    {
        vertexCount = int.Parse(Console.ReadLine());
        graph = new List<int>[vertexCount];

        for (int i = 0; i < vertexCount; i++)
        {
            graph[i] = new List<int>();
        }

        int edgeCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < edgeCount; i++)
        {
            var edgeParts = Console.ReadLine().Split();
            int start = int.Parse(edgeParts[0]);
            int end = int.Parse(edgeParts[1]);
            graph[start].Add(end);
            graph[end].Add(start);
        }

        int colorsCount = int.Parse(Console.ReadLine());
        colors = new int[vertexCount];

        if (ColorGraph(colorsCount, 0))
        {
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"Vertex {i} - Color {colors[i]}");
            }
        }
        else
        {
            Console.WriteLine("No solution.");
        }
    }

    private static bool ColorGraph(int colorsCount, int vertex)
    {
        if (vertex == vertexCount)
        {
            return true;
        }

        for (int color = 1; color <= colorsCount; color++)
        {
            if (IsValidColor(vertex, color))
            {
                colors[vertex] = color;

                if (ColorGraph(colorsCount, vertex + 1))
                {
                    return true;
                }

                colors[vertex] = 0;
            }
        }

        return false;
    }

    private static bool IsValidColor(int vertex, int color)
    {
        foreach (var neighbor in graph[vertex])
        {
            if (colors[neighbor] == color)
            {
                return false;
            }
        }

        return true;
    }
}