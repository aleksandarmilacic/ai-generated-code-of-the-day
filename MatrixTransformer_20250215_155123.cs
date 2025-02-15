using System;

class MatrixTransformer
{
    public int[][] Transform(int[][] matrix)
    {
        int rowLength = matrix.Length;
        int colLength = matrix[0].Length;
        int[][] transformedMatrix = new int[colLength][];

        for (int i = 0; i < colLength; i++)
        {
            transformedMatrix[i] = new int[rowLength];
            for (int j = 0; j < rowLength; j++)
            {
                transformedMatrix[i][j] = matrix[j][i];
            }
        }
        
        for (int i = 0; i < transformedMatrix.Length; i++)
        {
            Array.Reverse(transformedMatrix[i]);
        }
        return transformedMatrix;
    }
}