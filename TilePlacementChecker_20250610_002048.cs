using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var grid = new int[][] {
            new int[] { 1, 0, 0, 0 },
            new int[] { 0, 1, 0, 0 },
            new int[] { 0, 0, 1, 0 },
            new int[] { 0, 0, 0, 1 },
        };
        Console.WriteLine(CanPlaceTiles(grid));
    }

    public static bool CanPlaceTiles(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    if (CanPlaceDominoes(grid, i, j) == false)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }

    private static bool CanPlaceDominoes(int[][] grid, int row, int col)
    {
        if (row + 1 < grid.Length && grid[row + 1][col] == 1)
        {
            grid[row][col] = 0;
            grid[row + 1][col] = 0;
        }
        else if (col + 1 < grid[row].Length && grid[row][col + 1] == 1)
        {
            grid[row][col] = 0;
            grid[row][col + 1] = 0;
        }
        else
        {
            return false;
        }
        return true;
    }
}