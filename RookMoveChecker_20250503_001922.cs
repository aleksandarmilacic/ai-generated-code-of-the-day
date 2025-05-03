using System;

public class ChessBoard
{
    private int size;

    public ChessBoard(int size)
    {
        this.size = size;
    }

    public bool IsValidMove(int currentX, int currentY, int newX, int newY)
    {
        return currentX == newX || currentY == newY;
    }
}

class Program
{
    static void Main()
    {
        ChessBoard chessBoard = new ChessBoard(8);
        Console.WriteLine(chessBoard.IsValidMove(0, 0, 7, 0)); // True
        Console.WriteLine(chessBoard.IsValidMove(0, 0, 0, 7)); // True
        Console.WriteLine(chessBoard.IsValidMove(0, 0, 7, 7)); // False
    }
}