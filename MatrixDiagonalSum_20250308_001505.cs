using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = new int[][] { 
            new int[] {1,2,3}, 
            new int[] {4,5,6}, 
            new int[] {7,8,9}
        };

        Console.WriteLine("Diagonal sum: " + DiagonalSum(matrix));
    }

    public static int DiagonalSum(int[][] mat)
    {
        int sum = 0, size = mat.Length;

        for (int i = 0; i < size; i++)
        {
            if (i == size - i - 1)
            {
                sum += mat[i][i];
            }
            else
            {
                sum += mat[i][i] + mat[i][size - i - 1];
            }
        }

        return sum;
    }
}