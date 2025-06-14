using System;

class Solution
{
    public static bool IsValidSudoku(char[][] board)
    {
        bool[,] row = new bool[9, 9], col = new bool[9, 9], sec = new bool[9, 9];
        
        for (int i = 0; i < 9; ++i)
        {
            for (int j = 0; j < 9; ++j)
            {
                if (board[i][j] != '.')
                {
                    int num = board[i][j] - '1', k = i / 3 * 3 + j / 3;
                    if (row[i, num] || col[j, num] || sec[k, num])
                        return false;
                    row[i, num] = col[j, num] = sec[k, num] = true;
                }
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        char[][] sudokuBoard = new char[][]
        {
            new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
            new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'},
        };
        Console.WriteLine(IsValidSudoku(sudokuBoard));
    }
}