using System;
using System.Collections.Generic;

public class Game
{
    private int[][] directions = new[] { new[] { -2, -1 }, new[] { -2, 1 }, new[] { -1, -2 }, new[] { -1, 2 }, new[] { 1, -2 }, new[] { 1, 2 }, new[] { 2, -1 }, new[] { 2, 1 } };

    public int CalculateMinimumMoves(int[,] grid, int[] startPosition, int[] targetPosition)
    {
        int gridRowsLength = grid.GetLength(0);
        int gridColumnsLength = grid.GetLength(1);
        var visited = new bool[gridRowsLength, gridColumnsLength];
        var queue = new Queue<int[]>();
        queue.Enqueue(startPosition);
        int steps = 0;

        while (queue.Count != 0)
        {
            int count = queue.Count;
            while (count-- > 0)
            {
                var current = queue.Dequeue();
                if (current[0] == targetPosition[0] && current[1] == targetPosition[1])
                {
                    return steps;
                }

                foreach (var direction in directions)
                {
                    int newRow = current[0] + direction[0];
                    int newCol = current[1] + direction[1];
                    if (newRow >= 0 && newRow < gridRowsLength && newCol >= 0 && newCol < gridColumnsLength && !visited[newRow, newCol])
                    {
                        visited[newRow, newCol] = true;
                        queue.Enqueue(new int[] { newRow, newCol });
                    }
                }
            }
            steps++;
        }
        return -1;
    }

    private static void Main()
    {
        Game game = new Game();
        int[,] grid = new int[5, 5];
        int[] startPosition = new int[] { 0, 0 };
        int[] targetPosition = new int[] { 4, 1 };
        Console.WriteLine(game.CalculateMinimumMoves(grid, startPosition, targetPosition));
    }
}