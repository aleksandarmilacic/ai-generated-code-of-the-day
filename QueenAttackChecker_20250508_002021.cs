using System;

class Program 
{
    static bool CanQueenAttack(int queenRow, int queenColumn, int opponentRow, int opponentColumn) 
    {
        // Check if queen and opponent are in the same row or column
        if (queenRow == opponentRow || queenColumn == opponentColumn)
            return true;

        // Check if queen and opponent are in the same diagonal
        if (Math.Abs(queenRow - opponentRow) == Math.Abs(queenColumn - opponentColumn))
            return true;

        return false;
    }

    static void Main() 
    {
        Console.WriteLine(CanQueenAttack(1, 1, 3, 2));
        Console.WriteLine(CanQueenAttack(4, 5, 5, 5));
        Console.WriteLine(CanQueenAttack(2, 2, 3, 4));
    }
}