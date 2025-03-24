using System;
using System.Collections.Generic;

class Program
{
    static int MinKnightMoves(int x, int y)
    {
        int[,] directions = new int[,] { { 2, 1 }, { 1, 2 }, { -1, 2 }, { -2, 1 }, { -2, -1 }, { -1, -2 }, { 1, -2 }, { 2, -1 } };
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { 0, 0 });

        HashSet<string> visited = new HashSet<string>();
        visited.Add("0,0");

        int steps = 0;

        while (queue.Count > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                int[] point = queue.Dequeue();
                if (point[0] == x && point[1] == y)
                {
                    return steps;
                }

                for (int j = 0; j < 8; j++)
                {
                    int row = point[0] + directions[j, 0];
                    int col = point[1] + directions[j, 1];
                    if (!visited.Contains($"{row},{col}"))
                    {
                        queue.Enqueue(new int[] { row, col });
                        visited.Add($"{row},{col}");
                    }
                }
            }
            steps++;
        }

        return -1;
    }

    static void Main()
    {
        Console.WriteLine(MinKnightMoves(5, 5));
        Console.WriteLine(MinKnightMoves(7, 7));
    }
}