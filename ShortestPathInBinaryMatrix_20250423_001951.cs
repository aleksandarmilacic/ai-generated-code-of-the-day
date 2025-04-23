using System;
using System.Collections.Generic;

public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        int n = grid.Length;
        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1) return -1;

        var queue = new Queue<(int row, int col, int dist)>();
        queue.Enqueue((0, 0, 1));

        while (queue.Count > 0) {
            var (row, col, dist) = queue.Dequeue();
            if (row == n - 1 && col == n - 1) return dist;
            foreach (var direction in directions) {
                int newRow = row + direction[0], newCol = col + direction[1];
                if (IsSafe(grid, newRow, newCol)) {
                    grid[newRow][newCol] = 1;
                    queue.Enqueue((newRow, newCol, dist + 1));
                }
            }
        }

        return -1;
    }

    private bool IsSafe(int[][] grid, int row, int col) =>
        row >= 0 && row < grid.Length && col >= 0 && col < grid[0].Length && grid[row][col] == 0;

    private static readonly int[][] directions = new[] {
        new[] {-1, 0}, new[] {1, 0}, new[] {0, -1}, new[] {0, 1},
        new[] {-1, -1}, new[] {-1, 1}, new[] {1, -1}, new[] {1, 1}
    };
   
    static void Main() {
        var sol = new Solution();
        int[][] grid = new int[][] {
            new int[] {0, 0, 0},
            new int[] {1, 1, 0},
            new int[] {1, 1, 0}
        };
        int result = sol.ShortestPathBinaryMatrix(grid);
        Console.WriteLine(result);
    }
}