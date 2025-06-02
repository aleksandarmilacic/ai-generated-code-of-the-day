using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] mat = new int[3,3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        RotateMatrix(mat);
        DisplayMatrix(mat);
    }

    static void RotateMatrix(int [,] matrix)
    {
        int N = matrix.GetLength(0);

        for(int x = 0; x < N / 2; x++)
        {
            for(int y = x; y < N - x - 1; y++)
            {
                int temp = matrix[x, y];
                matrix[x, y] = matrix[N - 1 - y, x];
                matrix[N - 1 - y, x] = matrix[N - 1 - x, N - 1 - y];
                matrix[N - 1 - x, N - 1 - y] = matrix[y, N - 1 - x];
                matrix[y, N - 1 - x] = temp;
            }
        }
    }

    static void DisplayMatrix(int[,] mat)
    {
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("{0} ", mat[i, j]);
            }
            Console.Write("\n");
        }
    }
}