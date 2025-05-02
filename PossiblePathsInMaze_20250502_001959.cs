using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] maze = new int[,] { { 0, 1, 0, 0, 0 }, 
                                   { 0, 1, 0, 1, 0 }, 
                                   { 0, 0, 0, 0, 0 }, 
                                   { 0, 1, 1, 1, 1 }, 
                                   { 0, 0, 0, 0, 0 } };

        List<string> pathList = new List<string>();
        string pathSoFar = string.Empty;

        FindPaths(maze, 0, 0, pathList, pathSoFar);

        foreach (var path in pathList)
        {
            Console.WriteLine(path);
        }
    }

    static void FindPaths(int[,] maze, int x, int y, List<string> pathList, string pathSoFar)
    {
        int rows = maze.GetLength(0);
        int cols = maze.GetLength(1);

        if (!ValidMove(maze, x, y)) return;

        if (x == rows - 1 && y == cols - 1)
        {
            pathList.Add(pathSoFar);
            return;
        }

        maze[x, y] = 1;

        FindPaths(maze, x - 1, y, pathList, pathSoFar + "U");
        FindPaths(maze, x + 1, y, pathList, pathSoFar + "D");
        FindPaths(maze, x, y - 1, pathList, pathSoFar + "L");
        FindPaths(maze, x, y + 1, pathList, pathSoFar + "R");

        maze[x, y] = 0;
    }

    static bool ValidMove(int[,] maze, int x, int y)
    {
        int rows = maze.GetLength(0);
        int cols = maze.GetLength(1);

        return (x >= 0 && x < rows && y >= 0 && y < cols && maze[x, y] == 0);
    }
}