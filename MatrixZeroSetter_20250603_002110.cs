using System;

class Solution {
    public void SetZeroes(int[][] matrix) {
        bool isCol = false;
        for (int i = 0; i < matrix.Length; i++) {
            if (matrix[i][0] == 0) {
                isCol = true;
            }

            for (int j = 1; j < matrix[0].Length; j++) {
                if (matrix[i][j] == 0) {
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
            }
        }

        for (int i = 1; i < matrix.Length; i++) {
            for (int j = 1; j < matrix[0].Length; j++) {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                    matrix[i][j] = 0;
                }
            }
        }

        if (matrix[0][0] == 0) {
            for (int j = 0; j < matrix[0].Length; j++) {
                matrix[0][j] = 0;
            }
        }

        if (isCol) {
            for (int i = 0; i < matrix.Length; i++) {
                matrix[i][0] = 0;
            }
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[][] matrix = new int[][]{
            new int[]{1,1,1},
            new int[]{1,0,1},
            new int[]{1,1,1}
        };
        solution.SetZeroes(matrix);
        foreach (var row in matrix)
        {
            Console.WriteLine(String.Join(" ", row));
        }
    }
}