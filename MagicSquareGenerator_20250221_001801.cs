using System;

class Program
{
    static void Main()
    {
        int size = 3; 
        GenerateMagicSquare(size);
    }

    private static void GenerateMagicSquare(int n)
    {
        int[,] magicSquare = new int[n, n];

        int row = n / 2;
        int col = n - 1;

        for (int num = 1; num <= n * n;)
        {
            if (row == -1 && col == n) 
            {
                col = n - 2;
                row = 0;
            }
            else
            {
                if (col == n)
                    col = 0;

                if (row < 0)
                    row = n - 1;
            }

            if (magicSquare[(int)row, (int)col]) 
            {
                col -= 2;
                row++;
                continue;
            }
            else
                magicSquare[(int)row, (int)col] = num++; 

            col++; 
            row--; 
        }

        PrintSquare(magicSquare, n);
    }

    private static void PrintSquare(int[,] magicSquare, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(magicSquare[i, j] + " ");
            Console.WriteLine();
        }
    }
}