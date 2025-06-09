using System;

class Program
{
    static void Main()
    {
        int[,] dungeon = {
            {-2, -3, 3},
            {-5, -10, 1},
            {10, 30, -5}
        };
        Console.WriteLine(CalculateMinimumHP(dungeon));
    }

    public static int CalculateMinimumHP(int[,] dungeon)
    {
        int m = dungeon.GetLength(0);
        int n = dungeon.GetLength(1);
        int[,] dp = new int[m, n];
        dp[m - 1, n - 1] = Math.Max(1, 1 - dungeon[m - 1, n - 1]);
        
        for (int i = m - 2; i >= 0; --i)
        {
            dp[i, n - 1] = Math.Max(dp[i + 1, n - 1] - dungeon[i, n - 1], 1);
        }
        
        for (int j = n - 2; j >= 0; --j)
        {
            dp[m - 1, j] = Math.Max(dp[m - 1, j + 1] - dungeon[m - 1, j], 1);
        }
        
        for (int i = m - 2; i >= 0; --i)
        {
            for (int j = n - 2; j >= 0; --j)
            {
                int dpMin = Math.Min(dp[i + 1, j], dp[i, j + 1]);
                dp[i, j] = Math.Max(dpMin - dungeon[i, j], 1);
            }
        }
        
        return dp[0, 0];
    }
}