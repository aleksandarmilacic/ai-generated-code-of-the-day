using System;

class Program 
{
    static void Main()
    {
        int[,] array = new int[5,5] {
            { 1,  2,  3,  4,  5},
            { 6,  7,  8,  9,  10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        };
        PrintSnakePattern(array);
    }

    static void PrintSnakePattern(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            else
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}