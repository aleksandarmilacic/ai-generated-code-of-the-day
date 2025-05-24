using System;
using System.Linq;

public class Program
{
    private static readonly int[][] directions = new[] { new[] { 1, 0 }, new[] { -1, 0 }, new[] { 0, 1 }, new[] { 0, -1 } };
    public static void Main()
    {
        int[][] matrix = new int[][] {
            new int[]{ 9, 9, 4 },
            new int[]{ 6, 6, 8 },
            new int[]{ 2, 1, 1 }
        };
        Console.WriteLine(LongestIncreasingPath(matrix));
    }

    public static int LongestIncreasingPath(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0) return 0;
        int m = matrix.Length, n = matrix[0].Length;
        var cache = new int[m][];
        for (int i = 0; i < m; i++) cache[i] = new int[n];
        return matrix.Select((row, i) => row.Select((val, j) => dfs(i, j, m, n, matrix, cache)).Max()).Max();
    }

    private static int dfs(int i, int j, int m, int n, int[][] matrix, int[][] cache)
    {
        if (cache[i][j] != 0) return cache[i][j];
        foreach (var dir in directions)
        {
            int x = i + dir[0], y = j + dir[1];
            if (x >= 0 && x < m && y >= 0 && y < n && matrix[x][y] > matrix[i][j])
                cache[i][j] = Math.Max(cache[i][j], dfs(x, y, m, n, matrix, cache));
        }
        return ++cache[i][j];
    }
}