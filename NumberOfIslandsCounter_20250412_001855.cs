using System;

class NumberOfIslandsCounter
{
    static int numIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0)
            return 0;

        int numberOfIslands = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                    numberOfIslands += dfs(grid, i, j);
            }
        }

        return numberOfIslands;
    }

    static int dfs(char[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == '0')
            return 0;

        grid[i][j] = '0';
        dfs(grid, i + 1, j);
        dfs(grid, i - 1, j);
        dfs(grid, i, j + 1);
        dfs(grid, i, j - 1);

        return 1;
    }

    static void Main()
    {
        char[][] grid = new char[][] {
            new char[] { '1', '1', '1', '1', '0' },
            new char[] { '1', '1', '0', '1', '0' },
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '0', '0', '0', '0', '0' }
        };

        Console.WriteLine(numIslands(grid));
    }
}