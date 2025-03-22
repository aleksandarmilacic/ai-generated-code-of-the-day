using System;

class Program
{
    static void Main()
    {
        int[,] matrixA = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matrixB = new int[,] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

        var result = MultiplyMatrices(matrixA, matrixB);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write($"{result[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int[,] result = new int[matrixA.GetLength(0), matrixA.GetLength(0)];

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < matrixB.GetLength(1); k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }
}